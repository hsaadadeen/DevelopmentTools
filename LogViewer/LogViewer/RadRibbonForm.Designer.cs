namespace LogViewer
{
    partial class RadRibbonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadRibbonForm));
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.lblFileName = new Telerik.WinControls.UI.RadLabelElement();
            this.lblLinesCount = new Telerik.WinControls.UI.RadLabelElement();
            this.lblCurrentLine = new Telerik.WinControls.UI.RadLabelElement();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radDock = new Telerik.WinControls.UI.Docking.RadDock();
            this.wSavedLogs = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.lstSavedLogs = new Telerik.WinControls.UI.RadListControl();
            this.toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.documentContainer = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.radRibbonBar = new Telerik.WinControls.UI.RadRibbonBar();
            this.ribbonTab1 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radRibbonBarButtonGroup1 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.btnNew = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup2 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radRibbonBarButtonGroup2 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.btnLoad = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarButtonGroup5 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.btnLoadNew = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup3 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radRibbonBarButtonGroup3 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.btnSave = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup4 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radRibbonBarButtonGroup4 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.btnRefresh = new Telerik.WinControls.UI.RadButtonElement();
            this.chkAutoRefresh = new Telerik.WinControls.UI.RadCheckBoxElement();
            this.radMenuSeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.btnAbout = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radMenuSeparatorItem2 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.documentWindow1 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.radPageControl1 = new LogViewer.RadPageControl();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDock)).BeginInit();
            this.radDock.SuspendLayout();
            this.wSavedLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstSavedLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).BeginInit();
            this.toolTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).BeginInit();
            this.documentTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar)).BeginInit();
            this.documentWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblFileName,
            this.lblLinesCount,
            this.lblCurrentLine});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 748);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(1203, 26);
            this.radStatusStrip1.SizingGrip = false;
            this.radStatusStrip1.TabIndex = 1;
            this.radStatusStrip1.Text = "radStatusStrip1";
            // 
            // lblFileName
            // 
            this.lblFileName.Name = "lblFileName";
            this.radStatusStrip1.SetSpring(this.lblFileName, false);
            this.lblFileName.Text = "{file name}";
            this.lblFileName.TextWrap = true;
            // 
            // lblLinesCount
            // 
            this.lblLinesCount.Name = "lblLinesCount";
            this.radStatusStrip1.SetSpring(this.lblLinesCount, false);
            this.lblLinesCount.Text = "lines: ";
            this.lblLinesCount.TextWrap = true;
            // 
            // lblCurrentLine
            // 
            this.lblCurrentLine.Name = "lblCurrentLine";
            this.radStatusStrip1.SetSpring(this.lblCurrentLine, false);
            this.lblCurrentLine.Text = "ln: ";
            this.lblCurrentLine.TextWrap = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radDock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 584);
            this.panel1.TabIndex = 2;
            // 
            // radDock
            // 
            this.radDock.ActiveWindow = this.wSavedLogs;
            this.radDock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radDock.CausesValidation = false;
            this.radDock.Controls.Add(this.toolTabStrip1);
            this.radDock.Controls.Add(this.documentContainer);
            this.radDock.IsCleanUpTarget = true;
            this.radDock.Location = new System.Drawing.Point(0, 0);
            this.radDock.MainDocumentContainer = this.documentContainer;
            this.radDock.Name = "radDock";
            // 
            // 
            // 
            this.radDock.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.radDock.Size = new System.Drawing.Size(1203, 584);
            this.radDock.TabIndex = 0;
            this.radDock.TabStop = false;
            this.radDock.Text = "radDock1";
            this.radDock.DockWindowClosing += new Telerik.WinControls.UI.Docking.DockWindowCancelEventHandler(this.radDock_DockWindowClosing);
            this.radDock.ActiveWindowChanged += new Telerik.WinControls.UI.Docking.DockWindowEventHandler(this.radDock_ActiveWindowChanged);
            // 
            // wSavedLogs
            // 
            this.wSavedLogs.Caption = null;
            this.wSavedLogs.Controls.Add(this.lstSavedLogs);
            this.wSavedLogs.Font = new System.Drawing.Font("Tahoma", 8F);
            this.wSavedLogs.Location = new System.Drawing.Point(1, 24);
            this.wSavedLogs.Name = "wSavedLogs";
            this.wSavedLogs.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Hidden;
            this.wSavedLogs.Size = new System.Drawing.Size(198, 548);
            this.wSavedLogs.Text = "Saved Logs";
            // 
            // lstSavedLogs
            // 
            this.lstSavedLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSavedLogs.Location = new System.Drawing.Point(6, 3);
            this.lstSavedLogs.Name = "lstSavedLogs";
            this.lstSavedLogs.Size = new System.Drawing.Size(177, 578);
            this.lstSavedLogs.TabIndex = 0;
            this.lstSavedLogs.Text = "radListControl1";
            this.lstSavedLogs.SelectedItemsChanged += new Telerik.WinControls.Data.NotifyCollectionChangedEventHandler(this.lstSavedLogs_SelectedItemsChanged);
            this.lstSavedLogs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstSavedLogs_MouseDoubleClick);
            // 
            // toolTabStrip1
            // 
            this.toolTabStrip1.CanUpdateChildIndex = true;
            this.toolTabStrip1.Controls.Add(this.wSavedLogs);
            this.toolTabStrip1.Location = new System.Drawing.Point(5, 5);
            this.toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            this.toolTabStrip1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.toolTabStrip1.SelectedIndex = 0;
            this.toolTabStrip1.Size = new System.Drawing.Size(200, 574);
            this.toolTabStrip1.TabIndex = 4;
            this.toolTabStrip1.TabStop = false;
            // 
            // documentContainer
            // 
            this.documentContainer.CausesValidation = false;
            this.documentContainer.Name = "documentContainer";
            // 
            // 
            // 
            this.documentContainer.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.documentContainer.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            this.documentContainer.TabIndex = 2;
            // 
            // documentTabStrip1
            // 
            this.documentTabStrip1.CanUpdateChildIndex = true;
            this.documentTabStrip1.Controls.Add(this.documentWindow1);
            this.documentTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.documentTabStrip1.Name = "documentTabStrip1";
            // 
            // 
            // 
            this.documentTabStrip1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentTabStrip1.SelectedIndex = 0;
            this.documentTabStrip1.Size = new System.Drawing.Size(989, 590);
            this.documentTabStrip1.TabIndex = 0;
            this.documentTabStrip1.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // radRibbonBar
            // 
            this.radRibbonBar.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.ribbonTab1});
            // 
            // 
            // 
            this.radRibbonBar.ExitButton.Image = global::LogViewer.Properties.Resources.blackExit;
            this.radRibbonBar.ExitButton.Text = "Exit";
            this.radRibbonBar.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radRibbonBar.ExitButton.Click += new System.EventHandler(this.radRibbonBar_ExitButton_Click);
            this.radRibbonBar.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar.Name = "radRibbonBar";
            // 
            // 
            // 
            this.radRibbonBar.OptionsButton.Image = global::LogViewer.Properties.Resources.blackOptions;
            this.radRibbonBar.OptionsButton.Text = "Options";
            this.radRibbonBar.OptionsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radRibbonBar.OptionsButton.Click += new System.EventHandler(this.radRibbonBar_OptionsButton_Click);
            // 
            // 
            // 
            this.radRibbonBar.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radRibbonBar.Size = new System.Drawing.Size(1203, 164);
            this.radRibbonBar.StartButtonImage = ((System.Drawing.Image)(resources.GetObject("radRibbonBar.StartButtonImage")));
            this.radRibbonBar.StartMenuItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuSeparatorItem1,
            this.btnAbout,
            this.radMenuSeparatorItem2});
            this.radRibbonBar.TabIndex = 0;
            this.radRibbonBar.Text = "Log Viewer";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.IsSelected = true;
            this.ribbonTab1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup1,
            this.radRibbonBarGroup2,
            this.radRibbonBarGroup3,
            this.radRibbonBarGroup4});
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Home";
            // 
            // radRibbonBarGroup1
            // 
            this.radRibbonBarGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarButtonGroup1});
            this.radRibbonBarGroup1.Name = "radRibbonBarGroup1";
            this.radRibbonBarGroup1.Text = "New";
            this.radRibbonBarGroup1.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // radRibbonBarButtonGroup1
            // 
            this.radRibbonBarButtonGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnNew});
            this.radRibbonBarButtonGroup1.Name = "radRibbonBarButtonGroup1";
            this.radRibbonBarButtonGroup1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.radRibbonBarButtonGroup1.Text = "radRibbonBarButtonGroup1";
            // 
            // btnNew
            // 
            this.btnNew.AutoSize = false;
            this.btnNew.Bounds = new System.Drawing.Rectangle(0, 0, 55, 63);
            this.btnNew.Image = global::LogViewer.Properties.Resources.blackNewTab;
            this.btnNew.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNew.Name = "btnNew";
            this.btnNew.Shape = null;
            this.btnNew.ShowBorder = false;
            this.btnNew.Text = "New Tab";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNew.TextWrap = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // radRibbonBarGroup2
            // 
            this.radRibbonBarGroup2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarButtonGroup2,
            this.radRibbonBarButtonGroup5});
            this.radRibbonBarGroup2.Name = "radRibbonBarGroup2";
            this.radRibbonBarGroup2.Text = "Load";
            // 
            // radRibbonBarButtonGroup2
            // 
            this.radRibbonBarButtonGroup2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnLoad});
            this.radRibbonBarButtonGroup2.Name = "radRibbonBarButtonGroup2";
            this.radRibbonBarButtonGroup2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.radRibbonBarButtonGroup2.Text = "radRibbonBarButtonGroup2";
            // 
            // btnLoad
            // 
            this.btnLoad.AutoSize = false;
            this.btnLoad.Bounds = new System.Drawing.Rectangle(0, 0, 55, 63);
            this.btnLoad.Image = global::LogViewer.Properties.Resources.blackLoadFile;
            this.btnLoad.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Text = "Load in Tab";
            this.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLoad.TextWrap = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // radRibbonBarButtonGroup5
            // 
            this.radRibbonBarButtonGroup5.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnLoadNew});
            this.radRibbonBarButtonGroup5.Name = "radRibbonBarButtonGroup5";
            this.radRibbonBarButtonGroup5.Text = "radRibbonBarButtonGroup5";
            // 
            // btnLoadNew
            // 
            this.btnLoadNew.AutoSize = false;
            this.btnLoadNew.Bounds = new System.Drawing.Rectangle(0, 0, 55, 63);
            this.btnLoadNew.Image = global::LogViewer.Properties.Resources.blackOpenFile;
            this.btnLoadNew.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLoadNew.Name = "btnLoadNew";
            this.btnLoadNew.Text = "Load in New Tab";
            this.btnLoadNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLoadNew.TextWrap = true;
            this.btnLoadNew.Click += new System.EventHandler(this.btnLoadNew_Click);
            // 
            // radRibbonBarGroup3
            // 
            this.radRibbonBarGroup3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarButtonGroup3});
            this.radRibbonBarGroup3.Name = "radRibbonBarGroup3";
            this.radRibbonBarGroup3.Text = "Save";
            // 
            // radRibbonBarButtonGroup3
            // 
            this.radRibbonBarButtonGroup3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnSave});
            this.radRibbonBarButtonGroup3.Name = "radRibbonBarButtonGroup3";
            this.radRibbonBarButtonGroup3.Text = "radRibbonBarButtonGroup3";
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.Bounds = new System.Drawing.Rectangle(0, 0, 48, 63);
            this.btnSave.Image = global::LogViewer.Properties.Resources.blackSaveFile;
            this.btnSave.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Name = "btnSave";
            this.btnSave.ShouldPaint = true;
            this.btnSave.ShowBorder = false;
            this.btnSave.Text = "Save Log Path";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.TextWrap = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // radRibbonBarGroup4
            // 
            this.radRibbonBarGroup4.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarButtonGroup4});
            this.radRibbonBarGroup4.Name = "radRibbonBarGroup4";
            this.radRibbonBarGroup4.Text = "Refresh";
            // 
            // radRibbonBarButtonGroup4
            // 
            this.radRibbonBarButtonGroup4.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnRefresh,
            this.chkAutoRefresh});
            this.radRibbonBarButtonGroup4.Name = "radRibbonBarButtonGroup4";
            this.radRibbonBarButtonGroup4.Text = "radRibbonBarButtonGroup4";
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = false;
            this.btnRefresh.Bounds = new System.Drawing.Rectangle(0, 0, 48, 63);
            this.btnRefresh.Image = global::LogViewer.Properties.Resources.blackRefreshFile;
            this.btnRefresh.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.TextWrap = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // chkAutoRefresh
            // 
            this.chkAutoRefresh.Checked = false;
            this.chkAutoRefresh.Name = "chkAutoRefresh";
            this.chkAutoRefresh.ReadOnly = false;
            this.chkAutoRefresh.Text = "Auto Refresh";
            this.chkAutoRefresh.CheckStateChanged += new System.EventHandler(this.chkAutoRefresh_CheckStateChanged);
            // 
            // radMenuSeparatorItem1
            // 
            this.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAbout
            // 
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // radMenuSeparatorItem2
            // 
            this.radMenuSeparatorItem2.Name = "radMenuSeparatorItem2";
            this.radMenuSeparatorItem2.Text = "radMenuSeparatorItem2";
            this.radMenuSeparatorItem2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // documentWindow1
            // 
            this.documentWindow1.Controls.Add(this.radPageControl1);
            this.documentWindow1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.documentWindow1.Location = new System.Drawing.Point(6, 27);
            this.documentWindow1.Name = "documentWindow1";
            this.documentWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            this.documentWindow1.Size = new System.Drawing.Size(977, 557);
            this.documentWindow1.Text = "documentWindow1";
            // 
            // radPageControl1
            // 
            this.radPageControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radPageControl1.AutoRefreshEnabled = false;
            this.radPageControl1.FilePath = "{file path}";
            this.radPageControl1.Location = new System.Drawing.Point(-3, 3);
            this.radPageControl1.Name = "radPageControl1";
            this.radPageControl1.Size = new System.Drawing.Size(914, 633);
            this.radPageControl1.TabIndex = 0;
            // 
            // RadRibbonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 774);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.radRibbonBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = null;
            this.Name = "RadRibbonForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Log Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RadRibbonForm_FormClosing);
            this.Load += new System.EventHandler(this.RadRibbonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radDock)).EndInit();
            this.radDock.ResumeLayout(false);
            this.wSavedLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstSavedLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).EndInit();
            this.toolTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).EndInit();
            this.documentTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar)).EndInit();
            this.documentWindow1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.Docking.RadDock radDock;
        private Telerik.WinControls.UI.Docking.ToolWindow wSavedLogs;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow1;
        private RadPageControl radPageControl1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab1;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup1;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup1;
        private Telerik.WinControls.UI.RadButtonElement btnNew;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup2;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup3;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup2;
        private Telerik.WinControls.UI.RadButtonElement btnLoad;
        private Telerik.WinControls.UI.RadButtonElement btnRefresh;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.UI.RadLabelElement lblFileName;
        private Telerik.WinControls.UI.RadLabelElement lblLinesCount;
        private Telerik.WinControls.UI.RadLabelElement lblCurrentLine;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup3;
        private Telerik.WinControls.UI.RadButtonElement btnSave;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup4;
        private Telerik.WinControls.UI.RadCheckBoxElement chkAutoRefresh;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup4;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem1;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.UI.RadMenuButtonItem btnAbout;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem2;
        private Telerik.WinControls.UI.RadListControl lstSavedLogs;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup5;
        private Telerik.WinControls.UI.RadButtonElement btnLoadNew;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
    }
}
