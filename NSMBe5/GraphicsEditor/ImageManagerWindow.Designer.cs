namespace NSMBe5
{
    partial class ImageManagerWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageManagerWindow));
            this.m = new NSMBe5.ImageManager();
            this.SuspendLayout();
            // 
            // m
            // 
            this.m.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m.Location = new System.Drawing.Point(0, 0);
            this.m.Margin = new System.Windows.Forms.Padding(5);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(1179, 596);
            this.m.TabIndex = 0;
            // 
            // ImageManagerWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1179, 596);
            this.Controls.Add(this.m);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ImageManagerWindow";
            this.Text = "2D Texture Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImageManagerWindow_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        public ImageManager m;

    }
}