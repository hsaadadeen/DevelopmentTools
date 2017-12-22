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
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn3 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.ConditionalFormattingObject conditionalFormattingObject7 = new Telerik.WinControls.UI.ConditionalFormattingObject();
            Telerik.WinControls.UI.ConditionalFormattingObject conditionalFormattingObject8 = new Telerik.WinControls.UI.ConditionalFormattingObject();
            Telerik.WinControls.UI.ConditionalFormattingObject conditionalFormattingObject9 = new Telerik.WinControls.UI.ConditionalFormattingObject();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.btnOpen = new Telerik.WinControls.UI.RadSplitButton();
            this.radRefresh = new Telerik.WinControls.UI.RadButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.nlogEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.radPageViewPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nlogEntityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPageView1
            // 
            this.radPageView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radPageView1.Controls.Add(this.radPageViewPage1);
            this.radPageView1.Location = new System.Drawing.Point(1, 1);
            this.radPageView1.Margin = new System.Windows.Forms.Padding(1);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.radPageViewPage1;
            this.radPageView1.Size = new System.Drawing.Size(844, 600);
            this.radPageView1.TabIndex = 0;
            this.radPageView1.Text = "radPageView1";
            this.radPageView1.NewPageRequested += new System.EventHandler(this.radPageView1_NewPageRequested);
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).ShowItemCloseButton = true;
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.Controls.Add(this.txtFilePath);
            this.radPageViewPage1.Controls.Add(this.btnOpen);
            this.radPageViewPage1.Controls.Add(this.radRefresh);
            this.radPageViewPage1.Controls.Add(this.radGridView1);
            this.radPageViewPage1.ItemSize = new System.Drawing.SizeF(87F, 28F);
            this.radPageViewPage1.Location = new System.Drawing.Point(10, 37);
            this.radPageViewPage1.Name = "radPageViewPage1";
            this.radPageViewPage1.Size = new System.Drawing.Size(823, 552);
            this.radPageViewPage1.Text = "New Page";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(3, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(110, 24);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            // 
            // radRefresh
            // 
            this.radRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radRefresh.Location = new System.Drawing.Point(742, 4);
            this.radRefresh.Name = "radRefresh";
            this.radRefresh.Size = new System.Drawing.Size(67, 24);
            this.radRefresh.TabIndex = 2;
            this.radRefresh.Text = "Refresh";
            this.radRefresh.Click += new System.EventHandler(this.radRefresh_Click);
            // 
            // radGridView1
            // 
            this.radGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGridView1.Location = new System.Drawing.Point(0, 34);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            gridViewDateTimeColumn3.FieldName = "LogTime";
            gridViewDateTimeColumn3.HeaderText = "DateTime";
            gridViewDateTimeColumn3.IsAutoGenerated = true;
            gridViewDateTimeColumn3.Name = "Log Time";
            gridViewDateTimeColumn3.ReadOnly = true;
            gridViewDateTimeColumn3.Width = 130;
            conditionalFormattingObject7.ApplyToRow = true;
            conditionalFormattingObject7.CellBackColor = System.Drawing.Color.Empty;
            conditionalFormattingObject7.CellForeColor = System.Drawing.Color.Empty;
            conditionalFormattingObject7.Name = "WarningCondition";
            conditionalFormattingObject7.RowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            conditionalFormattingObject7.RowForeColor = System.Drawing.Color.Empty;
            conditionalFormattingObject7.TValue1 = "Warn";
            conditionalFormattingObject8.ApplyToRow = true;
            conditionalFormattingObject8.CellBackColor = System.Drawing.Color.Empty;
            conditionalFormattingObject8.CellForeColor = System.Drawing.Color.Empty;
            conditionalFormattingObject8.Name = "ErrorCondition";
            conditionalFormattingObject8.RowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            conditionalFormattingObject8.RowForeColor = System.Drawing.Color.Empty;
            conditionalFormattingObject8.TValue1 = "Error";
            conditionalFormattingObject9.ApplyToRow = true;
            conditionalFormattingObject9.CellBackColor = System.Drawing.Color.Red;
            conditionalFormattingObject9.CellFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            conditionalFormattingObject9.CellForeColor = System.Drawing.Color.Empty;
            conditionalFormattingObject9.Name = "FatalCondition";
            conditionalFormattingObject9.RowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            conditionalFormattingObject9.RowForeColor = System.Drawing.Color.Empty;
            conditionalFormattingObject9.TValue1 = "Fatal";
            gridViewTextBoxColumn7.ConditionalFormattingObjectList.Add(conditionalFormattingObject7);
            gridViewTextBoxColumn7.ConditionalFormattingObjectList.Add(conditionalFormattingObject8);
            gridViewTextBoxColumn7.ConditionalFormattingObjectList.Add(conditionalFormattingObject9);
            gridViewTextBoxColumn7.FieldName = "Level";
            gridViewTextBoxColumn7.HeaderText = "Level";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.Name = "Level";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn8.FieldName = "CallStack";
            gridViewTextBoxColumn8.HeaderText = "CallStack";
            gridViewTextBoxColumn8.IsAutoGenerated = true;
            gridViewTextBoxColumn8.Name = "Call Stack";
            gridViewTextBoxColumn8.ReadOnly = true;
            gridViewTextBoxColumn8.Width = 170;
            gridViewTextBoxColumn9.FieldName = "Message";
            gridViewTextBoxColumn9.HeaderText = "Message";
            gridViewTextBoxColumn9.IsAutoGenerated = true;
            gridViewTextBoxColumn9.Name = "Message";
            gridViewTextBoxColumn9.ReadOnly = true;
            gridViewTextBoxColumn9.Width = 450;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDateTimeColumn3,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9});
            this.radGridView1.MasterTemplate.DataSource = this.nlogEntityBindingSource;
            this.radGridView1.MasterTemplate.EnableFiltering = true;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.Size = new System.Drawing.Size(820, 522);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            // 
            // nlogEntityBindingSource
            // 
            this.nlogEntityBindingSource.DataSource = typeof(LogViewer.BackEnd.Entities.NlogEntity);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilePath.Location = new System.Drawing.Point(119, 4);
            this.txtFilePath.Multiline = true;
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFilePath.Size = new System.Drawing.Size(617, 24);
            this.txtFilePath.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 602);
            this.Controls.Add(this.radPageView1);
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Log Viewer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.radPageViewPage1.ResumeLayout(false);
            this.radPageViewPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nlogEntityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.BindingSource nlogEntityBindingSource;
        private Telerik.WinControls.UI.RadButton radRefresh;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Telerik.WinControls.UI.RadSplitButton btnOpen;
        private System.Windows.Forms.TextBox txtFilePath;
    }
}
