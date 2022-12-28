namespace NSMBe5
{
    partial class ViewEditor
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
            this.viewsList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUnknown1 = new System.Windows.Forms.Label();
            this.lightList = new System.Windows.Forms.ComboBox();
            this.lblUnknown2 = new System.Windows.Forms.Label();
            this.lblUnknown3 = new System.Windows.Forms.Label();
            this.lbl3DLighting = new System.Windows.Forms.Label();
            this.lblMusic = new System.Windows.Forms.Label();
            this.lblProgressPath = new System.Windows.Forms.Label();
            this.music = new System.Windows.Forms.ComboBox();
            this.unk1 = new System.Windows.Forms.NumericUpDown();
            this.unk2 = new System.Windows.Forms.NumericUpDown();
            this.unk3 = new System.Windows.Forms.NumericUpDown();
            this.progressID = new System.Windows.Forms.NumericUpDown();
            this.camTop = new System.Windows.Forms.NumericUpDown();
            this.lblCameraTop = new System.Windows.Forms.Label();
            this.camBottom = new System.Windows.Forms.NumericUpDown();
            this.camTopSpecial = new System.Windows.Forms.NumericUpDown();
            this.camBottomSpecial = new System.Windows.Forms.NumericUpDown();
            this.lblCameraBottom = new System.Windows.Forms.Label();
            this.lblCameraTopSpecial = new System.Windows.Forms.Label();
            this.lblCameraBottomSpecial = new System.Windows.Forms.Label();
            this.lblScrollVertically = new System.Windows.Forms.Label();
            this.scrollVertically = new System.Windows.Forms.CheckBox();
            this.lblID = new System.Windows.Forms.Label();
            this.viewID = new System.Windows.Forms.NumericUpDown();
            this.addViewButton = new System.Windows.Forms.Button();
            this.deleteViewButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.TableLayoutPanel();
            this.selectContents = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unk1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unk2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unk3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camTopSpecial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camBottomSpecial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewID)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewsList
            // 
            this.viewsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewsList.FormattingEnabled = true;
            this.viewsList.Location = new System.Drawing.Point(0, 0);
            this.viewsList.Name = "viewsList";
            this.viewsList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.viewsList.Size = new System.Drawing.Size(280, 138);
            this.viewsList.TabIndex = 0;
            this.viewsList.SelectedIndexChanged += new System.EventHandler(this.viewsList_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.55556F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.44444F));
            this.tableLayoutPanel1.Controls.Add(this.lblUnknown1, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lightList, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.lblUnknown2, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblUnknown3, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.lbl3DLighting, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.lblMusic, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblProgressPath, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.music, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.unk1, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.unk2, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.unk3, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.progressID, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.camTop, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCameraTop, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.camBottom, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.camTopSpecial, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.camBottomSpecial, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblCameraBottom, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCameraTopSpecial, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCameraBottomSpecial, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblScrollVertically, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.scrollVertically, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 222);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(280, 298);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblUnknown1
            // 
            this.lblUnknown1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUnknown1.AutoSize = true;
            this.lblUnknown1.Location = new System.Drawing.Point(3, 166);
            this.lblUnknown1.Name = "lblUnknown1";
            this.lblUnknown1.Size = new System.Drawing.Size(80, 13);
            this.lblUnknown1.TabIndex = 0;
            this.lblUnknown1.Text = "<Unknown1>";
            // 
            // lightList
            // 
            this.lightList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lightList.FormattingEnabled = true;
            this.lightList.Location = new System.Drawing.Point(124, 246);
            this.lightList.Name = "lightList";
            this.lightList.Size = new System.Drawing.Size(121, 21);
            this.lightList.TabIndex = 2;
            this.lightList.SelectedIndexChanged += new System.EventHandler(this.lightList_SelectedIndexChanged);
            // 
            // lblUnknown2
            // 
            this.lblUnknown2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUnknown2.AutoSize = true;
            this.lblUnknown2.Location = new System.Drawing.Point(3, 194);
            this.lblUnknown2.Name = "lblUnknown2";
            this.lblUnknown2.Size = new System.Drawing.Size(80, 13);
            this.lblUnknown2.TabIndex = 0;
            this.lblUnknown2.Text = "<Unknown2>";
            // 
            // lblUnknown3
            // 
            this.lblUnknown3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUnknown3.AutoSize = true;
            this.lblUnknown3.Location = new System.Drawing.Point(3, 222);
            this.lblUnknown3.Name = "lblUnknown3";
            this.lblUnknown3.Size = new System.Drawing.Size(80, 13);
            this.lblUnknown3.TabIndex = 0;
            this.lblUnknown3.Text = "<Unknown3>";
            // 
            // lbl3DLighting
            // 
            this.lbl3DLighting.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl3DLighting.AutoSize = true;
            this.lbl3DLighting.Location = new System.Drawing.Point(3, 250);
            this.lbl3DLighting.Name = "lbl3DLighting";
            this.lbl3DLighting.Size = new System.Drawing.Size(80, 13);
            this.lbl3DLighting.TabIndex = 0;
            this.lbl3DLighting.Text = "<3DLighting>";
            // 
            // lblMusic
            // 
            this.lblMusic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMusic.AutoSize = true;
            this.lblMusic.Location = new System.Drawing.Point(3, 139);
            this.lblMusic.Name = "lblMusic";
            this.lblMusic.Size = new System.Drawing.Size(53, 13);
            this.lblMusic.TabIndex = 0;
            this.lblMusic.Text = "<Music>";
            // 
            // lblProgressPath
            // 
            this.lblProgressPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblProgressPath.AutoSize = true;
            this.lblProgressPath.Location = new System.Drawing.Point(3, 277);
            this.lblProgressPath.Name = "lblProgressPath";
            this.lblProgressPath.Size = new System.Drawing.Size(101, 13);
            this.lblProgressPath.TabIndex = 0;
            this.lblProgressPath.Text = "<ProgressPathID>";
            // 
            // music
            // 
            this.music.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.music.FormattingEnabled = true;
            this.music.Location = new System.Drawing.Point(124, 135);
            this.music.Name = "music";
            this.music.Size = new System.Drawing.Size(121, 21);
            this.music.TabIndex = 2;
            this.music.SelectedIndexChanged += new System.EventHandler(this.music_SelectedIndexChanged);
            // 
            // unk1
            // 
            this.unk1.Location = new System.Drawing.Point(124, 162);
            this.unk1.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.unk1.Name = "unk1";
            this.unk1.Size = new System.Drawing.Size(121, 22);
            this.unk1.TabIndex = 1;
            this.unk1.ValueChanged += new System.EventHandler(this.unk1_ValueChanged);
            // 
            // unk2
            // 
            this.unk2.Location = new System.Drawing.Point(124, 190);
            this.unk2.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.unk2.Name = "unk2";
            this.unk2.Size = new System.Drawing.Size(121, 22);
            this.unk2.TabIndex = 1;
            this.unk2.ValueChanged += new System.EventHandler(this.unk2_ValueChanged);
            // 
            // unk3
            // 
            this.unk3.Location = new System.Drawing.Point(124, 218);
            this.unk3.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.unk3.Name = "unk3";
            this.unk3.Size = new System.Drawing.Size(121, 22);
            this.unk3.TabIndex = 1;
            this.unk3.ValueChanged += new System.EventHandler(this.unk3_ValueChanged);
            // 
            // progressID
            // 
            this.progressID.Location = new System.Drawing.Point(124, 273);
            this.progressID.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.progressID.Name = "progressID";
            this.progressID.Size = new System.Drawing.Size(121, 22);
            this.progressID.TabIndex = 1;
            this.progressID.ValueChanged += new System.EventHandler(this.progressID_ValueChanged);
            // 
            // camTop
            // 
            this.camTop.Location = new System.Drawing.Point(124, 3);
            this.camTop.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.camTop.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.camTop.Name = "camTop";
            this.camTop.Size = new System.Drawing.Size(121, 22);
            this.camTop.TabIndex = 1;
            this.camTop.ValueChanged += new System.EventHandler(this.camTop_ValueChanged);
            // 
            // lblCameraTop
            // 
            this.lblCameraTop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCameraTop.AutoSize = true;
            this.lblCameraTop.Location = new System.Drawing.Point(3, 7);
            this.lblCameraTop.Name = "lblCameraTop";
            this.lblCameraTop.Size = new System.Drawing.Size(112, 13);
            this.lblCameraTop.TabIndex = 0;
            this.lblCameraTop.Text = "<CameraTopOffset>";
            // 
            // camBottom
            // 
            this.camBottom.Location = new System.Drawing.Point(124, 31);
            this.camBottom.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.camBottom.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.camBottom.Name = "camBottom";
            this.camBottom.Size = new System.Drawing.Size(121, 22);
            this.camBottom.TabIndex = 1;
            this.camBottom.ValueChanged += new System.EventHandler(this.camBottom_ValueChanged);
            // 
            // camTopSpecial
            // 
            this.camTopSpecial.Location = new System.Drawing.Point(124, 59);
            this.camTopSpecial.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.camTopSpecial.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.camTopSpecial.Name = "camTopSpecial";
            this.camTopSpecial.Size = new System.Drawing.Size(121, 22);
            this.camTopSpecial.TabIndex = 1;
            this.camTopSpecial.ValueChanged += new System.EventHandler(this.camTopSpecial_ValueChanged);
            // 
            // camBottomSpecial
            // 
            this.camBottomSpecial.Location = new System.Drawing.Point(124, 87);
            this.camBottomSpecial.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.camBottomSpecial.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.camBottomSpecial.Name = "camBottomSpecial";
            this.camBottomSpecial.Size = new System.Drawing.Size(121, 22);
            this.camBottomSpecial.TabIndex = 1;
            this.camBottomSpecial.ValueChanged += new System.EventHandler(this.camBottomSpecial_ValueChanged);
            // 
            // lblCameraBottom
            // 
            this.lblCameraBottom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCameraBottom.AutoSize = true;
            this.lblCameraBottom.Location = new System.Drawing.Point(3, 29);
            this.lblCameraBottom.Name = "lblCameraBottom";
            this.lblCameraBottom.Size = new System.Drawing.Size(112, 26);
            this.lblCameraBottom.TabIndex = 0;
            this.lblCameraBottom.Text = "<CameraBottomOffset>";
            // 
            // lblCameraTopSpecial
            // 
            this.lblCameraTopSpecial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCameraTopSpecial.AutoSize = true;
            this.lblCameraTopSpecial.Location = new System.Drawing.Point(3, 57);
            this.lblCameraTopSpecial.Name = "lblCameraTopSpecial";
            this.lblCameraTopSpecial.Size = new System.Drawing.Size(110, 26);
            this.lblCameraTopSpecial.TabIndex = 0;
            this.lblCameraTopSpecial.Text = "<CameraTopOffsetSpecial>";
            // 
            // lblCameraBottomSpecial
            // 
            this.lblCameraBottomSpecial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCameraBottomSpecial.AutoSize = true;
            this.lblCameraBottomSpecial.Location = new System.Drawing.Point(3, 85);
            this.lblCameraBottomSpecial.Name = "lblCameraBottomSpecial";
            this.lblCameraBottomSpecial.Size = new System.Drawing.Size(112, 26);
            this.lblCameraBottomSpecial.TabIndex = 0;
            this.lblCameraBottomSpecial.Text = "<CameraBottomOffsetSpecial>";
            // 
            // lblScrollVertically
            // 
            this.lblScrollVertically.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblScrollVertically.AutoSize = true;
            this.lblScrollVertically.Location = new System.Drawing.Point(3, 115);
            this.lblScrollVertically.Name = "lblScrollVertically";
            this.lblScrollVertically.Size = new System.Drawing.Size(96, 13);
            this.lblScrollVertically.TabIndex = 0;
            this.lblScrollVertically.Text = "<ScrollVertically>";
            // 
            // scrollVertically
            // 
            this.scrollVertically.AutoSize = true;
            this.scrollVertically.Location = new System.Drawing.Point(124, 115);
            this.scrollVertically.Name = "scrollVertically";
            this.scrollVertically.Size = new System.Drawing.Size(15, 14);
            this.scrollVertically.TabIndex = 3;
            this.scrollVertically.UseVisualStyleBackColor = true;
            this.scrollVertically.CheckedChanged += new System.EventHandler(this.scrollVertically_CheckedChanged);
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 8);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(34, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "<ID>";
            // 
            // viewID
            // 
            this.viewID.Location = new System.Drawing.Point(124, 3);
            this.viewID.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.viewID.Name = "viewID";
            this.viewID.Size = new System.Drawing.Size(121, 22);
            this.viewID.TabIndex = 1;
            this.viewID.ValueChanged += new System.EventHandler(this.viewID_ValueChanged);
            // 
            // addViewButton
            // 
            this.addViewButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addViewButton.Location = new System.Drawing.Point(55, 2);
            this.addViewButton.Name = "addViewButton";
            this.addViewButton.Size = new System.Drawing.Size(82, 22);
            this.addViewButton.TabIndex = 3;
            this.addViewButton.Text = "<addViewButton>";
            this.addViewButton.UseVisualStyleBackColor = true;
            this.addViewButton.Click += new System.EventHandler(this.addViewButton_Click);
            // 
            // deleteViewButton
            // 
            this.deleteViewButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteViewButton.Location = new System.Drawing.Point(143, 2);
            this.deleteViewButton.Name = "deleteViewButton";
            this.deleteViewButton.Size = new System.Drawing.Size(82, 22);
            this.deleteViewButton.TabIndex = 3;
            this.deleteViewButton.Text = "<deleteViewButton>";
            this.deleteViewButton.UseVisualStyleBackColor = true;
            this.deleteViewButton.Click += new System.EventHandler(this.deleteViewButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deleteViewButton);
            this.panel1.Controls.Add(this.addViewButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 26);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.ColumnCount = 2;
            this.panel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.56F));
            this.panel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.44F));
            this.panel2.Controls.Add(this.selectContents, 0, 1);
            this.panel2.Controls.Add(this.viewID, 1, 0);
            this.panel2.Controls.Add(this.lblID, 0, 0);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 164);
            this.panel2.Name = "panel2";
            this.panel2.RowCount = 2;
            this.panel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel2.Size = new System.Drawing.Size(280, 58);
            this.panel2.TabIndex = 5;
            // 
            // selectContents
            // 
            this.panel2.SetColumnSpan(this.selectContents, 2);
            this.selectContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectContents.Location = new System.Drawing.Point(3, 32);
            this.selectContents.Name = "selectContents";
            this.selectContents.Size = new System.Drawing.Size(274, 23);
            this.selectContents.TabIndex = 0;
            this.selectContents.Text = "<Select Contents>";
            this.selectContents.UseVisualStyleBackColor = true;
            this.selectContents.Click += new System.EventHandler(this.selectContents_Click);
            // 
            // ViewEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewsList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ViewEditor";
            this.Size = new System.Drawing.Size(280, 520);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unk1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unk2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unk3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camTopSpecial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camBottomSpecial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewID)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox viewsList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCameraTop;
        private System.Windows.Forms.Label lblUnknown1;
        private System.Windows.Forms.Label lblUnknown2;
        private System.Windows.Forms.Label lblUnknown3;
        private System.Windows.Forms.Label lbl3DLighting;
        private System.Windows.Forms.Label lblMusic;
        private System.Windows.Forms.Label lblProgressPath;
        private System.Windows.Forms.NumericUpDown camTop;
        private System.Windows.Forms.ComboBox music;
        private System.Windows.Forms.NumericUpDown unk1;
        private System.Windows.Forms.NumericUpDown unk2;
        private System.Windows.Forms.NumericUpDown unk3;
        private System.Windows.Forms.NumericUpDown progressID;
        private System.Windows.Forms.Button addViewButton;
        private System.Windows.Forms.Button deleteViewButton;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.NumericUpDown viewID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown camBottom;
        private System.Windows.Forms.NumericUpDown camTopSpecial;
        private System.Windows.Forms.NumericUpDown camBottomSpecial;
        private System.Windows.Forms.Label lblCameraBottom;
        private System.Windows.Forms.Label lblCameraTopSpecial;
        private System.Windows.Forms.Label lblCameraBottomSpecial;
        private System.Windows.Forms.Label lblScrollVertically;
        private System.Windows.Forms.TableLayoutPanel panel2;
        private System.Windows.Forms.Button selectContents;
        private System.Windows.Forms.ComboBox lightList;
        private System.Windows.Forms.CheckBox scrollVertically;
    }
}
