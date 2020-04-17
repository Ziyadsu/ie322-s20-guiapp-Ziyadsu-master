namespace Ziyad_IE322_1st
{
    partial class FrmRandomCombo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbRanom = new System.Windows.Forms.ComboBox();
            this.BtnGen1 = new System.Windows.Forms.Button();
            this.RadBtnLe500 = new System.Windows.Forms.RadioButton();
            this.RadBtnGre500 = new System.Windows.Forms.RadioButton();
            this.BtnRe1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.BtnGen2 = new System.Windows.Forms.Button();
            this.RadBtnLes50 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.BtnRes2 = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.LabCount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnRe1);
            this.groupBox1.Controls.Add(this.RadBtnGre500);
            this.groupBox1.Controls.Add(this.RadBtnLe500);
            this.groupBox1.Controls.Add(this.BtnGen1);
            this.groupBox1.Controls.Add(this.CmbRanom);
            this.groupBox1.Location = new System.Drawing.Point(55, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 313);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quiz3_AAF19";
            // 
            // CmbRanom
            // 
            this.CmbRanom.FormattingEnabled = true;
            this.CmbRanom.Location = new System.Drawing.Point(30, 65);
            this.CmbRanom.Name = "CmbRanom";
            this.CmbRanom.Size = new System.Drawing.Size(121, 27);
            this.CmbRanom.TabIndex = 0;
            // 
            // BtnGen1
            // 
            this.BtnGen1.Location = new System.Drawing.Point(191, 57);
            this.BtnGen1.Name = "BtnGen1";
            this.BtnGen1.Size = new System.Drawing.Size(106, 40);
            this.BtnGen1.TabIndex = 1;
            this.BtnGen1.Text = "Generate";
            this.BtnGen1.UseVisualStyleBackColor = true;
            this.BtnGen1.Click += new System.EventHandler(this.BtnGen1_Click);
            // 
            // RadBtnLe500
            // 
            this.RadBtnLe500.AutoSize = true;
            this.RadBtnLe500.Location = new System.Drawing.Point(172, 136);
            this.RadBtnLe500.Name = "RadBtnLe500";
            this.RadBtnLe500.Size = new System.Drawing.Size(132, 23);
            this.RadBtnLe500.TabIndex = 2;
            this.RadBtnLe500.TabStop = true;
            this.RadBtnLe500.Text = "Less than 500";
            this.RadBtnLe500.UseVisualStyleBackColor = true;
            // 
            // RadBtnGre500
            // 
            this.RadBtnGre500.AutoSize = true;
            this.RadBtnGre500.Location = new System.Drawing.Point(172, 194);
            this.RadBtnGre500.Name = "RadBtnGre500";
            this.RadBtnGre500.Size = new System.Drawing.Size(154, 23);
            this.RadBtnGre500.TabIndex = 3;
            this.RadBtnGre500.TabStop = true;
            this.RadBtnGre500.Text = "Greater than 500";
            this.RadBtnGre500.UseVisualStyleBackColor = true;
            this.RadBtnGre500.CheckedChanged += new System.EventHandler(this.RadBtnGre500_CheckedChanged);
            // 
            // BtnRe1
            // 
            this.BtnRe1.Location = new System.Drawing.Point(191, 262);
            this.BtnRe1.Name = "BtnRe1";
            this.BtnRe1.Size = new System.Drawing.Size(106, 40);
            this.BtnRe1.TabIndex = 4;
            this.BtnRe1.Text = "Reset";
            this.BtnRe1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LabCount);
            this.groupBox2.Controls.Add(this.BtnRes2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.RadBtnLes50);
            this.groupBox2.Controls.Add(this.BtnGen2);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Location = new System.Drawing.Point(557, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 313);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quiz3_EAF19";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(26, 70);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 27);
            this.comboBox2.TabIndex = 0;
            // 
            // BtnGen2
            // 
            this.BtnGen2.Location = new System.Drawing.Point(205, 71);
            this.BtnGen2.Name = "BtnGen2";
            this.BtnGen2.Size = new System.Drawing.Size(89, 37);
            this.BtnGen2.TabIndex = 1;
            this.BtnGen2.Text = "Generate";
            this.BtnGen2.UseVisualStyleBackColor = true;
            // 
            // RadBtnLes50
            // 
            this.RadBtnLes50.AutoSize = true;
            this.RadBtnLes50.Location = new System.Drawing.Point(191, 152);
            this.RadBtnLes50.Name = "RadBtnLes50";
            this.RadBtnLes50.Size = new System.Drawing.Size(123, 23);
            this.RadBtnLes50.TabIndex = 2;
            this.RadBtnLes50.TabStop = true;
            this.RadBtnLes50.Text = "Less than 50";
            this.RadBtnLes50.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(191, 221);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(145, 23);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Greater than 50";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // BtnRes2
            // 
            this.BtnRes2.Location = new System.Drawing.Point(191, 262);
            this.BtnRes2.Name = "BtnRes2";
            this.BtnRes2.Size = new System.Drawing.Size(123, 39);
            this.BtnRes2.TabIndex = 4;
            this.BtnRes2.Text = "Reset";
            this.BtnRes2.UseVisualStyleBackColor = true;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(616, 438);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(187, 49);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // LabCount
            // 
            this.LabCount.AutoSize = true;
            this.LabCount.Location = new System.Drawing.Point(26, 122);
            this.LabCount.Name = "LabCount";
            this.LabCount.Size = new System.Drawing.Size(51, 19);
            this.LabCount.TabIndex = 5;
            this.LabCount.Text = "Count";
            // 
            // FrmRandomCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 513);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRandomCombo";
            this.Text = "FrmRandomCombo";
            this.Load += new System.EventHandler(this.FrmRandomCombo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadBtnGre500;
        private System.Windows.Forms.RadioButton RadBtnLe500;
        private System.Windows.Forms.Button BtnGen1;
        private System.Windows.Forms.ComboBox CmbRanom;
        private System.Windows.Forms.Button BtnRe1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnRes2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton RadBtnLes50;
        private System.Windows.Forms.Button BtnGen2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label LabCount;
    }
}