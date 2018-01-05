using System;
using System.Linq;
using System.Windows.Forms;
using LogViewer.Properties;
using Telerik.WinControls;
using Telerik.WinControls.Data;
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

            LoadIcons();
        }

        private void Setupcontrols()
        {
            ThemeResolutionService.ApplicationThemeName = Settings.Default.ThemeName;
            chkAutoRefresh.Checked = Convert.ToBoolean(Settings.Default.AutoRefreshEnabled);

            SavedLogsLoader.LoadSavedLogsPaths();

            foreach (var pair in SavedLogsLoader.SavedLogsDic)
            {
                lstSavedLogs.Items.Add(new RadListDataItem(pair.Key, pair.Value));
            }
            lstSavedLogs.SelectedIndex = -1;
        }

        private void LoadIcons()
        {
            if (ThemeResolutionService.ApplicationThemeName == Resources.VisualStudio2012LightTheme)
            {
                btnNew.Image = Resources.blackNewTab;
                btnLoad.Image = Resources.blackLoadFile;
                btnLoadNew.Image = Resources.blackOpenFile;
                btnSave.Image = Resources.blackSaveFile;
                btnRefresh.Image = Resources.blackRefreshFile;

                radRibbonBar.OptionsButton.Image = Resources.blackOptions;
                radRibbonBar.ExitButton.Image = Resources.blackExit;
            }

            else if (ThemeResolutionService.ApplicationThemeName == Resources.VisualStudio2012DarkTheme)
            {
                btnNew.Image = Resources.whiteNewTab;
                btnLoad.Image = Resources.whiteLoadFile;
                btnLoadNew.Image = Resources.whiteOpenFile;
                btnSave.Image = Resources.whiteSaveFile;
                btnRefresh.Image = Resources.whiteRefreshFile;

                radRibbonBar.OptionsButton.Image = Resources.whiteOptions;
                radRibbonBar.ExitButton.Image = Resources.whiteExit;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AddNewTab();
        }

        private DockWindow AddNewTab()
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

            return docWindow;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFile(addTab: false);
        }

        private void btnLoadNew_Click(object sender, EventArgs e)
        {
            OpenFile(addTab: true);
        }

        private void OpenFile(bool addTab)
        {
            DialogResult openDialogResult = openFileDialog.ShowDialog();
            if (openDialogResult == DialogResult.OK)
            {
                var opened = radDock.GetWindow<DocumentWindow>(SavedLogsLoader.SavedLogsKeyOf(openFileDialog.FileName));
                if (opened != null)
                {
                    radDock.ActiveWindow = opened;
                    return;
                }

                if (addTab)
                    AddNewTab();

                LoadGrid(radDock.ActiveWindow, openFileDialog.FileName, true);
                RadPageControl page = radDock.ActiveWindow.Controls["RadPageControl"] as RadPageControl;

                if (page != null) lblLinesCount.Text = Resources.statusbar_lines + page.LinesCount;
            }
        }

        private void LoadGrid(DockWindow document, string filePath, bool autoRefreshEnabled)
        {
            RadPageControl page = document.Controls["RadPageControl"] as RadPageControl;

            if (page == null) return;
            page.AutoRefreshEnabled = autoRefreshEnabled;
            page.FilePath = filePath;
            page.LoadGrid();
            lblFileName.Text = page.FilePath;

            if (SavedLogsLoader.SavedLogsContains(filePath))
            {
                radDock.ActiveWindow.Text = SavedLogsLoader.SavedLogsKeyOf(filePath);
            }
            else if (!radDock.ActiveWindow.Text.Contains(Resources.UnsavedFileIndicator))
                radDock.ActiveWindow.Text += Resources.UnsavedFileIndicator;

            document.Name = document.Text;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RadPageControl page = radDock.ActiveWindow.Controls["RadPageControl"] as RadPageControl;
            page?.LoadGrid();
        }

        private void radDock_ActiveWindowChanged(object sender, DockWindowEventArgs e)
        {
            RadPageControl page = e.DockWindow?.Controls["RadPageControl"] as RadPageControl;
            if (page == null) return;
            lblFileName.Text = page.FilePath;
            lblLinesCount.Text = Resources.statusbar_lines + page.LinesCount;

            int index = SavedLogsLoader.SavedLogsIndexOf(e.DockWindow.Name);
            if (index != -1)
                lstSavedLogs.SelectedItem = lstSavedLogs.Items.FirstOrDefault(i => i.Text == e.DockWindow.Name);

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
                    frmSavePath frm = new frmSavePath(page.FilePath) { Text = radDock.ActiveWindow.Text };
                    var result = frm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        radDock.ActiveWindow.Text = frm.Key;
                        radDock.ActiveWindow.Name = frm.Key;
                        lstSavedLogs.Items.Add(new RadListDataItem(frm.Key, SavedLogsLoader.SavedLogsDic[frm.Key]));
                    }
                    frm.Dispose();
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
                LoadIcons();
            }
            frm.Dispose();
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
            lstSavedLogs.SelectedIndex = -1;
            if (e.NewWindow.Text.Contains("*"))
            {
                RadPageControl pageControl = e.NewWindow.Controls["RadPageControl"] as RadPageControl;
                if (pageControl != null)
                {
                    frmSavePath frm = new frmSavePath(pageControl.FilePath) { Text = e.NewWindow.Text };
                    frm.ShowDialog();
                    frm.Dispose();
                }
            }
        }

        private void lstSavedLogs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstSavedLogs.SelectedItem == null) return;

            DockWindow document = radDock.GetWindow<DockWindow>(lstSavedLogs.SelectedItem.Text);

            if (document != null)
            {
                if (document.TabStrip.TabStripElement.PreviewItem == document.TabStripItem)
                {
                    document.TabStrip.TabStripElement.PreviewItem = null;
                }
                radDock.ActiveWindow = document;
                return;
            }

            document = AddNewTab();

            RadPageControl page = radDock.ActiveWindow.Controls["RadPageControl"] as RadPageControl;
            if (page == null) return;

            LoadGrid(document, lstSavedLogs.SelectedItem.Value.ToString(), true);
            lblLinesCount.Text = Resources.statusbar_lines + page.LinesCount;
        }

        private void lstSavedLogs_SelectedItemsChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            //if(e.NewItems == null || e.NewItems.Count <= 0) return;
            //RadListDataItem selectedItem = e.NewItems[0] as RadListDataItem;
            //if (selectedItem != null)
            //{
            //    DocumentWindow document = radDock.GetWindow<DocumentWindow>(selectedItem.Text);
            //    if (document == null)
            //    {
            //        document = AddNewTab();
            //        LoadGrid(document, selectedItem.Value.ToString(), autoRefreshEnabled: false);
            //    }
            //    else
            //    {
            //        return;
            //    }

            //    if (document.TabStrip.TabStripElement.PreviewItem == document.TabStripItem)
            //    {
            //        return;
            //    }

            //    foreach (DocumentWindow dw in radDock.GetWindows<DocumentWindow>())
            //    {
            //        RadPageViewStripElement tabStrip = dw.TabStrip.TabStripElement;
            //        if (tabStrip.PreviewItem == null) continue;
            //        radDock.CloseWindow((DockWindow)((TabStripItem)tabStrip.PreviewItem).TabPanel);
            //        tabStrip.PreviewItem = null;
            //    }

            //    document.TabStrip.TabStripElement.PreviewItem = document.TabStripItem;
            //    radDock.ActiveWindow = document;
            //}
        }
    }
}
