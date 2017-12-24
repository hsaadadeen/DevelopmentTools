using System;
using System.Collections.Generic;
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
            var pbtnOpen = pageControl.Controls["btnOpen"] as RadSplitButton;
            pbtnOpen.DropDownButtonElement.ActionButton.Click += btnOpenActionButton_Click;
            var pgrdLogs = pageControl.Controls["grdLogs"] as RadGridView;
            pgrdLogs.DoubleClick += grdLogs_DoubleClick;
            var pbtnRefresh = pageControl.Controls["btnRefresh"] as RadButton;
            pbtnRefresh.Click += btnRefresh_Click;
        }

        private void SetControlsOnNewPage(RadPageControl pageControl)
        {
            (pageControl.Controls["grdLogs"] as RadGridView).MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            var pbtnOpen = pageControl.Controls["btnOpen"] as RadSplitButton;
            foreach (KeyValuePair<string, string> savedLogsPair in SavedLogsLoader.SavedLogsDic)
            {
                var menuItem = new RadMenuItem(savedLogsPair.Key, savedLogsPair.Value);
                menuItem.Click += RadMenuItem_Click;
                pbtnOpen.Items.Add(menuItem);
            }
        }

        private void LoadGrid(RadGridView grd, string path)
        {
            var logs = obzParser.ParseLogFile(path) as List<NlogEntity>;
            grd.DataSource = logs;
        }
    }
}
