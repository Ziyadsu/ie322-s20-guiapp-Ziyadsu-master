namespace Ziyad_IE322_1st
{
    partial class FrmCheck
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
            this.ChCoffee = new System.Windows.Forms.CheckBox();
            this.ChDount = new System.Windows.Forms.CheckBox();
            this.ChBro = new System.Windows.Forms.CheckBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(75, 52);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(105, 45);
            this.BtnShow.TabIndex = 0;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // ChCoffee
            // 
            this.ChCoffee.AutoSize = true;
            this.ChCoffee.Location = new System.Drawing.Point(90, 143);
            this.ChCoffee.Name = "ChCoffee";
            this.ChCoffee.Size = new System.Drawing.Size(80, 23);
            this.ChCoffee.TabIndex = 1;
            this.ChCoffee.Text = "Coffee";
            this.ChCoffee.UseVisualStyleBackColor = true;
            // 
            // ChDount
            // 
            this.ChDount.AutoSize = true;
            this.ChDount.Location = new System.Drawing.Point(90, 187);
            this.ChDount.Name = "ChDount";
            this.ChDount.Size = new System.Drawing.Size(78, 23);
            this.ChDount.TabIndex = 2;
            this.ChDount.Text = "Dount";
            this.ChDount.UseVisualStyleBackColor = true;
            // 
            // ChBro
            // 
            this.ChBro.AutoSize = true;
            this.ChBro.Location = new System.Drawing.Point(90, 234);
            this.ChBro.Name = "ChBro";
            this.ChBro.Size = new System.Drawing.Size(99, 23);
            this.ChBro.TabIndex = 3;
            this.ChBro.Text = "Brownise";
            this.ChBro.UseVisualStyleBackColor = true;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(329, 396);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(149, 42);
            this.BtnBack.TabIndex = 4;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // FrmCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.ChBro);
            this.Controls.Add(this.ChDount);
            this.Controls.Add(this.ChCoffee);
            this.Controls.Add(this.BtnShow);
            this.Name = "FrmCheck";
            this.Text = "FrmCheck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.CheckBox ChCoffee;
        private System.Windows.Forms.CheckBox ChDount;
        private System.Windows.Forms.CheckBox ChBro;
        private System.Windows.Forms.Button BtnBack;
    }
}