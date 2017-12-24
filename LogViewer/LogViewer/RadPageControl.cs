using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace LogViewer
{
    public partial class RadPageControl : UserControl
    {
        public string FilePath { get { return lblFilePath.Text; } set { lblFilePath.Text = value; } }
        public RadGridView LogLinesGrid { get { return grdLogs; } }
        public RadButton RefreshButton { get { return btnRefresh; } }
        public RadSplitButton OpenButton { get { return btnOpen; } }
        public string LinesCount { get { return lblLinesCount.Text.Replace("lines: ", string.Empty); } set { lblLinesCount.Text = "lines: " + value; } }
        public string CurrentLine { get { return lblCurrentLine.Text.Replace("ln: ", string.Empty); } set { lblCurrentLine.Text = "ln: " + value; } }

        public RadPageControl()
        {
            InitializeComponent();
        }

        private void grdLogs_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            CurrentLine = (e.CurrentRow.Index + 1).ToString();
        }
    }
}
