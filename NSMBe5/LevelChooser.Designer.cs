
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
            this.patchMethodComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.languagesComboBox = new System.Windows.Forms.ComboBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.usingSBCodeHackCheckBox = new System.Windows.Forms.CheckBox();
            this.deleteBackups = new System.Windows.Forms.Button();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.autoBackupTime = new System.Windows.Forms.NumericUpDown();
            this.updateSpriteDataButton = new System.Windows.Forms.Button();
            this.chkAutoBackup = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.linkNSMBHD = new System.Windows.Forms.LinkLabel();
            this.linkOgRepo = new System.Windows.Forms.LinkLabel();
            this.linkRepo = new System.Windows.Forms.LinkLabel();
            this.lblLinksHeader = new System.Windows.Forms.Label();
            this.lblCreditsHeader = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.importLevelDialog = new System.Windows.Forms.OpenFileDialog();
            this.exportLevelDialog = new System.Windows.Forms.SaveFileDialog();
            this.savePatchDialog = new System.Windows.Forms.SaveFileDialog();
            this.openPatchDialog = new System.Windows.Forms.OpenFileDialog();
            this.openTextFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveTextFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openROMDialog = new System.Windows.Forms.OpenFileDialog();
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
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(554, 483);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(546, 457);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "<Level Listing>";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // openClipboard
            // 
            this.openClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openClipboard.Location = new System.Drawing.Point(220, 427);
            this.openClipboard.Name = "openClipboard";
            this.openClipboard.Size = new System.Drawing.Size(118, 23);
            this.openClipboard.TabIndex = 8;
            this.openClipboard.Text = "<OpenClipboard>";
            this.openClipboard.UseVisualStyleBackColor = true;
            this.openClipboard.Click += new System.EventHandler(this.openClipboard_Click);
            // 
            // exportClipboard
            // 
            this.exportClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exportClipboard.Enabled = false;
            this.exportClipboard.Location = new System.Drawing.Point(107, 427);
            this.exportClipboard.Name = "exportClipboard";
            this.exportClipboard.Size = new System.Drawing.Size(106, 23);
            this.exportClipboard.TabIndex = 7;
            this.exportClipboard.Text = "<ExportToClipboard>";
            this.exportClipboard.UseVisualStyleBackColor = true;
            this.exportClipboard.Click += new System.EventHandler(this.exportClipboard_Click);
            // 
            // importClipboard
            // 
            this.importClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.importClipboard.Enabled = false;
            this.importClipboard.Location = new System.Drawing.Point(6, 427);
            this.importClipboard.Name = "importClipboard";
            this.importClipboard.Size = new System.Drawing.Size(94, 23);
            this.importClipboard.TabIndex = 6;
            this.importClipboard.Text = "<ImportClipboard>";
            this.importClipboard.UseVisualStyleBackColor = true;
            this.importClipboard.Click += new System.EventHandler(this.importClipboard_Click);
            // 
            // openLevel
            // 
            this.openLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openLevel.Location = new System.Drawing.Point(219, 397);
            this.openLevel.Name = "openLevel";
            this.openLevel.Size = new System.Drawing.Size(119, 23);
            this.openLevel.TabIndex = 5;
            this.openLevel.Text = "<OpenExportedLevel>";
            this.openLevel.UseVisualStyleBackColor = true;
            this.openLevel.Click += new System.EventHandler(this.openLevel_Click);
            // 
            // hexEditLevelButton
            // 
            this.hexEditLevelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.hexEditLevelButton.Enabled = false;
            this.hexEditLevelButton.Location = new System.Drawing.Point(456, 427);
            this.hexEditLevelButton.Name = "hexEditLevelButton";
            this.hexEditLevelButton.Size = new System.Drawing.Size(75, 23);
            this.hexEditLevelButton.TabIndex = 4;
            this.hexEditLevelButton.Text = "<hexEditLevelButton>";
            this.hexEditLevelButton.UseVisualStyleBackColor = true;
            this.hexEditLevelButton.Click += new System.EventHandler(this.hexEditLevelButton_Click);
            // 
            // exportLevelButton
            // 
            this.exportLevelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exportLevelButton.Enabled = false;
            this.exportLevelButton.Location = new System.Drawing.Point(106, 397);
            this.exportLevelButton.Name = "exportLevelButton";
            this.exportLevelButton.Size = new System.Drawing.Size(107, 23);
            this.exportLevelButton.TabIndex = 3;
            this.exportLevelButton.Text = "<exportLevelButton>";
            this.exportLevelButton.UseVisualStyleBackColor = true;
            this.exportLevelButton.Click += new System.EventHandler(this.exportLevelButton_Click);
            // 
            // importLevelButton
            // 
            this.importLevelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.importLevelButton.Enabled = false;
            this.importLevelButton.Location = new System.Drawing.Point(5, 397);
            this.importLevelButton.Name = "importLevelButton";
            this.importLevelButton.Size = new System.Drawing.Size(95, 23);
            this.importLevelButton.TabIndex = 2;
            this.importLevelButton.Text = "<importLevelButton>";
            this.importLevelButton.UseVisualStyleBackColor = true;
            this.importLevelButton.Click += new System.EventHandler(this.importLevelButton_Click);
            // 
            // editLevelButton
            // 
            this.editLevelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editLevelButton.Enabled = false;
            this.editLevelButton.Location = new System.Drawing.Point(456, 397);
            this.editLevelButton.Name = "editLevelButton";
            this.editLevelButton.Size = new System.Drawing.Size(75, 23);
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
            this.levelTreeView.Location = new System.Drawing.Point(6, 6);
            this.levelTreeView.Name = "levelTreeView";
            this.levelTreeView.Size = new System.Drawing.Size(526, 385);
            this.levelTreeView.TabIndex = 0;
            this.levelTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.levelTreeView_AfterSelect);
            this.levelTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.levelTreeView_NodeMouseDoubleClick);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tilesetList1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage5.Size = new System.Drawing.Size(542, 457);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "<Tilesets>";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tilesetList1
            // 
            this.tilesetList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tilesetList1.Location = new System.Drawing.Point(3, 3);
            this.tilesetList1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tilesetList1.Name = "tilesetList1";
            this.tilesetList1.Size = new System.Drawing.Size(536, 451);
            this.tilesetList1.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.backgroundList1);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(542, 457);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "<Backgrounds>";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // backgroundList1
            // 
            this.backgroundList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundList1.Location = new System.Drawing.Point(0, 0);
            this.backgroundList1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backgroundList1.Name = "backgroundList1";
            this.backgroundList1.Size = new System.Drawing.Size(542, 457);
            this.backgroundList1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.filesystemBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(542, 457);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "<File Browser>";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // filesystemBrowser1
            // 
            this.filesystemBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesystemBrowser1.Location = new System.Drawing.Point(3, 3);
            this.filesystemBrowser1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filesystemBrowser1.Name = "filesystemBrowser1";
            this.filesystemBrowser1.Size = new System.Drawing.Size(536, 451);
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
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(542, 457);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "<Tools/Options>";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // grpDLPMode
            // 
            this.grpDLPMode.Controls.Add(this.lblDLPMode2);
            this.grpDLPMode.Controls.Add(this.lblDLPMode1);
            this.grpDLPMode.Controls.Add(this.dlpCheckBox);
            this.grpDLPMode.Location = new System.Drawing.Point(6, 336);
            this.grpDLPMode.Name = "grpDLPMode";
            this.grpDLPMode.Size = new System.Drawing.Size(246, 117);
            this.grpDLPMode.TabIndex = 11;
            this.grpDLPMode.TabStop = false;
            this.grpDLPMode.Text = "<DLP mode>";
            // 
            // lblDLPMode2
            // 
            this.lblDLPMode2.Location = new System.Drawing.Point(6, 82);
            this.lblDLPMode2.Name = "lblDLPMode2";
            this.lblDLPMode2.Size = new System.Drawing.Size(231, 31);
            this.lblDLPMode2.TabIndex = 11;
            this.lblDLPMode2.Text = "<You do NOT need to enable this if you\'re using firmware.nds or FlashMe.>";
            // 
            // lblDLPMode1
            // 
            this.lblDLPMode1.Location = new System.Drawing.Point(6, 39);
            this.lblDLPMode1.Name = "lblDLPMode1";
            this.lblDLPMode1.Size = new System.Drawing.Size(234, 43);
            this.lblDLPMode1.TabIndex = 11;
            this.lblDLPMode1.Text = "<This will prevent some values in the header from being updated. The ROM will wor" +
    "k over DLP but may not work on some flashcards.>";
            // 
            // dlpCheckBox
            // 
            this.dlpCheckBox.AutoSize = true;
            this.dlpCheckBox.Location = new System.Drawing.Point(6, 19);
            this.dlpCheckBox.Name = "dlpCheckBox";
            this.dlpCheckBox.Size = new System.Drawing.Size(232, 17);
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
            this.musicSlotsGrp.Location = new System.Drawing.Point(258, 177);
            this.musicSlotsGrp.Name = "musicSlotsGrp";
            this.musicSlotsGrp.Size = new System.Drawing.Size(278, 277);
            this.musicSlotsGrp.TabIndex = 8;
            this.musicSlotsGrp.TabStop = false;
            this.musicSlotsGrp.Text = "<Music Slots>";
            // 
            // renameBtn
            // 
            this.renameBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.renameBtn.Location = new System.Drawing.Point(197, 251);
            this.renameBtn.Name = "renameBtn";
            this.renameBtn.Size = new System.Drawing.Size(75, 23);
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
            this.musicList.Location = new System.Drawing.Point(6, 20);
            this.musicList.Name = "musicList";
            this.musicList.Size = new System.Drawing.Size(266, 225);
            this.musicList.TabIndex = 9;
            // 
            // patchesGroupbox
            // 
            this.patchesGroupbox.Controls.Add(this.xdelta_import);
            this.patchesGroupbox.Controls.Add(this.xdelta_export);
            this.patchesGroupbox.Controls.Add(this.patchExport);
            this.patchesGroupbox.Controls.Add(this.patchImport);
            this.patchesGroupbox.Location = new System.Drawing.Point(258, 6);
            this.patchesGroupbox.Name = "patchesGroupbox";
            this.patchesGroupbox.Size = new System.Drawing.Size(278, 80);
            this.patchesGroupbox.TabIndex = 7;
            this.patchesGroupbox.TabStop = false;
            this.patchesGroupbox.Text = "<Patches>";
            // 
            // xdelta_import
            // 
            this.xdelta_import.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xdelta_import.Location = new System.Drawing.Point(140, 48);
            this.xdelta_import.Name = "xdelta_import";
            this.xdelta_import.Size = new System.Drawing.Size(132, 23);
            this.xdelta_import.TabIndex = 5;
            this.xdelta_import.Text = "XDelta Patch Import";
            this.xdelta_import.UseVisualStyleBackColor = true;
            this.xdelta_import.Click += new System.EventHandler(this.Xdelta_import_Click);
            // 
            // xdelta_export
            // 
            this.xdelta_export.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xdelta_export.Location = new System.Drawing.Point(140, 19);
            this.xdelta_export.Name = "xdelta_export";
            this.xdelta_export.Size = new System.Drawing.Size(132, 23);
            this.xdelta_export.TabIndex = 4;
            this.xdelta_export.Text = "XDelta Patch Export";
            this.xdelta_export.UseVisualStyleBackColor = true;
            this.xdelta_export.Click += new System.EventHandler(this.Xdelta_export_Click);
            // 
            // patchExport
            // 
            this.patchExport.Location = new System.Drawing.Point(6, 19);
            this.patchExport.Name = "patchExport";
            this.patchExport.Size = new System.Drawing.Size(133, 23);
            this.patchExport.TabIndex = 3;
            this.patchExport.Text = "<patchExport>";
            this.patchExport.UseVisualStyleBackColor = true;
            this.patchExport.Click += new System.EventHandler(this.patchExport_Click);
            // 
            // patchImport
            // 
            this.patchImport.Location = new System.Drawing.Point(6, 48);
            this.patchImport.Name = "patchImport";
            this.patchImport.Size = new System.Drawing.Size(133, 23);
            this.patchImport.TabIndex = 3;
            this.patchImport.Text = "<patchImport>";
            this.patchImport.UseVisualStyleBackColor = true;
            this.patchImport.Click += new System.EventHandler(this.patchImport_Click);
            // 
            // nsmbToolsGroupbox
            // 
            this.nsmbToolsGroupbox.Controls.Add(this.mpPatch2);
            this.nsmbToolsGroupbox.Controls.Add(this.dataFinderButton);
            this.nsmbToolsGroupbox.Location = new System.Drawing.Point(6, 6);
            this.nsmbToolsGroupbox.Name = "nsmbToolsGroupbox";
            this.nsmbToolsGroupbox.Size = new System.Drawing.Size(246, 80);
            this.nsmbToolsGroupbox.TabIndex = 6;
            this.nsmbToolsGroupbox.TabStop = false;
            this.nsmbToolsGroupbox.Text = "<NSMB Tools>";
            // 
            // mpPatch2
            // 
            this.mpPatch2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mpPatch2.Location = new System.Drawing.Point(6, 19);
            this.mpPatch2.Name = "mpPatch2";
            this.mpPatch2.Size = new System.Drawing.Size(234, 23);
            this.mpPatch2.TabIndex = 5;
            this.mpPatch2.Text = "<mpPatch2>";
            this.mpPatch2.UseVisualStyleBackColor = true;
            this.mpPatch2.Click += new System.EventHandler(this.mpPatch2_Click);
            // 
            // dataFinderButton
            // 
            this.dataFinderButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataFinderButton.Location = new System.Drawing.Point(6, 48);
            this.dataFinderButton.Name = "dataFinderButton";
            this.dataFinderButton.Size = new System.Drawing.Size(234, 23);
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
            this.asmToolsGroupbox.Location = new System.Drawing.Point(258, 92);
            this.asmToolsGroupbox.Name = "asmToolsGroupbox";
            this.asmToolsGroupbox.Size = new System.Drawing.Size(278, 79);
            this.asmToolsGroupbox.TabIndex = 4;
            this.asmToolsGroupbox.TabStop = false;
            this.asmToolsGroupbox.Text = "<Code hacking tools>";
            // 
            // cleanBuild
            // 
            this.cleanBuild.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cleanBuild.Location = new System.Drawing.Point(140, 48);
            this.cleanBuild.Name = "cleanBuild";
            this.cleanBuild.Size = new System.Drawing.Size(132, 23);
            this.cleanBuild.TabIndex = 3;
            this.cleanBuild.Text = "<Clean build>";
            this.cleanBuild.UseVisualStyleBackColor = true;
            this.cleanBuild.Click += new System.EventHandler(this.cleanBuild_Click);
            // 
            // compileInsert
            // 
            this.compileInsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.compileInsert.Location = new System.Drawing.Point(6, 48);
            this.compileInsert.Name = "compileInsert";
            this.compileInsert.Size = new System.Drawing.Size(133, 23);
            this.compileInsert.TabIndex = 3;
            this.compileInsert.Text = "<Compile and insert>";
            this.compileInsert.UseVisualStyleBackColor = true;
            this.compileInsert.Click += new System.EventHandler(this.compileInsert_Click);
            // 
            // decompArm9Bin
            // 
            this.decompArm9Bin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.decompArm9Bin.Location = new System.Drawing.Point(6, 19);
            this.decompArm9Bin.Name = "decompArm9Bin";
            this.decompArm9Bin.Size = new System.Drawing.Size(266, 23);
            this.decompArm9Bin.TabIndex = 3;
            this.decompArm9Bin.Text = "<Decompress ARM9 binary>";
            this.decompArm9Bin.UseVisualStyleBackColor = true;
            this.decompArm9Bin.Click += new System.EventHandler(this.decompArm9Bin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.patchMethodComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.languagesComboBox);
            this.groupBox1.Controls.Add(this.languageLabel);
            this.groupBox1.Controls.Add(this.usingSBCodeHackCheckBox);
            this.groupBox1.Controls.Add(this.deleteBackups);
            this.groupBox1.Controls.Add(this.minutesLabel);
            this.groupBox1.Controls.Add(this.autoBackupTime);
            this.groupBox1.Controls.Add(this.updateSpriteDataButton);
            this.groupBox1.Controls.Add(this.chkAutoBackup);
            this.groupBox1.Location = new System.Drawing.Point(6, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 238);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "<Settings>";
            // 
            // patchMethodComboBox
            // 
            this.patchMethodComboBox.FormattingEnabled = true;
            this.patchMethodComboBox.Location = new System.Drawing.Point(6, 50);
            this.patchMethodComboBox.Name = "patchMethodComboBox";
            this.patchMethodComboBox.Size = new System.Drawing.Size(108, 21);
            this.patchMethodComboBox.TabIndex = 14;
            this.patchMethodComboBox.SelectedIndexChanged += new System.EventHandler(this.patchMethodComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Code patching method";
            // 
            // languagesComboBox
            // 
            this.languagesComboBox.FormattingEnabled = true;
            this.languagesComboBox.Location = new System.Drawing.Point(6, 21);
            this.languagesComboBox.Name = "languagesComboBox";
            this.languagesComboBox.Size = new System.Drawing.Size(108, 21);
            this.languagesComboBox.TabIndex = 14;
            this.languagesComboBox.SelectedIndexChanged += new System.EventHandler(this.languagesComboBox_SelectedIndexChanged);
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(120, 24);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(74, 13);
            this.languageLabel.TabIndex = 0;
            this.languageLabel.Text = "<Language>";
            // 
            // usingSBCodeHackCheckBox
            // 
            this.usingSBCodeHackCheckBox.AutoSize = true;
            this.usingSBCodeHackCheckBox.Location = new System.Drawing.Point(6, 125);
            this.usingSBCodeHackCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usingSBCodeHackCheckBox.Name = "usingSBCodeHackCheckBox";
            this.usingSBCodeHackCheckBox.Size = new System.Drawing.Size(167, 17);
            this.usingSBCodeHackCheckBox.TabIndex = 12;
            this.usingSBCodeHackCheckBox.Text = "Using signboard code hack";
            this.usingSBCodeHackCheckBox.UseVisualStyleBackColor = true;
            this.usingSBCodeHackCheckBox.CheckedChanged += new System.EventHandler(this.Using_sb_asm_checkBox_CheckedChanged);
            // 
            // deleteBackups
            // 
            this.deleteBackups.Location = new System.Drawing.Point(6, 180);
            this.deleteBackups.Name = "deleteBackups";
            this.deleteBackups.Size = new System.Drawing.Size(234, 23);
            this.deleteBackups.TabIndex = 13;
            this.deleteBackups.Text = "<Delete all backups>";
            this.deleteBackups.UseVisualStyleBackColor = true;
            this.deleteBackups.Click += new System.EventHandler(this.deleteBackups_Click);
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Location = new System.Drawing.Point(66, 102);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(95, 13);
            this.minutesLabel.TabIndex = 12;
            this.minutesLabel.Text = "<Minutes delay>";
            // 
            // autoBackupTime
            // 
            this.autoBackupTime.Location = new System.Drawing.Point(6, 100);
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
            this.autoBackupTime.Size = new System.Drawing.Size(54, 22);
            this.autoBackupTime.TabIndex = 11;
            this.autoBackupTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.autoBackupTime.ValueChanged += new System.EventHandler(this.autoBackupTime_ValueChanged);
            // 
            // updateSpriteDataButton
            // 
            this.updateSpriteDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateSpriteDataButton.Location = new System.Drawing.Point(6, 209);
            this.updateSpriteDataButton.Name = "updateSpriteDataButton";
            this.updateSpriteDataButton.Size = new System.Drawing.Size(234, 23);
            this.updateSpriteDataButton.TabIndex = 3;
            this.updateSpriteDataButton.Text = "<UpdateSpriteData>";
            this.updateSpriteDataButton.UseVisualStyleBackColor = true;
            this.updateSpriteDataButton.Click += new System.EventHandler(this.updateSpriteDataButton_Click);
            // 
            // chkAutoBackup
            // 
            this.chkAutoBackup.AutoSize = true;
            this.chkAutoBackup.Location = new System.Drawing.Point(6, 77);
            this.chkAutoBackup.Name = "chkAutoBackup";
            this.chkAutoBackup.Size = new System.Drawing.Size(110, 17);
            this.chkAutoBackup.TabIndex = 9;
            this.chkAutoBackup.Text = "<Backup levels>";
            this.chkAutoBackup.UseVisualStyleBackColor = true;
            this.chkAutoBackup.CheckedChanged += new System.EventHandler(this.autoBackupTime_ValueChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.linkNSMBHD);
            this.tabPage4.Controls.Add(this.linkOgRepo);
            this.tabPage4.Controls.Add(this.linkRepo);
            this.tabPage4.Controls.Add(this.lblLinksHeader);
            this.tabPage4.Controls.Add(this.lblCreditsHeader);
            this.tabPage4.Controls.Add(this.versionLabel);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage4.Size = new System.Drawing.Size(542, 457);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "<About>";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(542, 164);
            this.label2.TabIndex = 8;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkNSMBHD
            // 
            this.linkNSMBHD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkNSMBHD.Location = new System.Drawing.Point(0, 340);
            this.linkNSMBHD.Name = "linkNSMBHD";
            this.linkNSMBHD.Size = new System.Drawing.Size(542, 23);
            this.linkNSMBHD.TabIndex = 7;
            this.linkNSMBHD.TabStop = true;
            this.linkNSMBHD.Text = "NSMB Hacking Domain";
            this.linkNSMBHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.linkNSMBHD, "http://nsmbhd.net/");
            this.linkNSMBHD.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNSMBHD_LinkClicked);
            // 
            // linkOgRepo
            // 
            this.linkOgRepo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkOgRepo.Location = new System.Drawing.Point(0, 318);
            this.linkOgRepo.Name = "linkOgRepo";
            this.linkOgRepo.Size = new System.Drawing.Size(542, 23);
            this.linkOgRepo.TabIndex = 6;
            this.linkOgRepo.TabStop = true;
            this.linkOgRepo.Text = "NSMBe on GitHub [The original repo]";
            this.linkOgRepo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.linkOgRepo, "https://github.com/Dirbaio/NSMB-Editor");
            this.linkOgRepo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkOgRepo_LinkClicked);
            // 
            // linkRepo
            // 
            this.linkRepo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkRepo.Location = new System.Drawing.Point(0, 295);
            this.linkRepo.Name = "linkRepo";
            this.linkRepo.Size = new System.Drawing.Size(542, 23);
            this.linkRepo.TabIndex = 5;
            this.linkRepo.TabStop = true;
            this.linkRepo.Text = "NSMBe on GitHub [The maintained repo]";
            this.linkRepo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.linkRepo, "https://github.com/MammaMiaTeam/NSMB-Editor");
            this.linkRepo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRepo_LinkClicked);
            // 
            // lblLinksHeader
            // 
            this.lblLinksHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLinksHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinksHeader.Location = new System.Drawing.Point(0, 275);
            this.lblLinksHeader.Name = "lblLinksHeader";
            this.lblLinksHeader.Size = new System.Drawing.Size(542, 20);
            this.lblLinksHeader.TabIndex = 4;
            this.lblLinksHeader.Text = "Links";
            this.lblLinksHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCreditsHeader
            // 
            this.lblCreditsHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCreditsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditsHeader.Location = new System.Drawing.Point(0, 81);
            this.lblCreditsHeader.Name = "lblCreditsHeader";
            this.lblCreditsHeader.Size = new System.Drawing.Size(542, 20);
            this.lblCreditsHeader.TabIndex = 2;
            this.lblCreditsHeader.Text = "Credits";
            this.lblCreditsHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // versionLabel
            // 
            this.versionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.Location = new System.Drawing.Point(0, 53);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(542, 28);
            this.versionLabel.TabIndex = 1;
            this.versionLabel.Text = "Version X";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Super Mario Bros. Editor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LevelChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 506);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LevelChooser";
            this.Text = "<_TITLE>";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LevelChooser_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LevelChooser_FormClosed);
            this.Load += new System.EventHandler(this.LevelChooser_Load);
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
        private System.Windows.Forms.Button updateSpriteDataButton;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCreditsHeader;
        private System.Windows.Forms.LinkLabel linkRepo;
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
        private System.Windows.Forms.CheckBox usingSBCodeHackCheckBox;
        private System.Windows.Forms.ComboBox patchMethodComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox languagesComboBox;
        private System.Windows.Forms.LinkLabel linkNSMBHD;
        private System.Windows.Forms.LinkLabel linkOgRepo;
        private System.Windows.Forms.Label label2;
    }
}
