using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumeroDaSorte
{
    public partial class Form1 : Form
    {

        int chances = 10;
        int tentativas = 0;
        int acertos = 0;
        public Form1()
        {
            InitializeComponent();
            
            lblChances.Text = Convert.ToString(chances);
            lblTentativas.Text = Convert.ToString(tentativas);
            lblAcerto.Text = Convert.ToString(acertos);
            
        }
            
            

        public static int numerosorte()
        {
            Random rnd = new Random();
            int numeroSorte = rnd.Next(0, 11);
            
            return numeroSorte;
        }
        int numero1 = numerosorte();
        
        
        


        
        
       

        public void Checar ()
        {
            lblNumS.Text = Convert.ToString(numero1);
            
            
            int numero;

            try
            {
                numero = int.Parse(txtNumero.Text);
                if (chances > 0)
                {
                    if (numero == numero1)
                    {
                        acertos++;
                        lblAcerto.Text = Convert.ToString(acertos);
                        DialogResult Resposta;
                        Resposta = MessageBox.Show("Parabens você acertou!\n Quer tentar de novo?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (Resposta.ToString() == "Yes")
                        {

                            numero1 = numerosorte();
                            lblNumS.Text = Convert.ToString(numero1);
                            lstBoxNumErrados.Items.Clear();
                            txtNumero.Focus();


                        }
                        else
                        {
                            this.Close();
                        }

                    }
                    else if (numero < numero1)
                    {
                        MessageBox.Show("O Numero digitado é menor que o Numero da Sorte");
                        chances--;
                        tentativas++;
                        lblTentativas.Text = Convert.ToString(tentativas);
                        lblChances.Text = Convert.ToString(chances);
                        txtNumero.Focus();

                        lstBoxNumErrados.Items.Add(Convert.ToString(txtNumero.Text));
                    }
                    else
                    {
                        MessageBox.Show("O Numero digitado é maior que o Numero da Sorte");
                        chances--;
                        tentativas++;
                        lblTentativas.Text = Convert.ToString(tentativas);
                        lblChances.Text = Convert.ToString(chances);
                        txtNumero.Focus();
                        lstBoxNumErrados.Items.Add(Convert.ToString(txtNumero.Text));
                    }
                }
                else
                {
                    DialogResult Resposta;
                    Resposta = MessageBox.Show("Acabou suas chances! Quer gerar um novo numero?", "Perdeu", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (Resposta.ToString() == "Yes")
                    {
                        numero1 = numerosorte();
                        chances = 10;
                        lblChances.Text = Convert.ToString(chances);
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Digite um numero por favor!");
                txtNumero.Text = "";
                txtNumero.Focus();
            }

 
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Checar();
        }


        private void btnTrocar_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("O Numero da Sorte Era: " + numerosorte());
            numerosorte();
        }

        private void btnDesistir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O Numero da Sorte Era: " + numerosorte());

        }
    }
}
