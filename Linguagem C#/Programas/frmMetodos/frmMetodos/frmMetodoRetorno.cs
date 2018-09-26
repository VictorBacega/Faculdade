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
    public partial class frmMetodoRetorno : Form
    {
        public frmMetodoRetorno()
        {
            InitializeComponent();
        }

        public int somar(int n1, int n2)
        {
            return (n1+n2);
        }

        public int subtrair(int n1, int n2)
        {
            return (n1 - n2);
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            
            
            MessageBox.Show("A soma é: " + somar(int.Parse(txtN1.Text), int.Parse(txtN2.Text)));
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("A soma é: " + subtrair(int.Parse(txtN1.Text), int.Parse(txtN2.Text)));
        }
    }
}
