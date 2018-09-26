using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmChecar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int checar(int n1, int n2)
        {
            int resto;
            resto = ((n1 % 2) + (n2% 2));
            return (resto);
        }
        public int dividir(int n1, int n2)
        {
            return (n1 / n2);
        }
        public int multiplicar(int n1, int n2)
        {
            return (n1 * n2);
        }

        private void btnChecar_Click(object sender, EventArgs e)
        {
            if (checar(int.Parse(txtN1.Text), int.Parse(txtN2.Text)) == 0)
            {
                MessageBox.Show("O numero é Par e a divisão é:\n" + dividir(int.Parse(txtN1.Text), int.Parse(txtN2.Text)));
            }
            else
            {
                MessageBox.Show("O numero é Impar e a multiplicação é: " + multiplicar(int.Parse(txtN1.Text), int.Parse(txtN2.Text)));
            }
        }
    }
}
