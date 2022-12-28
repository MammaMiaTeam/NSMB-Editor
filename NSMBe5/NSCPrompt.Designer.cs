namespace NSMBe5
{
    partial class NSCPrompt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NSCPrompt));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tilewidth_UpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tilesetpref_btn = new System.Windows.Forms.Button();
            this.defaultpref_btn = new System.Windows.Forms.Button();
            this.fgpref_btn = new System.Windows.Forms.Button();
            this.bgpref_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bmpoff_UpDown = new System.Windows.Forms.NumericUpDown();
            this.paloff_UpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.proceed_btn = new System.Windows.Forms.Button();
            this.res_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tilewidth_UpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bmpoff_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paloff_UpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(83, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please input the tilemap configuration before proceeding.";
            // 
            // tilewidth_UpDown
            // 
            this.tilewidth_UpDown.Location = new System.Drawing.Point(119, 91);
            this.tilewidth_UpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.tilewidth_UpDown.Name = "tilewidth_UpDown";
            this.tilewidth_UpDown.Size = new System.Drawing.Size(58, 22);
            this.tilewidth_UpDown.TabIndex = 3;
            this.tilewidth_UpDown.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.tilewidth_UpDown.ValueChanged += new System.EventHandler(this.UpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tile Width:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tilesetpref_btn);
            this.groupBox1.Controls.Add(this.defaultpref_btn);
            this.groupBox1.Controls.Add(this.fgpref_btn);
            this.groupBox1.Controls.Add(this.bgpref_btn);
            this.groupBox1.Location = new System.Drawing.Point(183, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 90);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Presets";
            // 
            // tilesetpref_btn
            // 
            this.tilesetpref_btn.Location = new System.Drawing.Point(107, 21);
            this.tilesetpref_btn.Name = "tilesetpref_btn";
            this.tilesetpref_btn.Size = new System.Drawing.Size(94, 28);
            this.tilesetpref_btn.TabIndex = 3;
            this.tilesetpref_btn.Text = "Tileset";
            this.tilesetpref_btn.UseVisualStyleBackColor = true;
            this.tilesetpref_btn.Click += new System.EventHandler(this.Tilesetpref_btn_Click);
            // 
            // defaultpref_btn
            // 
            this.defaultpref_btn.Location = new System.Drawing.Point(6, 21);
            this.defaultpref_btn.Name = "defaultpref_btn";
            this.defaultpref_btn.Size = new System.Drawing.Size(94, 28);
            this.defaultpref_btn.TabIndex = 2;
            this.defaultpref_btn.Text = "Default";
            this.defaultpref_btn.UseVisualStyleBackColor = true;
            this.defaultpref_btn.Click += new System.EventHandler(this.Defaultpref_btn_Click);
            // 
            // fgpref_btn
            // 
            this.fgpref_btn.Location = new System.Drawing.Point(107, 55);
            this.fgpref_btn.Name = "fgpref_btn";
            this.fgpref_btn.Size = new System.Drawing.Size(94, 28);
            this.fgpref_btn.TabIndex = 1;
            this.fgpref_btn.Text = "Foreground";
            this.fgpref_btn.UseVisualStyleBackColor = true;
            this.fgpref_btn.Click += new System.EventHandler(this.Fgpref_btn_Click);
            // 
            // bgpref_btn
            // 
            this.bgpref_btn.Location = new System.Drawing.Point(6, 55);
            this.bgpref_btn.Name = "bgpref_btn";
            this.bgpref_btn.Size = new System.Drawing.Size(94, 28);
            this.bgpref_btn.TabIndex = 0;
            this.bgpref_btn.Text = "Background";
            this.bgpref_btn.UseVisualStyleBackColor = true;
            this.bgpref_btn.Click += new System.EventHandler(this.Bgpref_btn_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bitmap Offset:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bmpoff_UpDown
            // 
            this.bmpoff_UpDown.Location = new System.Drawing.Point(119, 119);
            this.bmpoff_UpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.bmpoff_UpDown.Name = "bmpoff_UpDown";
            this.bmpoff_UpDown.Size = new System.Drawing.Size(58, 22);
            this.bmpoff_UpDown.TabIndex = 7;
            this.bmpoff_UpDown.ValueChanged += new System.EventHandler(this.UpDown_ValueChanged);
            // 
            // paloff_UpDown
            // 
            this.paloff_UpDown.Location = new System.Drawing.Point(119, 147);
            this.paloff_UpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.paloff_UpDown.Name = "paloff_UpDown";
            this.paloff_UpDown.Size = new System.Drawing.Size(58, 22);
            this.paloff_UpDown.TabIndex = 8;
            this.paloff_UpDown.ValueChanged += new System.EventHandler(this.UpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(13, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Palette Offset:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // proceed_btn
            // 
            this.proceed_btn.Location = new System.Drawing.Point(315, 179);
            this.proceed_btn.Name = "proceed_btn";
            this.proceed_btn.Size = new System.Drawing.Size(75, 32);
            this.proceed_btn.TabIndex = 10;
            this.proceed_btn.Text = "Proceed";
            this.proceed_btn.UseVisualStyleBackColor = true;
            this.proceed_btn.Click += new System.EventHandler(this.Proceed_btn_Click);
            // 
            // res_label
            // 
            this.res_label.Location = new System.Drawing.Point(13, 184);
            this.res_label.Name = "res_label";
            this.res_label.Size = new System.Drawing.Size(296, 22);
            this.res_label.TabIndex = 11;
            this.res_label.Text = "NSC Dimensions:";
            this.res_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NSCPrompt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(404, 226);
            this.Controls.Add(this.res_label);
            this.Controls.Add(this.proceed_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.paloff_UpDown);
            this.Controls.Add(this.bmpoff_UpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tilewidth_UpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = global::NSMBe5.Properties.Resources.nsmbe;
            this.Name = "NSCPrompt";
            this.Text = "NSMBe 5.3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tilewidth_UpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bmpoff_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paloff_UpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown tilewidth_UpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button fgpref_btn;
        private System.Windows.Forms.Button bgpref_btn;
        private System.Windows.Forms.Button defaultpref_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown bmpoff_UpDown;
        private System.Windows.Forms.NumericUpDown paloff_UpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button proceed_btn;
        private System.Windows.Forms.Label res_label;
        private System.Windows.Forms.Button tilesetpref_btn;
    }
}