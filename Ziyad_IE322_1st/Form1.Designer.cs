namespace Ziyad_IE322_1st
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnLog = new System.Windows.Forms.Button();
            this.LabPW = new System.Windows.Forms.Label();
            this.LabUser = new System.Windows.Forms.Label();
            this.TxtPW = new System.Windows.Forms.TextBox();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnCombo = new System.Windows.Forms.Button();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.BtnRad = new System.Windows.Forms.Button();
            this.Graphical = new System.Windows.Forms.GroupBox();
            this.BtnGroup = new System.Windows.Forms.Button();
            this.BtnPic2 = new System.Windows.Forms.Button();
            this.BtnSelf = new System.Windows.Forms.Button();
            this.BtnPic1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnRancom = new System.Windows.Forms.Button();
            this.BtnRan = new System.Windows.Forms.Button();
            this.BtnTimer = new System.Windows.Forms.Button();
            this.BtnProg = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnTalk = new System.Windows.Forms.Button();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BtnJoh = new System.Windows.Forms.Button();
            this.BtnABC = new System.Windows.Forms.Button();
            this.BtnRob = new System.Windows.Forms.Button();
            this.BtnMan = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnArd = new System.Windows.Forms.Button();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.BtnArray = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Graphical.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.Location = new System.Drawing.Point(261, 514);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(208, 63);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Controls.Add(this.BtnLog);
            this.groupBox1.Controls.Add(this.LabPW);
            this.groupBox1.Controls.Add(this.LabUser);
            this.groupBox1.Controls.Add(this.TxtPW);
            this.groupBox1.Controls.Add(this.TxtUser);
            this.groupBox1.Location = new System.Drawing.Point(22, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 183);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Signin";
            // 
            // BtnLog
            // 
            this.BtnLog.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnLog.Location = new System.Drawing.Point(146, 129);
            this.BtnLog.Name = "BtnLog";
            this.BtnLog.Size = new System.Drawing.Size(100, 34);
            this.BtnLog.TabIndex = 2;
            this.BtnLog.Text = "Login";
            this.BtnLog.UseVisualStyleBackColor = true;
            this.BtnLog.Click += new System.EventHandler(this.BtnLog_Click);
            // 
            // LabPW
            // 
            this.LabPW.AutoSize = true;
            this.LabPW.Location = new System.Drawing.Point(74, 88);
            this.LabPW.Name = "LabPW";
            this.LabPW.Size = new System.Drawing.Size(76, 19);
            this.LabPW.TabIndex = 3;
            this.LabPW.Text = "Password";
            // 
            // LabUser
            // 
            this.LabUser.AutoSize = true;
            this.LabUser.Location = new System.Drawing.Point(74, 34);
            this.LabUser.Name = "LabUser";
            this.LabUser.Size = new System.Drawing.Size(82, 19);
            this.LabUser.TabIndex = 2;
            this.LabUser.Text = "UserName";
            // 
            // TxtPW
            // 
            this.TxtPW.Location = new System.Drawing.Point(214, 80);
            this.TxtPW.Name = "TxtPW";
            this.TxtPW.PasswordChar = '*';
            this.TxtPW.Size = new System.Drawing.Size(120, 27);
            this.TxtPW.TabIndex = 1;
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(214, 26);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(120, 27);
            this.TxtUser.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.BtnCombo);
            this.groupBox2.Controls.Add(this.BtnCheck);
            this.groupBox2.Controls.Add(this.BtnRad);
            this.groupBox2.Location = new System.Drawing.Point(460, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 129);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic Contorls";
            // 
            // BtnCombo
            // 
            this.BtnCombo.Location = new System.Drawing.Point(92, 75);
            this.BtnCombo.Name = "BtnCombo";
            this.BtnCombo.Size = new System.Drawing.Size(75, 28);
            this.BtnCombo.TabIndex = 2;
            this.BtnCombo.Text = "Combo";
            this.BtnCombo.UseVisualStyleBackColor = true;
            this.BtnCombo.Click += new System.EventHandler(this.BtnCombo_Click);
            // 
            // BtnCheck
            // 
            this.BtnCheck.Location = new System.Drawing.Point(152, 26);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(75, 28);
            this.BtnCheck.TabIndex = 1;
            this.BtnCheck.Text = "CheckBox";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // BtnRad
            // 
            this.BtnRad.Location = new System.Drawing.Point(22, 26);
            this.BtnRad.Name = "BtnRad";
            this.BtnRad.Size = new System.Drawing.Size(75, 28);
            this.BtnRad.TabIndex = 0;
            this.BtnRad.Text = "Radio";
            this.BtnRad.UseVisualStyleBackColor = true;
            this.BtnRad.Click += new System.EventHandler(this.BtnRad_Click);
            // 
            // Graphical
            // 
            this.Graphical.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Graphical.Controls.Add(this.BtnGroup);
            this.Graphical.Controls.Add(this.BtnPic2);
            this.Graphical.Controls.Add(this.BtnSelf);
            this.Graphical.Controls.Add(this.BtnPic1);
            this.Graphical.Location = new System.Drawing.Point(356, 251);
            this.Graphical.Name = "Graphical";
            this.Graphical.Size = new System.Drawing.Size(273, 175);
            this.Graphical.TabIndex = 3;
            this.Graphical.TabStop = false;
            this.Graphical.Text = "Graphical";
            // 
            // BtnGroup
            // 
            this.BtnGroup.Location = new System.Drawing.Point(152, 110);
            this.BtnGroup.Name = "BtnGroup";
            this.BtnGroup.Size = new System.Drawing.Size(111, 37);
            this.BtnGroup.TabIndex = 3;
            this.BtnGroup.Text = "Groupie App";
            this.BtnGroup.UseVisualStyleBackColor = true;
            // 
            // BtnPic2
            // 
            this.BtnPic2.Location = new System.Drawing.Point(22, 110);
            this.BtnPic2.Name = "BtnPic2";
            this.BtnPic2.Size = new System.Drawing.Size(111, 37);
            this.BtnPic2.TabIndex = 2;
            this.BtnPic2.Text = "PictureBox2";
            this.BtnPic2.UseVisualStyleBackColor = true;
            // 
            // BtnSelf
            // 
            this.BtnSelf.Location = new System.Drawing.Point(152, 42);
            this.BtnSelf.Name = "BtnSelf";
            this.BtnSelf.Size = new System.Drawing.Size(111, 37);
            this.BtnSelf.TabIndex = 1;
            this.BtnSelf.Text = "SelfieApp";
            this.BtnSelf.UseVisualStyleBackColor = true;
            this.BtnSelf.Click += new System.EventHandler(this.BtnSelf_Click);
            // 
            // BtnPic1
            // 
            this.BtnPic1.Location = new System.Drawing.Point(22, 42);
            this.BtnPic1.Name = "BtnPic1";
            this.BtnPic1.Size = new System.Drawing.Size(111, 37);
            this.BtnPic1.TabIndex = 0;
            this.BtnPic1.Text = "PictureBox";
            this.BtnPic1.UseVisualStyleBackColor = true;
            this.BtnPic1.Click += new System.EventHandler(this.BtnPic1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.BtnRancom);
            this.groupBox3.Controls.Add(this.BtnRan);
            this.groupBox3.Controls.Add(this.BtnTimer);
            this.groupBox3.Controls.Add(this.BtnProg);
            this.groupBox3.Location = new System.Drawing.Point(39, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 175);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "More Contorls";
            // 
            // BtnRancom
            // 
            this.BtnRancom.Location = new System.Drawing.Point(141, 110);
            this.BtnRancom.Name = "BtnRancom";
            this.BtnRancom.Size = new System.Drawing.Size(111, 37);
            this.BtnRancom.TabIndex = 3;
            this.BtnRancom.Text = "RandomCom";
            this.BtnRancom.UseVisualStyleBackColor = true;
            this.BtnRancom.Click += new System.EventHandler(this.BtnRancom_Click);
            // 
            // BtnRan
            // 
            this.BtnRan.Location = new System.Drawing.Point(6, 110);
            this.BtnRan.Name = "BtnRan";
            this.BtnRan.Size = new System.Drawing.Size(111, 37);
            this.BtnRan.TabIndex = 2;
            this.BtnRan.Text = "Random";
            this.BtnRan.UseVisualStyleBackColor = true;
            this.BtnRan.Click += new System.EventHandler(this.BtnRan_Click);
            // 
            // BtnTimer
            // 
            this.BtnTimer.Location = new System.Drawing.Point(144, 42);
            this.BtnTimer.Name = "BtnTimer";
            this.BtnTimer.Size = new System.Drawing.Size(111, 37);
            this.BtnTimer.TabIndex = 1;
            this.BtnTimer.Text = "Timer";
            this.BtnTimer.UseVisualStyleBackColor = true;
            this.BtnTimer.Click += new System.EventHandler(this.BtnTimer_Click);
            // 
            // BtnProg
            // 
            this.BtnProg.Location = new System.Drawing.Point(6, 42);
            this.BtnProg.Name = "BtnProg";
            this.BtnProg.Size = new System.Drawing.Size(111, 37);
            this.BtnProg.TabIndex = 0;
            this.BtnProg.Text = "Progress";
            this.BtnProg.UseVisualStyleBackColor = true;
            this.BtnProg.Click += new System.EventHandler(this.BtnProg_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox4.Controls.Add(this.BtnTalk);
            this.groupBox4.Controls.Add(this.BtnDraw);
            this.groupBox4.Location = new System.Drawing.Point(1026, 177);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(213, 99);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Draw and Talk";
            // 
            // BtnTalk
            // 
            this.BtnTalk.Location = new System.Drawing.Point(117, 39);
            this.BtnTalk.Name = "BtnTalk";
            this.BtnTalk.Size = new System.Drawing.Size(76, 45);
            this.BtnTalk.TabIndex = 1;
            this.BtnTalk.Text = "Talk";
            this.BtnTalk.UseVisualStyleBackColor = true;
            // 
            // BtnDraw
            // 
            this.BtnDraw.Location = new System.Drawing.Point(16, 39);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(76, 45);
            this.BtnDraw.TabIndex = 0;
            this.BtnDraw.Text = "Draw";
            this.BtnDraw.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox5.Controls.Add(this.BtnJoh);
            this.groupBox5.Controls.Add(this.BtnABC);
            this.groupBox5.Controls.Add(this.BtnRob);
            this.groupBox5.Controls.Add(this.BtnMan);
            this.groupBox5.Location = new System.Drawing.Point(760, 38);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(244, 360);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Exam Apps";
            // 
            // BtnJoh
            // 
            this.BtnJoh.Location = new System.Drawing.Point(62, 297);
            this.BtnJoh.Name = "BtnJoh";
            this.BtnJoh.Size = new System.Drawing.Size(132, 35);
            this.BtnJoh.TabIndex = 3;
            this.BtnJoh.Text = "Johri";
            this.BtnJoh.UseVisualStyleBackColor = true;
            // 
            // BtnABC
            // 
            this.BtnABC.Location = new System.Drawing.Point(62, 213);
            this.BtnABC.Name = "BtnABC";
            this.BtnABC.Size = new System.Drawing.Size(132, 35);
            this.BtnABC.TabIndex = 2;
            this.BtnABC.Text = "ABC Analysis";
            this.BtnABC.UseVisualStyleBackColor = true;
            // 
            // BtnRob
            // 
            this.BtnRob.Location = new System.Drawing.Point(62, 132);
            this.BtnRob.Name = "BtnRob";
            this.BtnRob.Size = new System.Drawing.Size(132, 35);
            this.BtnRob.TabIndex = 1;
            this.BtnRob.Text = "Robtic Cell";
            this.BtnRob.UseVisualStyleBackColor = true;
            // 
            // BtnMan
            // 
            this.BtnMan.Location = new System.Drawing.Point(62, 57);
            this.BtnMan.Name = "BtnMan";
            this.BtnMan.Size = new System.Drawing.Size(132, 35);
            this.BtnMan.TabIndex = 0;
            this.BtnMan.Text = "Manufacturing Cell";
            this.BtnMan.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox6.Controls.Add(this.BtnArd);
            this.groupBox6.Location = new System.Drawing.Point(1026, 48);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(213, 99);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "More Control";
            // 
            // BtnArd
            // 
            this.BtnArd.Location = new System.Drawing.Point(38, 39);
            this.BtnArd.Name = "BtnArd";
            this.BtnArd.Size = new System.Drawing.Size(132, 38);
            this.BtnArd.TabIndex = 0;
            this.BtnArd.Text = "Arduino";
            this.BtnArd.UseVisualStyleBackColor = true;
            // 
            // BtnAbout
            // 
            this.BtnAbout.Image = ((System.Drawing.Image)(resources.GetObject("BtnAbout.Image")));
            this.BtnAbout.Location = new System.Drawing.Point(22, 513);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(208, 63);
            this.BtnAbout.TabIndex = 8;
            this.BtnAbout.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox7.Controls.Add(this.BtnArray);
            this.groupBox7.Controls.Add(this.button1);
            this.groupBox7.Controls.Add(this.button2);
            this.groupBox7.Controls.Add(this.button3);
            this.groupBox7.Controls.Add(this.button4);
            this.groupBox7.Location = new System.Drawing.Point(760, 38);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(244, 457);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Exam Apps";
            // 
            // BtnArray
            // 
            this.BtnArray.Location = new System.Drawing.Point(62, 367);
            this.BtnArray.Name = "BtnArray";
            this.BtnArray.Size = new System.Drawing.Size(127, 37);
            this.BtnArray.TabIndex = 4;
            this.BtnArray.Text = "Arrays";
            this.BtnArray.UseVisualStyleBackColor = true;
            this.BtnArray.Click += new System.EventHandler(this.BtnArray_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Johri";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(62, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "ABC Analysis";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(62, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 35);
            this.button3.TabIndex = 1;
            this.button3.Text = "Robtic Cell";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(62, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 35);
            this.button4.TabIndex = 0;
            this.button4.Text = "Manufacturing Cell";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1260, 601);
            this.Controls.Add(this.BtnAbout);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Graphical);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnExit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.Graphical.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabPW;
        private System.Windows.Forms.Label LabUser;
        private System.Windows.Forms.TextBox TxtPW;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.Button BtnLog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnCombo;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Button BtnRad;
        private System.Windows.Forms.GroupBox Graphical;
        private System.Windows.Forms.Button BtnGroup;
        private System.Windows.Forms.Button BtnPic2;
        private System.Windows.Forms.Button BtnSelf;
        private System.Windows.Forms.Button BtnPic1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnRancom;
        private System.Windows.Forms.Button BtnRan;
        private System.Windows.Forms.Button BtnTimer;
        private System.Windows.Forms.Button BtnProg;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnTalk;
        private System.Windows.Forms.Button BtnDraw;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BtnJoh;
        private System.Windows.Forms.Button BtnABC;
        private System.Windows.Forms.Button BtnRob;
        private System.Windows.Forms.Button BtnMan;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtnArd;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BtnArray;
        


    }
}

