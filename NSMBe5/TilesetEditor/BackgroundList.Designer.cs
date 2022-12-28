﻿namespace NSMBe5
{
    partial class BackgroundList
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.exportPNGButton = new System.Windows.Forms.Button();
            this.importPNGButton = new System.Windows.Forms.Button();
            this.exportTilesetBtn = new System.Windows.Forms.Button();
            this.importTilesetBtn = new System.Windows.Forms.Button();
            this.editTilesetBtn = new System.Windows.Forms.Button();
            this.setproperties_btn = new System.Windows.Forms.Button();
            this.tilesetListBox = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.exportPNGButton);
            this.flowLayoutPanel1.Controls.Add(this.importPNGButton);
            this.flowLayoutPanel1.Controls.Add(this.exportTilesetBtn);
            this.flowLayoutPanel1.Controls.Add(this.importTilesetBtn);
            this.flowLayoutPanel1.Controls.Add(this.editTilesetBtn);
            this.flowLayoutPanel1.Controls.Add(this.setproperties_btn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 272);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(508, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // exportPNGButton
            // 
            this.exportPNGButton.Location = new System.Drawing.Point(430, 3);
            this.exportPNGButton.Name = "exportPNGButton";
            this.exportPNGButton.Size = new System.Drawing.Size(75, 23);
            this.exportPNGButton.TabIndex = 4;
            this.exportPNGButton.Text = "<ExportPNG>";
            this.exportPNGButton.Click += new System.EventHandler(this.exportPNGButton_Click);
            // 
            // importPNGButton
            // 
            this.importPNGButton.Location = new System.Drawing.Point(349, 3);
            this.importPNGButton.Name = "importPNGButton";
            this.importPNGButton.Size = new System.Drawing.Size(75, 23);
            this.importPNGButton.TabIndex = 3;
            this.importPNGButton.Text = "<ImportPNG>";
            this.importPNGButton.UseVisualStyleBackColor = true;
            this.importPNGButton.Click += new System.EventHandler(this.importPNGButton_Click);
            // 
            // exportTilesetBtn
            // 
            this.exportTilesetBtn.Location = new System.Drawing.Point(268, 3);
            this.exportTilesetBtn.Name = "exportTilesetBtn";
            this.exportTilesetBtn.Size = new System.Drawing.Size(75, 23);
            this.exportTilesetBtn.TabIndex = 0;
            this.exportTilesetBtn.Text = "<Export>";
            this.exportTilesetBtn.UseVisualStyleBackColor = true;
            this.exportTilesetBtn.Click += new System.EventHandler(this.exportTilesetBtn_Click);
            // 
            // importTilesetBtn
            // 
            this.importTilesetBtn.Location = new System.Drawing.Point(187, 3);
            this.importTilesetBtn.Name = "importTilesetBtn";
            this.importTilesetBtn.Size = new System.Drawing.Size(75, 23);
            this.importTilesetBtn.TabIndex = 1;
            this.importTilesetBtn.Text = "<Import>";
            this.importTilesetBtn.UseVisualStyleBackColor = true;
            this.importTilesetBtn.Click += new System.EventHandler(this.importTilesetBtn_Click);
            // 
            // editTilesetBtn
            // 
            this.editTilesetBtn.Location = new System.Drawing.Point(106, 3);
            this.editTilesetBtn.Name = "editTilesetBtn";
            this.editTilesetBtn.Size = new System.Drawing.Size(75, 23);
            this.editTilesetBtn.TabIndex = 2;
            this.editTilesetBtn.Text = "<Edit>";
            this.editTilesetBtn.UseVisualStyleBackColor = true;
            this.editTilesetBtn.Click += new System.EventHandler(this.editTilesetBtn_Click);
            // 
            // setproperties_btn
            // 
            this.setproperties_btn.Location = new System.Drawing.Point(4, 3);
            this.setproperties_btn.Name = "setproperties_btn";
            this.setproperties_btn.Size = new System.Drawing.Size(96, 23);
            this.setproperties_btn.TabIndex = 5;
            this.setproperties_btn.Text = "Edit Properties";
            this.setproperties_btn.UseVisualStyleBackColor = true;
            this.setproperties_btn.Click += new System.EventHandler(this.Setproperties_btn_Click);
            // 
            // tilesetListBox
            // 
            this.tilesetListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tilesetListBox.FormattingEnabled = true;
            this.tilesetListBox.Location = new System.Drawing.Point(0, 0);
            this.tilesetListBox.Name = "tilesetListBox";
            this.tilesetListBox.Size = new System.Drawing.Size(508, 272);
            this.tilesetListBox.TabIndex = 1;
            this.tilesetListBox.DoubleClick += new System.EventHandler(this.tilesetListBox_DoubleClick);
            // 
            // BackgroundList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tilesetListBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BackgroundList";
            this.Size = new System.Drawing.Size(508, 301);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button exportTilesetBtn;
        private System.Windows.Forms.Button importTilesetBtn;
        private System.Windows.Forms.Button editTilesetBtn;
        private System.Windows.Forms.ListBox tilesetListBox;
        private System.Windows.Forms.Button exportPNGButton;
        private System.Windows.Forms.Button importPNGButton;
        private System.Windows.Forms.Button setproperties_btn;
    }
}
