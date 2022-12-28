namespace NSMBe5
{
    partial class BNBL
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
            this.height_UpDown = new System.Windows.Forms.NumericUpDown();
            this.width_UpDown = new System.Windows.Forms.NumericUpDown();
            this.yPos_UpDown = new System.Windows.Forms.NumericUpDown();
            this.xPos_UpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.currentTouchObj_UpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numberOfTouchObjs_UpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openImg = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.height_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.width_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPos_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPos_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentTouchObj_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfTouchObjs_UpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(7, 7);
            this.saveFile.Margin = new System.Windows.Forms.Padding(2);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(65, 25);
            this.saveFile.TabIndex = 0;
            this.saveFile.Text = "Save";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.height_UpDown);
            this.groupBox1.Controls.Add(this.width_UpDown);
            this.groupBox1.Controls.Add(this.yPos_UpDown);
            this.groupBox1.Controls.Add(this.xPos_UpDown);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.currentTouchObj_UpDown);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numberOfTouchObjs_UpDown);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(235, 220);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Values";
            // 
            // height_UpDown
            // 
            this.height_UpDown.Location = new System.Drawing.Point(174, 169);
            this.height_UpDown.Margin = new System.Windows.Forms.Padding(2);
            this.height_UpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.height_UpDown.Name = "height_UpDown";
            this.height_UpDown.Size = new System.Drawing.Size(50, 22);
            this.height_UpDown.TabIndex = 11;
            this.height_UpDown.ValueChanged += new System.EventHandler(this.valueChanged);
            // 
            // width_UpDown
            // 
            this.width_UpDown.Location = new System.Drawing.Point(174, 146);
            this.width_UpDown.Margin = new System.Windows.Forms.Padding(2);
            this.width_UpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.width_UpDown.Name = "width_UpDown";
            this.width_UpDown.Size = new System.Drawing.Size(50, 22);
            this.width_UpDown.TabIndex = 10;
            this.width_UpDown.ValueChanged += new System.EventHandler(this.valueChanged);
            // 
            // yPos_UpDown
            // 
            this.yPos_UpDown.Location = new System.Drawing.Point(174, 123);
            this.yPos_UpDown.Margin = new System.Windows.Forms.Padding(2);
            this.yPos_UpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.yPos_UpDown.Name = "yPos_UpDown";
            this.yPos_UpDown.Size = new System.Drawing.Size(50, 22);
            this.yPos_UpDown.TabIndex = 9;
            this.yPos_UpDown.ValueChanged += new System.EventHandler(this.valueChanged);
            // 
            // xPos_UpDown
            // 
            this.xPos_UpDown.Location = new System.Drawing.Point(174, 101);
            this.xPos_UpDown.Margin = new System.Windows.Forms.Padding(2);
            this.xPos_UpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.xPos_UpDown.Name = "xPos_UpDown";
            this.xPos_UpDown.Size = new System.Drawing.Size(50, 22);
            this.xPos_UpDown.TabIndex = 8;
            this.xPos_UpDown.ValueChanged += new System.EventHandler(this.valueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "X Position:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Y Position:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Height:";
            // 
            // currentTouchObj_UpDown
            // 
            this.currentTouchObj_UpDown.Location = new System.Drawing.Point(174, 56);
            this.currentTouchObj_UpDown.Margin = new System.Windows.Forms.Padding(2);
            this.currentTouchObj_UpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.currentTouchObj_UpDown.Name = "currentTouchObj_UpDown";
            this.currentTouchObj_UpDown.Size = new System.Drawing.Size(50, 22);
            this.currentTouchObj_UpDown.TabIndex = 3;
            this.currentTouchObj_UpDown.ValueChanged += new System.EventHandler(this.ObjectClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current touch object:";
            // 
            // numberOfTouchObjs_UpDown
            // 
            this.numberOfTouchObjs_UpDown.Location = new System.Drawing.Point(174, 33);
            this.numberOfTouchObjs_UpDown.Margin = new System.Windows.Forms.Padding(2);
            this.numberOfTouchObjs_UpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numberOfTouchObjs_UpDown.Name = "numberOfTouchObjs_UpDown";
            this.numberOfTouchObjs_UpDown.Size = new System.Drawing.Size(50, 22);
            this.numberOfTouchObjs_UpDown.TabIndex = 1;
            this.numberOfTouchObjs_UpDown.ValueChanged += new System.EventHandler(this.ObjectClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of touch objects:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(245, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 192);
            this.panel1.TabIndex = 2;
            // 
            // openImg
            // 
            this.openImg.Location = new System.Drawing.Point(391, 7);
            this.openImg.Margin = new System.Windows.Forms.Padding(2);
            this.openImg.Name = "openImg";
            this.openImg.Size = new System.Drawing.Size(100, 25);
            this.openImg.TabIndex = 3;
            this.openImg.Text = "Open Image";
            this.openImg.UseVisualStyleBackColor = true;
            this.openImg.Click += new System.EventHandler(this.OpenImg_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(246, 39);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "2D Viewer:";
            // 
            // BNBL
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(514, 261);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.openImg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveFile);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::NSMBe5.Properties.Resources.nsmbe;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BNBL";
            this.Text = "BNBL Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BNBL_ClosedEvent);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.height_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.width_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPos_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPos_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentTouchObj_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfTouchObjs_UpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numberOfTouchObjs_UpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown currentTouchObj_UpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown height_UpDown;
        private System.Windows.Forms.NumericUpDown width_UpDown;
        private System.Windows.Forms.NumericUpDown yPos_UpDown;
        private System.Windows.Forms.NumericUpDown xPos_UpDown;
        private System.Windows.Forms.Button openImg;
        private System.Windows.Forms.Label label7;
    }
}