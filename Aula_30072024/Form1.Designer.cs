namespace Aula_30072024
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
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CaixaTexto_N1 = new System.Windows.Forms.TextBox();
            this.CaixaTexto_N2 = new System.Windows.Forms.TextBox();
            this.botao_soma = new System.Windows.Forms.Button();
            this.botao_limpar = new System.Windows.Forms.Button();
            this.botao_fechar = new System.Windows.Forms.Button();
            this.texto_soma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado:";
            // 
            // CaixaTexto_N1
            // 
            this.CaixaTexto_N1.Location = new System.Drawing.Point(157, 70);
            this.CaixaTexto_N1.Name = "CaixaTexto_N1";
            this.CaixaTexto_N1.Size = new System.Drawing.Size(457, 20);
            this.CaixaTexto_N1.TabIndex = 3;
            // 
            // CaixaTexto_N2
            // 
            this.CaixaTexto_N2.Location = new System.Drawing.Point(157, 105);
            this.CaixaTexto_N2.Name = "CaixaTexto_N2";
            this.CaixaTexto_N2.Size = new System.Drawing.Size(457, 20);
            this.CaixaTexto_N2.TabIndex = 4;
            // 
            // botao_soma
            // 
            this.botao_soma.Location = new System.Drawing.Point(157, 211);
            this.botao_soma.Name = "botao_soma";
            this.botao_soma.Size = new System.Drawing.Size(137, 78);
            this.botao_soma.TabIndex = 5;
            this.botao_soma.Text = "Soma";
            this.botao_soma.UseVisualStyleBackColor = true;
            this.botao_soma.Click += new System.EventHandler(this.botao_soma_Click);
            // 
            // botao_limpar
            // 
            this.botao_limpar.Location = new System.Drawing.Point(315, 211);
            this.botao_limpar.Name = "botao_limpar";
            this.botao_limpar.Size = new System.Drawing.Size(137, 78);
            this.botao_limpar.TabIndex = 6;
            this.botao_limpar.Text = "Limpar";
            this.botao_limpar.UseVisualStyleBackColor = true;
            this.botao_limpar.Click += new System.EventHandler(this.botao_limpar_Click);
            // 
            // botao_fechar
            // 
            this.botao_fechar.Location = new System.Drawing.Point(477, 211);
            this.botao_fechar.Name = "botao_fechar";
            this.botao_fechar.Size = new System.Drawing.Size(137, 78);
            this.botao_fechar.TabIndex = 7;
            this.botao_fechar.Text = "Fechar";
            this.botao_fechar.UseVisualStyleBackColor = true;
            this.botao_fechar.Click += new System.EventHandler(this.botao_fechar_Click);
            // 
            // texto_soma
            // 
            this.texto_soma.AutoSize = true;
            this.texto_soma.Location = new System.Drawing.Point(154, 338);
            this.texto_soma.Name = "texto_soma";
            this.texto_soma.Size = new System.Drawing.Size(0, 13);
            this.texto_soma.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.texto_soma);
            this.Controls.Add(this.botao_fechar);
            this.Controls.Add(this.botao_limpar);
            this.Controls.Add(this.botao_soma);
            this.Controls.Add(this.CaixaTexto_N2);
            this.Controls.Add(this.CaixaTexto_N1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CaixaTexto_N1;
        private System.Windows.Forms.TextBox CaixaTexto_N2;
        private System.Windows.Forms.Button botao_soma;
        private System.Windows.Forms.Button botao_limpar;
        private System.Windows.Forms.Button botao_fechar;
        private System.Windows.Forms.Label texto_soma;
    }
}

