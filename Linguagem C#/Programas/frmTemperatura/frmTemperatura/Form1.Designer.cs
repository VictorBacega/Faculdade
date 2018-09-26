namespace frmTemperatura
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
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.rbCelcius = new System.Windows.Forms.RadioButton();
            this.rbFar = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(66, 38);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 20);
            this.txtTemp.TabIndex = 1;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(78, 64);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Converter";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // rbCelcius
            // 
            this.rbCelcius.AutoSize = true;
            this.rbCelcius.Location = new System.Drawing.Point(39, 12);
            this.rbCelcius.Name = "rbCelcius";
            this.rbCelcius.Size = new System.Drawing.Size(61, 17);
            this.rbCelcius.TabIndex = 5;
            this.rbCelcius.TabStop = true;
            this.rbCelcius.Text = "Cº -> Fº";
            this.rbCelcius.UseVisualStyleBackColor = true;
            // 
            // rbFar
            // 
            this.rbFar.AutoSize = true;
            this.rbFar.Location = new System.Drawing.Point(125, 12);
            this.rbFar.Name = "rbFar";
            this.rbFar.Size = new System.Drawing.Size(61, 17);
            this.rbFar.TabIndex = 6;
            this.rbFar.TabStop = true;
            this.rbFar.Text = "Fº -> Cº";
            this.rbFar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 106);
            this.Controls.Add(this.rbFar);
            this.Controls.Add(this.rbCelcius);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtTemp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.RadioButton rbCelcius;
        private System.Windows.Forms.RadioButton rbFar;

    }
}

