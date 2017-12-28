using System;
using System.Windows.Forms;
using LogViewer.Properties;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Docking;

namespace LogViewer
{
    public partial class RadRibbonForm : Telerik.WinControls.UI.RadRibbonForm
    {
        private int _newDocument;

        public RadRibbonForm()
        {
            InitializeComponent();
        }

        private void RadRibbonForm_Load(object sender, EventArgs e)
        {
            Setupcontrols();

            LoadImages();
        }

        private void Setupcontrols()
        {
            ThemeResolutionService.ApplicationThemeName = Settings.Default.ThemeName;
            chkAutoRefresh.Checked = Convert.ToBoolean(Settings.Default.AutoRefreshEnabled);

            SavedLogsLoader.LoadSavedLogsPaths();

            AddNewWindow();
        }

        private void LoadImages()
        {
            if (ThemeResolutionService.ApplicationThemeName == Resources.VisualStudio2012LightTheme)
            {
                btnNew.Image = Resources.blackNewTab;
                btnLoad.Image = Resources.blackOpenFile;
                btnSave.Image = Resources.blackSaveFile;
                btnRefresh.Image = Resources.blackRefreshFile;

                radRibbonBar.OptionsButton.Image = Resources.blackOptions;
                radRibbonBar.ExitButton.Image = Resources.blackExit;
            }

            else if (ThemeResolutionService.ApplicationThemeName == Resources.VisualStudio2012DarkTheme)
            {
                btnNew.Image = Resources.whiteNewTab;
                btnLoad.Image = Resources.whiteOpenFile;
                btnSave.Image = Resources.whiteSaveFile;
                btnRefresh.Image = Resources.whiteRefreshFile;

                radRibbonBar.OptionsButton.Image = Resources.whiteOptions;
                radRibbonBar.ExitButton.Image = Resources.whiteExit;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AddNewWindow();
        }

        private void AddNewWindow()
        {
            DocumentWindow docWindow = new DocumentWindow("Log File " + ++_newDocument);
            RadPageControl pageControl = new RadPageControl();
            pageControl.LogLinesGrid.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            radDock.AddDocument(docWindow);
            docWindow.Controls.Add(pageControl);
            pageControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            pageControl.Size = docWindow.Size;
            pageControl.AutoRefreshEnabled = chkAutoRefresh.Checked;
            radDock.ActiveWindow = docWindow;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DialogResult openDialogResult = openFileDialog.ShowDialog();
            if (openDialogResult == DialogResult.OK)
            {
                RadPageControl page = radDock.ActiveWindow.Controls["RadPageControl"] as RadPageControl;
                if (page != null)
                {
                    page.FilePath = openFileDialog.FileName;
                    page.LoadGrid();
                    lblFileName.Text = page.FilePath;
                    lblLinesCount.Text = Resources.statusbar_lines + page.LinesCount;
                }

                if (SavedLogsLoader.SavedLogsDic.ContainsValue(SavedLogsLoader.GetConfigPath(openFileDialog.FileName))) return;
                if (!radDock.ActiveWindow.Text.Contains(Resources.UnsavedFileIndicator))
                    radDock.ActiveWindow.Text += Resources.UnsavedFileIndicator;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RadPageControl page = radDock.ActiveWindow.Controls["RadPageControl"] as RadPageControl;
            page?.LoadGrid();
        }

        private void radDock_ActiveWindowChanged(object sender, DockWindowEventArgs e)
        {
            if (e.DockWindow == null) return;
            RadPageControl page = e.DockWindow.Controls["RadPageControl"] as RadPageControl;
            if (page == null) return;
            lblFileName.Text = page.FilePath;
            lblLinesCount.Text = Resources.statusbar_lines + page.LinesCount;

            page.LogLinesGrid.CurrentRowChanged += grdLogs_CurrentRowChanged;
            page.LogLinesGrid.DataBindingComplete += grdLogs_CountUpdated;
        }

        private void grdLogs_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            lblCurrentLine.Text = Resources.statusbar_lineIndex + (e.CurrentRow.Index + 1);
        }

        private void grdLogs_CountUpdated(object sender, GridViewBindingCompleteEventArgs e)
        {
            RadPageControl page = radDock.ActiveWindow.Controls["RadPageControl"] as RadPageControl;
            if (page != null) lblLinesCount.Text = Resources.statusbar_lines + page.LinesCount;
        }

        private void RadRibbonForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            radDock.CloseAllWindows();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (radDock.ActiveWindow.Text.Contains("*"))
            {
                RadPageControl page = radDock.ActiveWindow.Controls["RadPageControl"] as RadPageControl;
                if (page != null)
                {
                    frmSavePath frm =
                        new frmSavePath(page.FilePath);
                    var result = frm.ShowDialog();
                    if (result == DialogResult.OK)
                        radDock.ActiveWindow.Text = radDock.ActiveWindow.Text.Replace("*", "");
                }
            }
        }

        private void chkAutoRefresh_CheckStateChanged(object sender, EventArgs e)
        {
            RadPageControl page = radDock.ActiveWindow.Controls["RadPageControl"] as RadPageControl;
            if (page != null) page.AutoRefreshEnabled = chkAutoRefresh.Checked;
            Settings.Default.AutoRefreshEnabled = chkAutoRefresh.Checked.ToString();
            Settings.Default.Save();
        }

        private void radRibbonBar_OptionsButton_Click(object sender, EventArgs e)
        {
            frmOptions frm = new frmOptions();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ThemeResolutionService.ApplicationThemeName = Settings.Default.ThemeName;
                LoadImages();
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAboutBox frm = new frmAboutBox();
            frm.Show();
        }

        private void radRibbonBar_ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radDock_DockWindowClosing(object sender, DockWindowCancelEventArgs e)
        {
            if (e.NewWindow.Text.Contains("*"))
            {
                RadPageControl pageControl = e.NewWindow.Controls["RadPageControl"] as RadPageControl;
                if (pageControl != null)
                {
                    frmSavePath frm = new frmSavePath(pageControl.FilePath);
                    frm.ShowDialog();
                }
            }
        }
    }
}
