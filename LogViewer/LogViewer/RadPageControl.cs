using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using LogViewer.BackEnd;
using LogViewer.BackEnd.Entities;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace LogViewer
{
    public partial class RadPageControl : UserControl
    {
        private readonly FileSystemWatcher _watcher;
        private string _filePath;
        private bool _autoRefreshEnabled;
        public string FilePath
        {
            get
            { return _filePath; }
            set
            {
                _filePath = value;
                StartWatching();
            }
        }
        public int LinesCount => grdLogs.Rows.Count;

        public bool AutoRefreshEnabled
        {
            get
            { return _watcher.EnableRaisingEvents; }
            set
            {
                _autoRefreshEnabled = value;
                try
                {
                    _watcher.EnableRaisingEvents = value;
                }
                catch (Exception)
                {
                    // ignored
                }
            }
        }

        public RadGridView LogLinesGrid => grdLogs;


        public RadPageControl()
        {
            InitializeComponent();
            _watcher = new FileSystemWatcher();
        }

        private void grdLogs_DoubleClick(object sender, EventArgs e)
        {
            RadGridView grd = sender as RadGridView;
            var selectedCell = grd?.CurrentCell;

            if (selectedCell?.ColumnIndex == 3)
                RadMessageBox.Show(selectedCell.Text);
        }

        public void LoadGrid()
        {
            try
            {
                bzParser obzParser = new bzParser();
                var logs = obzParser.ParseLogFile(_filePath) as BindingList<NlogEntity>;
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
                if (string.IsNullOrWhiteSpace(_filePath) || _filePath == "{file path}") return;
                _watcher.Path = Path.GetDirectoryName(_filePath);
                _watcher.Filter = Path.GetFileName(_filePath);
                _watcher.NotifyFilter = NotifyFilters.LastWrite;
                _watcher.Changed += OnFileChanged;
                _watcher.EnableRaisingEvents = _autoRefreshEnabled;
            }
            catch (Exception)
            {
                RadMessageBox.Show("Error occured while attaching watcher. Auto refresh is disabled.",
                    "Error while attaching watcher", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
            }
        }

        private void OnFileChanged(object source, FileSystemEventArgs e)
        {
            bzParser obzParser = new bzParser();
            var logs = obzParser.ParseLogFile(_filePath) as BindingList<NlogEntity>;
            var oldLogs = grdLogs.DataSource as BindingList<NlogEntity>;

            if (logs != null)
            {
                var newLines = logs.Where(r => oldLogs != null && !oldLogs.Any(l => l.LogTime == r.LogTime && l.Message == r.Message));
                if (newLines.Any())
                {
                    int rowIndex = -1;
                    if (grdLogs.Rows.Count > 0)
                    {
                        rowIndex = grdLogs.CurrentRow.Index;
                    }
                    grdLogs.Invoke(new MethodInvoker(() => { grdLogs.DataSource = logs; }));
                    if (rowIndex <= 0 || rowIndex >= grdLogs.Rows.Count) return;
                    if(grdLogs.Rows[rowIndex] == null) return;
                    grdLogs.Rows[rowIndex].IsCurrent = true;
                }
            }
        }
    }
}
