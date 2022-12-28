// Decompiled with JetBrains decompiler
// Type: NSMBe4.ExtDataSearch
// Assembly: NSMBe5, Version=5.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 375C0264-8422-4B10-96C9-D574BA1AC306
// Assembly location: C:\Users\tiago\Desktop\nsmbeBent\NSMBe5.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NSMBe5
{
  public class ExtraDataSearch : Form
  {
    public int selItem = -1;
    private Dictionary<string, int> dict;
    private IContainer components;
    private ListBox list;
    private TextBox searchBox;

    public ExtraDataSearch(Dictionary<string, int> dict, string caption = "")
    {
      this.dict = dict;
      this.InitializeComponent();
      if (caption != "")
        this.Text = this.Text + ": " + caption;
      this.CenterToParent();
      this.search("");
    }

    private void searchBox_TextChanged(object sender, EventArgs e)
    {
      this.search(this.searchBox.Text);
    }

    private void search(string s)
    {
      this.list.Items.Clear();
      this.list.SelectedIndex = -1;
      string[] array = new string[this.dict.Count];
      this.dict.Keys.CopyTo(array, 0);
      for (int index = 0; index < array.Length; ++index)
      {
        if (array[index].ToLower().Contains(s.ToLower()))
          this.list.Items.Add((object) array[index]);
      }
    }

    private void list_DoubleClick(object sender, MouseEventArgs e)
    {
      int index = this.list.IndexFromPoint(e.Location);
      if (index == -1)
        return;
      this.selItem = this.dict[this.list.Items[index].ToString()];
      this.DialogResult = DialogResult.OK;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtraDataSearch));
            this.list = new System.Windows.Forms.ListBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(12, 12);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(260, 303);
            this.list.TabIndex = 1;
            this.list.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_DoubleClick);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(12, 325);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(260, 22);
            this.searchBox.TabIndex = 2;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // ExtraDataSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.list);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExtraDataSearch";
            this.Text = "Extra Data - Search";
            this.ResumeLayout(false);
            this.PerformLayout();

    }
  }
}
