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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            PnlLateral = new Panel();
            BtnSair = new Button();
            BtnMeusPets = new Button();
            BtnAgendar = new Button();
            PnlCabeca = new Panel();
            PnlPricipal = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            DgvServicos = new DataGridView();
            tabPage2 = new TabPage();
            LblBemvindo = new Label();
            LblCuidado = new Label();
            CmbPetAgendamento = new ComboBox();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            PnlLateral.SuspendLayout();
            PnlCabeca.SuspendLayout();
            PnlPricipal.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvServicos).BeginInit();
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
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(CmbPetAgendamento);
            tabPage1.Controls.Add(LblCuidado);
            tabPage1.Controls.Add(DgvServicos);
            tabPage1.ForeColor = SystemColors.ControlText;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1243, 515);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "TbpAgendar";
            // 
            // DgvServicos
            // 
            DgvServicos.BackgroundColor = Color.White;
            DgvServicos.BorderStyle = BorderStyle.None;
            DgvServicos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.Padding = new Padding(0, 0, 40, 0);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DgvServicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DgvServicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new Padding(0, 0, 35, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            DgvServicos.DefaultCellStyle = dataGridViewCellStyle4;
            DgvServicos.EnableHeadersVisualStyles = false;
            DgvServicos.Location = new Point(1, 55);
            DgvServicos.Name = "DgvServicos";
            DgvServicos.Size = new Size(464, 423);
            DgvServicos.TabIndex = 0;
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
            // LblBemvindo
            // 
            LblBemvindo.BackColor = Color.RoyalBlue;
            LblBemvindo.Dock = DockStyle.Fill;
            LblBemvindo.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LblBemvindo.Location = new Point(0, 0);
            LblBemvindo.Name = "LblBemvindo";
            LblBemvindo.Size = new Size(1247, 96);
            LblBemvindo.TabIndex = 0;
            LblBemvindo.Text = "label1";
            LblBemvindo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblCuidado
            // 
            LblCuidado.AutoSize = true;
            LblCuidado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCuidado.ForeColor = Color.White;
            LblCuidado.Location = new Point(1, 2);
            LblCuidado.Name = "LblCuidado";
            LblCuidado.Size = new Size(231, 21);
            LblCuidado.TabIndex = 1;
            LblCuidado.Text = "Quem vai receber o cuidado?";
            // 
            // CmbPetAgendamento
            // 
            CmbPetAgendamento.FormattingEnabled = true;
            CmbPetAgendamento.Location = new Point(1, 26);
            CmbPetAgendamento.Name = "CmbPetAgendamento";
            CmbPetAgendamento.Size = new Size(125, 23);
            CmbPetAgendamento.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1, 482);
            button1.Name = "button1";
            button1.Size = new Size(162, 28);
            button1.TabIndex = 4;
            button1.Text = "Adicionar ao Carrinho";
            button1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(276, 486);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(189, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(178, 486);
            label1.Name = "label1";
            label1.Size = new Size(92, 17);
            label1.TabIndex = 6;
            label1.Text = "Para quando?";
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
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvServicos).EndInit();
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
        private DataGridView DgvServicos;
        private Label LblBemvindo;
        private Label LblCuidado;
        private Button button1;
        private ComboBox CmbPetAgendamento;
        private Label label1;
        private DateTimePicker dateTimePicker1;
    }
}