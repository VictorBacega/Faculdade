namespace Calculadora
{
    partial class frmCalculadora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdicao = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnMultiplicao = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkData = new System.Windows.Forms.CheckBox();
            this.chkHora = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.wbrBrowser = new System.Windows.Forms.WebBrowser();
            this.lstCores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAdicao
            // 
            this.btnAdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicao.Location = new System.Drawing.Point(357, 49);
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.Size = new System.Drawing.Size(42, 80);
            this.btnAdicao.TabIndex = 0;
            this.btnAdicao.Text = "+";
            this.btnAdicao.UseVisualStyleBackColor = true;
            this.btnAdicao.Click += new System.EventHandler(this.btnAdicao_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisao.Location = new System.Drawing.Point(276, 91);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(75, 38);
            this.btnDivisao.TabIndex = 1;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnMultiplicao
            // 
            this.btnMultiplicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicao.Location = new System.Drawing.Point(138, 91);
            this.btnMultiplicao.Name = "btnMultiplicao";
            this.btnMultiplicao.Size = new System.Drawing.Size(75, 38);
            this.btnMultiplicao.TabIndex = 2;
            this.btnMultiplicao.Text = "*";
            this.btnMultiplicao.UseVisualStyleBackColor = true;
            this.btnMultiplicao.Click += new System.EventHandler(this.btnMultiplicao_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtracao.Location = new System.Drawing.Point(12, 91);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(75, 38);
            this.btnSubtracao.TabIndex = 3;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btnCE
            // 
            this.btnCE.Location = new System.Drawing.Point(13, 155);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(75, 23);
            this.btnCE.TabIndex = 5;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(138, 155);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(12, 12);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(95, 20);
            this.dtpData.TabIndex = 7;
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(138, 12);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(96, 20);
            this.dtpHora.TabIndex = 8;
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(13, 49);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(74, 20);
            this.txtValor1.TabIndex = 9;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(138, 49);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(75, 20);
            this.txtValor2.TabIndex = 10;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(276, 49);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(75, 20);
            this.txtResultado.TabIndex = 11;
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Location = new System.Drawing.Point(94, 53);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(35, 13);
            this.lblOperacao.TabIndex = 12;
            this.lblOperacao.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "=";
            // 
            // chkData
            // 
            this.chkData.AutoSize = true;
            this.chkData.Location = new System.Drawing.Point(276, 155);
            this.chkData.Name = "chkData";
            this.chkData.Size = new System.Drawing.Size(77, 17);
            this.chkData.TabIndex = 14;
            this.chkData.Text = "Exibir Data";
            this.chkData.UseVisualStyleBackColor = true;
            this.chkData.CheckedChanged += new System.EventHandler(this.chkData_CheckedChanged);
            // 
            // chkHora
            // 
            this.chkHora.AutoSize = true;
            this.chkHora.Location = new System.Drawing.Point(276, 178);
            this.chkHora.Name = "chkHora";
            this.chkHora.Size = new System.Drawing.Size(77, 17);
            this.chkHora.TabIndex = 15;
            this.chkHora.Text = "Exibir Hora";
            this.chkHora.UseVisualStyleBackColor = true;
            this.chkHora.CheckedChanged += new System.EventHandler(this.chkHora_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cor de Fundo";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(12, 257);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(306, 20);
            this.txtEndereco.TabIndex = 17;
            this.txtEndereco.Text = "http://";
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(324, 257);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 18;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // wbrBrowser
            // 
            this.wbrBrowser.Location = new System.Drawing.Point(12, 283);
            this.wbrBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbrBrowser.Name = "wbrBrowser";
            this.wbrBrowser.Size = new System.Drawing.Size(387, 279);
            this.wbrBrowser.TabIndex = 19;
            // 
            // lstCores
            // 
            this.lstCores.FormattingEnabled = true;
            this.lstCores.Location = new System.Drawing.Point(13, 209);
            this.lstCores.Name = "lstCores";
            this.lstCores.Size = new System.Drawing.Size(120, 30);
            this.lstCores.TabIndex = 20;
            this.lstCores.SelectedIndexChanged += new System.EventHandler(this.lstCores_SelectedIndexChanged);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 574);
            this.Controls.Add(this.lstCores);
            this.Controls.Add(this.wbrBrowser);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkHora);
            this.Controls.Add(this.chkData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnMultiplicao);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnAdicao);
            this.Name = "frmCalculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicao;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnMultiplicao;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkData;
        private System.Windows.Forms.CheckBox chkHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.WebBrowser wbrBrowser;
        private System.Windows.Forms.ListBox lstCores;
    }
}

