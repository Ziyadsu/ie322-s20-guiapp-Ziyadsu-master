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
    public partial class FrmRadio : Form
    {
        public FrmRadio()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (RadRed2.Checked == true)
            RadRed2.ForeColor = Color.FromName("Red");
            else
            RadRed2.ForeColor = Color.FromName("Black");
        }

        private void RadGreen2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadGreen2.Checked == true)
            RadGreen2.ForeColor = Color.FromName("Green");
            else
            RadGreen2.ForeColor = Color.FromName("Black");
        }

        private void RadBlue2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadBlue2.Checked == true)
            RadBlue2.ForeColor = Color.FromName("Blue");
            else
            RadBlue2.ForeColor = Color.FromName("Black");
        }

        private void RadYellow2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadYellow2.Checked == true)
            RadYellow2.ForeColor = Color.FromName("Yellow");
            else
            RadYellow2.ForeColor = Color.FromName("Black");

        }

        private void BtnRest_Click(object sender, EventArgs e)
        {
            RadRed2.Checked = false;
            RadGreen2.Checked = false;
            RadBlue2.Checked = false;
            RadYellow2.Checked = false;


            RadGreen2.ForeColor = Color.FromName("Black");
            RadRed2.ForeColor = Color.FromName("Black");
            RadYellow2.ForeColor = Color.FromName("Black");
            RadBlue2.ForeColor = Color.FromName("Black");
        }

        private void FrmRadio_Load(object sender, EventArgs e)
        {

        }
    }
}
