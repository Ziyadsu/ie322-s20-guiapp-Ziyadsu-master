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
    public partial class FrmPictur : Form
    {
        public FrmPictur()
        {
            InitializeComponent();
            
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            PicTry.Image = Image.FromFile("D:\\IE322_1847496\\Ziyad_IE322_1st\\C#Pic.png");
        }

        private void FrmPictur_Load(object sender, EventArgs e)
        {

        }
    }
}
