namespace LogViewer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.radPageView = new Telerik.WinControls.UI.RadPageView();
            this.nlogEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nlogEntityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPageView
            // 
            this.radPageView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radPageView.Location = new System.Drawing.Point(1, 1);
            this.radPageView.Margin = new System.Windows.Forms.Padding(1);
            this.radPageView.Name = "radPageView";
            this.radPageView.Size = new System.Drawing.Size(996, 714);
            this.radPageView.TabIndex = 0;
            this.radPageView.Text = "radPageView1";
            this.radPageView.NewPageRequested += new System.EventHandler(this.radPageView1_NewPageRequested);
            this.radPageView.PageRemoving += new System.EventHandler<Telerik.WinControls.UI.RadPageViewCancelEventArgs>(this.radPageView1_PageRemoving);
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView.GetChildAt(0))).ShowItemCloseButton = true;
            // 
            // nlogEntityBindingSource
            // 
            this.nlogEntityBindingSource.DataSource = typeof(LogViewer.BackEnd.Entities.NlogEntity);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 716);
            this.Controls.Add(this.radPageView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Log Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPageView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nlogEntityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView radPageView;
        private System.Windows.Forms.BindingSource nlogEntityBindingSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
    }
}
