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
            this.buttonFirmwareLoad = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttondrawEditor = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDecodeMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonClearEditor = new System.Windows.Forms.Button();
            this.buttonIncreaseByWidth = new System.Windows.Forms.Button();
            this.buttonDecreaseByWidth = new System.Windows.Forms.Button();
            this.buttonIncreaseByOne = new System.Windows.Forms.Button();
            this.buttonDecreaseByOne = new System.Windows.Forms.Button();
            this.tbPixelSize = new System.Windows.Forms.NumericUpDown();
            this.tbStartPos = new System.Windows.Forms.NumericUpDown();
            this.tbWidth = new System.Windows.Forms.NumericUpDown();
            this.tbEndPos = new System.Windows.Forms.NumericUpDown();
            this.numIncreaseBy = new System.Windows.Forms.NumericUpDown();
            this.numDecreaseBy = new System.Windows.Forms.NumericUpDown();
            this.buttonDecreaseWidthOne = new System.Windows.Forms.Button();
            this.buttonIncreaseWidthOne = new System.Windows.Forms.Button();
            this.groupBoxCodeGen = new System.Windows.Forms.GroupBox();
            this.tbCodeGenHeight = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonGenerateIconCode = new System.Windows.Forms.Button();
            this.tBCodeGenName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tBCodeGenOutput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbPixelSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStartPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEndPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIncreaseBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDecreaseBy)).BeginInit();
            this.groupBoxCodeGen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCodeGenHeight)).BeginInit();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Viewer";
            // 
            // buttondrawEditor
            // 
            this.buttondrawEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondrawEditor.Location = new System.Drawing.Point(101, 365);
            this.buttondrawEditor.Name = "buttondrawEditor";
            this.buttondrawEditor.Size = new System.Drawing.Size(96, 23);
            this.buttondrawEditor.TabIndex = 24;
            this.buttondrawEditor.Text = "Draw Editor";
            this.buttondrawEditor.UseVisualStyleBackColor = true;
            this.buttondrawEditor.Click += new System.EventHandler(this.buttondrawEditor_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Version: 1.0.0";
            // 
            // cbDecodeMode
            // 
            this.cbDecodeMode.FormattingEnabled = true;
            this.cbDecodeMode.Location = new System.Drawing.Point(101, 170);
            this.cbDecodeMode.Name = "cbDecodeMode";
            this.cbDecodeMode.Size = new System.Drawing.Size(100, 21);
            this.cbDecodeMode.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Startposition";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Endposition";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Decode Mode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "EditorWidth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Pixel Size";
            // 
            // buttonClearEditor
            // 
            this.buttonClearEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearEditor.Location = new System.Drawing.Point(101, 394);
            this.buttonClearEditor.Name = "buttonClearEditor";
            this.buttonClearEditor.Size = new System.Drawing.Size(96, 23);
            this.buttonClearEditor.TabIndex = 37;
            this.buttonClearEditor.Text = "Clear Editor";
            this.buttonClearEditor.UseVisualStyleBackColor = true;
            this.buttonClearEditor.Click += new System.EventHandler(this.buttonClearEditor_Click);
            // 
            // buttonIncreaseByWidth
            // 
            this.buttonIncreaseByWidth.Location = new System.Drawing.Point(72, 336);
            this.buttonIncreaseByWidth.Name = "buttonIncreaseByWidth";
            this.buttonIncreaseByWidth.Size = new System.Drawing.Size(129, 23);
            this.buttonIncreaseByWidth.TabIndex = 38;
            this.buttonIncreaseByWidth.Text = "Increase by Width";
            this.buttonIncreaseByWidth.UseVisualStyleBackColor = true;
            this.buttonIncreaseByWidth.Click += new System.EventHandler(this.buttonIncreaseByWidth_Click);
            // 
            // buttonDecreaseByWidth
            // 
            this.buttonDecreaseByWidth.Location = new System.Drawing.Point(72, 307);
            this.buttonDecreaseByWidth.Name = "buttonDecreaseByWidth";
            this.buttonDecreaseByWidth.Size = new System.Drawing.Size(129, 23);
            this.buttonDecreaseByWidth.TabIndex = 39;
            this.buttonDecreaseByWidth.Text = "Decrease by Width";
            this.buttonDecreaseByWidth.UseVisualStyleBackColor = true;
            this.buttonDecreaseByWidth.Click += new System.EventHandler(this.buttonDecreaseByWidth_Click);
            // 
            // buttonIncreaseByOne
            // 
            this.buttonIncreaseByOne.Location = new System.Drawing.Point(11, 220);
            this.buttonIncreaseByOne.Name = "buttonIncreaseByOne";
            this.buttonIncreaseByOne.Size = new System.Drawing.Size(84, 23);
            this.buttonIncreaseByOne.TabIndex = 40;
            this.buttonIncreaseByOne.Text = "Increase by";
            this.buttonIncreaseByOne.UseVisualStyleBackColor = true;
            this.buttonIncreaseByOne.Click += new System.EventHandler(this.buttonIncreaseByOne_Click);
            // 
            // buttonDecreaseByOne
            // 
            this.buttonDecreaseByOne.Location = new System.Drawing.Point(11, 194);
            this.buttonDecreaseByOne.Name = "buttonDecreaseByOne";
            this.buttonDecreaseByOne.Size = new System.Drawing.Size(84, 23);
            this.buttonDecreaseByOne.TabIndex = 42;
            this.buttonDecreaseByOne.Text = "Decrease by";
            this.buttonDecreaseByOne.UseVisualStyleBackColor = true;
            this.buttonDecreaseByOne.Click += new System.EventHandler(this.buttonDecreaseByOne_Click);
            // 
            // tbPixelSize
            // 
            this.tbPixelSize.Location = new System.Drawing.Point(101, 144);
            this.tbPixelSize.Name = "tbPixelSize";
            this.tbPixelSize.Size = new System.Drawing.Size(100, 20);
            this.tbPixelSize.TabIndex = 43;
            this.tbPixelSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tbStartPos
            // 
            this.tbStartPos.Hexadecimal = true;
            this.tbStartPos.Location = new System.Drawing.Point(101, 67);
            this.tbStartPos.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tbStartPos.Name = "tbStartPos";
            this.tbStartPos.Size = new System.Drawing.Size(100, 20);
            this.tbStartPos.TabIndex = 44;
            this.tbStartPos.Value = new decimal(new int[] {
            160084,
            0,
            0,
            0});
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(101, 119);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(100, 20);
            this.tbWidth.TabIndex = 45;
            this.tbWidth.Value = new decimal(new int[] {
            36,
            0,
            0,
            0});
            // 
            // tbEndPos
            // 
            this.tbEndPos.Hexadecimal = true;
            this.tbEndPos.Location = new System.Drawing.Point(101, 93);
            this.tbEndPos.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tbEndPos.Name = "tbEndPos";
            this.tbEndPos.Size = new System.Drawing.Size(100, 20);
            this.tbEndPos.TabIndex = 46;
            this.tbEndPos.Value = new decimal(new int[] {
            160263,
            0,
            0,
            0});
            // 
            // numIncreaseBy
            // 
            this.numIncreaseBy.Location = new System.Drawing.Point(101, 223);
            this.numIncreaseBy.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numIncreaseBy.Name = "numIncreaseBy";
            this.numIncreaseBy.Size = new System.Drawing.Size(100, 20);
            this.numIncreaseBy.TabIndex = 47;
            this.numIncreaseBy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numDecreaseBy
            // 
            this.numDecreaseBy.Location = new System.Drawing.Point(101, 197);
            this.numDecreaseBy.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numDecreaseBy.Name = "numDecreaseBy";
            this.numDecreaseBy.Size = new System.Drawing.Size(100, 20);
            this.numDecreaseBy.TabIndex = 48;
            this.numDecreaseBy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonDecreaseWidthOne
            // 
            this.buttonDecreaseWidthOne.Location = new System.Drawing.Point(72, 249);
            this.buttonDecreaseWidthOne.Name = "buttonDecreaseWidthOne";
            this.buttonDecreaseWidthOne.Size = new System.Drawing.Size(129, 23);
            this.buttonDecreaseWidthOne.TabIndex = 50;
            this.buttonDecreaseWidthOne.Text = "Decrease Width by 1";
            this.buttonDecreaseWidthOne.UseVisualStyleBackColor = true;
            this.buttonDecreaseWidthOne.Click += new System.EventHandler(this.buttonDecreaseWidthOne_Click);
            // 
            // buttonIncreaseWidthOne
            // 
            this.buttonIncreaseWidthOne.Location = new System.Drawing.Point(72, 278);
            this.buttonIncreaseWidthOne.Name = "buttonIncreaseWidthOne";
            this.buttonIncreaseWidthOne.Size = new System.Drawing.Size(129, 23);
            this.buttonIncreaseWidthOne.TabIndex = 49;
            this.buttonIncreaseWidthOne.Text = "Increase Width by 1";
            this.buttonIncreaseWidthOne.UseVisualStyleBackColor = true;
            this.buttonIncreaseWidthOne.Click += new System.EventHandler(this.buttonIncreaseWidthOne_Click);
            // 
            // groupBoxCodeGen
            // 
            this.groupBoxCodeGen.Controls.Add(this.tBCodeGenOutput);
            this.groupBoxCodeGen.Controls.Add(this.label9);
            this.groupBoxCodeGen.Controls.Add(this.tBCodeGenName);
            this.groupBoxCodeGen.Controls.Add(this.buttonGenerateIconCode);
            this.groupBoxCodeGen.Controls.Add(this.label8);
            this.groupBoxCodeGen.Controls.Add(this.tbCodeGenHeight);
            this.groupBoxCodeGen.Location = new System.Drawing.Point(11, 457);
            this.groupBoxCodeGen.Name = "groupBoxCodeGen";
            this.groupBoxCodeGen.Size = new System.Drawing.Size(186, 195);
            this.groupBoxCodeGen.TabIndex = 51;
            this.groupBoxCodeGen.TabStop = false;
            this.groupBoxCodeGen.Text = "Code Generator";
            // 
            // tbCodeGenHeight
            // 
            this.tbCodeGenHeight.Location = new System.Drawing.Point(88, 19);
            this.tbCodeGenHeight.Name = "tbCodeGenHeight";
            this.tbCodeGenHeight.Size = new System.Drawing.Size(92, 20);
            this.tbCodeGenHeight.TabIndex = 52;
            this.tbCodeGenHeight.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "height in Bytes";
            // 
            // buttonGenerateIconCode
            // 
            this.buttonGenerateIconCode.Location = new System.Drawing.Point(6, 71);
            this.buttonGenerateIconCode.Name = "buttonGenerateIconCode";
            this.buttonGenerateIconCode.Size = new System.Drawing.Size(174, 23);
            this.buttonGenerateIconCode.TabIndex = 54;
            this.buttonGenerateIconCode.Text = "Generate Icon Data!";
            this.buttonGenerateIconCode.UseVisualStyleBackColor = true;
            this.buttonGenerateIconCode.Click += new System.EventHandler(this.buttonGenerateIconCode_Click);
            // 
            // tBCodeGenName
            // 
            this.tBCodeGenName.Location = new System.Drawing.Point(88, 45);
            this.tBCodeGenName.Name = "tBCodeGenName";
            this.tBCodeGenName.Size = new System.Drawing.Size(92, 20);
            this.tBCodeGenName.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 59;
            this.label9.Text = "Icon Name";
            // 
            // tBCodeGenOutput
            // 
            this.tBCodeGenOutput.Location = new System.Drawing.Point(6, 100);
            this.tBCodeGenOutput.Name = "tBCodeGenOutput";
            this.tBCodeGenOutput.Size = new System.Drawing.Size(174, 20);
            this.tBCodeGenOutput.TabIndex = 60;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 961);
            this.Controls.Add(this.groupBoxCodeGen);
            this.Controls.Add(this.buttonDecreaseWidthOne);
            this.Controls.Add(this.buttonIncreaseWidthOne);
            this.Controls.Add(this.numDecreaseBy);
            this.Controls.Add(this.numIncreaseBy);
            this.Controls.Add(this.tbEndPos);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.tbStartPos);
            this.Controls.Add(this.tbPixelSize);
            this.Controls.Add(this.buttonDecreaseByOne);
            this.Controls.Add(this.buttonIncreaseByOne);
            this.Controls.Add(this.buttonDecreaseByWidth);
            this.Controls.Add(this.buttonIncreaseByWidth);
            this.Controls.Add(this.buttonClearEditor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttondrawEditor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbDecodeMode);
            this.Controls.Add(this.buttonFirmwareLoad);
            this.Name = "Form1";
            this.Text = "Mi Band 2 Firmware Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbPixelSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStartPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEndPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIncreaseBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDecreaseBy)).EndInit();
            this.groupBoxCodeGen.ResumeLayout(false);
            this.groupBoxCodeGen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCodeGenHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFirmwareLoad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttondrawEditor;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDecodeMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonClearEditor;
        private System.Windows.Forms.Button buttonIncreaseByWidth;
        private System.Windows.Forms.Button buttonDecreaseByWidth;
        private System.Windows.Forms.Button buttonIncreaseByOne;
        private System.Windows.Forms.Button buttonDecreaseByOne;
        private System.Windows.Forms.NumericUpDown tbPixelSize;
        private System.Windows.Forms.NumericUpDown tbStartPos;
        private System.Windows.Forms.NumericUpDown tbWidth;
        private System.Windows.Forms.NumericUpDown tbEndPos;
        private System.Windows.Forms.NumericUpDown numIncreaseBy;
        private System.Windows.Forms.NumericUpDown numDecreaseBy;
        private System.Windows.Forms.Button buttonDecreaseWidthOne;
        private System.Windows.Forms.Button buttonIncreaseWidthOne;
        private System.Windows.Forms.GroupBox groupBoxCodeGen;
        private System.Windows.Forms.TextBox tBCodeGenOutput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tBCodeGenName;
        private System.Windows.Forms.Button buttonGenerateIconCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown tbCodeGenHeight;
    }
}

