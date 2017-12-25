using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogViewer.BackEnd;
using LogViewer.BackEnd.Entities;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace LogViewer
{
    public partial class RadPageControl : UserControl
    {
        private FileSystemWatcher watcher;
        private string filePath;
        public string FilePath
        {
            get
            { return filePath; }
            set
            {
                filePath = value;
                StartWatching();
            }
        }
        public int LinesCount { get { return grdLogs.Rows.Count; } }

        public RadGridView LogLinesGrid { get { return grdLogs; } }


        public RadPageControl()
        {
            InitializeComponent();
            watcher = new FileSystemWatcher();
        }

        private void grdLogs_DoubleClick(object sender, EventArgs e)
        {
            RadGridView grd = sender as RadGridView;
            var selectedCell = grd.CurrentCell;

            if (selectedCell.ColumnIndex == 3)
                RadMessageBox.Show(selectedCell.Text);
        }

        public void LoadGrid()
        {
            try
            {
                bzParser obzParser = new bzParser();
                var logs = obzParser.ParseLogFile(filePath) as BindingList<NlogEntity>;
                grdLogs.DataSource = logs;
            }
            catch (FileNotFoundException)
            {
                RadMessageBox.Show("No file found!", "File not found", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message, "Error while loading file", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        public void StartWatching()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(filePath) || filePath == "{file path}") return;
                watcher.Path = Path.GetDirectoryName(filePath);
                watcher.Filter = Path.GetFileName(filePath);
                watcher.NotifyFilter = NotifyFilters.LastWrite;
                watcher.Changed += new FileSystemEventHandler(OnFileChanged);
                watcher.EnableRaisingEvents = true;
            }
            catch (Exception ex)
            {
                RadMessageBox.Show("Error occured while attaching watcher. Auto refresh is disabled.",
                    "Error while attaching watcher", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
            }
        }

        private void OnFileChanged(object source, FileSystemEventArgs e)
        {
            bzParser obzParser = new bzParser();
            var logs = obzParser.ParseLogFile(filePath) as BindingList<NlogEntity>;
            var oldLogs = grdLogs.DataSource as BindingList<NlogEntity>;

            grdLogs.DataSource = logs;

            //var newLines = logs.Where(r => !oldLogs.Any(l => l.LogTime == r.LogTime && l.Message == r.Message));
            //if (newLines.Any())
            //{
            //    oldLogs.Add(new NlogEntity() {
            //    LogTime = DateTime.Now,
            //    Level = "ss",
            //    CallStack = "ss",
            //    Message = "ss"
            //});
            //grdLogs.Refresh();
        //}
        }
    }
}
