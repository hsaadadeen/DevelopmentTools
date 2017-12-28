using System;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace LogViewer
{
    public partial class frmSavePath : RadForm
    {
        public frmSavePath(string path)
        {
            InitializeComponent();

            txtPath.Text = path;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SavedLogsLoader.SavedLogsDic.Add(txtKey.Text, SavedLogsLoader.GetConfigPath(txtPath.Text));
                SavedLogsLoader.SaveLogPath(txtKey.Text);
                RadMessageBox.Show("New path saved", "Saved Successfully", MessageBoxButtons.OK, RadMessageIcon.Info);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message, "Error while saving", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }
    }
}
