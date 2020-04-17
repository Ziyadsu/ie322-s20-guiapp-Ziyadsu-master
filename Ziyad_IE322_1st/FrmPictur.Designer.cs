namespace Ziyad_IE322_1st
{
    partial class FrmPictur
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
            this.PicTry = new System.Windows.Forms.PictureBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicTry)).BeginInit();
            this.SuspendLayout();
            // 
            // PicTry
            // 
            this.PicTry.Location = new System.Drawing.Point(246, 166);
            this.PicTry.Name = "PicTry";
            this.PicTry.Size = new System.Drawing.Size(308, 167);
            this.PicTry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicTry.TabIndex = 0;
            this.PicTry.TabStop = false;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(545, 374);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(192, 50);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(74, 39);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(179, 86);
            this.BtnLoad.TabIndex = 2;
            this.BtnLoad.Text = "Load Image";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // FrmPictur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.PicTry);
            this.Name = "FrmPictur";
            this.Text = "FrmPictur";
            this.Load += new System.EventHandler(this.FrmPictur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicTry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicTry;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnLoad;
    }
}