using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogViewer.BackEnd.Entities;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace LogViewer
{
    public partial class MainForm
    {
        private void Setupcontrols()
        {
            RadPageViewStripElement stripElement = this.radPageView1.ViewElement as RadPageViewStripElement;
            stripElement.NewItemVisibility = StripViewNewItemVisibility.End;

            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            SavedLogsLoader.LoadSavedLogsPaths();

            btnOpen.DropDownButtonElement.ActionButton.Click += btnOpenActionButton_Click;
            foreach (KeyValuePair<string, string> savedLogsPair in SavedLogsLoader.SavedLogsDic)
            {
                var menuItem = new RadMenuItem(savedLogsPair.Key, savedLogsPair.Value);
                menuItem.Click += RadMenuItem_Click;
                btnOpen.Items.Add(menuItem);
            }

        }

        private void LoadGrid(string path)
        {
            var logs = obzParser.ParseLogFile(path) as List<NlogEntity>;
            radGridView1.DataSource = logs;
        }
    }
}
