using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace LogViewer
{
    public partial class frmSavePath : Telerik.WinControls.UI.RadForm
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
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message, "Error while saving", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }
    }
}
