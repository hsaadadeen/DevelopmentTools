using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LogViewer.BackEnd;
using LogViewer.BackEnd.Entities;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace LogViewer
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        private bzParser obzParser;
        private short pagesCount = 0;

        public MainForm()
        {
            InitializeComponent();

            obzParser = new bzParser();
        }

        void radPageView1_NewPageRequested(object sender, EventArgs e)
        {
            RadPageView pageView = sender as RadPageView;
            AddNewPage(pageView);
        }
        
        private void btnOpenActionButton_Click(object sender, EventArgs e)
        {
            DialogResult openDialogResult = openFileDialog1.ShowDialog();
            if (openDialogResult == DialogResult.OK)
            {
                RadPageControl page = radPageView.SelectedPage.Controls["RadPageControl"] as RadPageControl;
                page.FilePath = openFileDialog1.FileName;
                LoadGrid(page.LogLinesGrid, openFileDialog1.FileName);

                if (!SavedLogsLoader.SavedLogsDic.ContainsValue(openFileDialog1.FileName))
                    radPageView.SelectedPage.Text += "*";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RadPageControl page = radPageView.SelectedPage.Controls["RadPageControl"] as RadPageControl;
            LoadGrid(page.LogLinesGrid, page.FilePath);
        }

        private void RadMenuItem_Click(object sender, EventArgs e)
        {
            RadPageControl page = radPageView.SelectedPage.Controls["RadPageControl"] as RadPageControl;
            RadMenuItem clickedMenuItem = (RadMenuItem)sender;
            page.FilePath = clickedMenuItem.Tag.ToString();
            LoadGrid(page.LogLinesGrid, clickedMenuItem.Tag.ToString());

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Setupcontrols();
        }

        private void radPageView1_PageRemoving(object sender, RadPageViewCancelEventArgs e)
        {
            if (e.Page.Text.Contains("*"))
            {
                frmSavePath frm = new frmSavePath((e.Page.Controls["RadPageControl"] as RadPageControl).FilePath);
                frm.ShowDialog();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            int pages = radPageView.Pages.Count;
            for (int i = 0; i < pages; i++)
                radPageView.Pages.RemoveAt(0);
        }

        private void grdLogs_DoubleClick(object sender, EventArgs e)
        {
            RadGridView grd = sender as RadGridView;
            var selectedCell = grd.CurrentCell;

            if (selectedCell.ColumnIndex == 3)
                RadMessageBox.Show(selectedCell.Text);
        }
    }
}
