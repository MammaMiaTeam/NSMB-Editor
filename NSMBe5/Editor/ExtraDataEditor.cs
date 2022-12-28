// Decompiled with JetBrains decompiler
// Type: NSMBe4.ExtDataEditor
// Assembly: NSMBe5, Version=5.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 375C0264-8422-4B10-96C9-D574BA1AC306
// Assembly location: C:\Users\tiago\Desktop\nsmbeBent\NSMBe5.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NSMBe5
{
  public class ExtraDataEditor : Form
  {
    private Dictionary<string, int> classIDs = new Dictionary<string, int>();
    private Dictionary<string, int> particleIDs = new Dictionary<string, int>();
    private Dictionary<string, int> sfxIDs = new Dictionary<string, int>();
    private List<NSMBExtraData> dataList;
    private NSMBExtraData current;
    private bool acceptChanges;
    private const bool isNewerDS = true;
    private IContainer components;
    private Button add;
    private Button delete;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private NumericUpDown sfxID;
    private NumericUpDown ID;
    private NumericUpDown offsetX;
    private NumericUpDown offsetY;
    private NumericUpDown particleID;
    private ListBox list;
    private ComboBox classIDName;
    private Label label1;
    private Label label2;
    private ComboBox particleIDName;
    private ComboBox sfxIDName;
    private Label label8;
    private Label label12;
    private Label label11;
    private Label label10;
    private NumericUpDown pOffsetY;
    private NumericUpDown pOffsetX;
    private Label label13;
    private TabControl tabControl;
    private TabPage assTab;
    private TabPage rotctrlerTab;
    private TextBox spriteDataTextBox;
    private Button classSearch;
    private Button sfxSearch;
    private Button particleSearch;
    private NumericUpDown amount;
    private Label label9;
    private Label label14;
    private NumericUpDown zPos;
    private CheckBox noSwayAcceleration;
    private ComboBox modelZRot;
    private ComboBox modelYRot;
    private ComboBox modelXRot;
    private Label label18;
    private Label label17;
    private Label label16;
    private Label label15;
    private NumericUpDown drawDistance;
    private CheckBox gapFlag;
    private NumericUpDown tileShiftX;
    private Label label20;
    private Label label19;
    private NumericUpDown tileShiftY;
    private CheckBox shiftHalfTileY;
    private CheckBox shiftHalfTileX;
    private NumericUpDown speedMultiplier;
    private Label label21;
    private CheckBox unitInHalfTiles;
    private CheckBox spritesNotMoved;
    private Label label22;
    private NumericUpDown rotationStart;

    public ExtraDataEditor(LevelEditorControl ed)
    {
      this.dataList = ed.Level.ExtraData;
      this.InitializeComponent();
      this.CenterToParent();
    }

    private void ExtDataEditor_Load(object sender, EventArgs e)
    {
      if (!this.loadClassIDs())
        this.Close();
      else if (!this.loadParticleIDs())
        this.Close();
      else if (!this.loadSfxIDs())
        this.Close();
      else
        this.updateList();
    }

    private bool loadClassIDs()
    {
      try
      {
        string[] strArray = File.ReadAllLines(Application.StartupPath + "\\classIDs.txt");
        if (strArray.Length != 326)
        {
          int num = (int) MessageBox.Show("Error: Wrong ClassID count.", "NSMBe Extra Data", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          return false;
        }
        this.classIDs.Clear();
        this.classIDName.Items.Clear();
        for (int index = 0; index < 326; ++index)
        {
          this.classIDs.Add(index.ToString() + ": " + strArray[index], index);
          this.classIDName.Items.Add((object) (index.ToString() + ": " + strArray[index]));
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error: " + ex.Message, "NSMBe Extra Data", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        return false;
      }
      return true;
    }

    private bool loadParticleIDs()
    {
      try
      {
        string[] strArray1 = File.ReadAllLines(Application.StartupPath + "\\particleIDs.txt");
        this.particleIDs.Clear();
        this.particleIDName.Items.Clear();
        for (int index = 0; index < strArray1.Length; ++index)
        {
          string[] strArray2 = strArray1[index].Split(':');
          int result;
          if (strArray2.Length >= 2 && int.TryParse(strArray2[0], out result))
          {
            this.particleIDs.Add(strArray1[index], result);
            this.particleIDName.Items.Add((object) strArray1[index]);
          }
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error: " + ex.Message, "NSMBe Extra Data", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        return false;
      }
      return true;
    }

    private bool loadSfxIDs()
    {
      try
      {
        string[] strArray1 = File.ReadAllLines(Application.StartupPath + "\\sfxIDs.txt");
        this.sfxIDs.Clear();
        this.sfxIDName.Items.Clear();
        for (int index = 0; index < strArray1.Length; ++index)
        {
          string[] strArray2 = strArray1[index].Split(':');
          int result;
          if (strArray2.Length >= 2 && int.TryParse(strArray2[0], out result))
          {
            this.sfxIDs.Add(strArray1[index], result);
            this.sfxIDName.Items.Add((object) strArray1[index]);
          }
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error: " + ex.Message, "NSMBe Extra Data", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        return false;
      }
      return true;
    }

    private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.list.SelectedIndex == -1)
        return;
      this.updateValues();
    }

    private void updateList()
    {
      this.acceptChanges = false;
      this.current = null;
      this.setEditsEnabled(false);
      this.clearValues();
      this.list.Items.Clear();
      for (int index = 0; index < this.dataList.Count; ++index)
        this.list.Items.Add("ID: " + index);
      this.acceptChanges = true;
    }

    private void updateValues()
    {
      this.acceptChanges = false;
      this.ID.Value = (Decimal) this.current.getClassID();
      this.classIDName.SelectedIndex = (int) this.current.getClassID();
      this.spriteDataTextBox.Text = this.current.getSpriteData()[0].ToString("X2") + " " + this.current.getSpriteData()[1].ToString("X2") + " " + this.current.getSpriteData()[2].ToString("X2") + " " + this.current.getSpriteData()[3].ToString("X2") + " " + this.current.getSpriteData()[4].ToString("X2") + " " + this.current.getSpriteData()[5].ToString("X2");
      this.drawDistance.Value = (Decimal) this.current.getDrawDistance();
      this.offsetX.Value = (Decimal) this.current.getOffsetX();
      this.offsetY.Value = (Decimal) this.current.getOffsetY();
      this.particleID.Value = (Decimal) this.current.getParticleID();
      this.particleIDName.SelectedIndex = (int) this.current.getParticleID();
      if ((int) this.current.getParticleID() > this.particleIDName.Items.Count - 1)
        this.particleIDName.SelectedIndex = -1;
      else
        this.particleIDName.SelectedIndex = (int) this.current.getParticleID();
      this.pOffsetX.Value = (Decimal) this.current.getParticleOffsetX();
      this.pOffsetY.Value = (Decimal) this.current.getParticleOffsetY();
      this.sfxID.Value = (Decimal) this.current.getSfxID();
      if ((int) this.current.getSfxID() > this.sfxIDName.Items.Count - 1)
        this.sfxIDName.SelectedIndex = -1;
      else
        this.sfxIDName.SelectedIndex = (int) this.current.getSfxID();
      this.amount.Value = (Decimal) this.current.getAmount();
      this.zPos.Value = (Decimal) this.current.getZPos();
      this.gapFlag.Checked = this.current.getGapFlag();
      this.noSwayAcceleration.Checked = this.current.getNoSwayAcceleration();
      this.modelXRot.SelectedIndex = this.current.getModelRotation(0);
      this.modelYRot.SelectedIndex = this.current.getModelRotation(1);
      this.modelZRot.SelectedIndex = this.current.getModelRotation(2);
      this.speedMultiplier.Value = (Decimal) ((int) this.current.getSpeedMultiplier() + 1);
      this.tileShiftX.Value = (Decimal) this.current.getTileShiftX();
      this.tileShiftY.Value = (Decimal) this.current.getTileShiftY();
      this.shiftHalfTileX.Checked = this.current.getHalfTileShiftX();
      this.shiftHalfTileY.Checked = this.current.getHalfTileShiftY();
      this.unitInHalfTiles.Checked = this.current.getUnintIsHalfTiles();
      this.spritesNotMoved.Checked = this.current.getSpritesNotMoved();
      this.shiftHalfTileX.Checked = this.current.getHalfTileShiftX();
      this.shiftHalfTileY.Checked = this.current.getHalfTileShiftY();
      this.rotationStart.Value = (Decimal) this.current.getRotationStart();
      this.acceptChanges = true;
    }

    private void setEditsEnabled(bool enabled)
    {
      this.ID.Enabled = enabled;
      this.classIDName.Enabled = enabled;
      this.spriteDataTextBox.Enabled = enabled;
      this.drawDistance.Enabled = enabled;
      this.particleID.Enabled = enabled;
      this.particleIDName.Enabled = enabled;
      this.sfxID.Enabled = enabled;
      this.sfxIDName.Enabled = enabled;
      this.offsetX.Enabled = enabled;
      this.offsetY.Enabled = enabled;
      this.pOffsetX.Enabled = enabled;
      this.pOffsetY.Enabled = enabled;
      this.classSearch.Enabled = enabled;
      this.particleSearch.Enabled = enabled;
      this.sfxSearch.Enabled = enabled;
      this.amount.Enabled = enabled;
      this.zPos.Enabled = enabled;
      this.gapFlag.Enabled = enabled;
      this.noSwayAcceleration.Enabled = enabled;
      this.modelXRot.Enabled = enabled;
      this.modelYRot.Enabled = enabled;
      this.modelZRot.Enabled = enabled;
      this.speedMultiplier.Enabled = enabled;
      this.tileShiftX.Enabled = enabled;
      this.tileShiftY.Enabled = enabled;
      this.unitInHalfTiles.Enabled = enabled;
      this.spritesNotMoved.Enabled = enabled;
      this.shiftHalfTileX.Enabled = enabled;
      this.shiftHalfTileY.Enabled = enabled;
      this.rotationStart.Enabled = enabled;
    }

    private void clearValues()
    {
      bool acceptChanges = this.acceptChanges;
      this.acceptChanges = false;
      this.ID.Value = Decimal.Zero;
      this.classIDName.SelectedIndex = 0;
      this.spriteDataTextBox.Text = "00 00 00 00 00 00";
      this.drawDistance.Value = Decimal.Zero;
      this.particleID.Value = Decimal.Zero;
      this.particleIDName.SelectedIndex = 0;
      this.sfxID.Value = Decimal.Zero;
      this.sfxIDName.SelectedIndex = 0;
      this.offsetX.Value = Decimal.Zero;
      this.offsetY.Value = Decimal.Zero;
      this.pOffsetX.Value = Decimal.Zero;
      this.pOffsetY.Value = Decimal.Zero;
      this.amount.Value = Decimal.Zero;
      this.zPos.Value = Decimal.Zero;
      this.gapFlag.Checked = false;
      this.noSwayAcceleration.Checked = false;
      this.modelXRot.SelectedIndex = 0;
      this.modelYRot.SelectedIndex = 0;
      this.modelZRot.SelectedIndex = 0;
      this.speedMultiplier.Value = Decimal.One;
      this.tileShiftX.Value = Decimal.Zero;
      this.tileShiftY.Value = Decimal.Zero;
      this.unitInHalfTiles.Checked = false;
      this.spritesNotMoved.Checked = false;
      this.shiftHalfTileX.Checked = false;
      this.shiftHalfTileY.Checked = false;
      this.rotationStart.Value = Decimal.Zero;
      this.acceptChanges = acceptChanges;
    }

    private void list_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.list.SelectedIndex == -1)
        return;
      this.setEditsEnabled(true);
      this.current = this.dataList[this.list.SelectedIndex];
      this.updateValues();
    }

    private void add_Click(object sender, EventArgs e)
    {
      this.dataList.Add(new NSMBExtraData());
      this.updateList();
    }

    private void delete_Click(object sender, EventArgs e)
    {
      if (this.list.SelectedIndex == -1)
        return;
      this.dataList.RemoveAt(this.list.SelectedIndex);
      this.updateList();
    }

    private void spriteDataTextBox_TextChanged(object sender, EventArgs e)
    {
      if (!this.acceptChanges)
        return;
      this.acceptChanges = false;
      if (Regex.IsMatch(this.spriteDataTextBox.Text, "^[0-9a-f] *[0-9a-f] *[0-9a-f] *[0-9a-f] *[0-9a-f] *[0-9a-f] *[0-9a-f] *[0-9a-f] *[0-9a-f] *[0-9a-f] *[0-9a-f] *[0-9a-f] *$", RegexOptions.IgnoreCase))
      {
        string str = this.spriteDataTextBox.Text.Replace(" ", "");
        byte[] spriteData = new byte[6];
        for (int index = 0; index < 6; ++index)
          spriteData[index] = byte.Parse(str.Substring(index * 2, 2), NumberStyles.AllowHexSpecifier);
        this.spriteDataTextBox.BackColor = SystemColors.Window;
        int selectionStart = this.spriteDataTextBox.SelectionStart;
        string upper = str.ToUpper();
        this.spriteDataTextBox.Text = upper.Substring(0, 2) + " " + upper.Substring(2, 2) + " " + upper.Substring(4, 2) + " " + upper.Substring(6, 2) + " " + upper.Substring(8, 2) + " " + upper.Substring(10, 2);
        this.spriteDataTextBox.SelectionStart = selectionStart;
        this.current.setSpriteData(spriteData);
      }
      else
        this.spriteDataTextBox.BackColor = Color.Coral;
      this.acceptChanges = true;
    }

    private void offsetX_ValueChanged(object sender, EventArgs e)
    {
      if (!this.acceptChanges)
        return;
      this.current.setOffsetX((sbyte) this.offsetX.Value);
    }

    private void offsetY_ValueChanged(object sender, EventArgs e)
    {
      if (!this.acceptChanges)
        return;
      this.current.setOffsetY((sbyte) this.offsetY.Value);
    }

    private void particleID_ValueChanged(object sender, EventArgs e)
    {
      if (!this.acceptChanges)
        return;
      this.acceptChanges = false;
      if (!this.particleIDs.ContainsValue((int) this.particleID.Value))
      {
        this.particleIDName.SelectedIndex = -1;
      }
      else
      {
        string[] array = new string[this.particleIDs.Count];
        this.particleIDs.Keys.CopyTo(array, 0);
        for (int index = 0; index < array.Length; ++index)
        {
          if (array[index].StartsWith(this.particleID.Value.ToString() + ": "))
          {
            this.particleIDName.SelectedIndex = index;
            break;
          }
        }
      }
      this.acceptChanges = true;
      this.current.setParticleID((ushort) this.particleID.Value);
    }

    private void particleIDName_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!this.acceptChanges)
        return;
      this.acceptChanges = false;
      this.particleID.Value = (Decimal) this.particleIDs[this.particleIDName.Text];
      this.acceptChanges = true;
      this.current.setParticleID((ushort) this.particleIDName.SelectedIndex);
    }

    private void sfxID_ValueChanged(object sender, EventArgs e)
    {
      if (!this.acceptChanges)
        return;
      this.acceptChanges = false;
      if (!this.sfxIDs.ContainsValue((int) this.sfxID.Value))
      {
        this.sfxIDName.SelectedIndex = -1;
      }
      else
      {
        string[] array = new string[this.sfxIDs.Count];
        this.sfxIDs.Keys.CopyTo(array, 0);
        for (int index = 0; index < array.Length; ++index)
        {
          if (array[index].StartsWith(this.sfxID.Value.ToString() + ": "))
          {
            this.sfxIDName.SelectedIndex = index;
            break;
          }
        }
      }
      this.acceptChanges = true;
      this.current.setSfxID((ushort) this.sfxID.Value);
    }

    private void sfxIDName_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!this.acceptChanges)
        return;
      this.acceptChanges = false;
      this.sfxID.Value = (Decimal) this.sfxIDs[this.sfxIDName.Text];
      this.acceptChanges = true;
      this.current.setSfxID((ushort) this.sfxIDName.SelectedIndex);
    }

    private void ID_ValueChanged(object sender, EventArgs e)
    {
      if (!this.acceptChanges)
        return;
      this.acceptChanges = false;
      this.classIDName.SelectedIndex = (int) this.ID.Value;
      this.acceptChanges = true;
      this.current.setClassID((ushort) this.ID.Value);
    }

    private void classIDName_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!this.acceptChanges)
        return;
      this.acceptChanges = false;
      this.ID.Value = (Decimal) this.classIDName.SelectedIndex;
      this.acceptChanges = true;
      this.current.setClassID((ushort) this.classIDName.SelectedIndex);
    }

    private void pOffsetX_ValueChanged(object sender, EventArgs e)
    {
      if (!this.acceptChanges)
        return;
      this.current.setParticleOffsetX((sbyte) this.pOffsetX.Value);
    }

    private void pOffsetY_ValueChanged(object sender, EventArgs e)
    {
      if (!this.acceptChanges)
        return;
      this.current.setParticleOffsetY((sbyte) this.pOffsetY.Value);
    }

    private void classSearch_Click(object sender, EventArgs e)
    {
      ExtraDataSearch extDataSearch = new ExtraDataSearch(this.classIDs, "Class IDs");
      int num = (int) extDataSearch.ShowDialog();
      if (extDataSearch.DialogResult != DialogResult.OK || extDataSearch.selItem == -1)
        return;
      this.ID.Value = (Decimal) extDataSearch.selItem;
    }

    private void particleSearch_Click(object sender, EventArgs e)
    {
      ExtraDataSearch extDataSearch = new ExtraDataSearch(this.particleIDs, "Particle IDs");
      int num = (int) extDataSearch.ShowDialog();
      if (extDataSearch.DialogResult != DialogResult.OK || extDataSearch.selItem == -1)
        return;
      this.particleID.Value = (Decimal) extDataSearch.selItem;
    }

    private void sfxSearch_Click(object sender, EventArgs e)
    {
      ExtraDataSearch extDataSearch = new ExtraDataSearch(this.sfxIDs, "SFX IDs");
      int num = (int) extDataSearch.ShowDialog();
      if (extDataSearch.DialogResult != DialogResult.OK || extDataSearch.selItem == -1)
        return;
      this.sfxID.Value = (Decimal) extDataSearch.selItem;
    }

    private void amount_ValueChanged(object sender, EventArgs e)
    {
      if (!this.acceptChanges)
        return;
      this.current.setAmount((byte) this.amount.Value);
    }

    private void zPos_ValueChanged(object sender, EventArgs e)
    {
      if (!this.acceptChanges)
        return;
      this.current.setZPos((byte) this.zPos.Value);
    }

    private void gapFlag_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.acceptChanges)
        return;
      this.current.setGapFlag(this.gapFlag.Checked);
    }

    private void noSwayAcceleration_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.acceptChanges)
        return;
      this.current.setNoSwayAcceleration(this.noSwayAcceleration.Checked);
    }

    private void modelXRot_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!this.acceptChanges)
        return;
      this.current.setModelRotation(this.modelXRot.SelectedIndex, 0);
    }

    private void modelYRot_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!this.acceptChanges)
        return;
      this.current.setModelRotation(this.modelYRot.SelectedIndex, 1);
    }

    private void modelZRot_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!this.acceptChanges)
        return;
      this.current.setModelRotation(this.modelZRot.SelectedIndex, 2);
    }

    private void drawDistance_ValueChanged(object sender, EventArgs e)
    {
      if (!this.acceptChanges)
        return;
      this.current.setDrawDistance((byte) this.drawDistance.Value);
    }

    private void speedMultiplier_ValueChanged(object sender, EventArgs e)
    {
      if (!this.acceptChanges)
        return;
      this.current.setSpeedMultiplier((byte) (this.speedMultiplier.Value - Decimal.One));
    }

    private void tileShiftX_ValueChanged(object sender, EventArgs e)
    {
      if (!this.acceptChanges)
        return;
      this.current.setTileShiftX((byte) this.tileShiftX.Value);
    }

    private void tileShiftY_ValueChanged(object sender, EventArgs e)
    {
      if (!this.acceptChanges)
        return;
      this.current.setTileShiftY((byte) this.tileShiftY.Value);
    }

    private void unitInHalfTiles_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.acceptChanges)
        return;
      this.current.setUnintIsHalfTiles(this.unitInHalfTiles.Checked);
    }

    private void spritesNotMoved_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.acceptChanges)
        return;
      this.current.setSpritesNotMoved(this.spritesNotMoved.Checked);
    }

    private void shiftHalfTileX_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.acceptChanges)
        return;
      this.current.setHalfTileShiftX(this.shiftHalfTileX.Checked);
    }

    private void shiftHalfTileY_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.acceptChanges)
        return;
      this.current.setHalfTileShiftY(this.shiftHalfTileY.Checked);
    }

    private void rotationStart_ValueChanged(object sender, EventArgs e)
    {
      if (!this.acceptChanges)
        return;
      this.current.setRotationStart((byte) this.rotationStart.Value);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtraDataEditor));
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sfxID = new System.Windows.Forms.NumericUpDown();
            this.ID = new System.Windows.Forms.NumericUpDown();
            this.offsetX = new System.Windows.Forms.NumericUpDown();
            this.offsetY = new System.Windows.Forms.NumericUpDown();
            this.particleID = new System.Windows.Forms.NumericUpDown();
            this.list = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sfxIDName = new System.Windows.Forms.ComboBox();
            this.particleIDName = new System.Windows.Forms.ComboBox();
            this.classIDName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pOffsetY = new System.Windows.Forms.NumericUpDown();
            this.pOffsetX = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.assTab = new System.Windows.Forms.TabPage();
            this.sfxSearch = new System.Windows.Forms.Button();
            this.particleSearch = new System.Windows.Forms.Button();
            this.rotctrlerTab = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.rotationStart = new System.Windows.Forms.NumericUpDown();
            this.spritesNotMoved = new System.Windows.Forms.CheckBox();
            this.unitInHalfTiles = new System.Windows.Forms.CheckBox();
            this.shiftHalfTileY = new System.Windows.Forms.CheckBox();
            this.shiftHalfTileX = new System.Windows.Forms.CheckBox();
            this.modelZRot = new System.Windows.Forms.ComboBox();
            this.modelYRot = new System.Windows.Forms.ComboBox();
            this.modelXRot = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.gapFlag = new System.Windows.Forms.CheckBox();
            this.noSwayAcceleration = new System.Windows.Forms.CheckBox();
            this.speedMultiplier = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.tileShiftX = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tileShiftY = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.zPos = new System.Windows.Forms.NumericUpDown();
            this.spriteDataTextBox = new System.Windows.Forms.TextBox();
            this.classSearch = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.drawDistance = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.sfxID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.particleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOffsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOffsetX)).BeginInit();
            this.tabControl.SuspendLayout();
            this.assTab.SuspendLayout();
            this.rotctrlerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotationStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileShiftX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileShiftY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(12, 360);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 1;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(90, 360);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 2;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sprite Data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Offset X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Offset Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Particle ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "SFX ID:";
            // 
            // sfxID
            // 
            this.sfxID.Location = new System.Drawing.Point(98, 34);
            this.sfxID.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.sfxID.Name = "sfxID";
            this.sfxID.Size = new System.Drawing.Size(95, 22);
            this.sfxID.TabIndex = 9;
            this.sfxID.ValueChanged += new System.EventHandler(this.sfxID_ValueChanged);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(273, 39);
            this.ID.Maximum = new decimal(new int[] {
            325,
            0,
            0,
            0});
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(95, 22);
            this.ID.TabIndex = 4;
            this.ID.ValueChanged += new System.EventHandler(this.ID_ValueChanged);
            // 
            // offsetX
            // 
            this.offsetX.Location = new System.Drawing.Point(98, 60);
            this.offsetX.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.offsetX.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.offsetX.Name = "offsetX";
            this.offsetX.Size = new System.Drawing.Size(95, 22);
            this.offsetX.TabIndex = 6;
            this.offsetX.ValueChanged += new System.EventHandler(this.offsetX_ValueChanged);
            // 
            // offsetY
            // 
            this.offsetY.Location = new System.Drawing.Point(288, 60);
            this.offsetY.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.offsetY.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.offsetY.Name = "offsetY";
            this.offsetY.Size = new System.Drawing.Size(95, 22);
            this.offsetY.TabIndex = 7;
            this.offsetY.ValueChanged += new System.EventHandler(this.offsetY_ValueChanged);
            // 
            // particleID
            // 
            this.particleID.Location = new System.Drawing.Point(98, 7);
            this.particleID.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.particleID.Name = "particleID";
            this.particleID.Size = new System.Drawing.Size(95, 22);
            this.particleID.TabIndex = 8;
            this.particleID.ValueChanged += new System.EventHandler(this.particleID_ValueChanged);
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(12, 12);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(153, 342);
            this.list.TabIndex = 0;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(389, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "(in pixels)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "(in pixels)";
            // 
            // sfxIDName
            // 
            this.sfxIDName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sfxIDName.FormattingEnabled = true;
            this.sfxIDName.Location = new System.Drawing.Point(199, 33);
            this.sfxIDName.Name = "sfxIDName";
            this.sfxIDName.Size = new System.Drawing.Size(281, 21);
            this.sfxIDName.TabIndex = 27;
            this.sfxIDName.SelectedIndexChanged += new System.EventHandler(this.sfxIDName_SelectedIndexChanged);
            // 
            // particleIDName
            // 
            this.particleIDName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.particleIDName.FormattingEnabled = true;
            this.particleIDName.Items.AddRange(new object[] {
            "An explosion of rainbow stars",
            "Giant gray bits",
            "Gray bits",
            "Small gray bits",
            "Tiny gray bits",
            "Big gray bits",
            "Small gray bits",
            "Tiny gray bits",
            "Miniscule gray bits",
            "ground explosion",
            "puff of faint white smoke",
            "Tiny gray bits flying both sides",
            "Air being inhaled in from the right",
            "Air slowly inhaled from the left",
            "Air inhaled from the left",
            "Air inhaled from the left",
            "Puff of faint smoke going right",
            "Puff of faint smoke going left",
            "Puff of smoke going right",
            "Star explosion",
            "Circular puff of white",
            "Circular purple firework",
            "Red puff of smoke",
            "Many small red puffs of smoke",
            "Tiny puff of red smoke going out",
            "Small red firework",
            "Big poison water splash",
            "Small poison water splash",
            "Red ground explosion",
            "Two puffs of white smoke going side to side",
            "Big red ground explosion",
            "Big two puffs of faint white smoke going side to side",
            "Gray bits",
            "Tiny rainbow star explosion",
            "Tiny red circle ascending",
            "Rainbow star explosion",
            "Red circle ascending",
            "Big rainbow star explosion",
            "Big red circle ascending",
            "Giant rainbow star explosion",
            "Delayed big red circle ascending",
            "Giant rainbow star explosion",
            "Giant circle ascending",
            "Delayed giant rainbow star explosion",
            "Delayed giant red circle ascending",
            "Puff of white smoke",
            "Two puffs of white smoke going side to side",
            "Two stars going upward diagonally",
            "Two stars going upward ",
            "Purple splash",
            "Smoke",
            "Smoke",
            "Puff of smoke ",
            "Tiny smoke",
            "Tiny smoke",
            "Tiny smoke",
            "Tiny white smoke",
            "Puff of white smoke",
            "Puff of smoke",
            "Puff of smoke",
            "Puff of smoke",
            "Faint circular puff",
            "Blue firework",
            "Green-and-blue firework",
            "Big faint circular puff",
            "Yellow firework",
            "Tiny circular white puff",
            "Red firework",
            "Green firework",
            "Big circular faint puff",
            "Yellow firework",
            "Tiny circular white puff",
            "Purple firework",
            "Red firework",
            "Quick big circular faint puff",
            "Yellow firework",
            "Bits of pumpkin",
            "Yellow bits",
            "Faint explosion (pumpkin juice?)",
            "Orange bits",
            "Nothing",
            "Puff of smoke",
            "Glittery star",
            "Circular red thing",
            "Rainbow stars non-stop",
            "Three green stars explosion",
            "Two green stars explosion",
            "Blue circular explosion",
            "Water splash    ",
            "Water splash to left",
            "Water splash",
            "Water splash to right",
            "Tiny orange stars going upward",
            "Solid white puff",
            "Big water splash to the right",
            "Big water splash to the left",
            "White water splash",
            "White water splash",
            "Electricity",
            "Sparks",
            "Sparks (different)",
            "Glowing spot",
            "Bigger electricity",
            "Bigger sparks",
            "Bigger different sparks",
            "Big glowing spot",
            "Tiny red bits",
            "Big puff of white smoke",
            "Yellow/blue explosion",
            "Rainbow firework",
            "Puff of smoke",
            "Tiny red bits ",
            "Yellow star explosion then black smoke",
            "A pixel going down diagonally",
            "Black puff of smoke",
            "Yellow puff of smoke",
            "A row of continous rising smoke",
            "A row of continous rising smoke",
            "A row of continous rising smoke",
            "A puff of smoke going left",
            "A puff of smoke going right",
            "Tiny red bits exploding",
            "Puff of smoke",
            "Big orange firework",
            "Slow puff of smoke",
            "Big star",
            "Tiny white star ",
            "Puff of faint continous smoke",
            "Green glitter",
            "Bigger cloud of green glitter",
            "Red ouff of continous smoke",
            "Tiny faint puff of continous smoke",
            "Spin-down speed comet tail",
            "Bubbles (unused?)",
            "Yellow star ",
            "Poison clouds going to sides",
            "Poison puff",
            "Side poison puff",
            "Poison puff",
            "Side poison puff",
            "Poison puff",
            "Side poison puff",
            "Poison puff",
            "Side poison puff",
            "Poison puff",
            "Tiny rock falling",
            "Different tiny rock falling",
            "Rocks falling",
            "Gray rocks falling",
            "Tiny blue stars",
            "Snow splash",
            "Quick puff of diagonal upward smoke",
            "Snow splash of diagonal upwardness",
            "Sparks",
            "Continual puff of smoke",
            "Sparks",
            "Glitter",
            "Gray feathers?",
            "Gray feathers?",
            "Green swirl",
            "Glitter",
            "Two yellow stars going diagonally downward",
            "Thin comet tail going down",
            "White splash thing",
            "Small green whirl",
            "Tiny yellow walljumping effect to the right",
            "Tiny puff of smoke",
            "Orange rock falling",
            "White walljump-like effect to left",
            "Puff of smoke",
            "Faint pixels going down",
            "Wiggler steam right",
            "Wiggler steam left",
            "Barely visible thing",
            "Pixels galling",
            "Water splash going both ways",
            "White water splash",
            "Big water splash going both ways",
            "Big white water splash",
            "White water splash going upward",
            "Tiny water splash",
            "Water splash to the sides",
            "Water splash",
            "Tiny upward water splash",
            "Yellow star explosion  ",
            "Tiny stars",
            "0xBA (Unknown)",
            "0xBB (Unknown)",
            "0xBC (Unknown)",
            "0xBD (Unknown)",
            "0xBE (Unknown)",
            "0xBF (Unknown)",
            "0xC0 (Unknown)",
            "0xC1 (Unknown)",
            "0xC2 (Unknown)",
            "0xC3 (Unknown)",
            "0xC4 (Unknown)",
            "0xC5 (Unknown)",
            "0xC6 (Unknown)",
            "0xC7 (Unknown)",
            "0xC8 (Unknown)",
            "0xC9 (Unknown)",
            "0xCA (Unknown)",
            "0xCB (Unknown)",
            "0xCC (Unknown)",
            "0xCD (Unknown)",
            "0xCE (Unknown)",
            "0xCF (Unknown)",
            "0xD0 (Unknown)",
            "0xD1 (Unknown)",
            "0xD2 (Unknown)",
            "0xD3 (Unknown)",
            "0xD4 (Unknown)",
            "0xD5 (Unknown)",
            "0xD6 (Unknown)",
            "0xD7 (Unknown)",
            "0xD8 (Unknown)",
            "0xD9 (Unknown)",
            "0xDA (Unknown)",
            "0xDB (Unknown)",
            "0xDC (Unknown)",
            "0xDD (Unknown)",
            "0xDE (Unknown)",
            "0xDF (Unknown)",
            "0xE0 (Unknown)",
            "0xE1 (Unknown)",
            "0xE2 (Unknown)",
            "0xE3 (Unknown)",
            "0xE4 (Unknown)",
            "0xE5 (Unknown)",
            "0xE6 (Unknown)",
            "0xE7 (Unknown)",
            "0xE8 (Unknown)",
            "0xE9 (Unknown)",
            "0xEA (Unknown)",
            "0xEB (Unknown)",
            "0xEC (Unknown)",
            "0xED (Unknown)",
            "0xEE (Unknown)",
            "0xEF (Unknown)",
            "0xF0 (Unknown)",
            "0xF1 (Unknown)",
            "0xF2 (Unknown)",
            "0xF3 (Unknown)",
            "0xF4 (Unknown)",
            "0xF5 (Unknown)",
            "0xF6 (Unknown)",
            "0xF7 (Unknown)",
            "0xF8 (Unknown)",
            "0xF9 (Unknown)",
            "0xFA (Unknown)",
            "0xFB (Unknown)",
            "0xFC (Unknown)",
            "0xFD (Unknown)",
            "0xFE (Unknown)",
            "0xFF (Unknown)",
            "0x100 (Unknown)",
            "0x101 (Unknown)",
            "0x102 (Unknown)",
            "Sparks",
            "Continual puff of smoke",
            "Sparks",
            "Glitter",
            "Gray feathers?",
            "Gray feathers?",
            "Green swirl",
            "Glitter",
            "Two yellow stars going diagonally downward",
            "Thin comet tail going down",
            "White splash thing",
            "Small green whirl",
            "Tiny yellow walljumping effect to the right",
            "Tiny puff of smoke",
            "Orange rock falling",
            "White walljump-like effect to left",
            "Puff of smoke",
            "Faint pixels going down",
            "Wiggler steam right",
            "Wiggler steam left",
            "Barely visible thing",
            "Pixels galling",
            "Water splash going both ways",
            "White water splash",
            "Big water splash going both ways",
            "Big white water splash",
            "White water splash going upward",
            "Tiny water splash",
            "Water splash to the sides",
            "Water splash",
            "Tiny upward water splash",
            "Yellow star explosion  ",
            "Tiny stars"});
            this.particleIDName.Location = new System.Drawing.Point(199, 6);
            this.particleIDName.Name = "particleIDName";
            this.particleIDName.Size = new System.Drawing.Size(281, 21);
            this.particleIDName.TabIndex = 27;
            this.particleIDName.SelectedIndexChanged += new System.EventHandler(this.particleIDName_SelectedIndexChanged);
            // 
            // classIDName
            // 
            this.classIDName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classIDName.FormattingEnabled = true;
            this.classIDName.Location = new System.Drawing.Point(273, 12);
            this.classIDName.Name = "classIDName";
            this.classIDName.Size = new System.Drawing.Size(382, 21);
            this.classIDName.TabIndex = 26;
            this.classIDName.SelectedIndexChanged += new System.EventHandler(this.classIDName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Class ID by Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Class ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(196, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Particle Offset Y:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Particle Offset X:";
            // 
            // pOffsetY
            // 
            this.pOffsetY.Location = new System.Drawing.Point(288, 84);
            this.pOffsetY.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.pOffsetY.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.pOffsetY.Name = "pOffsetY";
            this.pOffsetY.Size = new System.Drawing.Size(95, 22);
            this.pOffsetY.TabIndex = 7;
            this.pOffsetY.ValueChanged += new System.EventHandler(this.pOffsetY_ValueChanged);
            // 
            // pOffsetX
            // 
            this.pOffsetX.Location = new System.Drawing.Point(98, 86);
            this.pOffsetX.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.pOffsetX.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.pOffsetX.Name = "pOffsetX";
            this.pOffsetX.Size = new System.Drawing.Size(95, 22);
            this.pOffsetX.TabIndex = 6;
            this.pOffsetX.ValueChanged += new System.EventHandler(this.pOffsetX_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(400, 369);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(322, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "The Extra Settings will only work with the related code hacks!";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.assTab);
            this.tabControl.Controls.Add(this.rotctrlerTab);
            this.tabControl.Location = new System.Drawing.Point(171, 122);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(521, 231);
            this.tabControl.TabIndex = 10;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // assTab
            // 
            this.assTab.Controls.Add(this.sfxSearch);
            this.assTab.Controls.Add(this.particleSearch);
            this.assTab.Controls.Add(this.label11);
            this.assTab.Controls.Add(this.label12);
            this.assTab.Controls.Add(this.label5);
            this.assTab.Controls.Add(this.particleID);
            this.assTab.Controls.Add(this.label8);
            this.assTab.Controls.Add(this.label10);
            this.assTab.Controls.Add(this.label6);
            this.assTab.Controls.Add(this.sfxIDName);
            this.assTab.Controls.Add(this.label4);
            this.assTab.Controls.Add(this.sfxID);
            this.assTab.Controls.Add(this.particleIDName);
            this.assTab.Controls.Add(this.pOffsetY);
            this.assTab.Controls.Add(this.label7);
            this.assTab.Controls.Add(this.offsetY);
            this.assTab.Controls.Add(this.offsetX);
            this.assTab.Controls.Add(this.pOffsetX);
            this.assTab.Location = new System.Drawing.Point(4, 22);
            this.assTab.Name = "assTab";
            this.assTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.assTab.Size = new System.Drawing.Size(513, 205);
            this.assTab.TabIndex = 0;
            this.assTab.Text = "Actor Spawner Settings";
            this.assTab.UseVisualStyleBackColor = true;
            // 
            // sfxSearch
            // 
            this.sfxSearch.Image = global::NSMBe5.Properties.Resources.search;
            this.sfxSearch.Location = new System.Drawing.Point(486, 33);
            this.sfxSearch.Name = "sfxSearch";
            this.sfxSearch.Size = new System.Drawing.Size(21, 21);
            this.sfxSearch.TabIndex = 28;
            this.sfxSearch.UseVisualStyleBackColor = true;
            this.sfxSearch.Click += new System.EventHandler(this.sfxSearch_Click);
            // 
            // particleSearch
            // 
            this.particleSearch.Image = global::NSMBe5.Properties.Resources.search;
            this.particleSearch.Location = new System.Drawing.Point(486, 6);
            this.particleSearch.Name = "particleSearch";
            this.particleSearch.Size = new System.Drawing.Size(21, 21);
            this.particleSearch.TabIndex = 28;
            this.particleSearch.UseVisualStyleBackColor = true;
            this.particleSearch.Click += new System.EventHandler(this.particleSearch_Click);
            // 
            // rotctrlerTab
            // 
            this.rotctrlerTab.Controls.Add(this.label22);
            this.rotctrlerTab.Controls.Add(this.rotationStart);
            this.rotctrlerTab.Controls.Add(this.spritesNotMoved);
            this.rotctrlerTab.Controls.Add(this.unitInHalfTiles);
            this.rotctrlerTab.Controls.Add(this.shiftHalfTileY);
            this.rotctrlerTab.Controls.Add(this.shiftHalfTileX);
            this.rotctrlerTab.Controls.Add(this.modelZRot);
            this.rotctrlerTab.Controls.Add(this.modelYRot);
            this.rotctrlerTab.Controls.Add(this.modelXRot);
            this.rotctrlerTab.Controls.Add(this.label18);
            this.rotctrlerTab.Controls.Add(this.label17);
            this.rotctrlerTab.Controls.Add(this.label16);
            this.rotctrlerTab.Controls.Add(this.gapFlag);
            this.rotctrlerTab.Controls.Add(this.noSwayAcceleration);
            this.rotctrlerTab.Controls.Add(this.speedMultiplier);
            this.rotctrlerTab.Controls.Add(this.label21);
            this.rotctrlerTab.Controls.Add(this.tileShiftX);
            this.rotctrlerTab.Controls.Add(this.label20);
            this.rotctrlerTab.Controls.Add(this.amount);
            this.rotctrlerTab.Controls.Add(this.label19);
            this.rotctrlerTab.Controls.Add(this.label9);
            this.rotctrlerTab.Controls.Add(this.tileShiftY);
            this.rotctrlerTab.Controls.Add(this.label14);
            this.rotctrlerTab.Controls.Add(this.zPos);
            this.rotctrlerTab.Location = new System.Drawing.Point(4, 22);
            this.rotctrlerTab.Name = "rotctrlerTab";
            this.rotctrlerTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.rotctrlerTab.Size = new System.Drawing.Size(513, 205);
            this.rotctrlerTab.TabIndex = 1;
            this.rotctrlerTab.Text = "Rotation Controller Settings";
            this.rotctrlerTab.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(209, 89);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(118, 13);
            this.label22.TabIndex = 41;
            this.label22.Text = "Model Rotation Start:";
            // 
            // rotationStart
            // 
            this.rotationStart.Location = new System.Drawing.Point(322, 87);
            this.rotationStart.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.rotationStart.Name = "rotationStart";
            this.rotationStart.Size = new System.Drawing.Size(95, 22);
            this.rotationStart.TabIndex = 40;
            this.rotationStart.ValueChanged += new System.EventHandler(this.rotationStart_ValueChanged);
            // 
            // spritesNotMoved
            // 
            this.spritesNotMoved.AutoSize = true;
            this.spritesNotMoved.Location = new System.Drawing.Point(98, 185);
            this.spritesNotMoved.Name = "spritesNotMoved";
            this.spritesNotMoved.Size = new System.Drawing.Size(120, 17);
            this.spritesNotMoved.TabIndex = 39;
            this.spritesNotMoved.Text = "Sprites not Moved";
            this.spritesNotMoved.UseVisualStyleBackColor = true;
            this.spritesNotMoved.CheckedChanged += new System.EventHandler(this.spritesNotMoved_CheckedChanged);
            // 
            // unitInHalfTiles
            // 
            this.unitInHalfTiles.AutoSize = true;
            this.unitInHalfTiles.Location = new System.Drawing.Point(98, 162);
            this.unitInHalfTiles.Name = "unitInHalfTiles";
            this.unitInHalfTiles.Size = new System.Drawing.Size(111, 17);
            this.unitInHalfTiles.TabIndex = 38;
            this.unitInHalfTiles.Text = "Unit in Half Tiles";
            this.unitInHalfTiles.UseVisualStyleBackColor = true;
            this.unitInHalfTiles.CheckedChanged += new System.EventHandler(this.unitInHalfTiles_CheckedChanged);
            // 
            // shiftHalfTileY
            // 
            this.shiftHalfTileY.AutoSize = true;
            this.shiftHalfTileY.Location = new System.Drawing.Point(98, 139);
            this.shiftHalfTileY.Name = "shiftHalfTileY";
            this.shiftHalfTileY.Size = new System.Drawing.Size(102, 17);
            this.shiftHalfTileY.TabIndex = 37;
            this.shiftHalfTileY.Text = "Shift ½  tile up";
            this.shiftHalfTileY.UseVisualStyleBackColor = true;
            this.shiftHalfTileY.CheckedChanged += new System.EventHandler(this.shiftHalfTileY_CheckedChanged);
            // 
            // shiftHalfTileX
            // 
            this.shiftHalfTileX.AutoSize = true;
            this.shiftHalfTileX.Location = new System.Drawing.Point(98, 116);
            this.shiftHalfTileX.Name = "shiftHalfTileX";
            this.shiftHalfTileX.Size = new System.Drawing.Size(113, 17);
            this.shiftHalfTileX.TabIndex = 37;
            this.shiftHalfTileX.Text = "Shift ½  tile right";
            this.shiftHalfTileX.UseVisualStyleBackColor = true;
            this.shiftHalfTileX.CheckedChanged += new System.EventHandler(this.shiftHalfTileX_CheckedChanged);
            // 
            // modelZRot
            // 
            this.modelZRot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelZRot.FormattingEnabled = true;
            this.modelZRot.Items.AddRange(new object[] {
            "None",
            "Positive",
            "Negative"});
            this.modelZRot.Location = new System.Drawing.Point(322, 60);
            this.modelZRot.Name = "modelZRot";
            this.modelZRot.Size = new System.Drawing.Size(95, 21);
            this.modelZRot.TabIndex = 36;
            this.modelZRot.SelectedIndexChanged += new System.EventHandler(this.modelZRot_SelectedIndexChanged);
            // 
            // modelYRot
            // 
            this.modelYRot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelYRot.FormattingEnabled = true;
            this.modelYRot.Items.AddRange(new object[] {
            "None",
            "Positive",
            "Negative"});
            this.modelYRot.Location = new System.Drawing.Point(322, 33);
            this.modelYRot.Name = "modelYRot";
            this.modelYRot.Size = new System.Drawing.Size(95, 21);
            this.modelYRot.TabIndex = 36;
            this.modelYRot.SelectedIndexChanged += new System.EventHandler(this.modelYRot_SelectedIndexChanged);
            // 
            // modelXRot
            // 
            this.modelXRot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelXRot.FormattingEnabled = true;
            this.modelXRot.Items.AddRange(new object[] {
            "None",
            "Positive",
            "Negative"});
            this.modelXRot.Location = new System.Drawing.Point(322, 6);
            this.modelXRot.Name = "modelXRot";
            this.modelXRot.Size = new System.Drawing.Size(95, 21);
            this.modelXRot.TabIndex = 36;
            this.modelXRot.SelectedIndexChanged += new System.EventHandler(this.modelXRot_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(224, 64);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Model Z Rotation:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(224, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "Model Y Rotation:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(224, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Model X Rotation:";
            // 
            // gapFlag
            // 
            this.gapFlag.AutoSize = true;
            this.gapFlag.Location = new System.Drawing.Point(322, 139);
            this.gapFlag.Name = "gapFlag";
            this.gapFlag.Size = new System.Drawing.Size(69, 17);
            this.gapFlag.TabIndex = 33;
            this.gapFlag.Text = "Has Gap";
            this.gapFlag.UseVisualStyleBackColor = true;
            this.gapFlag.CheckedChanged += new System.EventHandler(this.gapFlag_CheckedChanged);
            // 
            // noSwayAcceleration
            // 
            this.noSwayAcceleration.AutoSize = true;
            this.noSwayAcceleration.Location = new System.Drawing.Point(322, 162);
            this.noSwayAcceleration.Name = "noSwayAcceleration";
            this.noSwayAcceleration.Size = new System.Drawing.Size(136, 17);
            this.noSwayAcceleration.TabIndex = 33;
            this.noSwayAcceleration.Text = "No Sway Acceleration";
            this.noSwayAcceleration.UseVisualStyleBackColor = true;
            this.noSwayAcceleration.CheckedChanged += new System.EventHandler(this.noSwayAcceleration_CheckedChanged);
            // 
            // speedMultiplier
            // 
            this.speedMultiplier.Location = new System.Drawing.Point(98, 34);
            this.speedMultiplier.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.speedMultiplier.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speedMultiplier.Name = "speedMultiplier";
            this.speedMultiplier.Size = new System.Drawing.Size(95, 22);
            this.speedMultiplier.TabIndex = 31;
            this.speedMultiplier.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speedMultiplier.ValueChanged += new System.EventHandler(this.speedMultiplier_ValueChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(8, 36);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(95, 13);
            this.label21.TabIndex = 29;
            this.label21.Text = "Speed Multiplier:";
            // 
            // tileShiftX
            // 
            this.tileShiftX.Location = new System.Drawing.Point(98, 61);
            this.tileShiftX.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.tileShiftX.Name = "tileShiftX";
            this.tileShiftX.Size = new System.Drawing.Size(95, 22);
            this.tileShiftX.TabIndex = 31;
            this.tileShiftX.ValueChanged += new System.EventHandler(this.tileShiftX_ValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(31, 63);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 13);
            this.label20.TabIndex = 29;
            this.label20.Text = "Tile Shift X:";
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(98, 7);
            this.amount.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(95, 22);
            this.amount.TabIndex = 31;
            this.amount.ValueChanged += new System.EventHandler(this.amount_ValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(32, 89);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 13);
            this.label19.TabIndex = 30;
            this.label19.Text = "Tile Shift Y:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Sprite Count:";
            // 
            // tileShiftY
            // 
            this.tileShiftY.Location = new System.Drawing.Point(98, 87);
            this.tileShiftY.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.tileShiftY.Name = "tileShiftY";
            this.tileShiftY.Size = new System.Drawing.Size(95, 22);
            this.tileShiftY.TabIndex = 32;
            this.tileShiftY.ValueChanged += new System.EventHandler(this.tileShiftY_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(259, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Z Position:";
            // 
            // zPos
            // 
            this.zPos.Location = new System.Drawing.Point(322, 113);
            this.zPos.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.zPos.Name = "zPos";
            this.zPos.Size = new System.Drawing.Size(95, 22);
            this.zPos.TabIndex = 32;
            this.zPos.ValueChanged += new System.EventHandler(this.zPos_ValueChanged);
            // 
            // spriteDataTextBox
            // 
            this.spriteDataTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.spriteDataTextBox.Location = new System.Drawing.Point(273, 66);
            this.spriteDataTextBox.Name = "spriteDataTextBox";
            this.spriteDataTextBox.Size = new System.Drawing.Size(95, 22);
            this.spriteDataTextBox.TabIndex = 27;
            this.spriteDataTextBox.Text = "00 00 00 00 00 00";
            this.spriteDataTextBox.TextChanged += new System.EventHandler(this.spriteDataTextBox_TextChanged);
            // 
            // classSearch
            // 
            this.classSearch.Image = global::NSMBe5.Properties.Resources.search;
            this.classSearch.Location = new System.Drawing.Point(661, 12);
            this.classSearch.Name = "classSearch";
            this.classSearch.Size = new System.Drawing.Size(21, 21);
            this.classSearch.TabIndex = 28;
            this.classSearch.UseVisualStyleBackColor = true;
            this.classSearch.Click += new System.EventHandler(this.classSearch_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(187, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Draw Distance:";
            // 
            // drawDistance
            // 
            this.drawDistance.Location = new System.Drawing.Point(273, 90);
            this.drawDistance.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.drawDistance.Name = "drawDistance";
            this.drawDistance.Size = new System.Drawing.Size(95, 22);
            this.drawDistance.TabIndex = 30;
            this.drawDistance.ValueChanged += new System.EventHandler(this.drawDistance_ValueChanged);
            // 
            // ExtraDataEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 396);
            this.Controls.Add(this.drawDistance);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.classSearch);
            this.Controls.Add(this.spriteDataTextBox);
            this.Controls.Add(this.classIDName);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.list);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ID);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExtraDataEditor";
            this.Text = "Extra Settings";
            this.Load += new System.EventHandler(this.ExtDataEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sfxID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.particleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOffsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOffsetX)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.assTab.ResumeLayout(false);
            this.assTab.PerformLayout();
            this.rotctrlerTab.ResumeLayout(false);
            this.rotctrlerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotationStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileShiftX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileShiftY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
  }
}
