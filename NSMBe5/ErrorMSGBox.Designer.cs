using System.Drawing;

namespace NSMBe5
{
    partial class ErrorMSGBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorMSGBox));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reload_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.continue_button = new System.Windows.Forms.Button();
            this.subtextLabel = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(9, 104);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(246, 89);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(9, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.reload_button);
            this.groupBox1.Controls.Add(this.exit_button);
            this.groupBox1.Controls.Add(this.continue_button);
            this.groupBox1.Location = new System.Drawing.Point(15, 197);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(238, 49);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // reload_button
            // 
            this.reload_button.Location = new System.Drawing.Point(160, 15);
            this.reload_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reload_button.Name = "reload_button";
            this.reload_button.Size = new System.Drawing.Size(72, 26);
            this.reload_button.TabIndex = 2;
            this.reload_button.Text = "Reload";
            this.reload_button.UseVisualStyleBackColor = true;
            this.reload_button.Click += new System.EventHandler(this.Reload_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(83, 15);
            this.exit_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(72, 26);
            this.exit_button.TabIndex = 1;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // continue_button
            // 
            this.continue_button.Location = new System.Drawing.Point(7, 15);
            this.continue_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.continue_button.Name = "continue_button";
            this.continue_button.Size = new System.Drawing.Size(72, 26);
            this.continue_button.TabIndex = 0;
            this.continue_button.Text = "Continue";
            this.continue_button.UseVisualStyleBackColor = true;
            this.continue_button.Click += new System.EventHandler(this.Continue_button_Click);
            // 
            // subtextLabel
            // 
            this.subtextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subtextLabel.AutoSize = true;
            this.subtextLabel.Location = new System.Drawing.Point(9, 81);
            this.subtextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subtextLabel.Name = "subtextLabel";
            this.subtextLabel.Size = new System.Drawing.Size(254, 13);
            this.subtextLabel.TabIndex = 3;
            this.subtextLabel.Text = "It is recommend that you reload the application.";
            // 
            // textLabel
            // 
            this.textLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textLabel.Location = new System.Drawing.Point(68, 11);
            this.textLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(186, 68);
            this.textLabel.TabIndex = 4;
            this.textLabel.Text = "An unhandled exception has occured!";
            // 
            // ErrorMSGBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 261);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.subtextLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = global::NSMBe5.Properties.Resources.nsmbe;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(274, 300);
            this.Name = "ErrorMSGBox";
            this.Text = "Error";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button continue_button;
        private System.Windows.Forms.Button reload_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label subtextLabel;
        private System.Windows.Forms.Label textLabel;
    }
}