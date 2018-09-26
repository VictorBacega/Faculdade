using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMetodos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void somar()
        {
            MessageBox.Show("A soma é: "+(int.Parse(txtN1.Text) + Convert.ToInt32(txtN2.Text)));
        }

        public void somar2(int n1, int n2)
        {
            MessageBox.Show("A soma é: " + (n1 + n2));
        }

        public void subtrair(int n1, int n2)
        {
            MessageBox.Show("A soma é: " + (n1 - n2));
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            //somar();
            somar2(int.Parse(txtN1.Text), int.Parse(txtN2.Text));
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            subtrair(int.Parse(txtN1.Text), int.Parse(txtN2.Text));
        }


    }
}
