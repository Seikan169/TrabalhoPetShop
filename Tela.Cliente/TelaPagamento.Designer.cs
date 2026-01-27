namespace Tela.Cliente
{
    partial class TelaPagamento
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPagamento));
            LblValor = new Label();
            PbQrcode = new PictureBox();
            panel1 = new Panel();
            BtnFechar = new Button();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            BtnPagarEntrega = new Button();
            BtnDebito = new Button();
            BtnCredito = new Button();
            BtnPix = new Button();
            BtnCancelar = new Button();
            BtnComfirma = new Button();
            TmrPix = new System.Windows.Forms.Timer(components);
            PbIntrucao = new PictureBox();
            BtnCopiar = new Button();
            LblInformacao = new Label();
            ((System.ComponentModel.ISupportInitialize)PbQrcode).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbIntrucao).BeginInit();
            SuspendLayout();
            // 
            // LblValor
            // 
            LblValor.AutoSize = true;
            LblValor.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblValor.Location = new Point(353, 59);
            LblValor.Name = "LblValor";
            LblValor.Size = new Size(226, 30);
            LblValor.TabIndex = 0;
            LblValor.Text = "Total a Pagar: R$ 0,00";
            // 
            // PbQrcode
            // 
            PbQrcode.Location = new Point(365, 95);
            PbQrcode.Name = "PbQrcode";
            PbQrcode.Size = new Size(200, 200);
            PbQrcode.SizeMode = PictureBoxSizeMode.StretchImage;
            PbQrcode.TabIndex = 7;
            PbQrcode.TabStop = false;
            PbQrcode.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(BtnFechar);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(634, 59);
            panel1.TabIndex = 8;
            // 
            // BtnFechar
            // 
            BtnFechar.BackColor = Color.Transparent;
            BtnFechar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnFechar.ForeColor = Color.Cornsilk;
            BtnFechar.Image = (Image)resources.GetObject("BtnFechar.Image");
            BtnFechar.Location = new Point(595, 12);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(32, 32);
            BtnFechar.TabIndex = 2;
            BtnFechar.UseVisualStyleBackColor = false;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(170, -2);
            label1.Name = "label1";
            label1.Size = new Size(337, 48);
            label1.TabIndex = 1;
            label1.Text = "Finalizar Pagamento";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(BtnPagarEntrega);
            flowLayoutPanel1.Controls.Add(BtnDebito);
            flowLayoutPanel1.Controls.Add(BtnCredito);
            flowLayoutPanel1.Controls.Add(BtnPix);
            flowLayoutPanel1.Controls.Add(BtnCancelar);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 59);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(190, 302);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // BtnPagarEntrega
            // 
            BtnPagarEntrega.BackColor = Color.White;
            BtnPagarEntrega.Cursor = Cursors.Hand;
            BtnPagarEntrega.FlatStyle = FlatStyle.Flat;
            BtnPagarEntrega.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPagarEntrega.ForeColor = Color.Black;
            BtnPagarEntrega.Image = (Image)resources.GetObject("BtnPagarEntrega.Image");
            BtnPagarEntrega.ImageAlign = ContentAlignment.MiddleLeft;
            BtnPagarEntrega.Location = new Point(3, 3);
            BtnPagarEntrega.Name = "BtnPagarEntrega";
            BtnPagarEntrega.Size = new Size(172, 50);
            BtnPagarEntrega.TabIndex = 10;
            BtnPagarEntrega.Text = "Dinheiro";
            BtnPagarEntrega.UseVisualStyleBackColor = false;
            BtnPagarEntrega.Click += BtnPagarEntrega_Click_1;
            // 
            // BtnDebito
            // 
            BtnDebito.BackColor = Color.White;
            BtnDebito.Cursor = Cursors.Hand;
            BtnDebito.FlatStyle = FlatStyle.Flat;
            BtnDebito.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDebito.Image = (Image)resources.GetObject("BtnDebito.Image");
            BtnDebito.ImageAlign = ContentAlignment.MiddleLeft;
            BtnDebito.Location = new Point(3, 59);
            BtnDebito.Name = "BtnDebito";
            BtnDebito.Size = new Size(172, 50);
            BtnDebito.TabIndex = 9;
            BtnDebito.Text = "Débito";
            BtnDebito.UseVisualStyleBackColor = false;
            BtnDebito.Click += BtnDebito_Click_1;
            // 
            // BtnCredito
            // 
            BtnCredito.BackColor = Color.White;
            BtnCredito.Cursor = Cursors.Hand;
            BtnCredito.FlatStyle = FlatStyle.Flat;
            BtnCredito.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCredito.Image = (Image)resources.GetObject("BtnCredito.Image");
            BtnCredito.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCredito.Location = new Point(3, 115);
            BtnCredito.Name = "BtnCredito";
            BtnCredito.Size = new Size(172, 50);
            BtnCredito.TabIndex = 8;
            BtnCredito.Text = "Crédito";
            BtnCredito.UseVisualStyleBackColor = false;
            BtnCredito.Click += BtnCredito_Click_1;
            // 
            // BtnPix
            // 
            BtnPix.BackColor = Color.White;
            BtnPix.Cursor = Cursors.Hand;
            BtnPix.FlatStyle = FlatStyle.Flat;
            BtnPix.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPix.Image = (Image)resources.GetObject("BtnPix.Image");
            BtnPix.ImageAlign = ContentAlignment.MiddleLeft;
            BtnPix.Location = new Point(3, 171);
            BtnPix.Name = "BtnPix";
            BtnPix.Size = new Size(172, 50);
            BtnPix.TabIndex = 7;
            BtnPix.Text = "Pix";
            BtnPix.UseVisualStyleBackColor = false;
            BtnPix.Click += BtnPix_Click_1;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.Gray;
            BtnCancelar.Cursor = Cursors.Hand;
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCancelar.Location = new Point(3, 227);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(99, 33);
            BtnCancelar.TabIndex = 12;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click_1;
            // 
            // BtnComfirma
            // 
            BtnComfirma.FlatStyle = FlatStyle.Flat;
            BtnComfirma.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnComfirma.Location = new Point(365, 328);
            BtnComfirma.Name = "BtnComfirma";
            BtnComfirma.Size = new Size(200, 33);
            BtnComfirma.TabIndex = 11;
            BtnComfirma.Text = "Finalizar";
            BtnComfirma.UseVisualStyleBackColor = true;
            BtnComfirma.Click += BtnComfirma_Click_1;
            // 
            // TmrPix
            // 
            TmrPix.Interval = 10000;
            TmrPix.Tick += TmrPix_Tick;
            // 
            // PbIntrucao
            // 
            PbIntrucao.Image = (Image)resources.GetObject("PbIntrucao.Image");
            PbIntrucao.Location = new Point(365, 92);
            PbIntrucao.Name = "PbIntrucao";
            PbIntrucao.Size = new Size(200, 200);
            PbIntrucao.SizeMode = PictureBoxSizeMode.StretchImage;
            PbIntrucao.TabIndex = 13;
            PbIntrucao.TabStop = false;
            PbIntrucao.Visible = false;
            // 
            // BtnCopiar
            // 
            BtnCopiar.Cursor = Cursors.Hand;
            BtnCopiar.FlatAppearance.BorderColor = Color.LightGray;
            BtnCopiar.FlatStyle = FlatStyle.Flat;
            BtnCopiar.ForeColor = Color.DodgerBlue;
            BtnCopiar.Location = new Point(405, 298);
            BtnCopiar.Name = "BtnCopiar";
            BtnCopiar.Size = new Size(115, 30);
            BtnCopiar.TabIndex = 14;
            BtnCopiar.Text = "📋 Copiar Código Pix";
            BtnCopiar.UseVisualStyleBackColor = true;
            BtnCopiar.Visible = false;
            BtnCopiar.Click += BtnCopiar_Click;
            // 
            // LblInformacao
            // 
            LblInformacao.BackColor = Color.Transparent;
            LblInformacao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblInformacao.ForeColor = Color.DimGray;
            LblInformacao.ImageAlign = ContentAlignment.MiddleLeft;
            LblInformacao.Location = new Point(196, 78);
            LblInformacao.Name = "LblInformacao";
            LblInformacao.Size = new Size(163, 241);
            LblInformacao.TabIndex = 15;
            LblInformacao.Text = "label2";
            LblInformacao.TextAlign = ContentAlignment.MiddleCenter;
            LblInformacao.Visible = false;
            // 
            // TelaPagamento
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(634, 361);
            Controls.Add(LblInformacao);
            Controls.Add(BtnCopiar);
            Controls.Add(PbIntrucao);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(PbQrcode);
            Controls.Add(LblValor);
            Controls.Add(BtnComfirma);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TelaPagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaPagamento";
            ((System.ComponentModel.ISupportInitialize)PbQrcode).EndInit();
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PbIntrucao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblValor;
        private PictureBox PbQrcode;
        private Panel panel1;
        private Label label1;
        private Button BtnFechar;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button BtnPagarEntrega;
        private Button BtnDebito;
        private Button BtnCredito;
        private Button BtnPix;
        private Button BtnCancelar;
        private Button BtnComfirma;
        private System.Windows.Forms.Timer TmrPix;
        private PictureBox PbIntrucao;
        private Button BtnCopiar;
        private Label LblInformacao;
    }
}