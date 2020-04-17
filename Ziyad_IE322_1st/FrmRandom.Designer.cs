namespace Ziyad_IE322_1st
{
    partial class FrmRandom
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
            this.BtnGenrate = new System.Windows.Forms.Button();
            this.BtnRandom = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.LabelR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGenrate
            // 
            this.BtnGenrate.Location = new System.Drawing.Point(101, 42);
            this.BtnGenrate.Name = "BtnGenrate";
            this.BtnGenrate.Size = new System.Drawing.Size(576, 76);
            this.BtnGenrate.TabIndex = 0;
            this.BtnGenrate.Text = "Genrate Random Color";
            this.BtnGenrate.UseVisualStyleBackColor = true;
            this.BtnGenrate.Click += new System.EventHandler(this.BtnGenrate_Click);
            // 
            // BtnRandom
            // 
            this.BtnRandom.Location = new System.Drawing.Point(80, 343);
            this.BtnRandom.Name = "BtnRandom";
            this.BtnRandom.Size = new System.Drawing.Size(169, 35);
            this.BtnRandom.TabIndex = 1;
            this.BtnRandom.Text = "Random Number";
            this.BtnRandom.UseVisualStyleBackColor = true;
            this.BtnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(570, 373);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(168, 46);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // LabelR
            // 
            this.LabelR.AutoSize = true;
            this.LabelR.Location = new System.Drawing.Point(353, 180);
            this.LabelR.Name = "LabelR";
            this.LabelR.Size = new System.Drawing.Size(45, 19);
            this.LabelR.TabIndex = 3;
            this.LabelR.Text = "r-g-b";
            this.LabelR.Click += new System.EventHandler(this.LabelR_Click);
            // 
            // FrmRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelR);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnRandom);
            this.Controls.Add(this.BtnGenrate);
            this.Name = "FrmRandom";
            this.Text = "FrmRandom";
            this.Load += new System.EventHandler(this.FrmRandom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGenrate;
        private System.Windows.Forms.Button BtnRandom;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label LabelR;
    }
}