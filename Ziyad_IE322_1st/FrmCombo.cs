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
    public partial class FrmCombo : Form
    {
        public FrmCombo()
        {
            InitializeComponent();
            cmbDays.Items.Add("Sunday");
            cmbDays.Items.Add("Monday");
            cmbDays.Items.Add("Tuesday");
            cmbDays.Items.Add("Wedensday");
            cmbDays.Items.Add("Thursday");
            cmbDays.Items.Add("Friday");
            cmbDays.Items.Add("Saturday");
            

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FrmCombo_Load(object sender, EventArgs e)
        {

        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbDays.Text);
        }

        private void BtnRemove4_Click(object sender, EventArgs e)
        {
            cmbDays.Items.Remove("Friday");
        }

        private void BtnRemove3_Click(object sender, EventArgs e)
        {
            cmbDays.Items.RemoveAt(1);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (cmbDays.Items.Count>=1)
            {
                cmbDays.Items.RemoveAt(cmbDays.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("Cant remove last item");
            }
        }

        private void BtnRemove2_Click(object sender, EventArgs e)
        {
            if (cmbDays.Items.Count >= 2)
            {
                cmbDays.Items.RemoveAt(cmbDays.Items.Count - 2);
            }
            else
            {
                MessageBox.Show("Cant remove 2nd last item");
            }
        }

        private void BtnShow2_Click(object sender, EventArgs e)
        {
            string Day;
            Day = cmbDays.Text; 
            MessageBox.Show(Day);
        }
    }
}
