namespace Ziyad_IE322_1st
{
    partial class FrmCombo
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
            this.BtnShow = new System.Windows.Forms.Button();
            this.BtnShow2 = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnRemove2 = new System.Windows.Forms.Button();
            this.BtnRemove3 = new System.Windows.Forms.Button();
            this.BtnRemove4 = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.cmbDays = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(61, 49);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(127, 60);
            this.BtnShow.TabIndex = 0;
            this.BtnShow.Text = "show Selected Method1";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // BtnShow2
            // 
            this.BtnShow2.Location = new System.Drawing.Point(240, 49);
            this.BtnShow2.Name = "BtnShow2";
            this.BtnShow2.Size = new System.Drawing.Size(127, 60);
            this.BtnShow2.TabIndex = 1;
            this.BtnShow2.Text = "Show Selected Method2";
            this.BtnShow2.UseVisualStyleBackColor = true;
            this.BtnShow2.Click += new System.EventHandler(this.BtnShow2_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(666, 49);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(169, 60);
            this.BtnRemove.TabIndex = 2;
            this.BtnRemove.Text = "Remove last item";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnRemove2
            // 
            this.BtnRemove2.Location = new System.Drawing.Point(666, 192);
            this.BtnRemove2.Name = "BtnRemove2";
            this.BtnRemove2.Size = new System.Drawing.Size(169, 60);
            this.BtnRemove2.TabIndex = 3;
            this.BtnRemove2.Text = "Remove 2nd last item";
            this.BtnRemove2.UseVisualStyleBackColor = true;
            this.BtnRemove2.Click += new System.EventHandler(this.BtnRemove2_Click);
            // 
            // BtnRemove3
            // 
            this.BtnRemove3.Location = new System.Drawing.Point(61, 349);
            this.BtnRemove3.Name = "BtnRemove3";
            this.BtnRemove3.Size = new System.Drawing.Size(117, 60);
            this.BtnRemove3.TabIndex = 4;
            this.BtnRemove3.Text = "Remove by Index";
            this.BtnRemove3.UseVisualStyleBackColor = true;
            this.BtnRemove3.Click += new System.EventHandler(this.BtnRemove3_Click);
            // 
            // BtnRemove4
            // 
            this.BtnRemove4.Location = new System.Drawing.Point(240, 349);
            this.BtnRemove4.Name = "BtnRemove4";
            this.BtnRemove4.Size = new System.Drawing.Size(117, 60);
            this.BtnRemove4.TabIndex = 5;
            this.BtnRemove4.Text = "Remove by Name";
            this.BtnRemove4.UseVisualStyleBackColor = true;
            this.BtnRemove4.Click += new System.EventHandler(this.BtnRemove4_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(666, 385);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(152, 46);
            this.BtnBack.TabIndex = 6;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // cmbDays
            // 
            this.cmbDays.FormattingEnabled = true;
            this.cmbDays.Location = new System.Drawing.Point(102, 174);
            this.cmbDays.Name = "cmbDays";
            this.cmbDays.Size = new System.Drawing.Size(170, 27);
            this.cmbDays.TabIndex = 7;
            // 
            // FrmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 459);
            this.Controls.Add(this.cmbDays);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnRemove4);
            this.Controls.Add(this.BtnRemove3);
            this.Controls.Add(this.BtnRemove2);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnShow2);
            this.Controls.Add(this.BtnShow);
            this.Name = "FrmCombo";
            this.Text = "FrmCombo";
            this.Load += new System.EventHandler(this.FrmCombo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.Button BtnShow2;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnRemove2;
        private System.Windows.Forms.Button BtnRemove3;
        private System.Windows.Forms.Button BtnRemove4;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.ComboBox cmbDays;
    }
}