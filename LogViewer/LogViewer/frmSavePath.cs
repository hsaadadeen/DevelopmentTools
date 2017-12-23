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
                string path = Path.Combine(Path.GetDirectoryName(txtPath.Text), txtFileNameFormat.Text);
                SavedLogsLoader.SavedLogsDic.Add(txtKey.Text, path);
                SavedLogsLoader.SaveLogPath(txtKey.Text);
                MessageBox.Show("New path saved", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error while saving", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
