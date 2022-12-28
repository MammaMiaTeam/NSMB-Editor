namespace NSMBe5 {
    partial class ColourPicker {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColourPicker));
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.r_UpDown = new System.Windows.Forms.NumericUpDown();
            this.g_UpDown = new System.Windows.Forms.NumericUpDown();
            this.b_UpDown = new System.Windows.Forms.NumericUpDown();
            this.colourPickerControl1 = new NSMBe5.ColourPickerControl();
            ((System.ComponentModel.ISupportInitialize)(this.r_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_UpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(249, 120);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "<cancelButton>";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Location = new System.Drawing.Point(168, 120);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "<saveButton>";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // r_UpDown
            // 
            this.r_UpDown.Location = new System.Drawing.Point(274, 13);
            this.r_UpDown.Margin = new System.Windows.Forms.Padding(2);
            this.r_UpDown.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.r_UpDown.Name = "r_UpDown";
            this.r_UpDown.Size = new System.Drawing.Size(51, 22);
            this.r_UpDown.TabIndex = 4;
            this.r_UpDown.ValueChanged += new System.EventHandler(this.RBG_UpDown_ValueChanged);
            // 
            // g_UpDown
            // 
            this.g_UpDown.Location = new System.Drawing.Point(274, 41);
            this.g_UpDown.Margin = new System.Windows.Forms.Padding(2);
            this.g_UpDown.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.g_UpDown.Name = "g_UpDown";
            this.g_UpDown.Size = new System.Drawing.Size(51, 22);
            this.g_UpDown.TabIndex = 5;
            this.g_UpDown.ValueChanged += new System.EventHandler(this.RBG_UpDown_ValueChanged);
            // 
            // b_UpDown
            // 
            this.b_UpDown.Location = new System.Drawing.Point(274, 68);
            this.b_UpDown.Margin = new System.Windows.Forms.Padding(2);
            this.b_UpDown.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.b_UpDown.Name = "b_UpDown";
            this.b_UpDown.Size = new System.Drawing.Size(51, 22);
            this.b_UpDown.TabIndex = 6;
            this.b_UpDown.ValueChanged += new System.EventHandler(this.RBG_UpDown_ValueChanged);
            // 
            // colourPickerControl1
            // 
            this.colourPickerControl1.Location = new System.Drawing.Point(12, 12);
            this.colourPickerControl1.Margin = new System.Windows.Forms.Padding(4);
            this.colourPickerControl1.Name = "colourPickerControl1";
            this.colourPickerControl1.Size = new System.Drawing.Size(256, 102);
            this.colourPickerControl1.TabIndex = 1;
            this.colourPickerControl1.Value = 0;
            this.colourPickerControl1.ValueChanged += new System.EventHandler(this.ColourPickerControl_ValueChanged);
            // 
            // ColourPicker
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(339, 156);
            this.Controls.Add(this.b_UpDown);
            this.Controls.Add(this.g_UpDown);
            this.Controls.Add(this.r_UpDown);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.colourPickerControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColourPicker";
            this.Text = "<_TITLE>";
            ((System.ComponentModel.ISupportInitialize)(this.r_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_UpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ColourPickerControl colourPickerControl1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.NumericUpDown r_UpDown;
        private System.Windows.Forms.NumericUpDown g_UpDown;
        private System.Windows.Forms.NumericUpDown b_UpDown;
    }
}