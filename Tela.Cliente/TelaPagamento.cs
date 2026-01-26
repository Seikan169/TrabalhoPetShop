using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela.Cliente
{
    public partial class TelaPagamento : Form
    {
        public string MetodoEscolhido { get; private set; } = "";
        public TelaPagamento(decimal ValorTotal)
        {
            InitializeComponent();
        }
        private void DestacarBotao(Button botaoEscolhido)
        {
            // Pinta o escolhido de Verde e os outros de Cinza
            BtnPix.BackColor = Color.LightGray;
            BtnCredito.BackColor = Color.LightGray;
            BtnDebito.BackColor = Color.LightGray;
            BtnPagarEntrega.BackColor = Color.LightGray;

            botaoEscolhido.BackColor = Color.LightGreen;
        }

        private void BtnPix_Click(object sender, EventArgs e)
        {
            MetodoEscolhido = "Pix";
            DestacarBotao(BtnPix);
        }

        private void BtnCredito_Click(object sender, EventArgs e)
        {
            MetodoEscolhido = "Credito";
            DestacarBotao(BtnCredito);
        }

        private void BtnDebito_Click(object sender, EventArgs e)
        {
            MetodoEscolhido = "Debito";
            DestacarBotao(BtnDebito);
        }

        private void BtnPagarEntrega_Click(object sender, EventArgs e)
        {
            MetodoEscolhido = "Pagar na entrega";
            DestacarBotao(BtnPagarEntrega);
        }

        private void BtnComfirma_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MetodoEscolhido))
            {
                MessageBox.Show("Por favor, selecione uma forma de pagamento.");
                return;
            }

            // Fecha a tela dizendo "OK, deu certo"
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
