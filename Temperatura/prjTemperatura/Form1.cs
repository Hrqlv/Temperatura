using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjTemperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            if (rbFromC.Checked && rbToK.Checked)
            {
                double c = Double.Parse(txtTemperatura.Text);
                double k = c + 273.15;
                lbResposta.Text = k + " Kelvin ";
            }
            if (rbFromK.Checked && rbToC.Checked)
            {
                double k = Double.Parse(txtTemperatura.Text);
                double c = k - 273.15;
                lbResposta.Text = c + "Celsius";
            }
            if (rbFromC.Checked && rbToF.Checked)
            {
                double c = double.Parse(txtTemperatura.Text);
                double f = c * 1.8 + 32;
                lbResposta.Text = f + "Fahreinheit";
            }
            if (rbFromF.Checked && rbToC.Checked)
            {
                double f = Double.Parse(txtTemperatura.Text);
                double c = f / 1.8 - 32;
                lbResposta.Text = c.ToString("N2") + "Celsius";
            }
            if (rbFromF.Checked && rbToK.Checked)
            {
                double f = Double.Parse(txtTemperatura.Text);
                double k = (f - 32) / 1.8 + 273.15;
                lbResposta.Text = k + "Kevin";
            }
            if (rbFromK.Checked && rbToF.Checked)
            {
                double k = Double.Parse(txtTemperatura.Text);
                double f = k * 1.8 - 459.67;
                lbResposta.Text = f + "Fahrenheit";

            }
        }
    }
}

