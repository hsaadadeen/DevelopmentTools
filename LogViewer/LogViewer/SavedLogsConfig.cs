using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                SavedLogsDic.Add(log.Key, log.Path);
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
