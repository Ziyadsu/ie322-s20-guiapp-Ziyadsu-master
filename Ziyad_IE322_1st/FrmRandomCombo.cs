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
    public partial class FrmRandomCombo : Form
    {
        public FrmRandomCombo()
        {
            InitializeComponent();
        }

        private void RadBtnGre500_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FrmRandomCombo_Load(object sender, EventArgs e)
        {

        }

        private void BtnGen1_Click(object sender, EventArgs e)
        {
            CmbRanom.ResetText(); 
            CmbRanom.Items.Clear();//clear the comboBox

            Random r = new Random();
            for (int i=0;i<r.Next(1,50)-1;i++)
            {
                CmbRanom.Items.Add(r.Next(100,999));


            }
        }
    }
}
