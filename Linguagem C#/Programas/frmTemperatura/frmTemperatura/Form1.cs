using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmTemperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double celcToFar(double temp)
        {
            return (temp * 1.8 + 32);
        }
        public double FarToCelc(double temp)
        {
            return ((temp - 32) / 1.8);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {

            if (rbFar.Checked == true)
            { 
                MessageBox.Show("A conversão de: " + txtTemp.Text +"Fº \n Celcius: "+FarToCelc(Double.Parse(txtTemp.Text)).ToString("F")+"Cº");
            }
            else if (rbCelcius.Checked == true)
            {
               MessageBox.Show("A conversão de: " + txtTemp.Text +"Cº \n Celcius: "+celcToFar(Double.Parse(txtTemp.Text)).ToString("F")+"Fº"); 
            }
        }


    }
}
