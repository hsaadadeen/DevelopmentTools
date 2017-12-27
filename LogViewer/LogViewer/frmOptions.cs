using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace LogViewer
{
    public partial class frmOptions : Telerik.WinControls.UI.RadForm
    {
        private string[] themes = new[] { "VisualStudio2012Light", "VisualStudio2012Dark" };
        public frmOptions()
        {
            InitializeComponent();
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
            ddlTheme.Items.AddRange(themes);
            ddlTheme.SelectedIndex = Array.IndexOf(themes, Properties.Settings.Default.ThemeName);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ThemeName = themes[ddlTheme.SelectedIndex];
            this.DialogResult = DialogResult.OK;
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
