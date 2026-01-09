namespace Tela.Cliente
{
    partial class Tela_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Cliente));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            PnlLateral = new Panel();
            BtnSair = new Button();
            BtnMeusPets = new Button();
            BtnAgendar = new Button();
            PnlCabeca = new Panel();
            LblBemvindo = new Label();
            PnlPricipal = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            splitContainer1 = new SplitContainer();
            DgvServicos = new DataGridView();
            panel2 = new Panel();
            BtnAdicionar = new Button();
            panel1 = new Panel();
            CmbPetAgendar = new ComboBox();
            LblPetCuidado = new Label();
            LblResumo = new Label();
            DgvCarrinho = new DataGridView();
            PnlRodapePagar = new Panel();
            BtnFinalizar = new Button();
            LblData = new Label();
            DtpData = new DateTimePicker();
            LblTotal = new Label();
            PnlCabecaPagamneto = new Panel();
            LblPedido = new Label();
            tabPage2 = new TabPage();
            LblResumoP = new Label();
            PnlLateral.SuspendLayout();
            PnlCabeca.SuspendLayout();
            PnlPricipal.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvServicos).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCarrinho).BeginInit();
            PnlRodapePagar.SuspendLayout();
            PnlCabecaPagamneto.SuspendLayout();
            SuspendLayout();
            // 
            // PnlLateral
            // 
            PnlLateral.BackColor = Color.RoyalBlue;
            PnlLateral.BorderStyle = BorderStyle.Fixed3D;
            PnlLateral.Controls.Add(BtnSair);
            PnlLateral.Controls.Add(BtnMeusPets);
            PnlLateral.Controls.Add(BtnAgendar);
            PnlLateral.Dock = DockStyle.Left;
            PnlLateral.Location = new Point(0, 0);
            PnlLateral.Name = "PnlLateral";
            PnlLateral.Size = new Size(200, 643);
            PnlLateral.TabIndex = 0;
            // 
            // BtnSair
            // 
            BtnSair.Cursor = Cursors.Hand;
            BtnSair.Dock = DockStyle.Top;
            BtnSair.FlatAppearance.BorderSize = 0;
            BtnSair.FlatStyle = FlatStyle.Flat;
            BtnSair.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSair.ForeColor = Color.White;
            BtnSair.Image = (Image)resources.GetObject("BtnSair.Image");
            BtnSair.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSair.Location = new Point(0, 156);
            BtnSair.Name = "BtnSair";
            BtnSair.Padding = new Padding(50, 0, 0, 0);
            BtnSair.Size = new Size(196, 78);
            BtnSair.TabIndex = 2;
            BtnSair.Text = "Sair";
            BtnSair.TextAlign = ContentAlignment.MiddleRight;
            BtnSair.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSair.UseVisualStyleBackColor = true;
            // 
            // BtnMeusPets
            // 
            BtnMeusPets.Cursor = Cursors.Hand;
            BtnMeusPets.Dock = DockStyle.Top;
            BtnMeusPets.FlatAppearance.BorderSize = 0;
            BtnMeusPets.FlatStyle = FlatStyle.Flat;
            BtnMeusPets.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnMeusPets.ForeColor = Color.White;
            BtnMeusPets.Image = (Image)resources.GetObject("BtnMeusPets.Image");
            BtnMeusPets.ImageAlign = ContentAlignment.MiddleLeft;
            BtnMeusPets.Location = new Point(0, 78);
            BtnMeusPets.Name = "BtnMeusPets";
            BtnMeusPets.Padding = new Padding(50, 0, 0, 0);
            BtnMeusPets.Size = new Size(196, 78);
            BtnMeusPets.TabIndex = 1;
            BtnMeusPets.Text = "Meus Pets";
            BtnMeusPets.TextAlign = ContentAlignment.MiddleRight;
            BtnMeusPets.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnMeusPets.UseVisualStyleBackColor = true;
            BtnMeusPets.Click += BtnMeusPets_Click;
            // 
            // BtnAgendar
            // 
            BtnAgendar.Cursor = Cursors.Hand;
            BtnAgendar.Dock = DockStyle.Top;
            BtnAgendar.FlatAppearance.BorderSize = 0;
            BtnAgendar.FlatStyle = FlatStyle.Flat;
            BtnAgendar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAgendar.ForeColor = Color.White;
            BtnAgendar.Image = (Image)resources.GetObject("BtnAgendar.Image");
            BtnAgendar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgendar.Location = new Point(0, 0);
            BtnAgendar.Name = "BtnAgendar";
            BtnAgendar.Padding = new Padding(50, 0, 0, 0);
            BtnAgendar.Size = new Size(196, 78);
            BtnAgendar.TabIndex = 0;
            BtnAgendar.Text = "Agendar";
            BtnAgendar.TextAlign = ContentAlignment.MiddleRight;
            BtnAgendar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnAgendar.UseVisualStyleBackColor = true;
            BtnAgendar.Click += BtnAgendar_Click;
            // 
            // PnlCabeca
            // 
            PnlCabeca.BackColor = Color.RoyalBlue;
            PnlCabeca.BorderStyle = BorderStyle.Fixed3D;
            PnlCabeca.Controls.Add(LblBemvindo);
            PnlCabeca.Dock = DockStyle.Top;
            PnlCabeca.Location = new Point(200, 0);
            PnlCabeca.Name = "PnlCabeca";
            PnlCabeca.Size = new Size(1251, 100);
            PnlCabeca.TabIndex = 1;
            // 
            // LblBemvindo
            // 
            LblBemvindo.BackColor = Color.RoyalBlue;
            LblBemvindo.Dock = DockStyle.Fill;
            LblBemvindo.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LblBemvindo.ForeColor = Color.White;
            LblBemvindo.Location = new Point(0, 0);
            LblBemvindo.Name = "LblBemvindo";
            LblBemvindo.Size = new Size(1247, 96);
            LblBemvindo.TabIndex = 0;
            LblBemvindo.Text = "label1";
            LblBemvindo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PnlPricipal
            // 
            PnlPricipal.BackColor = Color.RoyalBlue;
            PnlPricipal.Controls.Add(tabControl1);
            PnlPricipal.Dock = DockStyle.Fill;
            PnlPricipal.Location = new Point(200, 100);
            PnlPricipal.Name = "PnlPricipal";
            PnlPricipal.Size = new Size(1251, 543);
            PnlPricipal.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1251, 543);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(64, 64, 64);
            tabPage1.BorderStyle = BorderStyle.Fixed3D;
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.ForeColor = SystemColors.ControlText;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1243, 515);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "TbpAgendar";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(DgvServicos);
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(LblResumo);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(DgvCarrinho);
            splitContainer1.Panel2.Controls.Add(PnlRodapePagar);
            splitContainer1.Panel2.Controls.Add(PnlCabecaPagamneto);
            splitContainer1.Size = new Size(1233, 505);
            splitContainer1.SplitterDistance = 700;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 11;
            // 
            // DgvServicos
            // 
            DgvServicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvServicos.BackgroundColor = Color.Silver;
            DgvServicos.BorderStyle = BorderStyle.None;
            DgvServicos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvServicos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Lime;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(0, 0, 40, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvServicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvServicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(0, 0, 35, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvServicos.DefaultCellStyle = dataGridViewCellStyle2;
            DgvServicos.Dock = DockStyle.Fill;
            DgvServicos.EnableHeadersVisualStyles = false;
            DgvServicos.Location = new Point(0, 100);
            DgvServicos.Name = "DgvServicos";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Salmon;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DgvServicos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DgvServicos.RowHeadersVisible = false;
            DgvServicos.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            DgvServicos.Size = new Size(700, 355);
            DgvServicos.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(BtnAdicionar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 455);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 50);
            panel2.TabIndex = 9;
            // 
            // BtnAdicionar
            // 
            BtnAdicionar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAdicionar.BackColor = Color.RoyalBlue;
            BtnAdicionar.Cursor = Cursors.Hand;
            BtnAdicionar.FlatStyle = FlatStyle.Flat;
            BtnAdicionar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAdicionar.ForeColor = Color.White;
            BtnAdicionar.Image = (Image)resources.GetObject("BtnAdicionar.Image");
            BtnAdicionar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAdicionar.Location = new Point(519, 6);
            BtnAdicionar.Name = "BtnAdicionar";
            BtnAdicionar.Size = new Size(178, 32);
            BtnAdicionar.TabIndex = 0;
            BtnAdicionar.Text = "Adicionar ao Carrinho";
            BtnAdicionar.TextAlign = ContentAlignment.MiddleRight;
            BtnAdicionar.UseVisualStyleBackColor = false;
            BtnAdicionar.Click += BtnAdicionar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(CmbPetAgendar);
            panel1.Controls.Add(LblPetCuidado);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 100);
            panel1.TabIndex = 8;
            // 
            // CmbPetAgendar
            // 
            CmbPetAgendar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbPetAgendar.FormattingEnabled = true;
            CmbPetAgendar.Location = new Point(3, 32);
            CmbPetAgendar.Name = "CmbPetAgendar";
            CmbPetAgendar.Size = new Size(267, 25);
            CmbPetAgendar.TabIndex = 1;
            // 
            // LblPetCuidado
            // 
            LblPetCuidado.AutoSize = true;
            LblPetCuidado.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LblPetCuidado.ForeColor = Color.White;
            LblPetCuidado.Location = new Point(3, 4);
            LblPetCuidado.Name = "LblPetCuidado";
            LblPetCuidado.Size = new Size(267, 25);
            LblPetCuidado.TabIndex = 0;
            LblPetCuidado.Text = "Quem vai receber o cuidado?";
            // 
            // LblResumo
            // 
            LblResumo.AutoSize = true;
            LblResumo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblResumo.ForeColor = Color.White;
            LblResumo.Location = new Point(81, -89);
            LblResumo.Name = "LblResumo";
            LblResumo.Size = new Size(153, 21);
            LblResumo.TabIndex = 7;
            LblResumo.Text = "Resumo do Pedido";
            // 
            // DgvCarrinho
            // 
            DgvCarrinho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvCarrinho.BackgroundColor = Color.Silver;
            DgvCarrinho.BorderStyle = BorderStyle.None;
            DgvCarrinho.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvCarrinho.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Lime;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.Padding = new Padding(0, 0, 40, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DgvCarrinho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DgvCarrinho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new Padding(0, 0, 35, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            DgvCarrinho.DefaultCellStyle = dataGridViewCellStyle5;
            DgvCarrinho.Dock = DockStyle.Fill;
            DgvCarrinho.EnableHeadersVisualStyles = false;
            DgvCarrinho.Location = new Point(0, 57);
            DgvCarrinho.Name = "DgvCarrinho";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.PaleTurquoise;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            DgvCarrinho.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            DgvCarrinho.RowHeadersVisible = false;
            DgvCarrinho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvCarrinho.Size = new Size(528, 348);
            DgvCarrinho.TabIndex = 2;
            DgvCarrinho.CellContentClick += DgvCarrinho_CellContentClick;
            // 
            // PnlRodapePagar
            // 
            PnlRodapePagar.Controls.Add(BtnFinalizar);
            PnlRodapePagar.Controls.Add(LblData);
            PnlRodapePagar.Controls.Add(DtpData);
            PnlRodapePagar.Controls.Add(LblTotal);
            PnlRodapePagar.Dock = DockStyle.Bottom;
            PnlRodapePagar.Location = new Point(0, 405);
            PnlRodapePagar.Name = "PnlRodapePagar";
            PnlRodapePagar.Size = new Size(528, 100);
            PnlRodapePagar.TabIndex = 1;
            // 
            // BtnFinalizar
            // 
            BtnFinalizar.FlatStyle = FlatStyle.Flat;
            BtnFinalizar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnFinalizar.ForeColor = Color.White;
            BtnFinalizar.Location = new Point(329, 28);
            BtnFinalizar.Name = "BtnFinalizar";
            BtnFinalizar.Size = new Size(183, 45);
            BtnFinalizar.TabIndex = 4;
            BtnFinalizar.Text = "Solicitar pedido ";
            BtnFinalizar.UseVisualStyleBackColor = true;
            BtnFinalizar.Click += BtnFinalizar_Click;
            // 
            // LblData
            // 
            LblData.AutoSize = true;
            LblData.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LblData.ForeColor = Color.White;
            LblData.Location = new Point(3, 49);
            LblData.Name = "LblData";
            LblData.Size = new Size(134, 25);
            LblData.TabIndex = 3;
            LblData.Text = "Para quando?";
            // 
            // DtpData
            // 
            DtpData.CustomFormat = "dd/MM/yyyy HH:mm";
            DtpData.Format = DateTimePickerFormat.Custom;
            DtpData.Location = new Point(143, 50);
            DtpData.Name = "DtpData";
            DtpData.Size = new Size(135, 23);
            DtpData.TabIndex = 2;
            // 
            // LblTotal
            // 
            LblTotal.AutoSize = true;
            LblTotal.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LblTotal.ForeColor = Color.White;
            LblTotal.Location = new Point(3, 5);
            LblTotal.Name = "LblTotal";
            LblTotal.Size = new Size(172, 32);
            LblTotal.TabIndex = 1;
            LblTotal.Text = "Total: R$ 0,00";
            // 
            // PnlCabecaPagamneto
            // 
            PnlCabecaPagamneto.Controls.Add(LblPedido);
            PnlCabecaPagamneto.Dock = DockStyle.Top;
            PnlCabecaPagamneto.Location = new Point(0, 0);
            PnlCabecaPagamneto.Name = "PnlCabecaPagamneto";
            PnlCabecaPagamneto.Size = new Size(528, 57);
            PnlCabecaPagamneto.TabIndex = 0;
            // 
            // LblPedido
            // 
            LblPedido.Dock = DockStyle.Fill;
            LblPedido.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LblPedido.ForeColor = Color.White;
            LblPedido.Location = new Point(0, 0);
            LblPedido.Name = "LblPedido";
            LblPedido.Size = new Size(528, 57);
            LblPedido.TabIndex = 1;
            LblPedido.Text = "Resumo do Pedido";
            LblPedido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1243, 515);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // LblResumoP
            // 
            LblResumoP.Dock = DockStyle.Fill;
            LblResumoP.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LblResumoP.ForeColor = Color.White;
            LblResumoP.Location = new Point(0, 0);
            LblResumoP.Name = "LblResumoP";
            LblResumoP.Size = new Size(817, 43);
            LblResumoP.TabIndex = 0;
            LblResumoP.Text = "Resumo do Pedido";
            LblResumoP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tela_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1451, 643);
            Controls.Add(PnlPricipal);
            Controls.Add(PnlCabeca);
            Controls.Add(PnlLateral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Tela_Cliente";
            Text = "Tela_Cliente";
            PnlLateral.ResumeLayout(false);
            PnlCabeca.ResumeLayout(false);
            PnlPricipal.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvServicos).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCarrinho).EndInit();
            PnlRodapePagar.ResumeLayout(false);
            PnlRodapePagar.PerformLayout();
            PnlCabecaPagamneto.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlLateral;
        private Panel PnlCabeca;
        private Panel PnlPricipal;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button BtnAgendar;
        private Button BtnMeusPets;
        private Button BtnSair;
        private Label LblBemvindo;
        private Label LblResumo;
        private SplitContainer splitContainer1;
        private Panel panel1;
        private Label LblPetCuidado;
        private DataGridView DgvServicos;
        private Panel panel2;
        private Button BtnAdicionar;
        private ComboBox CmbPetAgendar;
        private Panel panel3;
        private Label LblResumoP;
        private Panel PnlRodapePagar;
        private Panel PnlCabecaPagamneto;
        private Label LblPedido;
        private DateTimePicker DtpData;
        private Label LblTotal;
        private Button BtnFinalizar;
        private Label LblData;
        private DataGridView DgvCarrinho;
    }
}