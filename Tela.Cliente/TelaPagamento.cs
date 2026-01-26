using QRCoder;
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
        private string payloadPix;

        public string MetodoEscolhido { get; private set; } = "";
        private decimal _valorTotal;
        public TelaPagamento(decimal ValorTotal)
        {
            InitializeComponent();
            _valorTotal = ValorTotal; // <--- Guarde o valor aqui ao abrir a tela
            LblValor.Text = $"Total a Pagar: {ValorTotal:C2}";
            BtnComfirma.BackColor = Color.FromArgb(0, 184, 148);
        }
        private void DestacarBotao(Button botaoEscolhido)
        {
            // 1. Reseta todos os botões para o estilo "Desativado" (Cinza claro)
            ResetarEstilo(BtnPix);
            ResetarEstilo(BtnCredito);
            ResetarEstilo(BtnDebito);
            ResetarEstilo(BtnPagarEntrega);
            // Adicione o btnDinheiro se tiver criado

            // 2. Aplica o estilo "Ativo" no escolhido (Azul claro com borda)
            botaoEscolhido.BackColor = Color.FromArgb(214, 234, 248); // Azul Bebê
            botaoEscolhido.ForeColor = Color.Black;
            botaoEscolhido.FlatAppearance.BorderSize = 2;
            botaoEscolhido.FlatAppearance.BorderColor = Color.DodgerBlue;

            // 3. Controle de visibilidade do QR Code
            if (botaoEscolhido == BtnPix)
            {
                PbQrcode.Visible = true;
                // lblInstrucao.Text = "Escaneie o QR Code no app do seu banco";
            }
            else
            {
                PbQrcode.Visible = false;
                // lblInstrucao.Text = "Pague na maquininha ao finalizar.";
            }
        }
        private void ResetarEstilo(Button btn)
        {
            btn.BackColor = Color.WhiteSmoke; // Fundo neutro
            btn.ForeColor = Color.DimGray;    // Texto cinza
            btn.FlatAppearance.BorderSize = 0; // Sem borda
        }


        private void BtnPix_Click_1(object sender, EventArgs e)
        {
            MetodoEscolhido = "Pix";
            DestacarBotao(BtnPix);
            // 1. CONFIGURAR DADOS DO PIX (Coloque seus dados reais aqui para testar!)
            string minhaChavePix = "15708016655"; // <--- TROPQUE PELA SUA CHAVE
            string nomeRecebedor = "PetShop Mundo Animal";
            string cidade = "Belo Horizonte";

            // O valor já vem lá do construtor da tela, lembra?
            // Vamos limpar o R$ do texto da label ou usar a variável original se tiver guardado
            // Supondo que você guardou o valor numa variável global '_valorTotal'

            // 2. GERAR O TEXTO DO PIX (O Código Copia e Cola)
            var gerador = new GeradorPix(minhaChavePix, nomeRecebedor, cidade, _valorTotal);
            payloadPix = gerador.GerarPayload();

            // 3. GERAR A IMAGEM DO QR CODE
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(payloadPix, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            // 4. MOSTRAR NA TELA
            PbQrcode.Image = qrCodeImage;
            PbQrcode.Visible = true; // Mostra a imagem

            // Opcional: Copiar o código para a área de transferência
            Clipboard.SetText(payloadPix);
            MessageBox.Show("QR Code Gerado! O código 'Copia e Cola' foi copiado para sua área de transferência.");

        }

        private void BtnPagarEntrega_Click_1(object sender, EventArgs e)
        {
            MetodoEscolhido = "Pagar na entrega";
            DestacarBotao(BtnPagarEntrega);
        }

        private void BtnDebito_Click_1(object sender, EventArgs e)
        {
            MetodoEscolhido = "Debito";
            DestacarBotao(BtnDebito);
        }

        private void BtnCredito_Click_1(object sender, EventArgs e)
        {
            MetodoEscolhido = "Credito";
            DestacarBotao(BtnCredito);
        }

        private void BtnComfirma_Click_1(object sender, EventArgs e)
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

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(payloadPix);
            MessageBox.Show("Código Pix copiado! Agora é só colar no banco.");
        }
    }
}
