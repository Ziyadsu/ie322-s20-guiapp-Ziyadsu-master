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
    
    public partial class FrmRandom : Form
       
    {
        Random y = new Random();

        public FrmRandom()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FrmRandom_Load(object sender, EventArgs e)
        {

        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            BtnRandom.Text = Convert.ToString(y.Next(1, 10));
        }

        private void BtnGenrate_Click(object sender, EventArgs e)
        {
            int r = y.Next(0, 255);
            int g = y.Next(0, 255);
            int b = y.Next(0, 255);

            LabelR.Text = Convert.ToString(r)+"-"+Convert.ToString(g)+"-"+Convert.ToString(b);
            BtnGenrate.BackColor=Color.FromArgb(r, g, b);
            this.BackColor = Color.FromArgb(r, g, b);
        }

        private void LabelR_Click(object sender, EventArgs e)
        {
            
        }
    }
}
