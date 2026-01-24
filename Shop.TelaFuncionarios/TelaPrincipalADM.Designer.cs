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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            BtnSairADM = new Button();
            BtnRelatorioADM = new Button();
            BtnPainelFinanceiroADM = new Button();
            BtnClentesCadastradosADM = new Button();
            BtnTelaFuncionario = new Button();
            BtnAgendamentoADM = new Button();
            BtnBuscarADM = new Button();
            BtnControleFuncionario = new Button();
            pictureBox1 = new PictureBox();
            LblNomeAdm = new Label();
            PanelCentralADM = new Panel();
            PnlConteudoBaixo = new Panel();
            ChartPedidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            PnLCabeca = new Panel();
            LblTitulo = new Label();
            LblDATA = new Label();
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
            DgvPricipal = new DataGridView();
            PnlCardClientes = new Panel();
            LblQTDClientes = new Label();
            LblClientes = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelCentralADM.SuspendLayout();
            PnlConteudoBaixo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ChartPedidos).BeginInit();
            PnLCabeca.SuspendLayout();
            FlowPanelGrafico.SuspendLayout();
            PnlCardVendas.SuspendLayout();
            panel2.SuspendLayout();
            PnlVendasCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPricipal).BeginInit();
            PnlCardClientes.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(BtnSairADM);
            panel1.Controls.Add(BtnRelatorioADM);
            panel1.Controls.Add(BtnPainelFinanceiroADM);
            panel1.Controls.Add(BtnClentesCadastradosADM);
            panel1.Controls.Add(BtnTelaFuncionario);
            panel1.Controls.Add(BtnAgendamentoADM);
            panel1.Controls.Add(BtnBuscarADM);
            panel1.Controls.Add(BtnControleFuncionario);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(LblNomeAdm);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 555);
            panel1.TabIndex = 0;
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
            BtnSairADM.Click += BtnSairADM_Click;
            // 
            // BtnRelatorioADM
            // 
            BtnRelatorioADM.BackColor = SystemColors.ControlDarkDark;
            BtnRelatorioADM.Cursor = Cursors.Hand;
            BtnRelatorioADM.Dock = DockStyle.Top;
            BtnRelatorioADM.FlatAppearance.BorderSize = 0;
            BtnRelatorioADM.FlatStyle = FlatStyle.Flat;
            BtnRelatorioADM.Image = (Image)resources.GetObject("BtnRelatorioADM.Image");
            BtnRelatorioADM.ImageAlign = ContentAlignment.MiddleLeft;
            BtnRelatorioADM.Location = new Point(0, 404);
            BtnRelatorioADM.Margin = new Padding(3, 2, 3, 2);
            BtnRelatorioADM.Name = "BtnRelatorioADM";
            BtnRelatorioADM.Size = new Size(176, 48);
            BtnRelatorioADM.TabIndex = 1;
            BtnRelatorioADM.Text = "Relatórios ";
            BtnRelatorioADM.UseVisualStyleBackColor = false;
            BtnRelatorioADM.Click += BtnRelatorioADM_Click;
            // 
            // BtnPainelFinanceiroADM
            // 
            BtnPainelFinanceiroADM.BackColor = SystemColors.ControlDarkDark;
            BtnPainelFinanceiroADM.Cursor = Cursors.Hand;
            BtnPainelFinanceiroADM.Dock = DockStyle.Top;
            BtnPainelFinanceiroADM.FlatAppearance.BorderSize = 0;
            BtnPainelFinanceiroADM.FlatStyle = FlatStyle.Flat;
            BtnPainelFinanceiroADM.Image = (Image)resources.GetObject("BtnPainelFinanceiroADM.Image");
            BtnPainelFinanceiroADM.ImageAlign = ContentAlignment.MiddleLeft;
            BtnPainelFinanceiroADM.Location = new Point(0, 364);
            BtnPainelFinanceiroADM.Margin = new Padding(3, 2, 3, 2);
            BtnPainelFinanceiroADM.Name = "BtnPainelFinanceiroADM";
            BtnPainelFinanceiroADM.Size = new Size(176, 40);
            BtnPainelFinanceiroADM.TabIndex = 1;
            BtnPainelFinanceiroADM.Text = "Painel Financeiro";
            BtnPainelFinanceiroADM.UseVisualStyleBackColor = false;
            // 
            // BtnClentesCadastradosADM
            // 
            BtnClentesCadastradosADM.BackColor = SystemColors.ControlDarkDark;
            BtnClentesCadastradosADM.Cursor = Cursors.Hand;
            BtnClentesCadastradosADM.Dock = DockStyle.Top;
            BtnClentesCadastradosADM.FlatAppearance.BorderSize = 0;
            BtnClentesCadastradosADM.FlatStyle = FlatStyle.Flat;
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
            // BtnBuscarADM
            // 
            BtnBuscarADM.BackColor = SystemColors.ControlDarkDark;
            BtnBuscarADM.Cursor = Cursors.Hand;
            BtnBuscarADM.Dock = DockStyle.Top;
            BtnBuscarADM.FlatAppearance.BorderSize = 0;
            BtnBuscarADM.FlatStyle = FlatStyle.Flat;
            BtnBuscarADM.ForeColor = Color.White;
            BtnBuscarADM.Image = (Image)resources.GetObject("BtnBuscarADM.Image");
            BtnBuscarADM.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBuscarADM.Location = new Point(0, 165);
            BtnBuscarADM.Margin = new Padding(3, 2, 3, 2);
            BtnBuscarADM.Name = "BtnBuscarADM";
            BtnBuscarADM.Size = new Size(176, 48);
            BtnBuscarADM.TabIndex = 7;
            BtnBuscarADM.Text = "  Buscar Funcionarios ";
            BtnBuscarADM.UseVisualStyleBackColor = false;
            BtnBuscarADM.Click += BtnBuscarADM_Click;
            // 
            // BtnControleFuncionario
            // 
            BtnControleFuncionario.BackColor = SystemColors.ControlDarkDark;
            BtnControleFuncionario.Cursor = Cursors.Hand;
            BtnControleFuncionario.Dock = DockStyle.Top;
            BtnControleFuncionario.FlatAppearance.BorderSize = 0;
            BtnControleFuncionario.FlatStyle = FlatStyle.Flat;
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
            BtnControleFuncionario.Click += BtnControleFuncionario_Click;
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
            pictureBox1.Click += pictureBox1_Click;
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
            // PanelCentralADM
            // 
            PanelCentralADM.BackColor = Color.Transparent;
            PanelCentralADM.BorderStyle = BorderStyle.Fixed3D;
            PanelCentralADM.Controls.Add(PnlConteudoBaixo);
            PanelCentralADM.Controls.Add(FlowPanelGrafico);
            PanelCentralADM.Controls.Add(PnLCabeca);
            PanelCentralADM.Dock = DockStyle.Fill;
            PanelCentralADM.Location = new Point(180, 0);
            PanelCentralADM.Margin = new Padding(3, 2, 3, 2);
            PanelCentralADM.Name = "PanelCentralADM";
            PanelCentralADM.Size = new Size(1125, 555);
            PanelCentralADM.TabIndex = 2;
            // 
            // PnlConteudoBaixo
            // 
            PnlConteudoBaixo.BorderStyle = BorderStyle.Fixed3D;
            PnlConteudoBaixo.Controls.Add(ChartPedidos);
            PnlConteudoBaixo.Dock = DockStyle.Fill;
            PnlConteudoBaixo.Location = new Point(0, 231);
            PnlConteudoBaixo.Name = "PnlConteudoBaixo";
            PnlConteudoBaixo.Size = new Size(1121, 320);
            PnlConteudoBaixo.TabIndex = 4;
            // 
            // ChartPedidos
            // 
            chartArea1.BackColor = Color.White;
            chartArea1.BorderColor = Color.Transparent;
            chartArea1.Name = "ChartArea1";
            ChartPedidos.ChartAreas.Add(chartArea1);
            legend1.Alignment = StringAlignment.Center;
            legend1.BackColor = Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            ChartPedidos.Legends.Add(legend1);
            ChartPedidos.Location = new Point(333, 6);
            ChartPedidos.Name = "ChartPedidos";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.CustomProperties = "DoughnutRadius=70";
            series1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            series1.LabelForeColor = Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            ChartPedidos.Series.Add(series1);
            ChartPedidos.Size = new Size(300, 300);
            ChartPedidos.TabIndex = 0;
            ChartPedidos.Text = "chart1";
            // 
            // PnLCabeca
            // 
            PnLCabeca.BackColor = SystemColors.Highlight;
            PnLCabeca.BorderStyle = BorderStyle.Fixed3D;
            PnLCabeca.Controls.Add(LblTitulo);
            PnLCabeca.Controls.Add(LblDATA);
            PnLCabeca.Dock = DockStyle.Top;
            PnLCabeca.Location = new Point(0, 0);
            PnLCabeca.Name = "PnLCabeca";
            PnLCabeca.Size = new Size(1121, 50);
            PnLCabeca.TabIndex = 2;
            // 
            // LblTitulo
            // 
            LblTitulo.BackColor = Color.DodgerBlue;
            LblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.ForeColor = Color.White;
            LblTitulo.Location = new Point(41, 0);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(814, 46);
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
            LblDATA.Location = new Point(855, 0);
            LblDATA.Name = "LblDATA";
            LblDATA.Size = new Size(262, 46);
            LblDATA.TabIndex = 15;
            LblDATA.Text = "label2";
            LblDATA.TextAlign = ContentAlignment.MiddleCenter;
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
            FlowPanelGrafico.Location = new Point(0, 50);
            FlowPanelGrafico.Name = "FlowPanelGrafico";
            FlowPanelGrafico.Padding = new Padding(20);
            FlowPanelGrafico.Size = new Size(1121, 181);
            FlowPanelGrafico.TabIndex = 3;
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
            PnlVendasCard.Controls.Add(DgvPricipal);
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
            // DgvPricipal
            // 
            DgvPricipal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPricipal.BackgroundColor = Color.WhiteSmoke;
            DgvPricipal.BorderStyle = BorderStyle.Fixed3D;
            DgvPricipal.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvPricipal.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Lime;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.Padding = new Padding(0, 0, 40, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.Lime;
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
            DgvPricipal.EnableHeadersVisualStyles = false;
            DgvPricipal.GridColor = Color.Black;
            DgvPricipal.Location = new Point(136, 45);
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
            DgvPricipal.Size = new Size(368, 343);
            DgvPricipal.TabIndex = 1;
            DgvPricipal.Visible = false;
            DgvPricipal.CellContentClick += DgvPricipal_CellContentClick;
            // 
            // PnlCardClientes
            // 
            PnlCardClientes.BackColor = Color.SeaGreen;
            PnlCardClientes.BorderStyle = BorderStyle.Fixed3D;
            PnlCardClientes.Controls.Add(LblQTDClientes);
            PnlCardClientes.Controls.Add(LblClientes);
            PnlCardClientes.Location = new Point(791, 23);
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
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // TelaPrincipalADM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1305, 555);
            Controls.Add(PanelCentralADM);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaPrincipalADM";
            Text = "TelaPrincipalADM";
            Load += TelaPrincipalADM_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelCentralADM.ResumeLayout(false);
            PnlConteudoBaixo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ChartPedidos).EndInit();
            PnLCabeca.ResumeLayout(false);
            FlowPanelGrafico.ResumeLayout(false);
            PnlCardVendas.ResumeLayout(false);
            PnlCardVendas.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            PnlVendasCard.ResumeLayout(false);
            PnlVendasCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPricipal).EndInit();
            PnlCardClientes.ResumeLayout(false);
            PnlCardClientes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnControleFuncionario;
        private Button BtnRelatorioADM;
        private Button BtnPainelFinanceiroADM;
        private PictureBox pictureBox1;
        private Button BtnAgendamentoADM;
        private Button BtnClentesCadastradosADM;
        private Button BtnTelaFuncionario;
        private Button BtnBuscarADM;
        private Button BtnSairADM;
        private Panel PanelCentralADM;
        private DataGridView DgvPricipal;
        private Label LblNomeAdm;
        private Panel PnLCabeca;
        private Panel panel4;
        private Panel PnlConteudoBaixo;
        private FlowLayoutPanel FlowPanelGrafico;
        private Panel PnlCardVendas;
        private Label LblVendaHj;
        private Panel PnlVendasCard;
        private Panel PnlCardClientes;
        private Label label2;
        private Label LblQtdPendentes;
        private Label lBLPendente;
        private Label LblQTDClientes;
        private Label LblClientes;
        private Panel panel2;
        private Label LblMes;
        private Label LblValorMes;
        private Label LblTitulo;
        private Label LblDATA;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartPedidos;
    }
}