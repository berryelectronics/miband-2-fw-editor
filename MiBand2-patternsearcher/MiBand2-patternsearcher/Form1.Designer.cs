namespace MiBand2_patternsearcher
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.openPattern = new System.Windows.Forms.OpenFileDialog();
            this.openFirmware = new System.Windows.Forms.OpenFileDialog();
            this.buttonLoadPattern = new System.Windows.Forms.Button();
            this.buttonLoadFirmware = new System.Windows.Forms.Button();
            this.tBEndPosDec = new System.Windows.Forms.TextBox();
            this.tBStartPosDec = new System.Windows.Forms.TextBox();
            this.tBLengthHex = new System.Windows.Forms.TextBox();
            this.tBStartPosHex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSearchPattern = new System.Windows.Forms.Button();
            this.tBEndPosHex = new System.Windows.Forms.TextBox();
            this.tBLengthDec = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelFirmwarePath = new System.Windows.Forms.Label();
            this.labelPatternPath = new System.Windows.Forms.Label();
            this.buttonCopyStartHex = new System.Windows.Forms.Button();
            this.buttonCopyEndHex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openPattern
            // 
            this.openPattern.FileName = "openFileDialog1";
            // 
            // openFirmware
            // 
            this.openFirmware.FileName = "openFileDialog2";
            // 
            // buttonLoadPattern
            // 
            this.buttonLoadPattern.Location = new System.Drawing.Point(90, 9);
            this.buttonLoadPattern.Name = "buttonLoadPattern";
            this.buttonLoadPattern.Size = new System.Drawing.Size(90, 23);
            this.buttonLoadPattern.TabIndex = 0;
            this.buttonLoadPattern.Text = "Load Pattern";
            this.buttonLoadPattern.UseVisualStyleBackColor = true;
            this.buttonLoadPattern.Click += new System.EventHandler(this.buttonLoadPattern_Click);
            // 
            // buttonLoadFirmware
            // 
            this.buttonLoadFirmware.Location = new System.Drawing.Point(186, 9);
            this.buttonLoadFirmware.Name = "buttonLoadFirmware";
            this.buttonLoadFirmware.Size = new System.Drawing.Size(90, 23);
            this.buttonLoadFirmware.TabIndex = 1;
            this.buttonLoadFirmware.Text = "Load Firmware";
            this.buttonLoadFirmware.UseVisualStyleBackColor = true;
            this.buttonLoadFirmware.Click += new System.EventHandler(this.buttonLoadFirmware_Click);
            // 
            // tBEndPosDec
            // 
            this.tBEndPosDec.Location = new System.Drawing.Point(90, 111);
            this.tBEndPosDec.Name = "tBEndPosDec";
            this.tBEndPosDec.Size = new System.Drawing.Size(100, 20);
            this.tBEndPosDec.TabIndex = 2;
            // 
            // tBStartPosDec
            // 
            this.tBStartPosDec.Location = new System.Drawing.Point(90, 85);
            this.tBStartPosDec.Name = "tBStartPosDec";
            this.tBStartPosDec.Size = new System.Drawing.Size(100, 20);
            this.tBStartPosDec.TabIndex = 3;
            // 
            // tBLengthHex
            // 
            this.tBLengthHex.Location = new System.Drawing.Point(196, 137);
            this.tBLengthHex.Name = "tBLengthHex";
            this.tBLengthHex.Size = new System.Drawing.Size(100, 20);
            this.tBLengthHex.TabIndex = 4;
            // 
            // tBStartPosHex
            // 
            this.tBStartPosHex.Location = new System.Drawing.Point(196, 85);
            this.tBStartPosHex.Name = "tBStartPosHex";
            this.tBStartPosHex.Size = new System.Drawing.Size(100, 20);
            this.tBStartPosHex.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Startposition";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Endposition";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Decimal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hexadecimal";
            // 
            // buttonSearchPattern
            // 
            this.buttonSearchPattern.Location = new System.Drawing.Point(90, 38);
            this.buttonSearchPattern.Name = "buttonSearchPattern";
            this.buttonSearchPattern.Size = new System.Drawing.Size(90, 23);
            this.buttonSearchPattern.TabIndex = 10;
            this.buttonSearchPattern.Text = "Search Pattern";
            this.buttonSearchPattern.UseVisualStyleBackColor = true;
            this.buttonSearchPattern.Click += new System.EventHandler(this.buttonSearchPattern_Click);
            // 
            // tBEndPosHex
            // 
            this.tBEndPosHex.Location = new System.Drawing.Point(196, 111);
            this.tBEndPosHex.Name = "tBEndPosHex";
            this.tBEndPosHex.Size = new System.Drawing.Size(100, 20);
            this.tBEndPosHex.TabIndex = 11;
            // 
            // tBLengthDec
            // 
            this.tBLengthDec.Location = new System.Drawing.Point(90, 137);
            this.tBLengthDec.Name = "tBLengthDec";
            this.tBLengthDec.Size = new System.Drawing.Size(100, 20);
            this.tBLengthDec.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Length";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "First Step:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Second Step:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Version: 1.0.0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(279, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "by BerryElectronics";
            // 
            // labelFirmwarePath
            // 
            this.labelFirmwarePath.AutoSize = true;
            this.labelFirmwarePath.Location = new System.Drawing.Point(12, 184);
            this.labelFirmwarePath.Name = "labelFirmwarePath";
            this.labelFirmwarePath.Size = new System.Drawing.Size(16, 13);
            this.labelFirmwarePath.TabIndex = 18;
            this.labelFirmwarePath.Text = "---";
            // 
            // labelPatternPath
            // 
            this.labelPatternPath.AutoSize = true;
            this.labelPatternPath.Location = new System.Drawing.Point(11, 166);
            this.labelPatternPath.Name = "labelPatternPath";
            this.labelPatternPath.Size = new System.Drawing.Size(16, 13);
            this.labelPatternPath.TabIndex = 19;
            this.labelPatternPath.Text = "---";
            // 
            // buttonCopyStartHex
            // 
            this.buttonCopyStartHex.Location = new System.Drawing.Point(302, 83);
            this.buttonCopyStartHex.Name = "buttonCopyStartHex";
            this.buttonCopyStartHex.Size = new System.Drawing.Size(75, 23);
            this.buttonCopyStartHex.TabIndex = 20;
            this.buttonCopyStartHex.Text = "Copy Hex";
            this.buttonCopyStartHex.UseVisualStyleBackColor = true;
            this.buttonCopyStartHex.Click += new System.EventHandler(this.buttonCopyStartHex_Click);
            // 
            // buttonCopyEndHex
            // 
            this.buttonCopyEndHex.Location = new System.Drawing.Point(302, 109);
            this.buttonCopyEndHex.Name = "buttonCopyEndHex";
            this.buttonCopyEndHex.Size = new System.Drawing.Size(75, 23);
            this.buttonCopyEndHex.TabIndex = 21;
            this.buttonCopyEndHex.Text = "Copy Hex";
            this.buttonCopyEndHex.UseVisualStyleBackColor = true;
            this.buttonCopyEndHex.Click += new System.EventHandler(this.buttonCopyEndHex_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 227);
            this.Controls.Add(this.buttonCopyEndHex);
            this.Controls.Add(this.buttonCopyStartHex);
            this.Controls.Add(this.labelPatternPath);
            this.Controls.Add(this.labelFirmwarePath);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBLengthDec);
            this.Controls.Add(this.tBEndPosHex);
            this.Controls.Add(this.buttonSearchPattern);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBStartPosHex);
            this.Controls.Add(this.tBLengthHex);
            this.Controls.Add(this.tBStartPosDec);
            this.Controls.Add(this.tBEndPosDec);
            this.Controls.Add(this.buttonLoadFirmware);
            this.Controls.Add(this.buttonLoadPattern);
            this.Name = "Form1";
            this.Text = "Mi Band 2 FW Pattern Searcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openPattern;
        private System.Windows.Forms.OpenFileDialog openFirmware;
        private System.Windows.Forms.Button buttonLoadPattern;
        private System.Windows.Forms.Button buttonLoadFirmware;
        private System.Windows.Forms.TextBox tBEndPosDec;
        private System.Windows.Forms.TextBox tBStartPosDec;
        private System.Windows.Forms.TextBox tBLengthHex;
        private System.Windows.Forms.TextBox tBStartPosHex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSearchPattern;
        private System.Windows.Forms.TextBox tBEndPosHex;
        private System.Windows.Forms.TextBox tBLengthDec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelFirmwarePath;
        private System.Windows.Forms.Label labelPatternPath;
        private System.Windows.Forms.Button buttonCopyStartHex;
        private System.Windows.Forms.Button buttonCopyEndHex;
    }
}

