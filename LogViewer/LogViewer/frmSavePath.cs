using System;
using System.Windows.Forms;
using LogViewer.Properties;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace LogViewer
{
    public partial class frmSavePath : RadForm
    {
        private string _key;
        public string Key => _key;


        public frmSavePath(string path)
        {
            InitializeComponent();

            txtPath.Text = path;
            txtFileNameFormat.Text = Resources.DefaultFileNameFormat;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SavedLogsLoader.SavedLogsDic.Add(txtKey.Text, SavedLogsLoader.GetConfigPath(txtPath.Text, txtFileNameFormat.Text));
                SavedLogsLoader.SaveLogPath(txtKey.Text);
                RadMessageBox.Show("New path saved", "Saved Successfully", MessageBoxButtons.OK, RadMessageIcon.Info);
                DialogResult = DialogResult.OK;
                _key = txtKey.Text;
                Close();
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message, "Error while saving", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }
    }
}
