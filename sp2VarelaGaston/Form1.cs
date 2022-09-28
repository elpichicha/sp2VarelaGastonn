using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sp2VarelaGaston
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CMBtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CMBtipo.SelectedIndex !=-1)
            {
                CMBpersonas.Enabled = true;

            }
        }

        private void CMBpersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CMBpersonas.SelectedIndex !=-1)

            {
                CMBdias.Enabled = true;
            }
        }

        private void MRCadicionales_Enter(object sender, EventArgs e)
        {
            if (CMBdias.SelectedIndex !=-1)
            {
                MRCadicionales.Enabled = true;
            }
        }

        private void CMBdias_SelectedIndexChanged(object sender, EventArgs e)
        {
            MRCforma.Enabled = true;
            MRCadicionales.Enabled = true;
        }

        private void MRCforma_Enter(object sender, EventArgs e)
        {
            
        }

        private void OPTefe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            {

            }
        }
    }
}
