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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalADM));
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
            TxtNomeLogado = new TextBox();
            PanelCentralADM = new Panel();
            DgvPricipal = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelCentralADM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPricipal).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(BtnSairADM);
            panel1.Controls.Add(BtnRelatorioADM);
            panel1.Controls.Add(BtnPainelFinanceiroADM);
            panel1.Controls.Add(BtnClentesCadastradosADM);
            panel1.Controls.Add(BtnTelaFuncionario);
            panel1.Controls.Add(BtnAgendamentoADM);
            panel1.Controls.Add(BtnBuscarADM);
            panel1.Controls.Add(BtnControleFuncionario);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(TxtNomeLogado);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 421);
            panel1.TabIndex = 0;
            // 
            // BtnSairADM
            // 
            BtnSairADM.BackColor = Color.DodgerBlue;
            BtnSairADM.Dock = DockStyle.Bottom;
            BtnSairADM.FlatStyle = FlatStyle.Popup;
            BtnSairADM.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSairADM.Image = (Image)resources.GetObject("BtnSairADM.Image");
            BtnSairADM.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSairADM.Location = new Point(0, 391);
            BtnSairADM.Margin = new Padding(3, 2, 3, 2);
            BtnSairADM.Name = "BtnSairADM";
            BtnSairADM.Size = new Size(180, 30);
            BtnSairADM.TabIndex = 10;
            BtnSairADM.Text = "Sair";
            BtnSairADM.UseVisualStyleBackColor = false;
            BtnSairADM.Click += BtnSairADM_Click;
            // 
            // BtnRelatorioADM
            // 
            BtnRelatorioADM.BackColor = SystemColors.ControlDarkDark;
            BtnRelatorioADM.Dock = DockStyle.Top;
            BtnRelatorioADM.FlatAppearance.BorderSize = 0;
            BtnRelatorioADM.FlatStyle = FlatStyle.Flat;
            BtnRelatorioADM.Image = (Image)resources.GetObject("BtnRelatorioADM.Image");
            BtnRelatorioADM.ImageAlign = ContentAlignment.MiddleLeft;
            BtnRelatorioADM.Location = new Point(0, 301);
            BtnRelatorioADM.Margin = new Padding(3, 2, 3, 2);
            BtnRelatorioADM.Name = "BtnRelatorioADM";
            BtnRelatorioADM.Size = new Size(180, 34);
            BtnRelatorioADM.TabIndex = 1;
            BtnRelatorioADM.Text = "Relatórios ";
            BtnRelatorioADM.UseVisualStyleBackColor = false;
            // 
            // BtnPainelFinanceiroADM
            // 
            BtnPainelFinanceiroADM.BackColor = SystemColors.ControlDarkDark;
            BtnPainelFinanceiroADM.Dock = DockStyle.Top;
            BtnPainelFinanceiroADM.FlatAppearance.BorderSize = 0;
            BtnPainelFinanceiroADM.FlatStyle = FlatStyle.Flat;
            BtnPainelFinanceiroADM.Image = (Image)resources.GetObject("BtnPainelFinanceiroADM.Image");
            BtnPainelFinanceiroADM.ImageAlign = ContentAlignment.MiddleLeft;
            BtnPainelFinanceiroADM.Location = new Point(0, 271);
            BtnPainelFinanceiroADM.Margin = new Padding(3, 2, 3, 2);
            BtnPainelFinanceiroADM.Name = "BtnPainelFinanceiroADM";
            BtnPainelFinanceiroADM.Size = new Size(180, 30);
            BtnPainelFinanceiroADM.TabIndex = 1;
            BtnPainelFinanceiroADM.Text = "Painel Financeiro";
            BtnPainelFinanceiroADM.UseVisualStyleBackColor = false;
            // 
            // BtnClentesCadastradosADM
            // 
            BtnClentesCadastradosADM.BackColor = SystemColors.ControlDarkDark;
            BtnClentesCadastradosADM.Dock = DockStyle.Top;
            BtnClentesCadastradosADM.FlatAppearance.BorderSize = 0;
            BtnClentesCadastradosADM.FlatStyle = FlatStyle.Flat;
            BtnClentesCadastradosADM.ForeColor = Color.White;
            BtnClentesCadastradosADM.Image = (Image)resources.GetObject("BtnClentesCadastradosADM.Image");
            BtnClentesCadastradosADM.ImageAlign = ContentAlignment.MiddleLeft;
            BtnClentesCadastradosADM.Location = new Point(0, 232);
            BtnClentesCadastradosADM.Margin = new Padding(3, 2, 3, 2);
            BtnClentesCadastradosADM.Name = "BtnClentesCadastradosADM";
            BtnClentesCadastradosADM.Size = new Size(180, 39);
            BtnClentesCadastradosADM.TabIndex = 6;
            BtnClentesCadastradosADM.Text = "    Clientes Cadastrados";
            BtnClentesCadastradosADM.UseVisualStyleBackColor = false;
            // 
            // BtnTelaFuncionario
            // 
            BtnTelaFuncionario.BackColor = SystemColors.ControlDarkDark;
            BtnTelaFuncionario.Dock = DockStyle.Top;
            BtnTelaFuncionario.FlatAppearance.BorderSize = 0;
            BtnTelaFuncionario.FlatStyle = FlatStyle.Flat;
            BtnTelaFuncionario.Image = (Image)resources.GetObject("BtnTelaFuncionario.Image");
            BtnTelaFuncionario.ImageAlign = ContentAlignment.MiddleLeft;
            BtnTelaFuncionario.Location = new Point(0, 198);
            BtnTelaFuncionario.Margin = new Padding(3, 2, 3, 2);
            BtnTelaFuncionario.Name = "BtnTelaFuncionario";
            BtnTelaFuncionario.Size = new Size(180, 34);
            BtnTelaFuncionario.TabIndex = 8;
            BtnTelaFuncionario.Text = "Tela Funcionário";
            BtnTelaFuncionario.UseVisualStyleBackColor = false;
            // 
            // BtnAgendamentoADM
            // 
            BtnAgendamentoADM.BackColor = SystemColors.ControlDarkDark;
            BtnAgendamentoADM.Dock = DockStyle.Top;
            BtnAgendamentoADM.FlatAppearance.BorderSize = 0;
            BtnAgendamentoADM.FlatStyle = FlatStyle.Flat;
            BtnAgendamentoADM.Image = (Image)resources.GetObject("BtnAgendamentoADM.Image");
            BtnAgendamentoADM.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgendamentoADM.Location = new Point(0, 164);
            BtnAgendamentoADM.Margin = new Padding(3, 2, 3, 2);
            BtnAgendamentoADM.Name = "BtnAgendamentoADM";
            BtnAgendamentoADM.Size = new Size(180, 34);
            BtnAgendamentoADM.TabIndex = 4;
            BtnAgendamentoADM.Text = "    Agendamento Clientes";
            BtnAgendamentoADM.UseVisualStyleBackColor = false;
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
            BtnBuscarADM.Location = new Point(0, 136);
            BtnBuscarADM.Margin = new Padding(3, 2, 3, 2);
            BtnBuscarADM.Name = "BtnBuscarADM";
            BtnBuscarADM.Size = new Size(180, 28);
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
            BtnControleFuncionario.Location = new Point(0, 92);
            BtnControleFuncionario.Margin = new Padding(3, 2, 3, 2);
            BtnControleFuncionario.Name = "BtnControleFuncionario";
            BtnControleFuncionario.Size = new Size(180, 44);
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
            pictureBox1.Location = new Point(0, 23);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // TxtNomeLogado
            // 
            TxtNomeLogado.Dock = DockStyle.Top;
            TxtNomeLogado.Location = new Point(0, 0);
            TxtNomeLogado.Margin = new Padding(3, 2, 3, 2);
            TxtNomeLogado.Name = "TxtNomeLogado";
            TxtNomeLogado.Size = new Size(180, 23);
            TxtNomeLogado.TabIndex = 2;
            // 
            // PanelCentralADM
            // 
            PanelCentralADM.BackColor = Color.Transparent;
            PanelCentralADM.Controls.Add(DgvPricipal);
            PanelCentralADM.Dock = DockStyle.Fill;
            PanelCentralADM.Location = new Point(180, 0);
            PanelCentralADM.Margin = new Padding(3, 2, 3, 2);
            PanelCentralADM.Name = "PanelCentralADM";
            PanelCentralADM.Size = new Size(792, 421);
            PanelCentralADM.TabIndex = 2;
            // 
            // DgvPricipal
            // 
            DgvPricipal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPricipal.BackgroundColor = Color.Silver;
            DgvPricipal.BorderStyle = BorderStyle.None;
            DgvPricipal.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvPricipal.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Lime;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.Padding = new Padding(0, 0, 40, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvPricipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvPricipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(0, 0, 35, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = Color.RoyalBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvPricipal.DefaultCellStyle = dataGridViewCellStyle2;
            DgvPricipal.Dock = DockStyle.Fill;
            DgvPricipal.EnableHeadersVisualStyles = false;
            DgvPricipal.GridColor = Color.Black;
            DgvPricipal.Location = new Point(0, 0);
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
            DgvPricipal.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            DgvPricipal.Size = new Size(792, 421);
            DgvPricipal.TabIndex = 1;
            // 
            // TelaPrincipalADM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(972, 421);
            Controls.Add(PanelCentralADM);
            Controls.Add(panel1);
            ForeColor = Color.Transparent;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaPrincipalADM";
            Text = "TelaPrincipalADM";
            Load += TelaPrincipalADM_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelCentralADM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvPricipal).EndInit();
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
        private TextBox TxtNomeLogado;
        private Button BtnSairADM;
        private Panel PanelCentralADM;
        private DataGridView DgvPricipal;
    }
}