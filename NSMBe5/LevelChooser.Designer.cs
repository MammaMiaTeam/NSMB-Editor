
using NSMBe5.DSFileSystem;
namespace NSMBe5 {
    partial class LevelChooser {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelChooser));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openROMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openBackupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.recentFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.closeROMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.connectToNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hostTextBox = new System.Windows.Forms.ToolStripTextBox();
			this.portTextBox = new System.Windows.Forms.ToolStripTextBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.openClipboard = new System.Windows.Forms.Button();
			this.exportClipboard = new System.Windows.Forms.Button();
			this.importClipboard = new System.Windows.Forms.Button();
			this.openLevel = new System.Windows.Forms.Button();
			this.hexEditLevelButton = new System.Windows.Forms.Button();
			this.exportLevelButton = new System.Windows.Forms.Button();
			this.importLevelButton = new System.Windows.Forms.Button();
			this.editLevelButton = new System.Windows.Forms.Button();
			this.levelTreeView = new System.Windows.Forms.TreeView();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.tilesetList1 = new NSMBe5.TilesetList();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.backgroundList1 = new NSMBe5.BackgroundList();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.filesystemBrowser1 = new NSMBe5.DSFileSystem.FilesystemBrowser();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.grpDLPMode = new System.Windows.Forms.GroupBox();
			this.lblDLPMode2 = new System.Windows.Forms.Label();
			this.lblDLPMode1 = new System.Windows.Forms.Label();
			this.dlpCheckBox = new System.Windows.Forms.CheckBox();
			this.musicSlotsGrp = new System.Windows.Forms.GroupBox();
			this.renameBtn = new System.Windows.Forms.Button();
			this.musicList = new System.Windows.Forms.ListBox();
			this.patchesGroupbox = new System.Windows.Forms.GroupBox();
			this.xdelta_import = new System.Windows.Forms.Button();
			this.xdelta_export = new System.Windows.Forms.Button();
			this.patchExport = new System.Windows.Forms.Button();
			this.patchImport = new System.Windows.Forms.Button();
			this.nsmbToolsGroupbox = new System.Windows.Forms.GroupBox();
			this.mpPatch2 = new System.Windows.Forms.Button();
			this.dataFinderButton = new System.Windows.Forms.Button();
			this.asmToolsGroupbox = new System.Windows.Forms.GroupBox();
			this.cleanBuild = new System.Windows.Forms.Button();
			this.compileInsert = new System.Windows.Forms.Button();
			this.decompArm9Bin = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.managePluginsBtn = new System.Windows.Forms.Button();
			this.setFontBtn = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.fontTextBox = new System.Windows.Forms.TextBox();
			this.patchMethodComboBox = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.languagesComboBox = new System.Windows.Forms.ComboBox();
			this.languageLabel = new System.Windows.Forms.Label();
			this.deleteBackups = new System.Windows.Forms.Button();
			this.minutesLabel = new System.Windows.Forms.Label();
			this.autoBackupTime = new System.Windows.Forms.NumericUpDown();
			this.updateStageObjSetsButton = new System.Windows.Forms.Button();
			this.chkAutoBackup = new System.Windows.Forms.CheckBox();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.creditsLabel = new System.Windows.Forms.Label();
			this.linkNSMBHD = new System.Windows.Forms.Label();
			this.linkOgRepo = new System.Windows.Forms.Label();
			this.linkRepo = new System.Windows.Forms.Label();
			this.lblLinksHeader = new System.Windows.Forms.Label();
			this.lblCreditsHeader = new System.Windows.Forms.Label();
			this.versionLabel = new System.Windows.Forms.Label();
			this.appNameLabel = new System.Windows.Forms.Label();
			this.importLevelDialog = new System.Windows.Forms.OpenFileDialog();
			this.exportLevelDialog = new System.Windows.Forms.SaveFileDialog();
			this.savePatchDialog = new System.Windows.Forms.SaveFileDialog();
			this.openPatchDialog = new System.Windows.Forms.OpenFileDialog();
			this.openTextFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveTextFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.openROMDialog = new System.Windows.Forms.OpenFileDialog();
			this.menuStrip1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage5.SuspendLayout();
			this.tabPage6.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.grpDLPMode.SuspendLayout();
			this.musicSlotsGrp.SuspendLayout();
			this.patchesGroupbox.SuspendLayout();
			this.nsmbToolsGroupbox.SuspendLayout();
			this.asmToolsGroupbox.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.autoBackupTime)).BeginInit();
			this.tabPage4.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.connectToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(767, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openROMToolStripMenuItem,
            this.openBackupsToolStripMenuItem,
            this.recentFilesToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeROMToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openROMToolStripMenuItem
			// 
			this.openROMToolStripMenuItem.Name = "openROMToolStripMenuItem";
			this.openROMToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.openROMToolStripMenuItem.Text = "Open ROM...";
			this.openROMToolStripMenuItem.Click += new System.EventHandler(this.openROMToolStripMenuItem_Click);
			// 
			// openBackupsToolStripMenuItem
			// 
			this.openBackupsToolStripMenuItem.Name = "openBackupsToolStripMenuItem";
			this.openBackupsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.openBackupsToolStripMenuItem.Text = "Open Backups";
			this.openBackupsToolStripMenuItem.Click += new System.EventHandler(this.openBackupsToolStripMenuItem_Click);
			// 
			// recentFilesToolStripMenuItem
			// 
			this.recentFilesToolStripMenuItem.Name = "recentFilesToolStripMenuItem";
			this.recentFilesToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.recentFilesToolStripMenuItem.Text = "Recent Files";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(144, 6);
			// 
			// closeROMToolStripMenuItem
			// 
			this.closeROMToolStripMenuItem.Enabled = false;
			this.closeROMToolStripMenuItem.Name = "closeROMToolStripMenuItem";
			this.closeROMToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.closeROMToolStripMenuItem.Text = "Close ROM";
			this.closeROMToolStripMenuItem.Click += new System.EventHandler(this.closeROMToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(144, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// connectToolStripMenuItem
			// 
			this.connectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToNetworkToolStripMenuItem,
            this.hostTextBox,
            this.portTextBox});
			this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
			this.connectToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
			this.connectToolStripMenuItem.Text = "Connect";
			// 
			// connectToNetworkToolStripMenuItem
			// 
			this.connectToNetworkToolStripMenuItem.Name = "connectToNetworkToolStripMenuItem";
			this.connectToNetworkToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.connectToNetworkToolStripMenuItem.Text = "Connect";
			this.connectToNetworkToolStripMenuItem.Click += new System.EventHandler(this.connectToNetworkToolStripMenuItem_Click);
			// 
			// hostTextBox
			// 
			this.hostTextBox.Name = "hostTextBox";
			this.hostTextBox.Size = new System.Drawing.Size(100, 23);
			this.hostTextBox.Text = "localhost";
			// 
			// portTextBox
			// 
			this.portTextBox.Name = "portTextBox";
			this.portTextBox.Size = new System.Drawing.Size(100, 23);
			this.portTextBox.Text = "7777";
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Controls.Add(this.tabPage6);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Location = new System.Drawing.Point(17, 39);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(733, 570);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.openClipboard);
			this.tabPage2.Controls.Add(this.exportClipboard);
			this.tabPage2.Controls.Add(this.importClipboard);
			this.tabPage2.Controls.Add(this.openLevel);
			this.tabPage2.Controls.Add(this.hexEditLevelButton);
			this.tabPage2.Controls.Add(this.exportLevelButton);
			this.tabPage2.Controls.Add(this.importLevelButton);
			this.tabPage2.Controls.Add(this.editLevelButton);
			this.tabPage2.Controls.Add(this.levelTreeView);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage2.Size = new System.Drawing.Size(725, 565);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "<Level Listing>";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// openClipboard
			// 
			this.openClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.openClipboard.Location = new System.Drawing.Point(293, 526);
			this.openClipboard.Margin = new System.Windows.Forms.Padding(4);
			this.openClipboard.Name = "openClipboard";
			this.openClipboard.Size = new System.Drawing.Size(157, 28);
			this.openClipboard.TabIndex = 8;
			this.openClipboard.Text = "<OpenClipboard>";
			this.openClipboard.UseVisualStyleBackColor = true;
			this.openClipboard.Click += new System.EventHandler(this.openClipboard_Click);
			// 
			// exportClipboard
			// 
			this.exportClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.exportClipboard.Enabled = false;
			this.exportClipboard.Location = new System.Drawing.Point(143, 526);
			this.exportClipboard.Margin = new System.Windows.Forms.Padding(4);
			this.exportClipboard.Name = "exportClipboard";
			this.exportClipboard.Size = new System.Drawing.Size(141, 28);
			this.exportClipboard.TabIndex = 7;
			this.exportClipboard.Text = "<ExportToClipboard>";
			this.exportClipboard.UseVisualStyleBackColor = true;
			this.exportClipboard.Click += new System.EventHandler(this.exportClipboard_Click);
			// 
			// importClipboard
			// 
			this.importClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.importClipboard.Enabled = false;
			this.importClipboard.Location = new System.Drawing.Point(8, 526);
			this.importClipboard.Margin = new System.Windows.Forms.Padding(4);
			this.importClipboard.Name = "importClipboard";
			this.importClipboard.Size = new System.Drawing.Size(125, 28);
			this.importClipboard.TabIndex = 6;
			this.importClipboard.Text = "<ImportClipboard>";
			this.importClipboard.UseVisualStyleBackColor = true;
			this.importClipboard.Click += new System.EventHandler(this.importClipboard_Click);
			// 
			// openLevel
			// 
			this.openLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.openLevel.Location = new System.Drawing.Point(292, 489);
			this.openLevel.Margin = new System.Windows.Forms.Padding(4);
			this.openLevel.Name = "openLevel";
			this.openLevel.Size = new System.Drawing.Size(159, 28);
			this.openLevel.TabIndex = 5;
			this.openLevel.Text = "<OpenExportedLevel>";
			this.openLevel.UseVisualStyleBackColor = true;
			this.openLevel.Click += new System.EventHandler(this.openLevel_Click);
			// 
			// hexEditLevelButton
			// 
			this.hexEditLevelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.hexEditLevelButton.Enabled = false;
			this.hexEditLevelButton.Location = new System.Drawing.Point(603, 526);
			this.hexEditLevelButton.Margin = new System.Windows.Forms.Padding(4);
			this.hexEditLevelButton.Name = "hexEditLevelButton";
			this.hexEditLevelButton.Size = new System.Drawing.Size(100, 28);
			this.hexEditLevelButton.TabIndex = 4;
			this.hexEditLevelButton.Text = "<hexEditLevelButton>";
			this.hexEditLevelButton.UseVisualStyleBackColor = true;
			this.hexEditLevelButton.Click += new System.EventHandler(this.hexEditLevelButton_Click);
			// 
			// exportLevelButton
			// 
			this.exportLevelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.exportLevelButton.Enabled = false;
			this.exportLevelButton.Location = new System.Drawing.Point(141, 489);
			this.exportLevelButton.Margin = new System.Windows.Forms.Padding(4);
			this.exportLevelButton.Name = "exportLevelButton";
			this.exportLevelButton.Size = new System.Drawing.Size(143, 28);
			this.exportLevelButton.TabIndex = 3;
			this.exportLevelButton.Text = "<exportLevelButton>";
			this.exportLevelButton.UseVisualStyleBackColor = true;
			this.exportLevelButton.Click += new System.EventHandler(this.exportLevelButton_Click);
			// 
			// importLevelButton
			// 
			this.importLevelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.importLevelButton.Enabled = false;
			this.importLevelButton.Location = new System.Drawing.Point(7, 489);
			this.importLevelButton.Margin = new System.Windows.Forms.Padding(4);
			this.importLevelButton.Name = "importLevelButton";
			this.importLevelButton.Size = new System.Drawing.Size(127, 28);
			this.importLevelButton.TabIndex = 2;
			this.importLevelButton.Text = "<importLevelButton>";
			this.importLevelButton.UseVisualStyleBackColor = true;
			this.importLevelButton.Click += new System.EventHandler(this.importLevelButton_Click);
			// 
			// editLevelButton
			// 
			this.editLevelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.editLevelButton.Enabled = false;
			this.editLevelButton.Location = new System.Drawing.Point(603, 489);
			this.editLevelButton.Margin = new System.Windows.Forms.Padding(4);
			this.editLevelButton.Name = "editLevelButton";
			this.editLevelButton.Size = new System.Drawing.Size(100, 28);
			this.editLevelButton.TabIndex = 1;
			this.editLevelButton.Text = "<editLevelButton>";
			this.editLevelButton.UseVisualStyleBackColor = true;
			this.editLevelButton.Click += new System.EventHandler(this.editLevelButton_Click);
			// 
			// levelTreeView
			// 
			this.levelTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.levelTreeView.Location = new System.Drawing.Point(8, 7);
			this.levelTreeView.Margin = new System.Windows.Forms.Padding(4);
			this.levelTreeView.Name = "levelTreeView";
			this.levelTreeView.Size = new System.Drawing.Size(695, 473);
			this.levelTreeView.TabIndex = 0;
			this.levelTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.levelTreeView_AfterSelect);
			this.levelTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.levelTreeView_NodeMouseDoubleClick);
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.tilesetList1);
			this.tabPage5.Location = new System.Drawing.Point(4, 25);
			this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage5.Size = new System.Drawing.Size(725, 565);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "<Tilesets>";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// tilesetList1
			// 
			this.tilesetList1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tilesetList1.Location = new System.Drawing.Point(4, 4);
			this.tilesetList1.Margin = new System.Windows.Forms.Padding(5);
			this.tilesetList1.Name = "tilesetList1";
			this.tilesetList1.Size = new System.Drawing.Size(717, 557);
			this.tilesetList1.TabIndex = 0;
			// 
			// tabPage6
			// 
			this.tabPage6.Controls.Add(this.backgroundList1);
			this.tabPage6.Location = new System.Drawing.Point(4, 25);
			this.tabPage6.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Size = new System.Drawing.Size(725, 565);
			this.tabPage6.TabIndex = 5;
			this.tabPage6.Text = "<Backgrounds>";
			this.tabPage6.UseVisualStyleBackColor = true;
			// 
			// backgroundList1
			// 
			this.backgroundList1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.backgroundList1.Location = new System.Drawing.Point(0, 0);
			this.backgroundList1.Margin = new System.Windows.Forms.Padding(5);
			this.backgroundList1.Name = "backgroundList1";
			this.backgroundList1.Size = new System.Drawing.Size(725, 565);
			this.backgroundList1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.filesystemBrowser1);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage1.Size = new System.Drawing.Size(725, 565);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "<File Browser>";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// filesystemBrowser1
			// 
			this.filesystemBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.filesystemBrowser1.Location = new System.Drawing.Point(4, 4);
			this.filesystemBrowser1.Margin = new System.Windows.Forms.Padding(5);
			this.filesystemBrowser1.Name = "filesystemBrowser1";
			this.filesystemBrowser1.Size = new System.Drawing.Size(717, 557);
			this.filesystemBrowser1.TabIndex = 0;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.grpDLPMode);
			this.tabPage3.Controls.Add(this.musicSlotsGrp);
			this.tabPage3.Controls.Add(this.patchesGroupbox);
			this.tabPage3.Controls.Add(this.nsmbToolsGroupbox);
			this.tabPage3.Controls.Add(this.asmToolsGroupbox);
			this.tabPage3.Controls.Add(this.groupBox1);
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage3.Size = new System.Drawing.Size(725, 565);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "<Tools/Options>";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// grpDLPMode
			// 
			this.grpDLPMode.Controls.Add(this.lblDLPMode2);
			this.grpDLPMode.Controls.Add(this.lblDLPMode1);
			this.grpDLPMode.Controls.Add(this.dlpCheckBox);
			this.grpDLPMode.Location = new System.Drawing.Point(8, 414);
			this.grpDLPMode.Margin = new System.Windows.Forms.Padding(4);
			this.grpDLPMode.Name = "grpDLPMode";
			this.grpDLPMode.Padding = new System.Windows.Forms.Padding(4);
			this.grpDLPMode.Size = new System.Drawing.Size(328, 144);
			this.grpDLPMode.TabIndex = 11;
			this.grpDLPMode.TabStop = false;
			this.grpDLPMode.Text = "<DLP mode>";
			// 
			// lblDLPMode2
			// 
			this.lblDLPMode2.Location = new System.Drawing.Point(8, 101);
			this.lblDLPMode2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDLPMode2.Name = "lblDLPMode2";
			this.lblDLPMode2.Size = new System.Drawing.Size(308, 38);
			this.lblDLPMode2.TabIndex = 11;
			this.lblDLPMode2.Text = "<You do NOT need to enable this if you\'re using firmware.nds or FlashMe.>";
			// 
			// lblDLPMode1
			// 
			this.lblDLPMode1.Location = new System.Drawing.Point(8, 48);
			this.lblDLPMode1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDLPMode1.Name = "lblDLPMode1";
			this.lblDLPMode1.Size = new System.Drawing.Size(312, 53);
			this.lblDLPMode1.TabIndex = 11;
			this.lblDLPMode1.Text = "<This will prevent some values in the header from being updated. The ROM will wor" +
    "k over DLP but may not work on some flashcards.>";
			// 
			// dlpCheckBox
			// 
			this.dlpCheckBox.AutoSize = true;
			this.dlpCheckBox.Location = new System.Drawing.Point(8, 23);
			this.dlpCheckBox.Margin = new System.Windows.Forms.Padding(4);
			this.dlpCheckBox.Name = "dlpCheckBox";
			this.dlpCheckBox.Size = new System.Drawing.Size(265, 20);
			this.dlpCheckBox.TabIndex = 10;
			this.dlpCheckBox.Text = "<Enable Download Play-friendly mode>";
			this.dlpCheckBox.UseVisualStyleBackColor = true;
			this.dlpCheckBox.CheckedChanged += new System.EventHandler(this.dlpCheckBox_CheckedChanged);
			// 
			// musicSlotsGrp
			// 
			this.musicSlotsGrp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.musicSlotsGrp.Controls.Add(this.renameBtn);
			this.musicSlotsGrp.Controls.Add(this.musicList);
			this.musicSlotsGrp.Location = new System.Drawing.Point(344, 218);
			this.musicSlotsGrp.Margin = new System.Windows.Forms.Padding(4);
			this.musicSlotsGrp.Name = "musicSlotsGrp";
			this.musicSlotsGrp.Padding = new System.Windows.Forms.Padding(4);
			this.musicSlotsGrp.Size = new System.Drawing.Size(371, 341);
			this.musicSlotsGrp.TabIndex = 8;
			this.musicSlotsGrp.TabStop = false;
			this.musicSlotsGrp.Text = "<Music Slots>";
			// 
			// renameBtn
			// 
			this.renameBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.renameBtn.Location = new System.Drawing.Point(263, 309);
			this.renameBtn.Margin = new System.Windows.Forms.Padding(4);
			this.renameBtn.Name = "renameBtn";
			this.renameBtn.Size = new System.Drawing.Size(100, 28);
			this.renameBtn.TabIndex = 10;
			this.renameBtn.Text = "<Rename>";
			this.renameBtn.UseVisualStyleBackColor = true;
			this.renameBtn.Click += new System.EventHandler(this.renameBtn_Click);
			// 
			// musicList
			// 
			this.musicList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.musicList.FormattingEnabled = true;
			this.musicList.ItemHeight = 16;
			this.musicList.Location = new System.Drawing.Point(8, 25);
			this.musicList.Margin = new System.Windows.Forms.Padding(4);
			this.musicList.Name = "musicList";
			this.musicList.Size = new System.Drawing.Size(353, 276);
			this.musicList.TabIndex = 9;
			// 
			// patchesGroupbox
			// 
			this.patchesGroupbox.Controls.Add(this.xdelta_import);
			this.patchesGroupbox.Controls.Add(this.xdelta_export);
			this.patchesGroupbox.Controls.Add(this.patchExport);
			this.patchesGroupbox.Controls.Add(this.patchImport);
			this.patchesGroupbox.Location = new System.Drawing.Point(344, 7);
			this.patchesGroupbox.Margin = new System.Windows.Forms.Padding(4);
			this.patchesGroupbox.Name = "patchesGroupbox";
			this.patchesGroupbox.Padding = new System.Windows.Forms.Padding(4);
			this.patchesGroupbox.Size = new System.Drawing.Size(371, 98);
			this.patchesGroupbox.TabIndex = 7;
			this.patchesGroupbox.TabStop = false;
			this.patchesGroupbox.Text = "<Patches>";
			// 
			// xdelta_import
			// 
			this.xdelta_import.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.xdelta_import.Location = new System.Drawing.Point(187, 59);
			this.xdelta_import.Margin = new System.Windows.Forms.Padding(4);
			this.xdelta_import.Name = "xdelta_import";
			this.xdelta_import.Size = new System.Drawing.Size(176, 28);
			this.xdelta_import.TabIndex = 5;
			this.xdelta_import.Text = "XDelta Patch Import";
			this.xdelta_import.UseVisualStyleBackColor = true;
			this.xdelta_import.Click += new System.EventHandler(this.Xdelta_import_Click);
			// 
			// xdelta_export
			// 
			this.xdelta_export.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.xdelta_export.Location = new System.Drawing.Point(187, 23);
			this.xdelta_export.Margin = new System.Windows.Forms.Padding(4);
			this.xdelta_export.Name = "xdelta_export";
			this.xdelta_export.Size = new System.Drawing.Size(176, 28);
			this.xdelta_export.TabIndex = 4;
			this.xdelta_export.Text = "XDelta Patch Export";
			this.xdelta_export.UseVisualStyleBackColor = true;
			this.xdelta_export.Click += new System.EventHandler(this.Xdelta_export_Click);
			// 
			// patchExport
			// 
			this.patchExport.Location = new System.Drawing.Point(8, 23);
			this.patchExport.Margin = new System.Windows.Forms.Padding(4);
			this.patchExport.Name = "patchExport";
			this.patchExport.Size = new System.Drawing.Size(177, 28);
			this.patchExport.TabIndex = 3;
			this.patchExport.Text = "<patchExport>";
			this.patchExport.UseVisualStyleBackColor = true;
			this.patchExport.Click += new System.EventHandler(this.patchExport_Click);
			// 
			// patchImport
			// 
			this.patchImport.Location = new System.Drawing.Point(8, 59);
			this.patchImport.Margin = new System.Windows.Forms.Padding(4);
			this.patchImport.Name = "patchImport";
			this.patchImport.Size = new System.Drawing.Size(177, 28);
			this.patchImport.TabIndex = 3;
			this.patchImport.Text = "<patchImport>";
			this.patchImport.UseVisualStyleBackColor = true;
			this.patchImport.Click += new System.EventHandler(this.patchImport_Click);
			// 
			// nsmbToolsGroupbox
			// 
			this.nsmbToolsGroupbox.Controls.Add(this.mpPatch2);
			this.nsmbToolsGroupbox.Controls.Add(this.dataFinderButton);
			this.nsmbToolsGroupbox.Location = new System.Drawing.Point(8, 7);
			this.nsmbToolsGroupbox.Margin = new System.Windows.Forms.Padding(4);
			this.nsmbToolsGroupbox.Name = "nsmbToolsGroupbox";
			this.nsmbToolsGroupbox.Padding = new System.Windows.Forms.Padding(4);
			this.nsmbToolsGroupbox.Size = new System.Drawing.Size(328, 98);
			this.nsmbToolsGroupbox.TabIndex = 6;
			this.nsmbToolsGroupbox.TabStop = false;
			this.nsmbToolsGroupbox.Text = "<NSMB Tools>";
			// 
			// mpPatch2
			// 
			this.mpPatch2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mpPatch2.Location = new System.Drawing.Point(8, 23);
			this.mpPatch2.Margin = new System.Windows.Forms.Padding(4);
			this.mpPatch2.Name = "mpPatch2";
			this.mpPatch2.Size = new System.Drawing.Size(312, 28);
			this.mpPatch2.TabIndex = 5;
			this.mpPatch2.Text = "<mpPatch2>";
			this.mpPatch2.UseVisualStyleBackColor = true;
			this.mpPatch2.Click += new System.EventHandler(this.mpPatch2_Click);
			// 
			// dataFinderButton
			// 
			this.dataFinderButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataFinderButton.Location = new System.Drawing.Point(8, 59);
			this.dataFinderButton.Margin = new System.Windows.Forms.Padding(4);
			this.dataFinderButton.Name = "dataFinderButton";
			this.dataFinderButton.Size = new System.Drawing.Size(312, 28);
			this.dataFinderButton.TabIndex = 3;
			this.dataFinderButton.Text = "<dataFinderButton>";
			this.dataFinderButton.UseVisualStyleBackColor = true;
			this.dataFinderButton.Click += new System.EventHandler(this.dataFinderButton_Click);
			// 
			// asmToolsGroupbox
			// 
			this.asmToolsGroupbox.Controls.Add(this.cleanBuild);
			this.asmToolsGroupbox.Controls.Add(this.compileInsert);
			this.asmToolsGroupbox.Controls.Add(this.decompArm9Bin);
			this.asmToolsGroupbox.Location = new System.Drawing.Point(344, 113);
			this.asmToolsGroupbox.Margin = new System.Windows.Forms.Padding(4);
			this.asmToolsGroupbox.Name = "asmToolsGroupbox";
			this.asmToolsGroupbox.Padding = new System.Windows.Forms.Padding(4);
			this.asmToolsGroupbox.Size = new System.Drawing.Size(371, 97);
			this.asmToolsGroupbox.TabIndex = 4;
			this.asmToolsGroupbox.TabStop = false;
			this.asmToolsGroupbox.Text = "<Code hacking tools>";
			// 
			// cleanBuild
			// 
			this.cleanBuild.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cleanBuild.Location = new System.Drawing.Point(187, 59);
			this.cleanBuild.Margin = new System.Windows.Forms.Padding(4);
			this.cleanBuild.Name = "cleanBuild";
			this.cleanBuild.Size = new System.Drawing.Size(176, 28);
			this.cleanBuild.TabIndex = 3;
			this.cleanBuild.Text = "<Clean build>";
			this.cleanBuild.UseVisualStyleBackColor = true;
			this.cleanBuild.Click += new System.EventHandler(this.cleanBuild_Click);
			// 
			// compileInsert
			// 
			this.compileInsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.compileInsert.Location = new System.Drawing.Point(8, 59);
			this.compileInsert.Margin = new System.Windows.Forms.Padding(4);
			this.compileInsert.Name = "compileInsert";
			this.compileInsert.Size = new System.Drawing.Size(177, 28);
			this.compileInsert.TabIndex = 3;
			this.compileInsert.Text = "<Compile and insert>";
			this.compileInsert.UseVisualStyleBackColor = true;
			this.compileInsert.Click += new System.EventHandler(this.compileInsert_Click);
			// 
			// decompArm9Bin
			// 
			this.decompArm9Bin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.decompArm9Bin.Location = new System.Drawing.Point(8, 23);
			this.decompArm9Bin.Margin = new System.Windows.Forms.Padding(4);
			this.decompArm9Bin.Name = "decompArm9Bin";
			this.decompArm9Bin.Size = new System.Drawing.Size(355, 28);
			this.decompArm9Bin.TabIndex = 3;
			this.decompArm9Bin.Text = "<Decompress ARM9 binary>";
			this.decompArm9Bin.UseVisualStyleBackColor = true;
			this.decompArm9Bin.Click += new System.EventHandler(this.decompArm9Bin_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.managePluginsBtn);
			this.groupBox1.Controls.Add(this.setFontBtn);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.fontTextBox);
			this.groupBox1.Controls.Add(this.patchMethodComboBox);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.languagesComboBox);
			this.groupBox1.Controls.Add(this.languageLabel);
			this.groupBox1.Controls.Add(this.deleteBackups);
			this.groupBox1.Controls.Add(this.minutesLabel);
			this.groupBox1.Controls.Add(this.autoBackupTime);
			this.groupBox1.Controls.Add(this.updateStageObjSetsButton);
			this.groupBox1.Controls.Add(this.chkAutoBackup);
			this.groupBox1.Location = new System.Drawing.Point(8, 113);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(328, 293);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "<Settings>";
			// 
			// managePluginsBtn
			// 
			this.managePluginsBtn.Location = new System.Drawing.Point(8, 187);
			this.managePluginsBtn.Name = "managePluginsBtn";
			this.managePluginsBtn.Size = new System.Drawing.Size(312, 28);
			this.managePluginsBtn.TabIndex = 18;
			this.managePluginsBtn.Text = "Manage Plugins";
			this.managePluginsBtn.UseVisualStyleBackColor = true;
			this.managePluginsBtn.Click += new System.EventHandler(this.managePluginsBtn_Click);
			// 
			// setFontBtn
			// 
			this.setFontBtn.Location = new System.Drawing.Point(251, 153);
			this.setFontBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.setFontBtn.Name = "setFontBtn";
			this.setFontBtn.Size = new System.Drawing.Size(69, 25);
			this.setFontBtn.TabIndex = 17;
			this.setFontBtn.Text = "Set";
			this.setFontBtn.UseVisualStyleBackColor = true;
			this.setFontBtn.Click += new System.EventHandler(this.setFontBtn_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(160, 158);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 16);
			this.label3.TabIndex = 16;
			this.label3.Text = "Current font";
			// 
			// fontTextBox
			// 
			this.fontTextBox.Location = new System.Drawing.Point(8, 154);
			this.fontTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.fontTextBox.Name = "fontTextBox";
			this.fontTextBox.Size = new System.Drawing.Size(143, 22);
			this.fontTextBox.TabIndex = 15;
			// 
			// patchMethodComboBox
			// 
			this.patchMethodComboBox.FormattingEnabled = true;
			this.patchMethodComboBox.Location = new System.Drawing.Point(8, 62);
			this.patchMethodComboBox.Margin = new System.Windows.Forms.Padding(4);
			this.patchMethodComboBox.Name = "patchMethodComboBox";
			this.patchMethodComboBox.Size = new System.Drawing.Size(143, 24);
			this.patchMethodComboBox.TabIndex = 14;
			this.patchMethodComboBox.SelectedIndexChanged += new System.EventHandler(this.patchMethodComboBox_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(160, 65);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(142, 16);
			this.label4.TabIndex = 14;
			this.label4.Text = "Code patching method";
			// 
			// languagesComboBox
			// 
			this.languagesComboBox.FormattingEnabled = true;
			this.languagesComboBox.Location = new System.Drawing.Point(8, 26);
			this.languagesComboBox.Margin = new System.Windows.Forms.Padding(4);
			this.languagesComboBox.Name = "languagesComboBox";
			this.languagesComboBox.Size = new System.Drawing.Size(143, 24);
			this.languagesComboBox.TabIndex = 14;
			this.languagesComboBox.SelectedIndexChanged += new System.EventHandler(this.languagesComboBox_SelectedIndexChanged);
			// 
			// languageLabel
			// 
			this.languageLabel.AutoSize = true;
			this.languageLabel.Location = new System.Drawing.Point(160, 30);
			this.languageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.languageLabel.Name = "languageLabel";
			this.languageLabel.Size = new System.Drawing.Size(82, 16);
			this.languageLabel.TabIndex = 0;
			this.languageLabel.Text = "<Language>";
			// 
			// deleteBackups
			// 
			this.deleteBackups.Location = new System.Drawing.Point(8, 222);
			this.deleteBackups.Margin = new System.Windows.Forms.Padding(4);
			this.deleteBackups.Name = "deleteBackups";
			this.deleteBackups.Size = new System.Drawing.Size(312, 28);
			this.deleteBackups.TabIndex = 13;
			this.deleteBackups.Text = "<Delete all backups>";
			this.deleteBackups.UseVisualStyleBackColor = true;
			this.deleteBackups.Click += new System.EventHandler(this.deleteBackups_Click);
			// 
			// minutesLabel
			// 
			this.minutesLabel.AutoSize = true;
			this.minutesLabel.Location = new System.Drawing.Point(88, 126);
			this.minutesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.minutesLabel.Name = "minutesLabel";
			this.minutesLabel.Size = new System.Drawing.Size(104, 16);
			this.minutesLabel.TabIndex = 12;
			this.minutesLabel.Text = "<Minutes delay>";
			// 
			// autoBackupTime
			// 
			this.autoBackupTime.Location = new System.Drawing.Point(8, 123);
			this.autoBackupTime.Margin = new System.Windows.Forms.Padding(4);
			this.autoBackupTime.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
			this.autoBackupTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.autoBackupTime.Name = "autoBackupTime";
			this.autoBackupTime.Size = new System.Drawing.Size(72, 22);
			this.autoBackupTime.TabIndex = 11;
			this.autoBackupTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.autoBackupTime.ValueChanged += new System.EventHandler(this.autoBackupTime_ValueChanged);
			// 
			// updateStageObjSetsButton
			// 
			this.updateStageObjSetsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.updateStageObjSetsButton.Location = new System.Drawing.Point(8, 257);
			this.updateStageObjSetsButton.Margin = new System.Windows.Forms.Padding(4);
			this.updateStageObjSetsButton.Name = "updateStageObjSetsButton";
			this.updateStageObjSetsButton.Size = new System.Drawing.Size(312, 28);
			this.updateStageObjSetsButton.TabIndex = 3;
			this.updateStageObjSetsButton.Text = "<UpdateStageObjSets>";
			this.updateStageObjSetsButton.UseVisualStyleBackColor = true;
			this.updateStageObjSetsButton.Click += new System.EventHandler(this.updateStageObjSetsButton_Click);
			// 
			// chkAutoBackup
			// 
			this.chkAutoBackup.AutoSize = true;
			this.chkAutoBackup.Location = new System.Drawing.Point(8, 95);
			this.chkAutoBackup.Margin = new System.Windows.Forms.Padding(4);
			this.chkAutoBackup.Name = "chkAutoBackup";
			this.chkAutoBackup.Size = new System.Drawing.Size(128, 20);
			this.chkAutoBackup.TabIndex = 9;
			this.chkAutoBackup.Text = "<Backup levels>";
			this.chkAutoBackup.UseVisualStyleBackColor = true;
			this.chkAutoBackup.CheckedChanged += new System.EventHandler(this.autoBackupTime_ValueChanged);
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.creditsLabel);
			this.tabPage4.Controls.Add(this.linkNSMBHD);
			this.tabPage4.Controls.Add(this.linkOgRepo);
			this.tabPage4.Controls.Add(this.linkRepo);
			this.tabPage4.Controls.Add(this.lblLinksHeader);
			this.tabPage4.Controls.Add(this.lblCreditsHeader);
			this.tabPage4.Controls.Add(this.versionLabel);
			this.tabPage4.Controls.Add(this.appNameLabel);
			this.tabPage4.Location = new System.Drawing.Point(4, 25);
			this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage4.Size = new System.Drawing.Size(725, 565);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "<About>";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// creditsLabel
			// 
			this.creditsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.creditsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.creditsLabel.Location = new System.Drawing.Point(4, 124);
			this.creditsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.creditsLabel.Name = "creditsLabel";
			this.creditsLabel.Size = new System.Drawing.Size(717, 202);
			this.creditsLabel.TabIndex = 8;
			this.creditsLabel.Text = resources.GetString("creditsLabel.Text");
			this.creditsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// linkNSMBHD
			// 
			this.linkNSMBHD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.linkNSMBHD.Cursor = System.Windows.Forms.Cursors.Hand;
			this.linkNSMBHD.ForeColor = System.Drawing.Color.Blue;
			this.linkNSMBHD.Location = new System.Drawing.Point(4, 418);
			this.linkNSMBHD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.linkNSMBHD.Name = "linkNSMBHD";
			this.linkNSMBHD.Size = new System.Drawing.Size(717, 28);
			this.linkNSMBHD.TabIndex = 7;
			this.linkNSMBHD.Text = "NSMB Hacking Domain";
			this.linkNSMBHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip1.SetToolTip(this.linkNSMBHD, "http://nsmbhd.net/");
			this.linkNSMBHD.Click += new System.EventHandler(this.linkNSMBHD_Click);
			// 
			// linkOgRepo
			// 
			this.linkOgRepo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.linkOgRepo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.linkOgRepo.ForeColor = System.Drawing.Color.Blue;
			this.linkOgRepo.Location = new System.Drawing.Point(4, 391);
			this.linkOgRepo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.linkOgRepo.Name = "linkOgRepo";
			this.linkOgRepo.Size = new System.Drawing.Size(717, 28);
			this.linkOgRepo.TabIndex = 6;
			this.linkOgRepo.Text = "NSMBe on GitHub [The original repo]";
			this.linkOgRepo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip1.SetToolTip(this.linkOgRepo, "https://github.com/Dirbaio/NSMB-Editor");
			this.linkOgRepo.Click += new System.EventHandler(this.linkOgRepo_Click);
			// 
			// linkRepo
			// 
			this.linkRepo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.linkRepo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.linkRepo.ForeColor = System.Drawing.Color.Blue;
			this.linkRepo.Location = new System.Drawing.Point(4, 363);
			this.linkRepo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.linkRepo.Name = "linkRepo";
			this.linkRepo.Size = new System.Drawing.Size(717, 28);
			this.linkRepo.TabIndex = 5;
			this.linkRepo.Text = "NSMBe on GitHub [The maintained repo]";
			this.linkRepo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip1.SetToolTip(this.linkRepo, "https://github.com/MammaMiaTeam/NSMB-Editor");
			this.linkRepo.Click += new System.EventHandler(this.linkRepo_Click);
			// 
			// lblLinksHeader
			// 
			this.lblLinksHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblLinksHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLinksHeader.Location = new System.Drawing.Point(4, 338);
			this.lblLinksHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblLinksHeader.Name = "lblLinksHeader";
			this.lblLinksHeader.Size = new System.Drawing.Size(717, 25);
			this.lblLinksHeader.TabIndex = 4;
			this.lblLinksHeader.Text = "Links";
			this.lblLinksHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblCreditsHeader
			// 
			this.lblCreditsHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCreditsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCreditsHeader.Location = new System.Drawing.Point(4, 100);
			this.lblCreditsHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCreditsHeader.Name = "lblCreditsHeader";
			this.lblCreditsHeader.Size = new System.Drawing.Size(717, 25);
			this.lblCreditsHeader.TabIndex = 2;
			this.lblCreditsHeader.Text = "Credits";
			this.lblCreditsHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// versionLabel
			// 
			this.versionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.versionLabel.Location = new System.Drawing.Point(4, 65);
			this.versionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.versionLabel.Name = "versionLabel";
			this.versionLabel.Size = new System.Drawing.Size(717, 34);
			this.versionLabel.TabIndex = 1;
			this.versionLabel.Text = "Version X";
			this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// appNameLabel
			// 
			this.appNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.appNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.appNameLabel.Location = new System.Drawing.Point(4, 20);
			this.appNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.appNameLabel.Name = "appNameLabel";
			this.appNameLabel.Size = new System.Drawing.Size(717, 46);
			this.appNameLabel.TabIndex = 0;
			this.appNameLabel.Text = "New Super Mario Bros. Editor";
			this.appNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LevelChooser
			// 
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(767, 623);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "LevelChooser";
			this.Text = "<_TITLE>";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LevelChooser_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LevelChooser_FormClosed);
			this.Load += new System.EventHandler(this.LevelChooser_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage5.ResumeLayout(false);
			this.tabPage6.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.grpDLPMode.ResumeLayout(false);
			this.grpDLPMode.PerformLayout();
			this.musicSlotsGrp.ResumeLayout(false);
			this.patchesGroupbox.ResumeLayout(false);
			this.nsmbToolsGroupbox.ResumeLayout(false);
			this.asmToolsGroupbox.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.autoBackupTime)).EndInit();
			this.tabPage4.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button exportLevelButton;
        private System.Windows.Forms.Button importLevelButton;
        private System.Windows.Forms.Button editLevelButton;
        private System.Windows.Forms.TreeView levelTreeView;
        private System.Windows.Forms.OpenFileDialog importLevelDialog;
        private System.Windows.Forms.SaveFileDialog exportLevelDialog;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Button dataFinderButton;
        private System.Windows.Forms.Button hexEditLevelButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button patchExport;
        private System.Windows.Forms.Button patchImport;
        private System.Windows.Forms.SaveFileDialog savePatchDialog;
        private System.Windows.Forms.OpenFileDialog openPatchDialog;
        private FilesystemBrowser filesystemBrowser1;
        private System.Windows.Forms.Button decompArm9Bin;
        private System.Windows.Forms.Button mpPatch2;
        private System.Windows.Forms.GroupBox asmToolsGroupbox;
        private System.Windows.Forms.Button compileInsert;
        private System.Windows.Forms.OpenFileDialog openTextFileDialog;
        private System.Windows.Forms.Button cleanBuild;
        private System.Windows.Forms.SaveFileDialog saveTextFileDialog;
        private System.Windows.Forms.Button updateStageObjSetsButton;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.Label lblCreditsHeader;
        private System.Windows.Forms.Label linkRepo;
        private System.Windows.Forms.Label lblLinksHeader;
        private System.Windows.Forms.GroupBox patchesGroupbox;
        private System.Windows.Forms.GroupBox nsmbToolsGroupbox;
        private System.Windows.Forms.TabPage tabPage5;
        private TilesetList tilesetList1;
        private System.Windows.Forms.TabPage tabPage6;
        private BackgroundList backgroundList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox musicSlotsGrp;
        private System.Windows.Forms.Button renameBtn;
        private System.Windows.Forms.ListBox musicList;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.NumericUpDown autoBackupTime;
        private System.Windows.Forms.CheckBox chkAutoBackup;
        private System.Windows.Forms.Button deleteBackups;
        private System.Windows.Forms.Button openLevel;
        private System.Windows.Forms.Button importClipboard;
        private System.Windows.Forms.Button openClipboard;
        private System.Windows.Forms.Button exportClipboard;
        private System.Windows.Forms.GroupBox grpDLPMode;
        private System.Windows.Forms.Label lblDLPMode1;
        private System.Windows.Forms.CheckBox dlpCheckBox;
        private System.Windows.Forms.Label lblDLPMode2;
        private System.Windows.Forms.OpenFileDialog openROMDialog;
        private System.Windows.Forms.Button xdelta_import;
        private System.Windows.Forms.Button xdelta_export;
        private System.Windows.Forms.ComboBox patchMethodComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox languagesComboBox;
        private System.Windows.Forms.Label linkNSMBHD;
        private System.Windows.Forms.Label linkOgRepo;
        private System.Windows.Forms.Label creditsLabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox fontTextBox;
		private System.Windows.Forms.Button setFontBtn;
		private System.Windows.Forms.Button managePluginsBtn;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openROMToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openBackupsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem recentFilesToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem closeROMToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectToNetworkToolStripMenuItem;
		private System.Windows.Forms.ToolStripTextBox hostTextBox;
		private System.Windows.Forms.ToolStripTextBox portTextBox;
	}
}
