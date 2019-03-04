namespace MiFirmwareEditor
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.buttonFirmwareLoad = new System.Windows.Forms.Button();
            this.buttonFirmwareSave = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEditorSave = new System.Windows.Forms.Button();
            this.buttonEditorDiscard = new System.Windows.Forms.Button();
            this.cbEditItem = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbXPos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbYPos = new System.Windows.Forms.TextBox();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.buttonFillRectangle = new System.Windows.Forms.Button();
            this.buttonredrawEditor = new System.Windows.Forms.Button();
            this.buttonUnfillRectangle = new System.Windows.Forms.Button();
            this.buttonInvertRectangle = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timerMouseDown = new System.Windows.Forms.Timer(this.components);
            this.numericUpDownBrushWidth = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxVersionSelect = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.labelInfoSelectVersion = new System.Windows.Forms.Label();
            this.buttonGetdata = new System.Windows.Forms.Button();
            this.textBoxGetData = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrushWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFirmwareLoad
            // 
            this.buttonFirmwareLoad.Location = new System.Drawing.Point(13, 13);
            this.buttonFirmwareLoad.Name = "buttonFirmwareLoad";
            this.buttonFirmwareLoad.Size = new System.Drawing.Size(91, 23);
            this.buttonFirmwareLoad.TabIndex = 0;
            this.buttonFirmwareLoad.Text = "Load Firmware";
            this.buttonFirmwareLoad.UseVisualStyleBackColor = true;
            this.buttonFirmwareLoad.Click += new System.EventHandler(this.buttonFirmwareLoad_Click);
            // 
            // buttonFirmwareSave
            // 
            this.buttonFirmwareSave.Location = new System.Drawing.Point(110, 13);
            this.buttonFirmwareSave.Name = "buttonFirmwareSave";
            this.buttonFirmwareSave.Size = new System.Drawing.Size(121, 23);
            this.buttonFirmwareSave.TabIndex = 1;
            this.buttonFirmwareSave.Text = "Save edited Firmware";
            this.buttonFirmwareSave.UseVisualStyleBackColor = true;
            this.buttonFirmwareSave.Click += new System.EventHandler(this.buttonFirmwareSave_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(1102, 99);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(176, 21);
            this.cbCategory.TabIndex = 4;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1099, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select item to edit";
            // 
            // buttonEditorSave
            // 
            this.buttonEditorSave.Location = new System.Drawing.Point(1102, 263);
            this.buttonEditorSave.Name = "buttonEditorSave";
            this.buttonEditorSave.Size = new System.Drawing.Size(96, 23);
            this.buttonEditorSave.TabIndex = 8;
            this.buttonEditorSave.Text = "Save changes";
            this.buttonEditorSave.UseVisualStyleBackColor = true;
            this.buttonEditorSave.Click += new System.EventHandler(this.buttonEditorSave_Click);
            // 
            // buttonEditorDiscard
            // 
            this.buttonEditorDiscard.Location = new System.Drawing.Point(1102, 293);
            this.buttonEditorDiscard.Name = "buttonEditorDiscard";
            this.buttonEditorDiscard.Size = new System.Drawing.Size(96, 23);
            this.buttonEditorDiscard.TabIndex = 9;
            this.buttonEditorDiscard.Text = "Discard Changes";
            this.buttonEditorDiscard.UseVisualStyleBackColor = true;
            this.buttonEditorDiscard.Click += new System.EventHandler(this.buttonEditorDiscard_Click);
            // 
            // cbEditItem
            // 
            this.cbEditItem.FormattingEnabled = true;
            this.cbEditItem.Location = new System.Drawing.Point(1102, 126);
            this.cbEditItem.Name = "cbEditItem";
            this.cbEditItem.Size = new System.Drawing.Size(176, 21);
            this.cbEditItem.TabIndex = 11;
            this.cbEditItem.SelectedIndexChanged += new System.EventHandler(this.cbEditItem_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Editor";
            // 
            // tbXPos
            // 
            this.tbXPos.Location = new System.Drawing.Point(1140, 357);
            this.tbXPos.Name = "tbXPos";
            this.tbXPos.Size = new System.Drawing.Size(46, 20);
            this.tbXPos.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1102, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Fill a rectangle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1102, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "XPos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1102, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "YPos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1102, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Width";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1102, 438);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Height";
            // 
            // tbYPos
            // 
            this.tbYPos.Location = new System.Drawing.Point(1140, 383);
            this.tbYPos.Name = "tbYPos";
            this.tbYPos.Size = new System.Drawing.Size(46, 20);
            this.tbYPos.TabIndex = 20;
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(1140, 409);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(46, 20);
            this.tbWidth.TabIndex = 21;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(1139, 435);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(46, 20);
            this.tbHeight.TabIndex = 22;
            // 
            // buttonFillRectangle
            // 
            this.buttonFillRectangle.Location = new System.Drawing.Point(1105, 471);
            this.buttonFillRectangle.Name = "buttonFillRectangle";
            this.buttonFillRectangle.Size = new System.Drawing.Size(93, 23);
            this.buttonFillRectangle.TabIndex = 23;
            this.buttonFillRectangle.Text = "Fill rectangle";
            this.buttonFillRectangle.UseVisualStyleBackColor = true;
            this.buttonFillRectangle.Click += new System.EventHandler(this.buttonFillRectangle_Click);
            // 
            // buttonredrawEditor
            // 
            this.buttonredrawEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonredrawEditor.Location = new System.Drawing.Point(1105, 587);
            this.buttonredrawEditor.Name = "buttonredrawEditor";
            this.buttonredrawEditor.Size = new System.Drawing.Size(96, 23);
            this.buttonredrawEditor.TabIndex = 24;
            this.buttonredrawEditor.Text = "Redraw Editor";
            this.buttonredrawEditor.UseVisualStyleBackColor = true;
            this.buttonredrawEditor.Click += new System.EventHandler(this.buttonredrawEditor_Click);
            // 
            // buttonUnfillRectangle
            // 
            this.buttonUnfillRectangle.Location = new System.Drawing.Point(1105, 500);
            this.buttonUnfillRectangle.Name = "buttonUnfillRectangle";
            this.buttonUnfillRectangle.Size = new System.Drawing.Size(93, 23);
            this.buttonUnfillRectangle.TabIndex = 25;
            this.buttonUnfillRectangle.Text = "Unfill rectangle";
            this.buttonUnfillRectangle.UseVisualStyleBackColor = true;
            this.buttonUnfillRectangle.Click += new System.EventHandler(this.buttonUnfillRectangle_Click);
            // 
            // buttonInvertRectangle
            // 
            this.buttonInvertRectangle.Location = new System.Drawing.Point(1105, 529);
            this.buttonInvertRectangle.Name = "buttonInvertRectangle";
            this.buttonInvertRectangle.Size = new System.Drawing.Size(93, 23);
            this.buttonInvertRectangle.TabIndex = 26;
            this.buttonInvertRectangle.Text = "Invert rectangle";
            this.buttonInvertRectangle.UseVisualStyleBackColor = true;
            this.buttonInvertRectangle.Click += new System.EventHandler(this.buttonInvertRectangle_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1105, 617);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Version: 1.0.0";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(1102, 153);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(165, 17);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "Current Editormode: Add pixel";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timerMouseDown
            // 
            this.timerMouseDown.Interval = 25;
            this.timerMouseDown.Tick += new System.EventHandler(this.timerMouseDown_Tick);
            // 
            // numericUpDownBrushWidth
            // 
            this.numericUpDownBrushWidth.Location = new System.Drawing.Point(1102, 203);
            this.numericUpDownBrushWidth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownBrushWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBrushWidth.Name = "numericUpDownBrushWidth";
            this.numericUpDownBrushWidth.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownBrushWidth.TabIndex = 29;
            this.numericUpDownBrushWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBrushWidth.ValueChanged += new System.EventHandler(this.numericUpDownBrushWidth_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1102, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Brush width";
            // 
            // comboBoxVersionSelect
            // 
            this.comboBoxVersionSelect.FormattingEnabled = true;
            this.comboBoxVersionSelect.Location = new System.Drawing.Point(1102, 59);
            this.comboBoxVersionSelect.Name = "comboBoxVersionSelect";
            this.comboBoxVersionSelect.Size = new System.Drawing.Size(176, 21);
            this.comboBoxVersionSelect.TabIndex = 31;
            this.comboBoxVersionSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxVersionSelect_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1099, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Select Version";
            // 
            // labelInfoSelectVersion
            // 
            this.labelInfoSelectVersion.AutoSize = true;
            this.labelInfoSelectVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoSelectVersion.Location = new System.Drawing.Point(237, 16);
            this.labelInfoSelectVersion.Name = "labelInfoSelectVersion";
            this.labelInfoSelectVersion.Size = new System.Drawing.Size(289, 15);
            this.labelInfoSelectVersion.TabIndex = 33;
            this.labelInfoSelectVersion.Text = "Select the correct version before continuing!";
            this.labelInfoSelectVersion.Visible = false;
            // 
            // buttonGetdata
            // 
            this.buttonGetdata.Location = new System.Drawing.Point(1105, 634);
            this.buttonGetdata.Name = "buttonGetdata";
            this.buttonGetdata.Size = new System.Drawing.Size(100, 23);
            this.buttonGetdata.TabIndex = 34;
            this.buttonGetdata.Text = "Get Data";
            this.buttonGetdata.UseVisualStyleBackColor = true;
            this.buttonGetdata.Click += new System.EventHandler(this.buttonGetdata_Click);
            // 
            // textBoxGetData
            // 
            this.textBoxGetData.Location = new System.Drawing.Point(1105, 663);
            this.textBoxGetData.Name = "textBoxGetData";
            this.textBoxGetData.Size = new System.Drawing.Size(100, 20);
            this.textBoxGetData.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 761);
            this.Controls.Add(this.textBoxGetData);
            this.Controls.Add(this.buttonGetdata);
            this.Controls.Add(this.labelInfoSelectVersion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxVersionSelect);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericUpDownBrushWidth);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonInvertRectangle);
            this.Controls.Add(this.buttonUnfillRectangle);
            this.Controls.Add(this.buttonredrawEditor);
            this.Controls.Add(this.buttonFillRectangle);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.tbYPos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbXPos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbEditItem);
            this.Controls.Add(this.buttonEditorDiscard);
            this.Controls.Add(this.buttonEditorSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.buttonFirmwareSave);
            this.Controls.Add(this.buttonFirmwareLoad);
            this.Name = "Form1";
            this.Text = "Mi Band 2 Firmware Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown_1);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrushWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFirmwareLoad;
        private System.Windows.Forms.Button buttonFirmwareSave;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEditorSave;
        private System.Windows.Forms.Button buttonEditorDiscard;
        private System.Windows.Forms.ComboBox cbEditItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbXPos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbYPos;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Button buttonFillRectangle;
        private System.Windows.Forms.Button buttonredrawEditor;
        private System.Windows.Forms.Button buttonUnfillRectangle;
        private System.Windows.Forms.Button buttonInvertRectangle;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timerMouseDown;
        private System.Windows.Forms.NumericUpDown numericUpDownBrushWidth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxVersionSelect;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelInfoSelectVersion;
        private System.Windows.Forms.Button buttonGetdata;
        private System.Windows.Forms.TextBox textBoxGetData;
    }
}

