namespace NSMBe5
{
    partial class BNCL
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
            this.saveFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yPos_UpDown = new System.Windows.Forms.NumericUpDown();
            this.xPos_UpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.currentObj_UpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numberOfObjs_UpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.graphicID_UpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openImg = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gfxHeight_UpDown = new System.Windows.Forms.NumericUpDown();
            this.gfxWidth_UpDown = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.yPosAlign_UpDown = new System.Windows.Forms.NumericUpDown();
            this.xPosAlign_UpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.desc_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yPos_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPos_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentObj_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfObjs_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphicID_UpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gfxHeight_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gfxWidth_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPosAlign_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPosAlign_UpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(12, 12);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(85, 25);
            this.saveFile.TabIndex = 0;
            this.saveFile.Text = "Save";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.yPos_UpDown);
            this.groupBox1.Controls.Add(this.xPos_UpDown);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.currentObj_UpDown);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numberOfObjs_UpDown);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 169);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Values";
            // 
            // yPos_UpDown
            // 
            this.yPos_UpDown.Location = new System.Drawing.Point(179, 136);
            this.yPos_UpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.yPos_UpDown.Name = "yPos_UpDown";
            this.yPos_UpDown.Size = new System.Drawing.Size(48, 22);
            this.yPos_UpDown.TabIndex = 9;
            this.yPos_UpDown.ValueChanged += new System.EventHandler(this.OnObjectPropertiesChange);
            // 
            // xPos_UpDown
            // 
            this.xPos_UpDown.Location = new System.Drawing.Point(179, 108);
            this.xPos_UpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.xPos_UpDown.Name = "xPos_UpDown";
            this.xPos_UpDown.Size = new System.Drawing.Size(48, 22);
            this.xPos_UpDown.TabIndex = 8;
            this.xPos_UpDown.ValueChanged += new System.EventHandler(this.OnObjectPropertiesChange);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "X Position:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Y Position:";
            // 
            // currentObj_UpDown
            // 
            this.currentObj_UpDown.Location = new System.Drawing.Point(179, 53);
            this.currentObj_UpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.currentObj_UpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.currentObj_UpDown.Name = "currentObj_UpDown";
            this.currentObj_UpDown.Size = new System.Drawing.Size(48, 22);
            this.currentObj_UpDown.TabIndex = 3;
            this.currentObj_UpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.currentObj_UpDown.ValueChanged += new System.EventHandler(this.OnSelectedObjectChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current object:";
            // 
            // numberOfObjs_UpDown
            // 
            this.numberOfObjs_UpDown.Enabled = false;
            this.numberOfObjs_UpDown.Location = new System.Drawing.Point(179, 25);
            this.numberOfObjs_UpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numberOfObjs_UpDown.Name = "numberOfObjs_UpDown";
            this.numberOfObjs_UpDown.Size = new System.Drawing.Size(48, 22);
            this.numberOfObjs_UpDown.TabIndex = 1;
            this.numberOfObjs_UpDown.ValueChanged += new System.EventHandler(this.OnSelectedObjectChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of objects:";
            // 
            // graphicID_UpDown
            // 
            this.graphicID_UpDown.Enabled = false;
            this.graphicID_UpDown.Location = new System.Drawing.Point(179, 137);
            this.graphicID_UpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.graphicID_UpDown.Name = "graphicID_UpDown";
            this.graphicID_UpDown.Size = new System.Drawing.Size(48, 22);
            this.graphicID_UpDown.TabIndex = 10;
            this.graphicID_UpDown.ValueChanged += new System.EventHandler(this.OnObjectPropertiesChange);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Graphic ID:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(255, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 192);
            this.panel1.TabIndex = 2;
            // 
            // openImg
            // 
            this.openImg.Location = new System.Drawing.Point(406, 12);
            this.openImg.Name = "openImg";
            this.openImg.Size = new System.Drawing.Size(101, 25);
            this.openImg.TabIndex = 3;
            this.openImg.Text = "Open Image";
            this.openImg.UseVisualStyleBackColor = true;
            this.openImg.Click += new System.EventHandler(this.OpenImg_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(252, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "2D Viewer:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gfxHeight_UpDown);
            this.groupBox2.Controls.Add(this.gfxWidth_UpDown);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.yPosAlign_UpDown);
            this.groupBox2.Controls.Add(this.graphicID_UpDown);
            this.groupBox2.Controls.Add(this.xPosAlign_UpDown);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 173);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hardcoded Values";
            // 
            // gfxHeight_UpDown
            // 
            this.gfxHeight_UpDown.Enabled = false;
            this.gfxHeight_UpDown.Location = new System.Drawing.Point(179, 109);
            this.gfxHeight_UpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.gfxHeight_UpDown.Name = "gfxHeight_UpDown";
            this.gfxHeight_UpDown.Size = new System.Drawing.Size(48, 22);
            this.gfxHeight_UpDown.TabIndex = 14;
            // 
            // gfxWidth_UpDown
            // 
            this.gfxWidth_UpDown.Enabled = false;
            this.gfxWidth_UpDown.Location = new System.Drawing.Point(179, 81);
            this.gfxWidth_UpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.gfxWidth_UpDown.Name = "gfxWidth_UpDown";
            this.gfxWidth_UpDown.Size = new System.Drawing.Size(48, 22);
            this.gfxWidth_UpDown.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Graphic Width:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Graphic Height:";
            // 
            // yPosAlign_UpDown
            // 
            this.yPosAlign_UpDown.Enabled = false;
            this.yPosAlign_UpDown.Location = new System.Drawing.Point(179, 53);
            this.yPosAlign_UpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.yPosAlign_UpDown.Name = "yPosAlign_UpDown";
            this.yPosAlign_UpDown.Size = new System.Drawing.Size(48, 22);
            this.yPosAlign_UpDown.TabIndex = 9;
            // 
            // xPosAlign_UpDown
            // 
            this.xPosAlign_UpDown.Enabled = false;
            this.xPosAlign_UpDown.Location = new System.Drawing.Point(179, 25);
            this.xPosAlign_UpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.xPosAlign_UpDown.Name = "xPosAlign_UpDown";
            this.xPosAlign_UpDown.Size = new System.Drawing.Size(48, 22);
            this.xPosAlign_UpDown.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "X Position Alignment:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Y Position Alignment:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(255, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Description:";
            // 
            // desc_label
            // 
            this.desc_label.AutoSize = true;
            this.desc_label.Location = new System.Drawing.Point(255, 299);
            this.desc_label.Name = "desc_label";
            this.desc_label.Size = new System.Drawing.Size(96, 13);
            this.desc_label.TabIndex = 12;
            this.desc_label.Text = "Description Label";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Update GFX Defs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.UpdateGFXDefs_Click);
            // 
            // BNCL
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(524, 406);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.desc_label);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.openImg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveFile);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::NSMBe5.Properties.Resources.nsmbe;
            this.Name = "BNCL";
            this.Text = "BNCL Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BNCL_ClosedEvent);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yPos_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPos_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentObj_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfObjs_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphicID_UpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gfxHeight_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gfxWidth_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPosAlign_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPosAlign_UpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numberOfObjs_UpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown currentObj_UpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown graphicID_UpDown;
        private System.Windows.Forms.NumericUpDown yPos_UpDown;
        private System.Windows.Forms.NumericUpDown xPos_UpDown;
        private System.Windows.Forms.Button openImg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown yPosAlign_UpDown;
        private System.Windows.Forms.NumericUpDown xPosAlign_UpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown gfxHeight_UpDown;
        private System.Windows.Forms.NumericUpDown gfxWidth_UpDown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label desc_label;
        private System.Windows.Forms.Button button1;
    }
}