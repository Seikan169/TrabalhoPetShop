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

            ResetarEstilo(BtnCredito);
            ResetarEstilo(BtnDebito);
            ResetarEstilo(BtnPagarEntrega);
            // Adicione o btnDinheiro se tiver criado

            // 2. Aplica o estilo "Ativo" no escolhido (Azul claro com borda)
            botaoEscolhido.BackColor = Color.FromArgb(214, 234, 248); // Azul Bebê
            botaoEscolhido.ForeColor = Color.Black;
            botaoEscolhido.FlatAppearance.BorderSize = 2;
            botaoEscolhido.FlatAppearance.BorderColor = Color.DodgerBlue;


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
            LblInformacao.Text = "Aponte a câmera do seu celular \n para o QR Code ou copie o código Pix.";
            PbIntrucao.Visible = false;
           
            // 1. CONFIGURAR DADOS DO PIX (Coloque seus dados reais aqui para testar!)
            string minhaChavePix = "15708016655"; // <--- TROPQUE PELA SUA CHAVE
            string nomeRecebedor = "PetShop Mundo Animal";
            string cidade = "Belo Horizonte";

            // O valor já vem lá do construtor da tela, lembra?
            // Vamos limpar o R$ do texto da label ou usar a variável original se tiver guardado
            // Supondo que você guardou o valor numa variável global '_valorTotal'
            try
            {



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
                BtnCopiar.Visible = true;
                BtnComfirma.Enabled = false;
                BtnComfirma.Text = "Aguardando Pagamento...";
                BtnComfirma.BackColor = Color.Gray; // Deixa cinza para parecer desativado
                                                    // Inicia o cronômetro para simular a confirmação do pagamento

                Clipboard.SetText(payloadPix);
                MessageBox.Show("QR Code Gerado! O código 'Copia e Cola' foi copiado para sua área de transferência.");
                TmrPix.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar o QR Code: " + ex.Message);

            }
        }

        private void BtnPagarEntrega_Click_1(object sender, EventArgs e)
        {
            PbIntrucao.Visible = true;
            PbIntrucao.Image = Properties.Resources.bicicleta_de_entrega; // Coloque uma imagem de entrega se tiver
            LblInformacao.Visible = true;
            LblInformacao.Text = "💵\n\nPagamento em Dinheiro.\nReceba o valor no balcão ou na entrega.";
            MetodoEscolhido = "Dinheiro";
            DestacarBotao(BtnPagarEntrega);
        }

        private void BtnDebito_Click_1(object sender, EventArgs e)
        {
            PbIntrucao.Image = Properties.Resources.maquina_de_cartao;// Coloque uma imagem de maquininha se tiver
            PbIntrucao.Visible = true;
            LblInformacao.Text =  "💳\n\nCartão de Débito.\nUtilize a maquininha para processar.";
            MetodoEscolhido = "Debito";
            DestacarBotao(BtnDebito);
        }

        private void BtnCredito_Click_1(object sender, EventArgs e)
        {
            PbIntrucao.Image = Properties.Resources.maquina_de_cartao;
            PbIntrucao.Visible = true;
            LblInformacao.Text = "💳\n\nCartão de Crédito.\nInsira o cartão ou aproxime da maquininha.";
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



        private void TmrPix_Tick(object sender, EventArgs e)
        {
            // O Cronômetro apita depois de 5 segundos!

            // 1. Para o relógio (senão ele fica apitando para sempre)
            TmrPix.Stop();

            // 2. Destrava o botão
            BtnComfirma.Enabled = true;
            BtnComfirma.Text = "FINALIZAR";
            BtnComfirma.BackColor = Color.SeaGreen; // Volta a ficar verde (ou a cor original)

            // 3. Toca um som de sucesso (opcional, fica chique!)
            System.Media.SystemSounds.Exclamation.Play();

            // 4. Mostra mensagem
            MessageBox.Show("Pagamento Pix Identificado com Sucesso!", "Banco", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(payloadPix);
            MessageBox.Show("Código Pix copiado! Agora é só colar no banco.");
        }
    }
}


