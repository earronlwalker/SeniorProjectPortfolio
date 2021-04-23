//Program:  Temperature Converter
//Author:   Earron Walker
//Date:     March 17 2021
//Purpose:  This application converts a celsius temperature 
//          into a fahrenheit temperature and vice versa

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_Converter
{
    public partial class frmTempConverter : Form
    {
        public frmTempConverter()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal fahrenheit = ((numTemp.Value - 32) * 5 / 9);
            decimal celsius = ((numTemp.Value * 9 / 5) + 32);
            if (btnCelsius.Checked == true)
                lblOuput.Text = celsius.ToString("0.0") + "F";
         
            else
                lblOuput.Text = fahrenheit.ToString("0.0") + "C";
        }

        private void txtTemp_TextChanged(object sender, EventArgs e)
        {

        }

        private void numTemp_ValueChanged(object sender, EventArgs e)
        {
            if (btnCelsius.Checked == true)
            {
                numTemp.Minimum = -273;
                numTemp.Maximum = decimal.MaxValue;
                lblMin.Text = "Minimum Celsisus Input is -273";
            }
            else
            { 
                numTemp.Minimum = -500;
                numTemp.Maximum = decimal.MaxValue;
                lblMin.Text = "Minimum Fahrenheit Input is -459.4";
            }

            numTemp.DecimalPlaces = 1;
            numTemp.Increment = .1M;
        }



    }
}
