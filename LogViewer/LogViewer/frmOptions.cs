using System;
using System.Windows.Forms;
using LogViewer.Properties;
using Telerik.WinControls.UI;

namespace LogViewer
{
    public partial class frmOptions : RadForm
    {
        private readonly string[] _themes = new[] { Resources.VisualStudio2012LightTheme, Resources.VisualStudio2012DarkTheme };
        public frmOptions()
        {
            InitializeComponent();
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
            ddlTheme.Items.AddRange(_themes);
            ddlTheme.SelectedIndex = Array.IndexOf(_themes, Settings.Default.ThemeName);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.Default.ThemeName = _themes[ddlTheme.SelectedIndex];
            DialogResult = DialogResult.OK;
            Settings.Default.Save();
            Close();
        }
    }
}
