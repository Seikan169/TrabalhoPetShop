namespace Shop.TelaFuncionarios
{
    partial class TelaPrincipalADM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalADM));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            timer1 = new System.Windows.Forms.Timer(components);
            PnlBotoes = new Panel();
            BtnSairADM = new Button();
            BtnRelatorioADM = new Button();
            BtnPainelFinanceiroADM = new Button();
            BtnClentesCadastradosADM = new Button();
            BtnTelaFuncionario = new Button();
            BtnAgendamentoADM = new Button();
            BtnBuscarFuncionario = new Button();
            BtnControleFuncionario = new Button();
            pictureBox1 = new PictureBox();
            LblNomeAdm = new Label();
            PnLCabeca = new Panel();
            LblTitulo = new Label();
            LblDATA = new Label();
            DgvPricipal = new DataGridView();
            PnlConteudoBaixo = new Panel();
            FlowPanelGrafico = new FlowLayoutPanel();
            PnlCardVendas = new Panel();
            label2 = new Label();
            LblVendaHj = new Label();
            panel2 = new Panel();
            LblValorMes = new Label();
            LblMes = new Label();
            PnlVendasCard = new Panel();
            LblQtdPendentes = new Label();
            lBLPendente = new Label();
            PnlCardClientes = new Panel();
            LblQTDClientes = new Label();
            LblClientes = new Label();
            ChartPedidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            PnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PnLCabeca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPricipal).BeginInit();
            PnlConteudoBaixo.SuspendLayout();
            FlowPanelGrafico.SuspendLayout();
            PnlCardVendas.SuspendLayout();
            panel2.SuspendLayout();
            PnlVendasCard.SuspendLayout();
            PnlCardClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ChartPedidos).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // PnlBotoes
            // 
            PnlBotoes.BackColor = Color.DodgerBlue;
            PnlBotoes.BorderStyle = BorderStyle.Fixed3D;
            PnlBotoes.Controls.Add(BtnSairADM);
            PnlBotoes.Controls.Add(BtnRelatorioADM);
            PnlBotoes.Controls.Add(BtnPainelFinanceiroADM);
            PnlBotoes.Controls.Add(BtnClentesCadastradosADM);
            PnlBotoes.Controls.Add(BtnTelaFuncionario);
            PnlBotoes.Controls.Add(BtnAgendamentoADM);
            PnlBotoes.Controls.Add(BtnBuscarFuncionario);
            PnlBotoes.Controls.Add(BtnControleFuncionario);
            PnlBotoes.Controls.Add(pictureBox1);
            PnlBotoes.Controls.Add(LblNomeAdm);
            PnlBotoes.Dock = DockStyle.Left;
            PnlBotoes.Location = new Point(0, 0);
            PnlBotoes.Margin = new Padding(3, 2, 3, 2);
            PnlBotoes.Name = "PnlBotoes";
            PnlBotoes.Size = new Size(180, 555);
            PnlBotoes.TabIndex = 5;
            PnlBotoes.Paint += PnlBotoes_Paint;
            // 
            // BtnSairADM
            // 
            BtnSairADM.BackColor = Color.DodgerBlue;
            BtnSairADM.Cursor = Cursors.Hand;
            BtnSairADM.Dock = DockStyle.Bottom;
            BtnSairADM.FlatStyle = FlatStyle.Popup;
            BtnSairADM.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSairADM.Image = (Image)resources.GetObject("BtnSairADM.Image");
            BtnSairADM.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSairADM.Location = new Point(0, 511);
            BtnSairADM.Margin = new Padding(3, 2, 3, 2);
            BtnSairADM.Name = "BtnSairADM";
            BtnSairADM.Size = new Size(176, 40);
            BtnSairADM.TabIndex = 10;
            BtnSairADM.Text = "Sair";
            BtnSairADM.UseVisualStyleBackColor = false;
            BtnSairADM.Click += BtnSairADM_Click_1;
            // 
            // BtnRelatorioADM
            // 
            BtnRelatorioADM.BackColor = SystemColors.ControlDarkDark;
            BtnRelatorioADM.Cursor = Cursors.Hand;
            BtnRelatorioADM.Dock = DockStyle.Top;
            BtnRelatorioADM.FlatAppearance.BorderSize = 0;
            BtnRelatorioADM.FlatStyle = FlatStyle.Flat;
            BtnRelatorioADM.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRelatorioADM.ForeColor = Color.FromArgb(128, 255, 128);
            BtnRelatorioADM.Image = (Image)resources.GetObject("BtnRelatorioADM.Image");
            BtnRelatorioADM.ImageAlign = ContentAlignment.MiddleLeft;
            BtnRelatorioADM.Location = new Point(0, 404);
            BtnRelatorioADM.Margin = new Padding(3, 2, 3, 2);
            BtnRelatorioADM.Name = "BtnRelatorioADM";
            BtnRelatorioADM.Size = new Size(176, 36);
            BtnRelatorioADM.TabIndex = 1;
            BtnRelatorioADM.Text = "Relatórios ";
            BtnRelatorioADM.UseVisualStyleBackColor = false;
            // 
            // BtnPainelFinanceiroADM
            // 
            BtnPainelFinanceiroADM.BackColor = SystemColors.ControlDarkDark;
            BtnPainelFinanceiroADM.Cursor = Cursors.Hand;
            BtnPainelFinanceiroADM.Dock = DockStyle.Top;
            BtnPainelFinanceiroADM.FlatAppearance.BorderSize = 0;
            BtnPainelFinanceiroADM.FlatStyle = FlatStyle.Flat;
            BtnPainelFinanceiroADM.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPainelFinanceiroADM.ForeColor = Color.White;
            BtnPainelFinanceiroADM.Image = (Image)resources.GetObject("BtnPainelFinanceiroADM.Image");
            BtnPainelFinanceiroADM.ImageAlign = ContentAlignment.MiddleLeft;
            BtnPainelFinanceiroADM.Location = new Point(0, 364);
            BtnPainelFinanceiroADM.Margin = new Padding(3, 2, 3, 2);
            BtnPainelFinanceiroADM.Name = "BtnPainelFinanceiroADM";
            BtnPainelFinanceiroADM.Size = new Size(176, 40);
            BtnPainelFinanceiroADM.TabIndex = 1;
            BtnPainelFinanceiroADM.Text = "Painel Financeiro";
            BtnPainelFinanceiroADM.UseVisualStyleBackColor = false;
            BtnPainelFinanceiroADM.Click += BtnPainelFinanceiroADM_Click;
            // 
            // BtnClentesCadastradosADM
            // 
            BtnClentesCadastradosADM.BackColor = SystemColors.ControlDarkDark;
            BtnClentesCadastradosADM.Cursor = Cursors.Hand;
            BtnClentesCadastradosADM.Dock = DockStyle.Top;
            BtnClentesCadastradosADM.FlatAppearance.BorderSize = 0;
            BtnClentesCadastradosADM.FlatStyle = FlatStyle.Flat;
            BtnClentesCadastradosADM.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnClentesCadastradosADM.ForeColor = Color.White;
            BtnClentesCadastradosADM.Image = (Image)resources.GetObject("BtnClentesCadastradosADM.Image");
            BtnClentesCadastradosADM.ImageAlign = ContentAlignment.MiddleLeft;
            BtnClentesCadastradosADM.Location = new Point(0, 316);
            BtnClentesCadastradosADM.Margin = new Padding(3, 2, 3, 2);
            BtnClentesCadastradosADM.Name = "BtnClentesCadastradosADM";
            BtnClentesCadastradosADM.Size = new Size(176, 48);
            BtnClentesCadastradosADM.TabIndex = 6;
            BtnClentesCadastradosADM.Text = "    Clientes Cadastrados";
            BtnClentesCadastradosADM.UseVisualStyleBackColor = false;
            BtnClentesCadastradosADM.Click += BtnClentesCadastradosADM_Click;
            // 
            // BtnTelaFuncionario
            // 
            BtnTelaFuncionario.BackColor = SystemColors.ControlDarkDark;
            BtnTelaFuncionario.Cursor = Cursors.Hand;
            BtnTelaFuncionario.Dock = DockStyle.Top;
            BtnTelaFuncionario.FlatAppearance.BorderSize = 0;
            BtnTelaFuncionario.FlatStyle = FlatStyle.Flat;
            BtnTelaFuncionario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnTelaFuncionario.ForeColor = Color.White;
            BtnTelaFuncionario.Image = (Image)resources.GetObject("BtnTelaFuncionario.Image");
            BtnTelaFuncionario.ImageAlign = ContentAlignment.MiddleLeft;
            BtnTelaFuncionario.Location = new Point(0, 261);
            BtnTelaFuncionario.Margin = new Padding(3, 2, 3, 2);
            BtnTelaFuncionario.Name = "BtnTelaFuncionario";
            BtnTelaFuncionario.Size = new Size(176, 55);
            BtnTelaFuncionario.TabIndex = 8;
            BtnTelaFuncionario.Text = "Tela Funcionário";
            BtnTelaFuncionario.UseVisualStyleBackColor = false;
            // 
            // BtnAgendamentoADM
            // 
            BtnAgendamentoADM.BackColor = SystemColors.ControlDarkDark;
            BtnAgendamentoADM.Cursor = Cursors.Hand;
            BtnAgendamentoADM.Dock = DockStyle.Top;
            BtnAgendamentoADM.FlatAppearance.BorderSize = 0;
            BtnAgendamentoADM.FlatStyle = FlatStyle.Flat;
            BtnAgendamentoADM.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAgendamentoADM.ForeColor = Color.White;
            BtnAgendamentoADM.Image = (Image)resources.GetObject("BtnAgendamentoADM.Image");
            BtnAgendamentoADM.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgendamentoADM.Location = new Point(0, 213);
            BtnAgendamentoADM.Margin = new Padding(3, 2, 3, 2);
            BtnAgendamentoADM.Name = "BtnAgendamentoADM";
            BtnAgendamentoADM.Size = new Size(176, 48);
            BtnAgendamentoADM.TabIndex = 4;
            BtnAgendamentoADM.Text = "    Agendamento Clientes";
            BtnAgendamentoADM.UseVisualStyleBackColor = false;
            BtnAgendamentoADM.Click += BtnAgendamentoADM_Click;
            // 
            // BtnBuscarFuncionario
            // 
            BtnBuscarFuncionario.BackColor = SystemColors.ControlDarkDark;
            BtnBuscarFuncionario.Cursor = Cursors.Hand;
            BtnBuscarFuncionario.Dock = DockStyle.Top;
            BtnBuscarFuncionario.FlatAppearance.BorderSize = 0;
            BtnBuscarFuncionario.FlatStyle = FlatStyle.Flat;
            BtnBuscarFuncionario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBuscarFuncionario.ForeColor = Color.White;
            BtnBuscarFuncionario.Image = (Image)resources.GetObject("BtnBuscarFuncionario.Image");
            BtnBuscarFuncionario.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBuscarFuncionario.Location = new Point(0, 165);
            BtnBuscarFuncionario.Margin = new Padding(3, 2, 3, 2);
            BtnBuscarFuncionario.Name = "BtnBuscarFuncionario";
            BtnBuscarFuncionario.Size = new Size(176, 48);
            BtnBuscarFuncionario.TabIndex = 7;
            BtnBuscarFuncionario.Text = "  Buscar Funcionarios ";
            BtnBuscarFuncionario.UseVisualStyleBackColor = false;
            BtnBuscarFuncionario.Click += BtnBuscarADM_Click_1;
            // 
            // BtnControleFuncionario
            // 
            BtnControleFuncionario.BackColor = SystemColors.ControlDarkDark;
            BtnControleFuncionario.Cursor = Cursors.Hand;
            BtnControleFuncionario.Dock = DockStyle.Top;
            BtnControleFuncionario.FlatAppearance.BorderSize = 0;
            BtnControleFuncionario.FlatStyle = FlatStyle.Flat;
            BtnControleFuncionario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnControleFuncionario.ForeColor = Color.White;
            BtnControleFuncionario.Image = (Image)resources.GetObject("BtnControleFuncionario.Image");
            BtnControleFuncionario.ImageAlign = ContentAlignment.MiddleLeft;
            BtnControleFuncionario.Location = new Point(0, 105);
            BtnControleFuncionario.Margin = new Padding(3, 2, 3, 2);
            BtnControleFuncionario.Name = "BtnControleFuncionario";
            BtnControleFuncionario.Size = new Size(176, 60);
            BtnControleFuncionario.TabIndex = 1;
            BtnControleFuncionario.Text = "Cadastro de Funcionário";
            BtnControleFuncionario.TextAlign = ContentAlignment.MiddleRight;
            BtnControleFuncionario.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 36);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // LblNomeAdm
            // 
            LblNomeAdm.BackColor = Color.DodgerBlue;
            LblNomeAdm.Dock = DockStyle.Top;
            LblNomeAdm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNomeAdm.ForeColor = Color.White;
            LblNomeAdm.Location = new Point(0, 0);
            LblNomeAdm.Name = "LblNomeAdm";
            LblNomeAdm.Size = new Size(176, 36);
            LblNomeAdm.TabIndex = 11;
            LblNomeAdm.Text = "label1";
            LblNomeAdm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PnLCabeca
            // 
            PnLCabeca.BackColor = SystemColors.Highlight;
            PnLCabeca.BorderStyle = BorderStyle.Fixed3D;
            PnLCabeca.Controls.Add(LblTitulo);
            PnLCabeca.Controls.Add(LblDATA);
            PnLCabeca.Dock = DockStyle.Top;
            PnLCabeca.Location = new Point(180, 0);
            PnLCabeca.Name = "PnLCabeca";
            PnLCabeca.Size = new Size(1270, 50);
            PnLCabeca.TabIndex = 2;
            // 
            // LblTitulo
            // 
            LblTitulo.BackColor = Color.DodgerBlue;
            LblTitulo.Dock = DockStyle.Fill;
            LblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.ForeColor = Color.White;
            LblTitulo.Location = new Point(0, 0);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(1004, 46);
            LblTitulo.TabIndex = 14;
            LblTitulo.Text = "label2";
            LblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblDATA
            // 
            LblDATA.BackColor = Color.DodgerBlue;
            LblDATA.Dock = DockStyle.Right;
            LblDATA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblDATA.ForeColor = Color.White;
            LblDATA.Location = new Point(1004, 0);
            LblDATA.Name = "LblDATA";
            LblDATA.Size = new Size(262, 46);
            LblDATA.TabIndex = 15;
            LblDATA.Text = "label2";
            LblDATA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DgvPricipal
            // 
            DgvPricipal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPricipal.BackgroundColor = Color.WhiteSmoke;
            DgvPricipal.BorderStyle = BorderStyle.Fixed3D;
            DgvPricipal.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvPricipal.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DimGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(0, 0, 40, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvPricipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvPricipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(0, 0, 35, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvPricipal.DefaultCellStyle = dataGridViewCellStyle2;
            DgvPricipal.Dock = DockStyle.Fill;
            DgvPricipal.EnableHeadersVisualStyles = false;
            DgvPricipal.GridColor = Color.Black;
            DgvPricipal.Location = new Point(180, 50);
            DgvPricipal.Name = "DgvPricipal";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Salmon;
            dataGridViewCellStyle3.SelectionForeColor = Color.RoyalBlue;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DgvPricipal.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DgvPricipal.RowHeadersVisible = false;
            DgvPricipal.RowHeadersWidth = 51;
            DgvPricipal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvPricipal.Size = new Size(1270, 505);
            DgvPricipal.TabIndex = 1;
            DgvPricipal.Visible = false;
            DgvPricipal.CellContentClick += DgvPricipal_CellContentClick;
            // 
            // PnlConteudoBaixo
            // 
            PnlConteudoBaixo.BackColor = Color.White;
            PnlConteudoBaixo.BorderStyle = BorderStyle.Fixed3D;
            PnlConteudoBaixo.Controls.Add(FlowPanelGrafico);
            PnlConteudoBaixo.Controls.Add(ChartPedidos);
            PnlConteudoBaixo.Dock = DockStyle.Fill;
            PnlConteudoBaixo.Location = new Point(180, 50);
            PnlConteudoBaixo.Name = "PnlConteudoBaixo";
            PnlConteudoBaixo.Size = new Size(1270, 505);
            PnlConteudoBaixo.TabIndex = 4;
            // 
            // FlowPanelGrafico
            // 
            FlowPanelGrafico.BackColor = Color.White;
            FlowPanelGrafico.BorderStyle = BorderStyle.Fixed3D;
            FlowPanelGrafico.Controls.Add(PnlCardVendas);
            FlowPanelGrafico.Controls.Add(panel2);
            FlowPanelGrafico.Controls.Add(PnlVendasCard);
            FlowPanelGrafico.Controls.Add(PnlCardClientes);
            FlowPanelGrafico.Dock = DockStyle.Top;
            FlowPanelGrafico.Location = new Point(0, 0);
            FlowPanelGrafico.Name = "FlowPanelGrafico";
            FlowPanelGrafico.Padding = new Padding(20);
            FlowPanelGrafico.Size = new Size(908, 468);
            FlowPanelGrafico.TabIndex = 4;
            // 
            // PnlCardVendas
            // 
            PnlCardVendas.BackColor = Color.RoyalBlue;
            PnlCardVendas.BorderStyle = BorderStyle.Fixed3D;
            PnlCardVendas.Controls.Add(label2);
            PnlCardVendas.Controls.Add(LblVendaHj);
            PnlCardVendas.Location = new Point(23, 23);
            PnlCardVendas.Name = "PnlCardVendas";
            PnlCardVendas.Size = new Size(250, 140);
            PnlCardVendas.TabIndex = 0;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(246, 45);
            label2.TabIndex = 2;
            label2.Text = "Vendas Hoje: ";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblVendaHj
            // 
            LblVendaHj.AutoSize = true;
            LblVendaHj.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblVendaHj.Location = new Point(3, 45);
            LblVendaHj.Name = "LblVendaHj";
            LblVendaHj.Size = new Size(131, 45);
            LblVendaHj.TabIndex = 1;
            LblVendaHj.Text = "R$ 0,00";
            // 
            // panel2
            // 
            panel2.BackColor = Color.BlueViolet;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(LblValorMes);
            panel2.Controls.Add(LblMes);
            panel2.Location = new Point(279, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 140);
            panel2.TabIndex = 3;
            // 
            // LblValorMes
            // 
            LblValorMes.AutoSize = true;
            LblValorMes.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblValorMes.Location = new Point(3, 45);
            LblValorMes.Name = "LblValorMes";
            LblValorMes.Size = new Size(131, 45);
            LblValorMes.TabIndex = 5;
            LblValorMes.Text = "R$ 0,00";
            // 
            // LblMes
            // 
            LblMes.BackColor = Color.Transparent;
            LblMes.Dock = DockStyle.Top;
            LblMes.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblMes.Image = (Image)resources.GetObject("LblMes.Image");
            LblMes.ImageAlign = ContentAlignment.MiddleRight;
            LblMes.Location = new Point(0, 0);
            LblMes.Name = "LblMes";
            LblMes.Size = new Size(246, 34);
            LblMes.TabIndex = 4;
            LblMes.Text = "Vendas do mês ";
            // 
            // PnlVendasCard
            // 
            PnlVendasCard.BackColor = Color.DarkOrange;
            PnlVendasCard.BorderStyle = BorderStyle.Fixed3D;
            PnlVendasCard.Controls.Add(LblQtdPendentes);
            PnlVendasCard.Controls.Add(lBLPendente);
            PnlVendasCard.Location = new Point(535, 23);
            PnlVendasCard.Name = "PnlVendasCard";
            PnlVendasCard.Size = new Size(250, 140);
            PnlVendasCard.TabIndex = 1;
            // 
            // LblQtdPendentes
            // 
            LblQtdPendentes.AutoSize = true;
            LblQtdPendentes.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblQtdPendentes.Location = new Point(3, 45);
            LblQtdPendentes.Name = "LblQtdPendentes";
            LblQtdPendentes.Size = new Size(0, 45);
            LblQtdPendentes.TabIndex = 4;
            // 
            // lBLPendente
            // 
            lBLPendente.BackColor = Color.Transparent;
            lBLPendente.Dock = DockStyle.Top;
            lBLPendente.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lBLPendente.ImageAlign = ContentAlignment.MiddleRight;
            lBLPendente.Location = new Point(0, 0);
            lBLPendente.Name = "lBLPendente";
            lBLPendente.Size = new Size(246, 34);
            lBLPendente.TabIndex = 3;
            lBLPendente.Text = "Pendente";
            // 
            // PnlCardClientes
            // 
            PnlCardClientes.BackColor = Color.SeaGreen;
            PnlCardClientes.BorderStyle = BorderStyle.Fixed3D;
            PnlCardClientes.Controls.Add(LblQTDClientes);
            PnlCardClientes.Controls.Add(LblClientes);
            PnlCardClientes.Location = new Point(23, 169);
            PnlCardClientes.Name = "PnlCardClientes";
            PnlCardClientes.Size = new Size(250, 140);
            PnlCardClientes.TabIndex = 2;
            // 
            // LblQTDClientes
            // 
            LblQTDClientes.AutoSize = true;
            LblQTDClientes.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblQTDClientes.Location = new Point(3, 45);
            LblQTDClientes.Name = "LblQTDClientes";
            LblQTDClientes.Size = new Size(0, 45);
            LblQTDClientes.TabIndex = 5;
            // 
            // LblClientes
            // 
            LblClientes.BackColor = Color.Transparent;
            LblClientes.Dock = DockStyle.Top;
            LblClientes.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblClientes.Image = (Image)resources.GetObject("LblClientes.Image");
            LblClientes.ImageAlign = ContentAlignment.MiddleRight;
            LblClientes.Location = new Point(0, 0);
            LblClientes.Name = "LblClientes";
            LblClientes.Size = new Size(246, 34);
            LblClientes.TabIndex = 4;
            LblClientes.Text = "Clientes";
            // 
            // ChartPedidos
            // 
            ChartPedidos.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.BackColor = Color.White;
            chartArea1.BorderColor = Color.Transparent;
            chartArea1.Name = "ChartArea1";
            ChartPedidos.ChartAreas.Add(chartArea1);
            ChartPedidos.Dock = DockStyle.Right;
            legend1.Alignment = StringAlignment.Center;
            legend1.BackColor = Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            ChartPedidos.Legends.Add(legend1);
            ChartPedidos.Location = new Point(908, 0);
            ChartPedidos.Name = "ChartPedidos";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.CustomProperties = "DoughnutRadius=70";
            series1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            series1.LabelForeColor = Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            ChartPedidos.Series.Add(series1);
            ChartPedidos.Size = new Size(358, 501);
            ChartPedidos.TabIndex = 0;
            ChartPedidos.Text = "chart1";
            // 
            // TelaPrincipalADM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1450, 555);
            Controls.Add(PnlConteudoBaixo);
            Controls.Add(DgvPricipal);
            Controls.Add(PnLCabeca);
            Controls.Add(PnlBotoes);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaPrincipalADM";
            Text = "TelaPrincipalADM";
            Load += TelaPrincipalADM_Load;
            PnlBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PnLCabeca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvPricipal).EndInit();
            PnlConteudoBaixo.ResumeLayout(false);
            FlowPanelGrafico.ResumeLayout(false);
            PnlCardVendas.ResumeLayout(false);
            PnlCardVendas.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            PnlVendasCard.ResumeLayout(false);
            PnlVendasCard.PerformLayout();
            PnlCardClientes.ResumeLayout(false);
            PnlCardClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ChartPedidos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel4;
        private System.Windows.Forms.Timer timer1;
        private Panel PnlBotoes;
        private Button BtnSairADM;
        private Button BtnRelatorioADM;
        private Button BtnPainelFinanceiroADM;
        private Button BtnClentesCadastradosADM;
        private Button BtnTelaFuncionario;
        private Button BtnAgendamentoADM;
        private Button BtnBuscarFuncionario;
        private Button BtnControleFuncionario;
        private PictureBox pictureBox1;
        private Label LblNomeAdm;
        private Panel PnLCabeca;
        private Label LblTitulo;
        private Label LblDATA;
        private DataGridView DgvPricipal;
        private Panel PnlConteudoBaixo;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartPedidos;
        private FlowLayoutPanel FlowPanelGrafico;
        private Panel PnlCardVendas;
        private Label label2;
        private Label LblVendaHj;
        private Panel panel2;
        private Label LblValorMes;
        private Label LblMes;
        private Panel PnlVendasCard;
        private Label LblQtdPendentes;
        private Label lBLPendente;
        private Panel PnlCardClientes;
        private Label LblQTDClientes;
        private Label LblClientes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVendas;
    }
}