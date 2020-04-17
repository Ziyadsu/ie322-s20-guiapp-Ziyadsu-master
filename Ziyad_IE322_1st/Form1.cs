using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ziyad_IE322_1st
{
   
    public partial class Form1 : Form
    {
        string username = "Ziyad";
        int attempt = 1;
        int MaxAttempts = 3;
        bool loggedIn = false;
        public Form1()
        {
            
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            

            

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }





        private void BtnRancom_Click(object sender, EventArgs e)
        {
            FrmRandomCombo frm = new FrmRandomCombo();
            frm.ShowDialog();
        }

        private void BtnTimer_Click(object sender, EventArgs e)
        {

        }

        private void BtnProg_Click(object sender, EventArgs e)
        {

        }

        private void BtnRan_Click(object sender, EventArgs e)
        {
            FrmRandom frm = new FrmRandom();
            frm.ShowDialog();
        }

        private void BtnSelf_Click(object sender, EventArgs e)
        {

        }

        private void BtnLog_Click(object sender, EventArgs e)
        {

            if (! loggedIn)

            while (attempt<=MaxAttempts)
            {
                
                if (TxtUser.Text!=username)
                {
                    MessageBox.Show("Incorrect Username, "+(MaxAttempts-attempt)+" attempts remaining");
                    attempt=attempt+1;
                        TxtUser.Text = "";
                        TxtPW.Text = "";

                    return;

                }
                else
                {
                    if(TxtPW.Text!="123")
                    {
                        MessageBox.Show("Inorrect password, "+(MaxAttempts - attempt)+" attempts remaining");
                            attempt++;
                            TxtPW.Text = "";
                        return;

                             
                    }
                    else
                    {
                            attempt = 1;
                            loggedIn = true;
                        MessageBox.Show("Hi " + username + ", login successful");
                        BtnLog.Text = "Logout";
                        
                        break;


                    }
                }
            }
        }

        private void BtnRad_Click(object sender, EventArgs e)
        {
            FrmRadio frm = new FrmRadio();
            frm.ShowDialog();

        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            FrmCheck frm = new FrmCheck();
            frm.ShowDialog();
        }

        private void BtnCombo_Click(object sender, EventArgs e)
        {
            FrmCombo frm = new FrmCombo();
            frm.ShowDialog();
        }

        private void BtnPic1_Click(object sender, EventArgs e)
        {
            FrmPictur frm = new FrmPictur();
            frm.ShowDialog();

        }

        private void BtnArray_Click(object sender, EventArgs e)
        {
            
        }
    }
}
