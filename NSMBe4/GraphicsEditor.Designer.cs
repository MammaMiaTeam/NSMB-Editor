﻿namespace NSMBe4 {
    partial class GraphicsEditor {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.zoomIn = new System.Windows.Forms.Button();
            this.zoomActualSize = new System.Windows.Forms.Button();
            this.zoomOut = new System.Windows.Forms.Button();
            this.pickerTool = new System.Windows.Forms.Button();
            this.lineTool = new System.Windows.Forms.Button();
            this.brushTool = new System.Windows.Forms.Button();
            this.showGrid = new System.Windows.Forms.Button();
            this.fillTool = new System.Windows.Forms.Button();
            this.eraserTool = new System.Windows.Forms.Button();
            this.zoomLabel = new System.Windows.Forms.Label();
            this.hoverStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.drawingBox = new System.Windows.Forms.PictureBox();
            this.paletteChooser = new System.Windows.Forms.ComboBox();
            this.paletteChooserLabel = new System.Windows.Forms.Label();
            this.imageStatus = new System.Windows.Forms.Label();
            this.palettePicker1 = new NSMBe4.PalettePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingBox)).BeginInit();
            this.SuspendLayout();
            // 
            // zoomIn
            // 
            this.zoomIn.Image = global::NSMBe4.Properties.Resources.zoom;
            this.zoomIn.Location = new System.Drawing.Point(3, 3);
            this.zoomIn.Name = "zoomIn";
            this.zoomIn.Size = new System.Drawing.Size(24, 24);
            this.zoomIn.TabIndex = 0;
            this.zoomIn.UseVisualStyleBackColor = true;
            this.zoomIn.Click += new System.EventHandler(this.zoomIn_Click);
            // 
            // zoomActualSize
            // 
            this.zoomActualSize.Image = global::NSMBe4.Properties.Resources.zoomactual;
            this.zoomActualSize.Location = new System.Drawing.Point(33, 3);
            this.zoomActualSize.Name = "zoomActualSize";
            this.zoomActualSize.Size = new System.Drawing.Size(24, 24);
            this.zoomActualSize.TabIndex = 1;
            this.zoomActualSize.UseVisualStyleBackColor = true;
            this.zoomActualSize.Click += new System.EventHandler(this.zoomActualSize_Click);
            // 
            // zoomOut
            // 
            this.zoomOut.Image = global::NSMBe4.Properties.Resources.zoomout;
            this.zoomOut.Location = new System.Drawing.Point(63, 3);
            this.zoomOut.Name = "zoomOut";
            this.zoomOut.Size = new System.Drawing.Size(24, 24);
            this.zoomOut.TabIndex = 2;
            this.zoomOut.UseVisualStyleBackColor = true;
            this.zoomOut.Click += new System.EventHandler(this.zoomOut_Click);
            // 
            // pickerTool
            // 
            this.pickerTool.Image = global::NSMBe4.Properties.Resources.picker;
            this.pickerTool.Location = new System.Drawing.Point(199, 3);
            this.pickerTool.Name = "pickerTool";
            this.pickerTool.Size = new System.Drawing.Size(24, 24);
            this.pickerTool.TabIndex = 5;
            this.pickerTool.UseVisualStyleBackColor = true;
            this.pickerTool.Click += new System.EventHandler(this.toolButton_Click);
            // 
            // lineTool
            // 
            this.lineTool.Image = global::NSMBe4.Properties.Resources.line;
            this.lineTool.Location = new System.Drawing.Point(259, 3);
            this.lineTool.Name = "lineTool";
            this.lineTool.Size = new System.Drawing.Size(24, 24);
            this.lineTool.TabIndex = 4;
            this.lineTool.UseVisualStyleBackColor = true;
            this.lineTool.Click += new System.EventHandler(this.toolButton_Click);
            // 
            // brushTool
            // 
            this.brushTool.Image = global::NSMBe4.Properties.Resources.brush;
            this.brushTool.Location = new System.Drawing.Point(139, 3);
            this.brushTool.Name = "brushTool";
            this.brushTool.Size = new System.Drawing.Size(24, 24);
            this.brushTool.TabIndex = 3;
            this.brushTool.UseVisualStyleBackColor = true;
            this.brushTool.Click += new System.EventHandler(this.toolButton_Click);
            // 
            // showGrid
            // 
            this.showGrid.Image = global::NSMBe4.Properties.Resources.grid;
            this.showGrid.Location = new System.Drawing.Point(93, 3);
            this.showGrid.Name = "showGrid";
            this.showGrid.Size = new System.Drawing.Size(24, 24);
            this.showGrid.TabIndex = 8;
            this.showGrid.UseVisualStyleBackColor = true;
            this.showGrid.Click += new System.EventHandler(this.showGrid_Click);
            // 
            // fillTool
            // 
            this.fillTool.Image = global::NSMBe4.Properties.Resources.fill;
            this.fillTool.Location = new System.Drawing.Point(229, 3);
            this.fillTool.Name = "fillTool";
            this.fillTool.Size = new System.Drawing.Size(24, 24);
            this.fillTool.TabIndex = 7;
            this.fillTool.UseVisualStyleBackColor = true;
            this.fillTool.Click += new System.EventHandler(this.toolButton_Click);
            // 
            // eraserTool
            // 
            this.eraserTool.Image = global::NSMBe4.Properties.Resources.eraser;
            this.eraserTool.Location = new System.Drawing.Point(169, 3);
            this.eraserTool.Name = "eraserTool";
            this.eraserTool.Size = new System.Drawing.Size(24, 24);
            this.eraserTool.TabIndex = 6;
            this.eraserTool.UseVisualStyleBackColor = true;
            this.eraserTool.Click += new System.EventHandler(this.toolButton_Click);
            // 
            // zoomLabel
            // 
            this.zoomLabel.AutoSize = true;
            this.zoomLabel.Location = new System.Drawing.Point(0, 31);
            this.zoomLabel.Name = "zoomLabel";
            this.zoomLabel.Size = new System.Drawing.Size(70, 13);
            this.zoomLabel.TabIndex = 9;
            this.zoomLabel.Text = "<zoomLabel>";
            // 
            // hoverStatus
            // 
            this.hoverStatus.AutoSize = true;
            this.hoverStatus.Location = new System.Drawing.Point(136, 31);
            this.hoverStatus.Name = "hoverStatus";
            this.hoverStatus.Size = new System.Drawing.Size(76, 13);
            this.hoverStatus.TabIndex = 10;
            this.hoverStatus.Text = "<hoverStatus>";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.drawingBox);
            this.panel1.Location = new System.Drawing.Point(3, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 213);
            this.panel1.TabIndex = 11;
            // 
            // drawingBox
            // 
            this.drawingBox.BackColor = System.Drawing.SystemColors.Control;
            this.drawingBox.Location = new System.Drawing.Point(0, 0);
            this.drawingBox.Name = "drawingBox";
            this.drawingBox.Size = new System.Drawing.Size(100, 50);
            this.drawingBox.TabIndex = 0;
            this.drawingBox.TabStop = false;
            this.drawingBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingBox_MouseMove);
            this.drawingBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingBox_MouseDown);
            this.drawingBox.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingBox_Paint);
            // 
            // paletteChooser
            // 
            this.paletteChooser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.paletteChooser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paletteChooser.FormattingEnabled = true;
            this.paletteChooser.Location = new System.Drawing.Point(435, 3);
            this.paletteChooser.Name = "paletteChooser";
            this.paletteChooser.Size = new System.Drawing.Size(48, 21);
            this.paletteChooser.TabIndex = 13;
            this.paletteChooser.SelectedIndexChanged += new System.EventHandler(this.paletteChooser_SelectedIndexChanged);
            // 
            // paletteChooserLabel
            // 
            this.paletteChooserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.paletteChooserLabel.Location = new System.Drawing.Point(357, 6);
            this.paletteChooserLabel.Name = "paletteChooserLabel";
            this.paletteChooserLabel.Size = new System.Drawing.Size(72, 13);
            this.paletteChooserLabel.TabIndex = 14;
            this.paletteChooserLabel.Text = "<paletteChooserLabel>";
            this.paletteChooserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // imageStatus
            // 
            this.imageStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageStatus.Location = new System.Drawing.Point(289, 31);
            this.imageStatus.Name = "imageStatus";
            this.imageStatus.Size = new System.Drawing.Size(194, 13);
            this.imageStatus.TabIndex = 15;
            this.imageStatus.Text = "<imageStatus>";
            this.imageStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // palettePicker1
            // 
            this.palettePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.palettePicker1.Location = new System.Drawing.Point(289, 50);
            this.palettePicker1.Name = "palettePicker1";
            this.palettePicker1.Size = new System.Drawing.Size(194, 194);
            this.palettePicker1.TabIndex = 12;
            // 
            // GraphicsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imageStatus);
            this.Controls.Add(this.paletteChooserLabel);
            this.Controls.Add(this.paletteChooser);
            this.Controls.Add(this.palettePicker1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hoverStatus);
            this.Controls.Add(this.zoomLabel);
            this.Controls.Add(this.showGrid);
            this.Controls.Add(this.fillTool);
            this.Controls.Add(this.eraserTool);
            this.Controls.Add(this.pickerTool);
            this.Controls.Add(this.lineTool);
            this.Controls.Add(this.brushTool);
            this.Controls.Add(this.zoomOut);
            this.Controls.Add(this.zoomActualSize);
            this.Controls.Add(this.zoomIn);
            this.Name = "GraphicsEditor";
            this.Size = new System.Drawing.Size(486, 266);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drawingBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zoomIn;
        private System.Windows.Forms.Button zoomActualSize;
        private System.Windows.Forms.Button zoomOut;
        private System.Windows.Forms.Button pickerTool;
        private System.Windows.Forms.Button lineTool;
        private System.Windows.Forms.Button brushTool;
        private System.Windows.Forms.Button showGrid;
        private System.Windows.Forms.Button fillTool;
        private System.Windows.Forms.Button eraserTool;
        private System.Windows.Forms.Label zoomLabel;
        private System.Windows.Forms.Label hoverStatus;
        private System.Windows.Forms.Panel panel1;
        private PalettePicker palettePicker1;
        private System.Windows.Forms.ComboBox paletteChooser;
        private System.Windows.Forms.Label paletteChooserLabel;
        private System.Windows.Forms.PictureBox drawingBox;
        private System.Windows.Forms.Label imageStatus;
    }
}
