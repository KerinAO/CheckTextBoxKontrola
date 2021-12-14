using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            txtIspis.Clear();
            txtIspis.AppendText("Odabrali ste:" + Environment.NewLine);
            if (chkDorucak.Checked)
            {
                txtIspis.AppendText(chkDorucak.Text + Environment.NewLine);
            }
            if (chkRucak.Checked)
            {
                txtIspis.AppendText(chkRucak.Text + Environment.NewLine);
            }
            if (chkVecera.Checked)
            {
                txtIspis.AppendText(chkVecera.Text);
            }
        }

        private void chkSakrij_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSakrij.Checked)
            {
                txtIspis.Hide();
            }
            else
            {
                txtIspis.Show();
            }
        }
    }
}
