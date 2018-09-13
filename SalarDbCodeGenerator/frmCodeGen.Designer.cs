namespace SalarDbCodeGenerator
{
	partial class frmCodeGen
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Tables", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Views", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Stored Procedure", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Common", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Project", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Pattern1");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Pattern2");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Pattern");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Pattern3");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("TestView1");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("TestView2");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("TestTable1");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("TestTable2");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCodeGen));
            this.barStarusBar = new System.Windows.Forms.StatusStrip();
            this.lblModified = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.barProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.splContent = new System.Windows.Forms.SplitContainer();
            this.lstPatterns = new System.Windows.Forms.ListView();
            this.colTemplates = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlPatternInfo = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPatternDatabases = new System.Windows.Forms.Label();
            this.lblPatternLanguage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbPatternProjectFile = new System.Windows.Forms.ComboBox();
            this.btnChangePattern = new System.Windows.Forms.Button();
            this.tabMainProject = new System.Windows.Forms.TabControl();
            this.tabDatabaseContents = new System.Windows.Forms.TabPage();
            this.btnRefetchDatabase = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lstViews = new System.Windows.Forms.ListView();
            this.colViews = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstTables = new System.Windows.Forms.ListView();
            this.colTables = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabGenFiles = new System.Windows.Forms.TabPage();
            this.btnRefrshGenFiles = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treGenFiles = new System.Windows.Forms.TreeView();
            this.imgGeneratedFiles = new System.Windows.Forms.ImageList(this.components);
            this.txtCodeEditor = new ICSharpCode.TextEditor.TextEditorControl();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lnkGenerationPath = new System.Windows.Forms.LinkLabel();
            this.lblInfoGenerationPath = new System.Windows.Forms.Label();
            this.lblInfoLastGeneration = new System.Windows.Forms.Label();
            this.lblInfoDbServer = new System.Windows.Forms.Label();
            this.lblInfoProjectName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.barStandard = new System.Windows.Forms.ToolStrip();
            this.btnNewProject = new System.Windows.Forms.ToolStripButton();
            this.btnOpenProject = new System.Windows.Forms.ToolStripButton();
            this.barSp2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSaveProject = new System.Windows.Forms.ToolStripButton();
            this.btnSaveAs = new System.Windows.Forms.ToolStripButton();
            this.barSp1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnProjectOptions = new System.Windows.Forms.ToolStripButton();
            this.barSp3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnStartGeneration = new System.Windows.Forms.ToolStripButton();
            this.barMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnufile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReopen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLine5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuClearReopen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLine1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLine2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLine3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRefetchDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLine4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuStartGenerate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpenPattern = new System.Windows.Forms.OpenFileDialog();
            this.tipHints = new System.Windows.Forms.ToolTip(this.components);
            this.dlgOpenProject = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveProject = new System.Windows.Forms.SaveFileDialog();
            this.barStarusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splContent)).BeginInit();
            this.splContent.Panel1.SuspendLayout();
            this.splContent.Panel2.SuspendLayout();
            this.splContent.SuspendLayout();
            this.pnlPatternInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabMainProject.SuspendLayout();
            this.tabDatabaseContents.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabGenFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.barStandard.SuspendLayout();
            this.barMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // barStarusBar
            // 
            this.barStarusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblModified});
            this.barStarusBar.Location = new System.Drawing.Point(0, 534);
            this.barStarusBar.Name = "barStarusBar";
            this.barStarusBar.Size = new System.Drawing.Size(793, 22);
            this.barStarusBar.TabIndex = 0;
            // 
            // lblModified
            // 
            this.lblModified.Name = "lblModified";
            this.lblModified.Size = new System.Drawing.Size(44, 17);
            this.lblModified.Text = "Ready";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 17);
            this.lblStatus.Tag = "";
            this.lblStatus.Text = "Done";
            // 
            // barProgress
            // 
            this.barProgress.Name = "barProgress";
            this.barProgress.Size = new System.Drawing.Size(100, 16);
            this.barProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // splContent
            // 
            this.splContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splContent.Location = new System.Drawing.Point(0, 102);
            this.splContent.Name = "splContent";
            // 
            // splContent.Panel1
            // 
            this.splContent.Panel1.Controls.Add(this.lstPatterns);
            this.splContent.Panel1.Controls.Add(this.pnlPatternInfo);
            this.splContent.Panel1.Controls.Add(this.panel1);
            // 
            // splContent.Panel2
            // 
            this.splContent.Panel2.Controls.Add(this.tabMainProject);
            this.splContent.Size = new System.Drawing.Size(793, 432);
            this.splContent.SplitterDistance = 217;
            this.splContent.TabIndex = 0;
            // 
            // lstPatterns
            // 
            this.lstPatterns.CheckBoxes = true;
            this.lstPatterns.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTemplates});
            this.lstPatterns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPatterns.FullRowSelect = true;
            this.lstPatterns.GridLines = true;
            listViewGroup1.Header = "Tables";
            listViewGroup1.Name = "Tables";
            listViewGroup2.Header = "Views";
            listViewGroup2.Name = "Views";
            listViewGroup3.Header = "Stored Procedure";
            listViewGroup3.Name = "StoredProcedure";
            listViewGroup4.Header = "Common";
            listViewGroup4.Name = "Common";
            listViewGroup5.Header = "Project";
            listViewGroup5.Name = "Project";
            this.lstPatterns.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5});
            this.lstPatterns.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem1.Group = listViewGroup2;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.Group = listViewGroup2;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.Group = listViewGroup1;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.Group = listViewGroup3;
            listViewItem4.StateImageIndex = 0;
            this.lstPatterns.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.lstPatterns.Location = new System.Drawing.Point(0, 60);
            this.lstPatterns.Name = "lstPatterns";
            this.lstPatterns.ShowItemToolTips = true;
            this.lstPatterns.Size = new System.Drawing.Size(217, 372);
            this.lstPatterns.TabIndex = 0;
            this.lstPatterns.UseCompatibleStateImageBehavior = false;
            this.lstPatterns.View = System.Windows.Forms.View.Details;
            this.lstPatterns.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstPatterns_ItemChecked);
            this.lstPatterns.SelectedIndexChanged += new System.EventHandler(this.lstPatterns_SelectedIndexChanged);
            // 
            // colTemplates
            // 
            this.colTemplates.Text = "模板";
            this.colTemplates.Width = 163;
            // 
            // pnlPatternInfo
            // 
            this.pnlPatternInfo.Controls.Add(this.label5);
            this.pnlPatternInfo.Controls.Add(this.label4);
            this.pnlPatternInfo.Controls.Add(this.lblPatternDatabases);
            this.pnlPatternInfo.Controls.Add(this.lblPatternLanguage);
            this.pnlPatternInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPatternInfo.Location = new System.Drawing.Point(0, 25);
            this.pnlPatternInfo.Name = "pnlPatternInfo";
            this.pnlPatternInfo.Size = new System.Drawing.Size(217, 35);
            this.pnlPatternInfo.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(3, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "数据库支持:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "语言:";
            // 
            // lblPatternDatabases
            // 
            this.lblPatternDatabases.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPatternDatabases.AutoEllipsis = true;
            this.lblPatternDatabases.Location = new System.Drawing.Point(67, 19);
            this.lblPatternDatabases.Name = "lblPatternDatabases";
            this.lblPatternDatabases.Size = new System.Drawing.Size(147, 12);
            this.lblPatternDatabases.TabIndex = 3;
            this.lblPatternDatabases.Text = "(None)";
            // 
            // lblPatternLanguage
            // 
            this.lblPatternLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPatternLanguage.AutoEllipsis = true;
            this.lblPatternLanguage.Location = new System.Drawing.Point(67, 3);
            this.lblPatternLanguage.Name = "lblPatternLanguage";
            this.lblPatternLanguage.Size = new System.Drawing.Size(147, 12);
            this.lblPatternLanguage.TabIndex = 3;
            this.lblPatternLanguage.Text = "(None)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbPatternProjectFile);
            this.panel1.Controls.Add(this.btnChangePattern);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 25);
            this.panel1.TabIndex = 1;
            // 
            // cmbPatternProjectFile
            // 
            this.cmbPatternProjectFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPatternProjectFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatternProjectFile.FormattingEnabled = true;
            this.cmbPatternProjectFile.ItemHeight = 12;
            this.cmbPatternProjectFile.Location = new System.Drawing.Point(3, 3);
            this.cmbPatternProjectFile.MaxDropDownItems = 15;
            this.cmbPatternProjectFile.Name = "cmbPatternProjectFile";
            this.cmbPatternProjectFile.Size = new System.Drawing.Size(180, 20);
            this.cmbPatternProjectFile.TabIndex = 2;
            this.tipHints.SetToolTip(this.cmbPatternProjectFile, "Pattern projects");
            this.cmbPatternProjectFile.SelectedIndexChanged += new System.EventHandler(this.cmbPatternProjectFile_SelectedIndexChanged);
            // 
            // btnChangePattern
            // 
            this.btnChangePattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePattern.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangePattern.Location = new System.Drawing.Point(189, 2);
            this.btnChangePattern.Name = "btnChangePattern";
            this.btnChangePattern.Size = new System.Drawing.Size(25, 21);
            this.btnChangePattern.TabIndex = 1;
            this.btnChangePattern.Text = "...";
            this.tipHints.SetToolTip(this.btnChangePattern, "Change pattern project");
            this.btnChangePattern.UseVisualStyleBackColor = true;
            this.btnChangePattern.Click += new System.EventHandler(this.btnChangePattern_Click);
            // 
            // tabMainProject
            // 
            this.tabMainProject.Controls.Add(this.tabDatabaseContents);
            this.tabMainProject.Controls.Add(this.tabGenFiles);
            this.tabMainProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMainProject.Location = new System.Drawing.Point(0, 0);
            this.tabMainProject.Name = "tabMainProject";
            this.tabMainProject.SelectedIndex = 0;
            this.tabMainProject.Size = new System.Drawing.Size(572, 432);
            this.tabMainProject.TabIndex = 0;
            // 
            // tabDatabaseContents
            // 
            this.tabDatabaseContents.Controls.Add(this.btnRefetchDatabase);
            this.tabDatabaseContents.Controls.Add(this.tableLayoutPanel1);
            this.tabDatabaseContents.Location = new System.Drawing.Point(4, 22);
            this.tabDatabaseContents.Name = "tabDatabaseContents";
            this.tabDatabaseContents.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatabaseContents.Size = new System.Drawing.Size(564, 406);
            this.tabDatabaseContents.TabIndex = 0;
            this.tabDatabaseContents.Text = "数据库";
            this.tabDatabaseContents.UseVisualStyleBackColor = true;
            // 
            // btnRefetchDatabase
            // 
            this.btnRefetchDatabase.Image = global::SalarDbCodeGenerator.Properties.Resources.DbRefetch16;
            this.btnRefetchDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefetchDatabase.Location = new System.Drawing.Point(9, 7);
            this.btnRefetchDatabase.Name = "btnRefetchDatabase";
            this.btnRefetchDatabase.Size = new System.Drawing.Size(130, 21);
            this.btnRefetchDatabase.TabIndex = 1;
            this.btnRefetchDatabase.Text = "获取数据库";
            this.btnRefetchDatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tipHints.SetToolTip(this.btnRefetchDatabase, "Reloads tables and views from data source");
            this.btnRefetchDatabase.UseVisualStyleBackColor = true;
            this.btnRefetchDatabase.Click += new System.EventHandler(this.btnRefetchDatabase_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lstViews, 0, -1);
            this.tableLayoutPanel1.Controls.Add(this.lstTables, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 34);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 372F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 372F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 372F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 372F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(549, 366);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lstViews
            // 
            this.lstViews.CheckBoxes = true;
            this.lstViews.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colViews});
            this.lstViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstViews.FullRowSelect = true;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.StateImageIndex = 0;
            this.lstViews.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6});
            this.lstViews.Location = new System.Drawing.Point(3, 3);
            this.lstViews.Name = "lstViews";
            this.lstViews.Size = new System.Drawing.Size(268, 360);
            this.lstViews.TabIndex = 0;
            this.lstViews.UseCompatibleStateImageBehavior = false;
            this.lstViews.View = System.Windows.Forms.View.Details;
            this.lstViews.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstViews_ItemChecked);
            // 
            // colViews
            // 
            this.colViews.Text = "Views";
            this.colViews.Width = 222;
            // 
            // lstTables
            // 
            this.lstTables.CheckBoxes = true;
            this.lstTables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTables});
            this.lstTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTables.FullRowSelect = true;
            listViewItem7.StateImageIndex = 0;
            listViewItem8.StateImageIndex = 0;
            this.lstTables.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8});
            this.lstTables.Location = new System.Drawing.Point(277, 3);
            this.lstTables.Name = "lstTables";
            this.lstTables.Size = new System.Drawing.Size(269, 360);
            this.lstTables.TabIndex = 2;
            this.lstTables.UseCompatibleStateImageBehavior = false;
            this.lstTables.View = System.Windows.Forms.View.Details;
            this.lstTables.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstTables_ItemChecked);
            // 
            // colTables
            // 
            this.colTables.Text = "Tables";
            this.colTables.Width = 222;
            // 
            // tabGenFiles
            // 
            this.tabGenFiles.Controls.Add(this.btnRefrshGenFiles);
            this.tabGenFiles.Controls.Add(this.splitContainer2);
            this.tabGenFiles.Location = new System.Drawing.Point(4, 22);
            this.tabGenFiles.Name = "tabGenFiles";
            this.tabGenFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabGenFiles.Size = new System.Drawing.Size(564, 406);
            this.tabGenFiles.TabIndex = 1;
            this.tabGenFiles.Text = "生成文件";
            this.tabGenFiles.UseVisualStyleBackColor = true;
            // 
            // btnRefrshGenFiles
            // 
            this.btnRefrshGenFiles.Image = global::SalarDbCodeGenerator.Properties.Resources.Refresh16;
            this.btnRefrshGenFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefrshGenFiles.Location = new System.Drawing.Point(9, 7);
            this.btnRefrshGenFiles.Name = "btnRefrshGenFiles";
            this.btnRefrshGenFiles.Size = new System.Drawing.Size(130, 21);
            this.btnRefrshGenFiles.TabIndex = 2;
            this.btnRefrshGenFiles.Text = "Refresh Files";
            this.btnRefrshGenFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefrshGenFiles.UseVisualStyleBackColor = true;
            this.btnRefrshGenFiles.Click += new System.EventHandler(this.btnRefrshGenFiles_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(6, 34);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.treGenFiles);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtCodeEditor);
            this.splitContainer2.Size = new System.Drawing.Size(550, 369);
            this.splitContainer2.SplitterDistance = 181;
            this.splitContainer2.TabIndex = 0;
            // 
            // treGenFiles
            // 
            this.treGenFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treGenFiles.FullRowSelect = true;
            this.treGenFiles.ImageIndex = 2;
            this.treGenFiles.ImageList = this.imgGeneratedFiles;
            this.treGenFiles.ItemHeight = 20;
            this.treGenFiles.Location = new System.Drawing.Point(0, 0);
            this.treGenFiles.Name = "treGenFiles";
            this.treGenFiles.SelectedImageKey = "Folder";
            this.treGenFiles.Size = new System.Drawing.Size(181, 369);
            this.treGenFiles.StateImageList = this.imgGeneratedFiles;
            this.treGenFiles.TabIndex = 0;
            this.treGenFiles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treGenFiles_AfterSelect);
            // 
            // imgGeneratedFiles
            // 
            this.imgGeneratedFiles.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgGeneratedFiles.ImageStream")));
            this.imgGeneratedFiles.TransparentColor = System.Drawing.Color.Transparent;
            this.imgGeneratedFiles.Images.SetKeyName(0, "FileCS");
            this.imgGeneratedFiles.Images.SetKeyName(1, "Folder");
            this.imgGeneratedFiles.Images.SetKeyName(2, "File");
            this.imgGeneratedFiles.Images.SetKeyName(3, "FileVB");
            // 
            // txtCodeEditor
            // 
            this.txtCodeEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodeEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodeEditor.IsIconBarVisible = true;
            this.txtCodeEditor.IsReadOnly = false;
            this.txtCodeEditor.Location = new System.Drawing.Point(0, 0);
            this.txtCodeEditor.Name = "txtCodeEditor";
            this.txtCodeEditor.Size = new System.Drawing.Size(365, 369);
            this.txtCodeEditor.TabIndex = 9;
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.lnkGenerationPath);
            this.pnlInfo.Controls.Add(this.lblInfoGenerationPath);
            this.pnlInfo.Controls.Add(this.lblInfoLastGeneration);
            this.pnlInfo.Controls.Add(this.lblInfoDbServer);
            this.pnlInfo.Controls.Add(this.lblInfoProjectName);
            this.pnlInfo.Controls.Add(this.label3);
            this.pnlInfo.Controls.Add(this.label2);
            this.pnlInfo.Controls.Add(this.label1);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(0, 50);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(793, 52);
            this.pnlInfo.TabIndex = 3;
            // 
            // lnkGenerationPath
            // 
            this.lnkGenerationPath.AutoSize = true;
            this.lnkGenerationPath.Location = new System.Drawing.Point(246, 30);
            this.lnkGenerationPath.Name = "lnkGenerationPath";
            this.lnkGenerationPath.Size = new System.Drawing.Size(59, 12);
            this.lnkGenerationPath.TabIndex = 5;
            this.lnkGenerationPath.TabStop = true;
            this.lnkGenerationPath.Text = "生成路径:";
            this.lnkGenerationPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGenerationPath_LinkClicked);
            // 
            // lblInfoGenerationPath
            // 
            this.lblInfoGenerationPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoGenerationPath.AutoEllipsis = true;
            this.lblInfoGenerationPath.Location = new System.Drawing.Point(337, 30);
            this.lblInfoGenerationPath.Name = "lblInfoGenerationPath";
            this.lblInfoGenerationPath.Size = new System.Drawing.Size(444, 12);
            this.lblInfoGenerationPath.TabIndex = 3;
            this.lblInfoGenerationPath.Text = "(None)";
            // 
            // lblInfoLastGeneration
            // 
            this.lblInfoLastGeneration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoLastGeneration.AutoEllipsis = true;
            this.lblInfoLastGeneration.Location = new System.Drawing.Point(337, 9);
            this.lblInfoLastGeneration.Name = "lblInfoLastGeneration";
            this.lblInfoLastGeneration.Size = new System.Drawing.Size(444, 12);
            this.lblInfoLastGeneration.TabIndex = 3;
            this.lblInfoLastGeneration.Text = "(None)";
            // 
            // lblInfoDbServer
            // 
            this.lblInfoDbServer.AutoEllipsis = true;
            this.lblInfoDbServer.Location = new System.Drawing.Point(92, 30);
            this.lblInfoDbServer.Name = "lblInfoDbServer";
            this.lblInfoDbServer.Size = new System.Drawing.Size(148, 12);
            this.lblInfoDbServer.TabIndex = 3;
            this.lblInfoDbServer.Text = "(None)";
            // 
            // lblInfoProjectName
            // 
            this.lblInfoProjectName.AutoEllipsis = true;
            this.lblInfoProjectName.Location = new System.Drawing.Point(92, 9);
            this.lblInfoProjectName.Name = "lblInfoProjectName";
            this.lblInfoProjectName.Size = new System.Drawing.Size(148, 12);
            this.lblInfoProjectName.TabIndex = 3;
            this.lblInfoProjectName.Text = "(无)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "上次生成:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "服务器:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "项目名称:";
            // 
            // barStandard
            // 
            this.barStandard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewProject,
            this.btnOpenProject,
            this.barSp2,
            this.btnSaveProject,
            this.btnSaveAs,
            this.barSp1,
            this.btnProjectOptions,
            this.barSp3,
            this.btnStartGeneration});
            this.barStandard.Location = new System.Drawing.Point(0, 25);
            this.barStandard.Name = "barStandard";
            this.barStandard.Size = new System.Drawing.Size(793, 25);
            this.barStandard.TabIndex = 0;
            // 
            // btnNewProject
            // 
            this.btnNewProject.Image = global::SalarDbCodeGenerator.Properties.Resources.New16;
            this.btnNewProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Size = new System.Drawing.Size(76, 22);
            this.btnNewProject.Text = "新建项目";
            this.btnNewProject.Click += new System.EventHandler(this.btnNewProject_Click);
            // 
            // btnOpenProject
            // 
            this.btnOpenProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenProject.Image = global::SalarDbCodeGenerator.Properties.Resources.Open16;
            this.btnOpenProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenProject.Name = "btnOpenProject";
            this.btnOpenProject.Size = new System.Drawing.Size(23, 22);
            this.btnOpenProject.Text = "Open Project";
            this.btnOpenProject.Click += new System.EventHandler(this.btnOpenProject_Click);
            // 
            // barSp2
            // 
            this.barSp2.Name = "barSp2";
            this.barSp2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSaveProject
            // 
            this.btnSaveProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveProject.Image = global::SalarDbCodeGenerator.Properties.Resources.Save16;
            this.btnSaveProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveProject.Name = "btnSaveProject";
            this.btnSaveProject.Size = new System.Drawing.Size(23, 22);
            this.btnSaveProject.Text = "Save Project";
            this.btnSaveProject.Click += new System.EventHandler(this.btnSaveProject_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAs.Image = global::SalarDbCodeGenerator.Properties.Resources.SaveAs16;
            this.btnSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(23, 22);
            this.btnSaveAs.Text = "Save as...";
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // barSp1
            // 
            this.barSp1.Name = "barSp1";
            this.barSp1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnProjectOptions
            // 
            this.btnProjectOptions.Image = global::SalarDbCodeGenerator.Properties.Resources.Settings16;
            this.btnProjectOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProjectOptions.Name = "btnProjectOptions";
            this.btnProjectOptions.Size = new System.Drawing.Size(52, 22);
            this.btnProjectOptions.Text = "设置";
            this.btnProjectOptions.Click += new System.EventHandler(this.btnProjectOptions_Click);
            // 
            // barSp3
            // 
            this.barSp3.Name = "barSp3";
            this.barSp3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnStartGeneration
            // 
            this.btnStartGeneration.Image = global::SalarDbCodeGenerator.Properties.Resources.Generate16;
            this.btnStartGeneration.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStartGeneration.Name = "btnStartGeneration";
            this.btnStartGeneration.Size = new System.Drawing.Size(52, 22);
            this.btnStartGeneration.Text = "生成";
            this.btnStartGeneration.Click += new System.EventHandler(this.btnStartGeneration_Click);
            // 
            // barMainMenu
            // 
            this.barMainMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.barMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnufile,
            this.mnuProject,
            this.mnuHelp});
            this.barMainMenu.Location = new System.Drawing.Point(0, 0);
            this.barMainMenu.Name = "barMainMenu";
            this.barMainMenu.Size = new System.Drawing.Size(793, 25);
            this.barMainMenu.TabIndex = 1;
            this.barMainMenu.Text = "Menu";
            // 
            // mnufile
            // 
            this.mnufile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuOpen,
            this.mnuReopen,
            this.mnuLine1,
            this.mnuSave,
            this.mnuSaveAs,
            this.mnuLine2,
            this.mnuExit});
            this.mnufile.Name = "mnufile";
            this.mnufile.Size = new System.Drawing.Size(44, 21);
            this.mnufile.Text = "文件";
            // 
            // mnuNew
            // 
            this.mnuNew.Image = global::SalarDbCodeGenerator.Properties.Resources.New16;
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(152, 22);
            this.mnuNew.Text = "新建项目";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Image = global::SalarDbCodeGenerator.Properties.Resources.Open16;
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(152, 22);
            this.mnuOpen.Text = "打开项目";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuReopen
            // 
            this.mnuReopen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLine5,
            this.mnuClearReopen});
            this.mnuReopen.Name = "mnuReopen";
            this.mnuReopen.Size = new System.Drawing.Size(152, 22);
            this.mnuReopen.Text = "重新打开...";
            // 
            // mnuLine5
            // 
            this.mnuLine5.Name = "mnuLine5";
            this.mnuLine5.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuClearReopen
            // 
            this.mnuClearReopen.Name = "mnuClearReopen";
            this.mnuClearReopen.Size = new System.Drawing.Size(152, 22);
            this.mnuClearReopen.Text = "清除列表";
            // 
            // mnuLine1
            // 
            this.mnuLine1.Name = "mnuLine1";
            this.mnuLine1.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuSave
            // 
            this.mnuSave.Image = global::SalarDbCodeGenerator.Properties.Resources.Save16;
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(152, 22);
            this.mnuSave.Text = "保存";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuSaveAs
            // 
            this.mnuSaveAs.Image = global::SalarDbCodeGenerator.Properties.Resources.SaveAs16;
            this.mnuSaveAs.Name = "mnuSaveAs";
            this.mnuSaveAs.Size = new System.Drawing.Size(152, 22);
            this.mnuSaveAs.Text = "另存为...";
            this.mnuSaveAs.Click += new System.EventHandler(this.mnuSaveAs_Click);
            // 
            // mnuLine2
            // 
            this.mnuLine2.Name = "mnuLine2";
            this.mnuLine2.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Image = global::SalarDbCodeGenerator.Properties.Resources.Exit16;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeyDisplayString = "";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuExit.Size = new System.Drawing.Size(152, 22);
            this.mnuExit.Text = "&退出";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuProject
            // 
            this.mnuProject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptions,
            this.mnuLine3,
            this.mnuRefetchDatabase,
            this.mnuLine4,
            this.mnuStartGenerate});
            this.mnuProject.Name = "mnuProject";
            this.mnuProject.Size = new System.Drawing.Size(44, 21);
            this.mnuProject.Text = "项目";
            // 
            // mnuOptions
            // 
            this.mnuOptions.Image = global::SalarDbCodeGenerator.Properties.Resources.Settings16;
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(152, 22);
            this.mnuOptions.Text = "项目设置";
            this.mnuOptions.Click += new System.EventHandler(this.mnuOptions_Click);
            // 
            // mnuLine3
            // 
            this.mnuLine3.Name = "mnuLine3";
            this.mnuLine3.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuRefetchDatabase
            // 
            this.mnuRefetchDatabase.Image = global::SalarDbCodeGenerator.Properties.Resources.DbRefetch16;
            this.mnuRefetchDatabase.Name = "mnuRefetchDatabase";
            this.mnuRefetchDatabase.Size = new System.Drawing.Size(152, 22);
            this.mnuRefetchDatabase.Text = "获取数据库";
            this.mnuRefetchDatabase.Click += new System.EventHandler(this.mnuRefetch_Click);
            // 
            // mnuLine4
            // 
            this.mnuLine4.Name = "mnuLine4";
            this.mnuLine4.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuStartGenerate
            // 
            this.mnuStartGenerate.Image = global::SalarDbCodeGenerator.Properties.Resources.Generate16;
            this.mnuStartGenerate.Name = "mnuStartGenerate";
            this.mnuStartGenerate.Size = new System.Drawing.Size(152, 22);
            this.mnuStartGenerate.Text = "开始生成";
            this.mnuStartGenerate.Click += new System.EventHandler(this.mnuStartGenerate_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 21);
            this.mnuHelp.Text = "帮助";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Image = global::SalarDbCodeGenerator.Properties.Resources.About16;
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(152, 22);
            this.mnuAbout.Text = "&关于";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // dlgOpenPattern
            // 
            this.dlgOpenPattern.DefaultExt = "SalarCodeGen Pattern (*.dbpat)|*.dbpat";
            this.dlgOpenPattern.Filter = "SalarCodeGen DbPattern (*.dbpat)|*.dbpat";
            this.dlgOpenPattern.Title = "Change the Pattern";
            // 
            // dlgOpenProject
            // 
            this.dlgOpenProject.DefaultExt = "SalarCodeGen DbProject (*.dbgen)|*.dbgen";
            this.dlgOpenProject.Filter = "SalarCodeGen DbProject (*.dbgen)|*.dbgen";
            this.dlgOpenProject.Title = "Open Project";
            // 
            // dlgSaveProject
            // 
            this.dlgSaveProject.DefaultExt = "SalarCodeGen DbProject (*.dbgen)|*.dbgen";
            this.dlgSaveProject.Filter = "SalarCodeGen DbProject (*.dbgen)|*.dbgen";
            this.dlgSaveProject.Title = "Save Project";
            // 
            // frmCodeGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 556);
            this.Controls.Add(this.splContent);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.barStandard);
            this.Controls.Add(this.barMainMenu);
            this.Controls.Add(this.barStarusBar);
            this.Name = "frmCodeGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalarDbCodeGenerator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCodeGen_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCodeGen_FormClosed);
            this.Load += new System.EventHandler(this.frmCodeGen_Load);
            this.Shown += new System.EventHandler(this.frmCodeGen_Shown);
            this.barStarusBar.ResumeLayout(false);
            this.barStarusBar.PerformLayout();
            this.splContent.Panel1.ResumeLayout(false);
            this.splContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splContent)).EndInit();
            this.splContent.ResumeLayout(false);
            this.pnlPatternInfo.ResumeLayout(false);
            this.pnlPatternInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabMainProject.ResumeLayout(false);
            this.tabDatabaseContents.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabGenFiles.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.barStandard.ResumeLayout(false);
            this.barStandard.PerformLayout();
            this.barMainMenu.ResumeLayout(false);
            this.barMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.SplitContainer splContent;
		private System.Windows.Forms.ListView lstPatterns;
		private System.Windows.Forms.TabControl tabMainProject;
		private System.Windows.Forms.TabPage tabDatabaseContents;
		private System.Windows.Forms.TabPage tabGenFiles;
		private System.Windows.Forms.ToolStrip barStandard;
		private System.Windows.Forms.ToolStripButton btnNewProject;
		private System.Windows.Forms.ToolStripButton btnOpenProject;
		private System.Windows.Forms.ToolStripButton btnSaveProject;
		private System.Windows.Forms.StatusStrip barStarusBar;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus;
		private System.Windows.Forms.ToolStripProgressBar barProgress;
		private System.Windows.Forms.MenuStrip barMainMenu;
		private System.Windows.Forms.ColumnHeader colTemplates;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ListView lstViews;
		private System.Windows.Forms.ColumnHeader colViews;
		private System.Windows.Forms.ListView lstTables;
		private System.Windows.Forms.ColumnHeader colTables;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.TreeView treGenFiles;
		private System.Windows.Forms.ToolStripMenuItem mnufile;
		private System.Windows.Forms.ToolStripMenuItem mnuExit;
		private System.Windows.Forms.ToolStripMenuItem mnuHelp;
		private System.Windows.Forms.ToolStripMenuItem mnuNew;
		private System.Windows.Forms.ToolStripMenuItem mnuOpen;
		private System.Windows.Forms.ToolStripSeparator mnuLine1;
		private System.Windows.Forms.ToolStripMenuItem mnuSave;
		private System.Windows.Forms.ToolStripMenuItem mnuSaveAs;
		private System.Windows.Forms.ToolStripSeparator mnuLine2;
		private System.Windows.Forms.ToolStripMenuItem mnuAbout;
		private System.Windows.Forms.ToolStripMenuItem mnuProject;
		private System.Windows.Forms.ToolStripMenuItem mnuOptions;
		private System.Windows.Forms.ToolStripSeparator mnuLine3;
		private System.Windows.Forms.ToolStripMenuItem mnuRefetchDatabase;
		private System.Windows.Forms.ToolStripSeparator mnuLine4;
		private System.Windows.Forms.ToolStripMenuItem mnuStartGenerate;
		private System.Windows.Forms.Panel pnlInfo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblInfoGenerationPath;
		private System.Windows.Forms.Label lblInfoLastGeneration;
		private System.Windows.Forms.Label lblInfoDbServer;
		private System.Windows.Forms.Label lblInfoProjectName;
		private System.Windows.Forms.Button btnRefetchDatabase;
		private System.Windows.Forms.ToolStripMenuItem mnuReopen;
		private System.Windows.Forms.ToolStripSeparator mnuLine5;
		private System.Windows.Forms.ToolStripMenuItem mnuClearReopen;
		private System.Windows.Forms.LinkLabel lnkGenerationPath;
		private System.Windows.Forms.ToolStripButton btnSaveAs;
		private System.Windows.Forms.Button btnRefrshGenFiles;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnChangePattern;
		private System.Windows.Forms.OpenFileDialog dlgOpenPattern;
		private System.Windows.Forms.ToolTip tipHints;
		private System.Windows.Forms.ToolStripSeparator barSp2;
		private System.Windows.Forms.ToolStripSeparator barSp1;
		private System.Windows.Forms.ToolStripButton btnProjectOptions;
		private System.Windows.Forms.ToolStripButton btnStartGeneration;
		private System.Windows.Forms.OpenFileDialog dlgOpenProject;
		private System.Windows.Forms.SaveFileDialog dlgSaveProject;
		private System.Windows.Forms.ImageList imgGeneratedFiles;
		private System.Windows.Forms.ToolStripSeparator barSp3;
		private System.Windows.Forms.ToolStripStatusLabel lblModified;
		private System.Windows.Forms.ComboBox cmbPatternProjectFile;
		private System.Windows.Forms.Panel pnlPatternInfo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblPatternDatabases;
		private System.Windows.Forms.Label lblPatternLanguage;
		private ICSharpCode.TextEditor.TextEditorControl txtCodeEditor;

	}
}

