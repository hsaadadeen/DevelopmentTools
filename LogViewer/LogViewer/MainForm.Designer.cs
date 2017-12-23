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
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.ConditionalFormattingObject conditionalFormattingObject1 = new Telerik.WinControls.UI.ConditionalFormattingObject();
            Telerik.WinControls.UI.ConditionalFormattingObject conditionalFormattingObject2 = new Telerik.WinControls.UI.ConditionalFormattingObject();
            Telerik.WinControls.UI.ConditionalFormattingObject conditionalFormattingObject3 = new Telerik.WinControls.UI.ConditionalFormattingObject();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnOpen = new Telerik.WinControls.UI.RadSplitButton();
            this.radRefresh = new Telerik.WinControls.UI.RadButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.nlogEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
            this.radPageView1.Size = new System.Drawing.Size(996, 714);
            this.radPageView1.TabIndex = 0;
            this.radPageView1.Text = "radPageView1";
            this.radPageView1.NewPageRequested += new System.EventHandler(this.radPageView1_NewPageRequested);
            this.radPageView1.PageRemoving += new System.EventHandler<Telerik.WinControls.UI.RadPageViewCancelEventArgs>(this.radPageView1_PageRemoving);
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).ShowItemCloseButton = true;
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.Controls.Add(this.txtFilePath);
            this.radPageViewPage1.Controls.Add(this.btnOpen);
            this.radPageViewPage1.Controls.Add(this.radRefresh);
            this.radPageViewPage1.Controls.Add(this.radGridView1);
            this.radPageViewPage1.ItemSize = new System.Drawing.SizeF(84F, 28F);
            this.radPageViewPage1.Location = new System.Drawing.Point(10, 37);
            this.radPageViewPage1.Name = "radPageViewPage1";
            this.radPageViewPage1.Size = new System.Drawing.Size(975, 666);
            this.radPageViewPage1.Text = "Log File 1";
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
            this.txtFilePath.Size = new System.Drawing.Size(768, 24);
            this.txtFilePath.TabIndex = 1;
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
            this.radRefresh.Location = new System.Drawing.Point(893, 4);
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
            this.radGridView1.MasterTemplate.AllowSearchRow = true;
            gridViewDateTimeColumn1.FieldName = "LogTime";
            gridViewDateTimeColumn1.HeaderText = "DateTime";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "Log Time";
            gridViewDateTimeColumn1.ReadOnly = true;
            gridViewDateTimeColumn1.Width = 130;
            conditionalFormattingObject1.ApplyToRow = true;
            conditionalFormattingObject1.CellBackColor = System.Drawing.Color.Empty;
            conditionalFormattingObject1.CellForeColor = System.Drawing.Color.Empty;
            conditionalFormattingObject1.Name = "WarningCondition";
            conditionalFormattingObject1.RowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            conditionalFormattingObject1.RowForeColor = System.Drawing.Color.Empty;
            conditionalFormattingObject1.TValue1 = "Warn";
            conditionalFormattingObject2.ApplyToRow = true;
            conditionalFormattingObject2.CellBackColor = System.Drawing.Color.Empty;
            conditionalFormattingObject2.CellForeColor = System.Drawing.Color.Empty;
            conditionalFormattingObject2.Name = "ErrorCondition";
            conditionalFormattingObject2.RowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            conditionalFormattingObject2.RowForeColor = System.Drawing.Color.Empty;
            conditionalFormattingObject2.TValue1 = "Error";
            conditionalFormattingObject3.ApplyToRow = true;
            conditionalFormattingObject3.CellBackColor = System.Drawing.Color.Red;
            conditionalFormattingObject3.CellFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            conditionalFormattingObject3.CellForeColor = System.Drawing.Color.Empty;
            conditionalFormattingObject3.Name = "FatalCondition";
            conditionalFormattingObject3.RowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            conditionalFormattingObject3.RowForeColor = System.Drawing.Color.Empty;
            conditionalFormattingObject3.TValue1 = "Fatal";
            gridViewTextBoxColumn1.ConditionalFormattingObjectList.Add(conditionalFormattingObject1);
            gridViewTextBoxColumn1.ConditionalFormattingObjectList.Add(conditionalFormattingObject2);
            gridViewTextBoxColumn1.ConditionalFormattingObjectList.Add(conditionalFormattingObject3);
            gridViewTextBoxColumn1.FieldName = "Level";
            gridViewTextBoxColumn1.HeaderText = "Level";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Level";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn2.FieldName = "CallStack";
            gridViewTextBoxColumn2.HeaderText = "CallStack";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Call Stack";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 170;
            gridViewTextBoxColumn3.FieldName = "Message";
            gridViewTextBoxColumn3.HeaderText = "Message";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "Message";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            gridViewTextBoxColumn3.Width = 600;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.radGridView1.MasterTemplate.DataSource = this.nlogEntityBindingSource;
            this.radGridView1.MasterTemplate.EnableFiltering = true;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.Size = new System.Drawing.Size(971, 640);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.DoubleClick += new System.EventHandler(this.radGridView1_DoubleClick);
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
            this.Controls.Add(this.radPageView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Log Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
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
