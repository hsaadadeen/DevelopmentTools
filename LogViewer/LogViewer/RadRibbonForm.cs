using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using LogViewer.BackEnd;
using LogViewer.BackEnd.Entities;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Docking;

namespace LogViewer
{
    public partial class RadRibbonForm : Telerik.WinControls.UI.RadRibbonForm
    {
        private int newDocument = 0;

        public RadRibbonForm()
        {
            InitializeComponent();
        }

        private void RadRibbonForm_Load(object sender, EventArgs e)
        {
            Setupcontrols();
        }

        private void Setupcontrols()
        {
            ThemeResolutionService.ApplicationThemeName = Properties.Settings.Default.ThemeName;

            SavedLogsLoader.LoadSavedLogsPaths();

            AddNewWindow();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AddNewWindow();
        }

        private void AddNewWindow()
        {
            DocumentWindow docWindow = new DocumentWindow("Log File " + ++newDocument);
            RadPageControl pageControl = new RadPageControl();
            pageControl.LogLinesGrid.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.radDock.AddDocument(docWindow);
            docWindow.Controls.Add(pageControl);
            pageControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            pageControl.Size = docWindow.Size;
            radDock.ActiveWindow = docWindow;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DialogResult openDialogResult = openFileDialog.ShowDialog();
            if (openDialogResult == DialogResult.OK)
            {
                RadPageControl page = radDock.ActiveWindow.Controls["RadPageControl"] as RadPageControl;
                page.FilePath = openFileDialog.FileName;
                page.LoadGrid();
                lblFileName.Text = page.FilePath;
                lblLinesCount.Text = "lines: " + page.LinesCount;

                chkAutoRefresh.Checked = Convert.ToBoolean(Properties.Settings.Default.AutoRefreshEnabled);

                if (SavedLogsLoader.SavedLogsDic.ContainsValue(SavedLogsLoader.GetConfigPath(openFileDialog.FileName))) return;
                if (!radDock.ActiveWindow.Text.Contains("*"))
                    radDock.ActiveWindow.Text += "*";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RadPageControl page = radDock.ActiveWindow.Controls["RadPageControl"] as RadPageControl;
            page.LoadGrid();
        }

        private void radDock_ActiveWindowChanged(object sender, DockWindowEventArgs e)
        {
            RadPageControl page = e.DockWindow.Controls["RadPageControl"] as RadPageControl;
            if (page == null) return;
            lblFileName.Text = page.FilePath;
            lblLinesCount.Text = "lines: " + page.LinesCount;

            page.LogLinesGrid.CurrentRowChanged += this.grdLogs_CurrentRowChanged;
            page.LogLinesGrid.DataBindingComplete += grdLogs_CountUpdated;
        }

        private void grdLogs_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            lblCurrentLine.Text = "ln: " + (e.CurrentRow.Index + 1);
        }

        private void grdLogs_CountUpdated(object sender, GridViewBindingCompleteEventArgs e)
        {
            RadPageControl page = radDock.ActiveWindow.Controls["RadPageControl"] as RadPageControl;
            lblLinesCount.Text = "lines: " + page.LinesCount;
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
            //int pages = radPageView.Pages.Count;
            //for (int i = 0; i < pages; i++)
            //    radPageView.Pages.RemoveAt(0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (radDock.ActiveWindow.Text.Contains("*"))
            {
                frmSavePath frm =
                    new frmSavePath((radDock.ActiveWindow.Controls["RadPageControl"] as RadPageControl).FilePath);
                var result = frm.ShowDialog();
                if (result == DialogResult.OK)
                    radDock.ActiveWindow.Text = radDock.ActiveWindow.Text.Replace("*", "");
            }
        }

        private void chkAutoRefresh_CheckStateChanged(object sender, EventArgs e)
        {
            RadPageControl page = radDock.ActiveWindow.Controls["RadPageControl"] as RadPageControl;
            page.AutoRefreshEnabled = chkAutoRefresh.Checked;
            Properties.Settings.Default.AutoRefreshEnabled = chkAutoRefresh.Checked.ToString();
            Properties.Settings.Default.Save();
        }

        private void radRibbonBar_OptionsButton_Click(object sender, EventArgs e)
        {
            frmOptions frm = new frmOptions();
            if(frm.ShowDialog() == DialogResult.OK)
                ThemeResolutionService.ApplicationThemeName = Properties.Settings.Default.ThemeName;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAboutBox frm = new frmAboutBox();
            frm.Show();
        }

        private void radRibbonBar_ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
