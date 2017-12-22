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

        public MainForm()
        {
            InitializeComponent();

            obzParser = new bzParser();
        }

        void radPageView1_NewPageRequested(object sender, EventArgs e)
        {
            RadPageView pageView = sender as RadPageView;
            RadPageViewStripElement stripElement = pageView.ViewElement as RadPageViewStripElement;
            RadPageViewPage page = new RadPageViewPage();
            page.Text = "New Page";
            pageView.Pages.Add(page);
            pageView.SelectedPage = page;
            pageView.ViewElement.EnsureItemVisible(stripElement.NewItem);
        }

        private void btnOpenActionButton_Click(object sender, EventArgs e)
        {
            DialogResult openDialogResult = openFileDialog1.ShowDialog();
            if (openDialogResult == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog1.FileName;
                LoadGrid(openFileDialog1.FileName);
            }
        }

        private void radRefresh_Click(object sender, EventArgs e)
        {
            LoadGrid(txtFilePath.Text);
        }

        private void RadMenuItem_Click(object sender, EventArgs e)
        {
            RadMenuItem clickedMenuItem = (RadMenuItem)sender;
            txtFilePath.Text = clickedMenuItem.Tag.ToString();
            LoadGrid(clickedMenuItem.Tag.ToString());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Setupcontrols();
        }
    }
}
