using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace koncerjegy_20240917
{
    public partial class form : Form
    {
        private void szamolas()
        {
            int ulomenny = cbulo.SelectedIndex;
            int allomenny = cballo.SelectedIndex;
            int osszeg = 0;
            int osszeg2 = 0;
            if (rbulo1.Checked)
            {
                osszeg = ulomenny*1990;
            }
            else
            {
                osszeg = ulomenny * 2990 ;

            }
            if (rballo1.Checked)
            {
                osszeg2 = allomenny * 1490;
            }
            else
            {
                osszeg2 = allomenny * 2190;
            }
            int fizetendo = osszeg + osszeg2;
            kiiratas.Text = "Fizetendő: " + fizetendo.ToString() + " Ft";
        }
        public form()
        {
            InitializeComponent();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            szamolas();
        }

        private void kilépésToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void rbulo1_CheckedChanged(object sender, EventArgs e)
        {
            szamolas();
        }

        private void rbulo2_CheckedChanged(object sender, EventArgs e)
        {
            szamolas();
        }

        private void rballo1_CheckedChanged(object sender, EventArgs e)
        {
            szamolas();
        }

        private void rballo2_CheckedChanged(object sender, EventArgs e)
        {
            szamolas();
        }

        private void cballo_SelectedIndexChanged(object sender, EventArgs e)
        {
            szamolas();
        }

        private void újVásárlásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbulo1.Checked = true;
            rballo1.Checked = true;
            cballo.SelectedIndex = 0;
            cbulo.SelectedIndex = 0;
            szamolas();
        }

        private void form_Load(object sender, EventArgs e)
        {
            rbulo1.Checked = true;
            rballo1.Checked = true;
            cballo.SelectedIndex = 0;
            cbulo.SelectedIndex = 0;
            szamolas();
        }
    }
}
