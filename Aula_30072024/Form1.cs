using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_30072024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botao_soma_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(CaixaTexto_N1.Text);
            int n2 = int.Parse(CaixaTexto_N2.Text);

            int resultado = n1 + n2;

            texto_soma.Text = resultado.ToString();
        }

        private void botao_limpar_Click(object sender, EventArgs e)
        {
            CaixaTexto_N1.Text = "";
            CaixaTexto_N2.Text = "";

            texto_soma.Text = "0";

            CaixaTexto_N1.Focus();
        }

        private void botao_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
