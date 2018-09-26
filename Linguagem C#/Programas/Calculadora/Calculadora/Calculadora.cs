using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToInt16(Convert.ToInt16(txtValor1.Text) + Convert.ToInt16(txtValor2.Text)).ToString();
            lblOperacao.Text = "+";

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            //Tirar duvida com o professor sobre essa operação de -
            txtResultado.Text = (Convert.ToInt16(txtValor1.Text) - Convert.ToInt16(txtValor2.Text)).ToString(); 
            lblOperacao.Text = "-";
        }

        private void btnMultiplicao_Click(object sender, EventArgs e)
        {
            txtResultado.Text = (Convert.ToInt16(txtValor1.Text) * Convert.ToInt16(txtValor2.Text)).ToString();
            lblOperacao.Text = "*";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            txtResultado.Text = (Convert.ToInt16(txtValor1.Text) / Convert.ToInt16(txtValor2.Text)).ToString();
            lblOperacao.Text = "/";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblOperacao.Text = "";
            dtpData.Visible = false;
            dtpHora.Visible = false;
            chkData.Checked = false;
            chkHora.Checked = false;
            lstCores.Items.Add("Vermelho");
            lstCores.Items.Add("Azul");
            lstCores.Items.Add("Verde");
            lstCores.Items.Add("Amarelo");
            lstCores.Items.Add("Laranja");
            lstCores.Items.Add("Rosa");
            lstCores.Items.Add("Marron");
            lstCores.Items.Add("Preto");
            

        }

        private void lstCores_SelectedIndexChanged(object sender, EventArgs e)
        {
            string NomeCor = Convert.ToString(lstCores.SelectedValue);
            string cor = "";
            switch (NomeCor)
            {
                case "Vermelho":
                    cor = "red";
                    break;
                case "Azul":
                    cor = "blue";
                    break;
                case "Verde":
                    cor = "green";
                    break;
                case "Amarelo":
                    cor = "yellow";
                    break;
                case "Laranja":
                    cor = "orange";
                    break;
                case "Rosa":
                    cor = "pink";
                    break;
                case "Marron":
                    cor = "brown";
                    break;
                case "Preto":
                    cor = "black";
                    break;
            }

            BackColor = System.Drawing.Color.FromName(cor);

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            txtValor1.Text = "";
            txtValor2.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Você deseja Sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d.ToString() == "Yes")
            {
                Application.Exit();
            }
        }

        private void chkData_CheckedChanged(object sender, EventArgs e)
        {
            if (chkData.Checked == true)
            {
                dtpData.Visible = true;
            }
            else
            {
                dtpData.Visible = false;
            }
        }

        private void chkHora_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHora.Checked == true)
            {
                dtpHora.Visible = true;
            }
            else
            {
                dtpHora.Visible = false;
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            wbrBrowser.Navigate(txtEndereco.Text);
        }

        
    }
}
