using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogViewer.BackEnd.Entities;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace LogViewer
{
    public partial class MainForm
    {
        private void Setupcontrols()
        {
            RadPageViewStripElement stripElement = this.radPageView.ViewElement as RadPageViewStripElement;
            stripElement.NewItemVisibility = StripViewNewItemVisibility.End;

            SavedLogsLoader.LoadSavedLogsPaths();

            AddNewPage(radPageView);

            ThemeResolutionService.ApplicationThemeName = "VisualStudio2012Light";
        }

        private void AddNewPage(RadPageView pageView)
        {
            RadPageViewStripElement stripElement = pageView.ViewElement as RadPageViewStripElement;
            RadPageViewPage page = new RadPageViewPage();
            page.Text = "Log File " + ++pagesCount;
            var pageControl = new RadPageControl();
            SetEventsOnNewPage(pageControl);
            SetControlsOnNewPage(pageControl);
            pageControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            pageControl.Size = page.Size;
            page.Controls.Add(pageControl);
            pageView.Pages.Add(page);
            pageView.SelectedPage = page;
            pageView.ViewElement.EnsureItemVisible(stripElement.NewItem);
        }

        private void SetEventsOnNewPage(RadPageControl pageControl)
        {
            pageControl.OpenButton.DropDownButtonElement.ActionButton.Click += btnOpenActionButton_Click;
            pageControl.LogLinesGrid.DoubleClick += grdLogs_DoubleClick;
            pageControl.RefreshButton.Click += btnRefresh_Click;
        }

        private void SetControlsOnNewPage(RadPageControl pageControl)
        {
            pageControl.LogLinesGrid.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            foreach (KeyValuePair<string, string> savedLogsPair in SavedLogsLoader.SavedLogsDic)
            {
                var menuItem = new RadMenuItem(savedLogsPair.Key, savedLogsPair.Value);
                menuItem.Click += RadMenuItem_Click;
                pageControl.OpenButton.Items.Add(menuItem);
            }
        }

        private void LoadGrid(RadGridView grd, string path)
        {
            try
            {
                var logs = obzParser.ParseLogFile(path) as List<NlogEntity>;
                grd.DataSource = logs;
                RadPageControl page = radPageView.SelectedPage.Controls["RadPageControl"] as RadPageControl;
                page.LinesCount = logs.Count.ToString();
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
    }
}
