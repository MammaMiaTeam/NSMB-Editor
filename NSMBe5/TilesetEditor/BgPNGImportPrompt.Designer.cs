namespace NSMBe5.TilemapEditor
{
    partial class BgPNGImportPrompt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BgPNGImportPrompt));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.proceed_btn = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.fgBmpSize_label = new System.Windows.Forms.Label();
            this.bgBmpSize_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(83, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 75);
            this.label1.TabIndex = 13;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // proceed_btn
            // 
            this.proceed_btn.Location = new System.Drawing.Point(385, 137);
            this.proceed_btn.Name = "proceed_btn";
            this.proceed_btn.Size = new System.Drawing.Size(75, 32);
            this.proceed_btn.TabIndex = 21;
            this.proceed_btn.Text = "Proceed";
            this.proceed_btn.UseVisualStyleBackColor = true;
            this.proceed_btn.Click += new System.EventHandler(this.Proceed_btn_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(99, 115);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            320,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            160,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(64, 22);
            this.numericUpDown1.TabIndex = 22;
            this.numericUpDown1.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tile Count:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fgBmpSize_label
            // 
            this.fgBmpSize_label.AutoSize = true;
            this.fgBmpSize_label.Location = new System.Drawing.Point(169, 118);
            this.fgBmpSize_label.Name = "fgBmpSize_label";
            this.fgBmpSize_label.Size = new System.Drawing.Size(90, 13);
            this.fgBmpSize_label.TabIndex = 24;
            this.fgBmpSize_label.Text = "fgBmpSize_label";
            // 
            // bgBmpSize_label
            // 
            this.bgBmpSize_label.AutoSize = true;
            this.bgBmpSize_label.Location = new System.Drawing.Point(169, 145);
            this.bgBmpSize_label.Name = "bgBmpSize_label";
            this.bgBmpSize_label.Size = new System.Drawing.Size(93, 13);
            this.bgBmpSize_label.TabIndex = 25;
            this.bgBmpSize_label.Text = "bgBmpSize_label";
            // 
            // BgPNGImportPrompt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(474, 181);
            this.Controls.Add(this.bgBmpSize_label);
            this.Controls.Add(this.fgBmpSize_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.proceed_btn);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = global::NSMBe5.Properties.Resources.nsmbe;
            this.Name = "BgPNGImportPrompt";
            this.Text = "NSMBe 5.3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button proceed_btn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fgBmpSize_label;
        private System.Windows.Forms.Label bgBmpSize_label;
    }
}