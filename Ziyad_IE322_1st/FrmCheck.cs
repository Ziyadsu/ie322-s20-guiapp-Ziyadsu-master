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
    public partial class FrmCheck : Form
    {
        public FrmCheck()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {

            string msg = "";

            if (ChCoffee.Checked == true)
            {
                msg = ChCoffee.Text;

            }
            if (ChDount.Checked == true)
            {
                msg = msg + " " + ChDount.Text;
            }
            if (ChBro.Checked == true)
            {
                msg = msg + " " + ChBro.Text;
            }
            if (msg.Length ==0)
            {
                msg = ("Nothing");
                
            }
            MessageBox.Show(msg + " ordered.");

        }
    }
}
