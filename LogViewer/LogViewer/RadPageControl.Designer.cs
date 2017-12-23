namespace LogViewer
{
    partial class RadPageControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.ConditionalFormattingObject conditionalFormattingObject1 = new Telerik.WinControls.UI.ConditionalFormattingObject();
            Telerik.WinControls.UI.ConditionalFormattingObject conditionalFormattingObject2 = new Telerik.WinControls.UI.ConditionalFormattingObject();
            Telerik.WinControls.UI.ConditionalFormattingObject conditionalFormattingObject3 = new Telerik.WinControls.UI.ConditionalFormattingObject();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnOpen = new Telerik.WinControls.UI.RadSplitButton();
            this.radRefresh = new Telerik.WinControls.UI.RadButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilePath.Location = new System.Drawing.Point(121, 3);
            this.txtFilePath.Multiline = true;
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFilePath.Size = new System.Drawing.Size(768, 24);
            this.txtFilePath.TabIndex = 4;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(5, 3);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(110, 24);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "Open";
            // 
            // radRefresh
            // 
            this.radRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radRefresh.Location = new System.Drawing.Point(895, 3);
            this.radRefresh.Name = "radRefresh";
            this.radRefresh.Size = new System.Drawing.Size(67, 24);
            this.radRefresh.TabIndex = 6;
            this.radRefresh.Text = "Refresh";
            // 
            // radGridView1
            // 
            this.radGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGridView1.Location = new System.Drawing.Point(2, 33);
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
            this.radGridView1.MasterTemplate.EnableFiltering = true;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.Size = new System.Drawing.Size(971, 630);
            this.radGridView1.TabIndex = 3;
            this.radGridView1.Text = "radGridView1";
            // 
            // RadPageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.radRefresh);
            this.Controls.Add(this.radGridView1);
            this.Name = "RadPageControl";
            this.Size = new System.Drawing.Size(975, 666);
            ((System.ComponentModel.ISupportInitialize)(this.btnOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilePath;
        private Telerik.WinControls.UI.RadSplitButton btnOpen;
        private Telerik.WinControls.UI.RadButton radRefresh;
        private Telerik.WinControls.UI.RadGridView radGridView1;
    }
}
