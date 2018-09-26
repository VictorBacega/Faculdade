namespace NumeroDaSorte
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lstBoxNumErrados = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblTentativas = new System.Windows.Forms.Label();
            this.lblChances = new System.Windows.Forms.Label();
            this.btnTrocar = new System.Windows.Forms.Button();
            this.btnDesistir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAcerto = new System.Windows.Forms.Label();
            this.lblNumS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um Numero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chances: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero Digitados:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(13, 30);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 3;
            // 
            // lstBoxNumErrados
            // 
            this.lstBoxNumErrados.FormattingEnabled = true;
            this.lstBoxNumErrados.Location = new System.Drawing.Point(134, 30);
            this.lstBoxNumErrados.Name = "lstBoxNumErrados";
            this.lstBoxNumErrados.Size = new System.Drawing.Size(120, 212);
            this.lstBoxNumErrados.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tentativas: ";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(13, 57);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(100, 30);
            this.btnVerificar.TabIndex = 6;
            this.btnVerificar.Text = "Tentar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblTentativas
            // 
            this.lblTentativas.AutoSize = true;
            this.lblTentativas.Location = new System.Drawing.Point(72, 104);
            this.lblTentativas.Name = "lblTentativas";
            this.lblTentativas.Size = new System.Drawing.Size(35, 13);
            this.lblTentativas.TabIndex = 7;
            this.lblTentativas.Text = "label5";
            // 
            // lblChances
            // 
            this.lblChances.AutoSize = true;
            this.lblChances.Location = new System.Drawing.Point(72, 127);
            this.lblChances.Name = "lblChances";
            this.lblChances.Size = new System.Drawing.Size(35, 13);
            this.lblChances.TabIndex = 8;
            this.lblChances.Text = "label6";
            // 
            // btnTrocar
            // 
            this.btnTrocar.Location = new System.Drawing.Point(13, 189);
            this.btnTrocar.Name = "btnTrocar";
            this.btnTrocar.Size = new System.Drawing.Size(100, 23);
            this.btnTrocar.TabIndex = 9;
            this.btnTrocar.Text = "Trocar Numero";
            this.btnTrocar.UseVisualStyleBackColor = true;
            this.btnTrocar.Click += new System.EventHandler(this.btnTrocar_Click_1);
            // 
            // btnDesistir
            // 
            this.btnDesistir.Location = new System.Drawing.Point(13, 218);
            this.btnDesistir.Name = "btnDesistir";
            this.btnDesistir.Size = new System.Drawing.Size(100, 23);
            this.btnDesistir.TabIndex = 10;
            this.btnDesistir.Text = "Desistir!";
            this.btnDesistir.UseVisualStyleBackColor = true;
            this.btnDesistir.Click += new System.EventHandler(this.btnDesistir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Acertos:";
            // 
            // lblAcerto
            // 
            this.lblAcerto.AutoSize = true;
            this.lblAcerto.Location = new System.Drawing.Point(72, 151);
            this.lblAcerto.Name = "lblAcerto";
            this.lblAcerto.Size = new System.Drawing.Size(35, 13);
            this.lblAcerto.TabIndex = 12;
            this.lblAcerto.Text = "label6";
            // 
            // lblNumS
            // 
            this.lblNumS.AutoSize = true;
            this.lblNumS.Location = new System.Drawing.Point(10, 255);
            this.lblNumS.Name = "lblNumS";
            this.lblNumS.Size = new System.Drawing.Size(35, 13);
            this.lblNumS.TabIndex = 13;
            this.lblNumS.Text = "label6";
            this.lblNumS.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 293);
            this.Controls.Add(this.lblNumS);
            this.Controls.Add(this.lblAcerto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDesistir);
            this.Controls.Add(this.btnTrocar);
            this.Controls.Add(this.lblChances);
            this.Controls.Add(this.lblTentativas);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstBoxNumErrados);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Jogo dos Numeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ListBox lstBoxNumErrados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblTentativas;
        private System.Windows.Forms.Label lblChances;
        private System.Windows.Forms.Button btnTrocar;
        private System.Windows.Forms.Button btnDesistir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAcerto;
        private System.Windows.Forms.Label lblNumS;
    }
}

