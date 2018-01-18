using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using LogViewer.BackEnd;

namespace LogViewer
{
    public static class SavedLogsLoader
    {
        public static Dictionary<string, string> SavedLogsDic;
         
        public static void LoadSavedLogsPaths()
        {
            var savedLogsConfig = ConfigurationManager.GetSection("SavedLogsPaths") as SavedLogsConfigSection;

            SavedLogsDic = new Dictionary<string, string>();
            foreach (SavedLogsConfigInstanceElement log in savedLogsConfig.Instances)
                SavedLogsDic.Add(log.Key, String.Format(log.Path, DateTime.Now));
        }

        public static void SaveLogPath(string key, string fileFormat)
        {
            string path = SavedLogsDic[key].Replace(Path.GetFileName(SavedLogsDic[key]), fileFormat);
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            var node = xmlDoc.CreateElement("add");
            node.SetAttribute("key", key);
            node.SetAttribute("path", path);

            xmlDoc.SelectSingleNode("//SavedLogsPaths").AppendChild(node);
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            ConfigurationManager.RefreshSection("SavedLogsPaths");
        }

        public static string GetConfigPath(string fileName, string fileNameFormat)
        {
            return Path.Combine(Path.GetDirectoryName(fileName), fileName);
        }

        public static bool SavedLogsContains(string path)
        {
            return SavedLogsDic.Any(keyValuePair => string.Format(keyValuePair.Value.ToLower(), DateTime.Now) == path.ToLower());
        }

        public static string SavedLogsKeyOf(string path)
        {
            var key = SavedLogsDic.FirstOrDefault(keyValuePair => string.Format(keyValuePair.Value.ToLower(), DateTime.Now) == path.ToLower()).Key;
            if(key == null) return string.Empty;
            return key;
        }

        public static int SavedLogsIndexOf(string key)
        {
            for (int i = 0; i < SavedLogsDic.Count; i++)
            {
                if (SavedLogsDic.ElementAt(i).Key == key)
                    return i;
            }
            return -1;
        }
    }

    public class SavedLogsConfigSection : ConfigurationSection
    {
        [ConfigurationProperty("", IsRequired = true, IsDefaultCollection = true)]
        public SavedLogsConfigInstanceCollection Instances
        {
            get { return (SavedLogsConfigInstanceCollection)this[""]; }
            set { this[""] = value; }
        }
    }
    public class SavedLogsConfigInstanceCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new SavedLogsConfigInstanceElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((SavedLogsConfigInstanceElement)element).Key;
        }
    }

    public class SavedLogsConfigInstanceElement : ConfigurationElement
    {
        [ConfigurationProperty("key", IsKey = true, IsRequired = true)]
        public string Key
        {
            get { return (string)base["key"]; }
            set { base["key"] = value; }
        }

        [ConfigurationProperty("path", IsRequired = true)]
        public string Path
        {

            get { return (string)base["path"]; }

            set
            { base["path"] = value; }
        }
    }
}
