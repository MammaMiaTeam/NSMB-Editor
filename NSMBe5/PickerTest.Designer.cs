﻿namespace NSMBe5
{
    partial class PickerTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PickerTest));
            this.objectPickerControlNew1 = new NSMBe5.ObjectPickerControlNew();
            this.SuspendLayout();
            // 
            // objectPickerControlNew1
            // 
            this.objectPickerControlNew1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectPickerControlNew1.Location = new System.Drawing.Point(0, 0);
            this.objectPickerControlNew1.Name = "objectPickerControlNew1";
            this.objectPickerControlNew1.Size = new System.Drawing.Size(284, 261);
            this.objectPickerControlNew1.TabIndex = 0;
            // 
            // PickerTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.objectPickerControlNew1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PickerTest";
            this.Text = "PickerTest";
            this.ResumeLayout(false);

        }

        #endregion

        private ObjectPickerControlNew objectPickerControlNew1;
    }
}