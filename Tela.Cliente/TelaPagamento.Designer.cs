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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPagamento));
            LblValor = new Label();
            BtnPix = new Button();
            BtnCredito = new Button();
            BtnDebito = new Button();
            BtnPagarEntrega = new Button();
            BtnComfirma = new Button();
            BtnCancelar = new Button();
            SuspendLayout();
            // 
            // LblValor
            // 
            LblValor.AutoSize = true;
            LblValor.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblValor.Location = new Point(93, 9);
            LblValor.Name = "LblValor";
            LblValor.Size = new Size(226, 30);
            LblValor.TabIndex = 0;
            LblValor.Text = "Total a Pagar: R$ 0,00";
            // 
            // BtnPix
            // 
            BtnPix.BackColor = Color.White;
            BtnPix.Cursor = Cursors.Hand;
            BtnPix.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPix.Image = (Image)resources.GetObject("BtnPix.Image");
            BtnPix.ImageAlign = ContentAlignment.MiddleLeft;
            BtnPix.Location = new Point(93, 65);
            BtnPix.Name = "BtnPix";
            BtnPix.Size = new Size(207, 50);
            BtnPix.TabIndex = 1;
            BtnPix.Text = "Pix";
            BtnPix.UseVisualStyleBackColor = false;
            BtnPix.Click += BtnPix_Click;
            // 
            // BtnCredito
            // 
            BtnCredito.BackColor = Color.White;
            BtnCredito.Cursor = Cursors.Hand;
            BtnCredito.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCredito.Image = (Image)resources.GetObject("BtnCredito.Image");
            BtnCredito.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCredito.Location = new Point(93, 121);
            BtnCredito.Name = "BtnCredito";
            BtnCredito.Size = new Size(207, 50);
            BtnCredito.TabIndex = 2;
            BtnCredito.Text = "Crédito";
            BtnCredito.UseVisualStyleBackColor = false;
            BtnCredito.Click += BtnCredito_Click;
            // 
            // BtnDebito
            // 
            BtnDebito.BackColor = Color.White;
            BtnDebito.Cursor = Cursors.Hand;
            BtnDebito.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDebito.Image = (Image)resources.GetObject("BtnDebito.Image");
            BtnDebito.ImageAlign = ContentAlignment.MiddleLeft;
            BtnDebito.Location = new Point(93, 177);
            BtnDebito.Name = "BtnDebito";
            BtnDebito.Size = new Size(207, 50);
            BtnDebito.TabIndex = 3;
            BtnDebito.Text = "Débito";
            BtnDebito.UseVisualStyleBackColor = false;
            BtnDebito.Click += BtnDebito_Click;
            // 
            // BtnPagarEntrega
            // 
            BtnPagarEntrega.BackColor = Color.White;
            BtnPagarEntrega.Cursor = Cursors.Hand;
            BtnPagarEntrega.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPagarEntrega.Image = (Image)resources.GetObject("BtnPagarEntrega.Image");
            BtnPagarEntrega.ImageAlign = ContentAlignment.MiddleLeft;
            BtnPagarEntrega.Location = new Point(93, 233);
            BtnPagarEntrega.Name = "BtnPagarEntrega";
            BtnPagarEntrega.Size = new Size(207, 50);
            BtnPagarEntrega.TabIndex = 4;
            BtnPagarEntrega.Text = "Pagar na entrega ";
            BtnPagarEntrega.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnPagarEntrega.UseVisualStyleBackColor = false;
            BtnPagarEntrega.Click += BtnPagarEntrega_Click;
            // 
            // BtnComfirma
            // 
            BtnComfirma.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnComfirma.Location = new Point(82, 325);
            BtnComfirma.Name = "BtnComfirma";
            BtnComfirma.Size = new Size(99, 33);
            BtnComfirma.TabIndex = 5;
            BtnComfirma.Text = "Finalizar";
            BtnComfirma.UseVisualStyleBackColor = true;
            BtnComfirma.Click += BtnComfirma_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCancelar.Location = new Point(187, 325);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(99, 33);
            BtnCancelar.TabIndex = 6;
            BtnCancelar.Text = "Voltar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // TelaPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(384, 361);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnComfirma);
            Controls.Add(BtnPagarEntrega);
            Controls.Add(BtnDebito);
            Controls.Add(BtnCredito);
            Controls.Add(BtnPix);
            Controls.Add(LblValor);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "TelaPagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaPagamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblValor;
        private Button BtnPix;
        private Button BtnCredito;
        private Button BtnDebito;
        private Button BtnPagarEntrega;
        private Button BtnComfirma;
        private Button BtnCancelar;
    }
}