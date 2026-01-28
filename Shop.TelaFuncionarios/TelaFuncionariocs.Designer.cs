namespace Shop.TelaFuncionarios
{
    partial class TelaFuncionariocs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaFuncionariocs));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            PnlTelaFuncionario = new Panel();
            BtnCancelados = new Button();
            BtnConcluidos = new Button();
            BtnIniciados = new Button();
            BtnFila = new Button();
            pictureBox1 = new PictureBox();
            BtnSairFuncionario = new Button();
            LblNomeFuncionario = new Label();
            DgvPedidos = new DataGridView();
            PnlCabeca = new Panel();
            LblTitulo = new Label();
            PnlBuscarNome = new Panel();
            TxtBuscarPorNome = new TextBox();
            BtnBuscar = new Button();
            PnlRodaPe = new Panel();
            BtnInicarAtendimento = new Button();
            BtnCancelar = new Button();
            BtnFinalizarAtendimento = new Button();
            PnlTelaFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvPedidos).BeginInit();
            PnlCabeca.SuspendLayout();
            PnlBuscarNome.SuspendLayout();
            PnlRodaPe.SuspendLayout();
            SuspendLayout();
            // 
            // PnlTelaFuncionario
            // 
            PnlTelaFuncionario.BackColor = SystemColors.HotTrack;
            PnlTelaFuncionario.BorderStyle = BorderStyle.FixedSingle;
            PnlTelaFuncionario.Controls.Add(BtnCancelados);
            PnlTelaFuncionario.Controls.Add(BtnConcluidos);
            PnlTelaFuncionario.Controls.Add(BtnIniciados);
            PnlTelaFuncionario.Controls.Add(BtnFila);
            PnlTelaFuncionario.Controls.Add(pictureBox1);
            PnlTelaFuncionario.Controls.Add(BtnSairFuncionario);
            PnlTelaFuncionario.Controls.Add(LblNomeFuncionario);
            PnlTelaFuncionario.Dock = DockStyle.Left;
            PnlTelaFuncionario.Location = new Point(0, 0);
            PnlTelaFuncionario.Margin = new Padding(3, 2, 3, 2);
            PnlTelaFuncionario.Name = "PnlTelaFuncionario";
            PnlTelaFuncionario.Size = new Size(201, 534);
            PnlTelaFuncionario.TabIndex = 0;
            // 
            // BtnCancelados
            // 
            BtnCancelados.BackColor = SystemColors.ControlDarkDark;
            BtnCancelados.Cursor = Cursors.Hand;
            BtnCancelados.Dock = DockStyle.Top;
            BtnCancelados.FlatStyle = FlatStyle.Flat;
            BtnCancelados.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCancelados.ForeColor = Color.White;
            BtnCancelados.Image = (Image)resources.GetObject("BtnCancelados.Image");
            BtnCancelados.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancelados.Location = new Point(0, 351);
            BtnCancelados.Margin = new Padding(3, 2, 3, 2);
            BtnCancelados.Name = "BtnCancelados";
            BtnCancelados.Size = new Size(199, 49);
            BtnCancelados.TabIndex = 6;
            BtnCancelados.Text = "     Cancelados";
            BtnCancelados.TextAlign = ContentAlignment.MiddleLeft;
            BtnCancelados.UseVisualStyleBackColor = false;
            BtnCancelados.Click += BtnCancelados_Click;
            // 
            // BtnConcluidos
            // 
            BtnConcluidos.BackColor = SystemColors.ControlDarkDark;
            BtnConcluidos.Cursor = Cursors.Hand;
            BtnConcluidos.Dock = DockStyle.Top;
            BtnConcluidos.FlatStyle = FlatStyle.Flat;
            BtnConcluidos.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnConcluidos.ForeColor = Color.White;
            BtnConcluidos.Image = (Image)resources.GetObject("BtnConcluidos.Image");
            BtnConcluidos.ImageAlign = ContentAlignment.MiddleLeft;
            BtnConcluidos.Location = new Point(0, 301);
            BtnConcluidos.Margin = new Padding(3, 2, 3, 2);
            BtnConcluidos.Name = "BtnConcluidos";
            BtnConcluidos.Size = new Size(199, 50);
            BtnConcluidos.TabIndex = 5;
            BtnConcluidos.Text = "     Concluídos";
            BtnConcluidos.TextAlign = ContentAlignment.MiddleLeft;
            BtnConcluidos.UseVisualStyleBackColor = false;
            BtnConcluidos.Click += BtnConcluidos_Click;
            // 
            // BtnIniciados
            // 
            BtnIniciados.BackColor = SystemColors.ControlDarkDark;
            BtnIniciados.Cursor = Cursors.Hand;
            BtnIniciados.Dock = DockStyle.Top;
            BtnIniciados.FlatStyle = FlatStyle.Flat;
            BtnIniciados.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnIniciados.ForeColor = Color.White;
            BtnIniciados.Image = (Image)resources.GetObject("BtnIniciados.Image");
            BtnIniciados.ImageAlign = ContentAlignment.MiddleLeft;
            BtnIniciados.Location = new Point(0, 250);
            BtnIniciados.Margin = new Padding(3, 2, 3, 2);
            BtnIniciados.Name = "BtnIniciados";
            BtnIniciados.Size = new Size(199, 51);
            BtnIniciados.TabIndex = 4;
            BtnIniciados.Text = "  Atendimento Iniciado";
            BtnIniciados.UseVisualStyleBackColor = false;
            BtnIniciados.Click += BtnIniciados_Click;
            // 
            // BtnFila
            // 
            BtnFila.BackColor = SystemColors.ControlDarkDark;
            BtnFila.Cursor = Cursors.Hand;
            BtnFila.Dock = DockStyle.Top;
            BtnFila.FlatStyle = FlatStyle.Flat;
            BtnFila.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnFila.ForeColor = Color.White;
            BtnFila.Image = (Image)resources.GetObject("BtnFila.Image");
            BtnFila.ImageAlign = ContentAlignment.MiddleLeft;
            BtnFila.Location = new Point(0, 194);
            BtnFila.Margin = new Padding(3, 2, 3, 2);
            BtnFila.Name = "BtnFila";
            BtnFila.RightToLeft = RightToLeft.No;
            BtnFila.Size = new Size(199, 56);
            BtnFila.TabIndex = 1;
            BtnFila.Text = " Fila de Atendimentos";
            BtnFila.UseVisualStyleBackColor = false;
            BtnFila.Click += BtnProximosAtendimentos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 36);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // BtnSairFuncionario
            // 
            BtnSairFuncionario.BackColor = SystemColors.HotTrack;
            BtnSairFuncionario.BackgroundImageLayout = ImageLayout.Stretch;
            BtnSairFuncionario.Cursor = Cursors.Hand;
            BtnSairFuncionario.Dock = DockStyle.Bottom;
            BtnSairFuncionario.FlatStyle = FlatStyle.Popup;
            BtnSairFuncionario.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSairFuncionario.ForeColor = Color.White;
            BtnSairFuncionario.Image = (Image)resources.GetObject("BtnSairFuncionario.Image");
            BtnSairFuncionario.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSairFuncionario.Location = new Point(0, 495);
            BtnSairFuncionario.Margin = new Padding(3, 2, 3, 2);
            BtnSairFuncionario.Name = "BtnSairFuncionario";
            BtnSairFuncionario.Size = new Size(199, 37);
            BtnSairFuncionario.TabIndex = 1;
            BtnSairFuncionario.Text = "Sair";
            BtnSairFuncionario.UseVisualStyleBackColor = false;
            BtnSairFuncionario.Click += BtnSairFuncionario_Click;
            // 
            // LblNomeFuncionario
            // 
            LblNomeFuncionario.BackColor = SystemColors.HotTrack;
            LblNomeFuncionario.Dock = DockStyle.Top;
            LblNomeFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNomeFuncionario.ForeColor = Color.White;
            LblNomeFuncionario.Location = new Point(0, 0);
            LblNomeFuncionario.Name = "LblNomeFuncionario";
            LblNomeFuncionario.Size = new Size(199, 36);
            LblNomeFuncionario.TabIndex = 12;
            LblNomeFuncionario.Text = "label1";
            LblNomeFuncionario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DgvPedidos
            // 
            DgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPedidos.BackgroundColor = Color.Silver;
            DgvPedidos.BorderStyle = BorderStyle.Fixed3D;
            DgvPedidos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvPedidos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Lime;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(0, 0, 40, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.Lime;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(0, 0, 35, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvPedidos.DefaultCellStyle = dataGridViewCellStyle2;
            DgvPedidos.Dock = DockStyle.Fill;
            DgvPedidos.EnableHeadersVisualStyles = false;
            DgvPedidos.Location = new Point(201, 59);
            DgvPedidos.Margin = new Padding(10, 5, 10, 5);
            DgvPedidos.Name = "DgvPedidos";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Salmon;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DgvPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DgvPedidos.RowHeadersVisible = false;
            DgvPedidos.RowHeadersWidth = 51;
            DgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvPedidos.Size = new Size(763, 416);
            DgvPedidos.TabIndex = 1;
            DgvPedidos.CellContentClick += DgvPedidos_CellContentClick;
            DgvPedidos.CellFormatting += DgvPedidos_CellFormatting;
            DgvPedidos.SelectionChanged += DgvPedidos_SelectionChanged;
            // 
            // PnlCabeca
            // 
            PnlCabeca.BackColor = SystemColors.HotTrack;
            PnlCabeca.BorderStyle = BorderStyle.Fixed3D;
            PnlCabeca.Controls.Add(LblTitulo);
            PnlCabeca.Controls.Add(PnlBuscarNome);
            PnlCabeca.Dock = DockStyle.Top;
            PnlCabeca.Location = new Point(201, 0);
            PnlCabeca.Name = "PnlCabeca";
            PnlCabeca.Size = new Size(763, 59);
            PnlCabeca.TabIndex = 2;
            // 
            // LblTitulo
            // 
            LblTitulo.Dock = DockStyle.Fill;
            LblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.Location = new Point(168, 0);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(591, 55);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "label1";
            LblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PnlBuscarNome
            // 
            PnlBuscarNome.BackColor = SystemColors.HotTrack;
            PnlBuscarNome.Controls.Add(TxtBuscarPorNome);
            PnlBuscarNome.Controls.Add(BtnBuscar);
            PnlBuscarNome.Dock = DockStyle.Left;
            PnlBuscarNome.Location = new Point(0, 0);
            PnlBuscarNome.Name = "PnlBuscarNome";
            PnlBuscarNome.Size = new Size(168, 55);
            PnlBuscarNome.TabIndex = 5;
            // 
            // TxtBuscarPorNome
            // 
            TxtBuscarPorNome.Cursor = Cursors.Hand;
            TxtBuscarPorNome.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtBuscarPorNome.Location = new Point(4, 22);
            TxtBuscarPorNome.Name = "TxtBuscarPorNome";
            TxtBuscarPorNome.Size = new Size(103, 27);
            TxtBuscarPorNome.TabIndex = 3;
            TxtBuscarPorNome.TextChanged += TxtBuscarPorNome_TextChanged;
            // 
            // BtnBuscar
            // 
            BtnBuscar.BackgroundImage = (Image)resources.GetObject("BtnBuscar.BackgroundImage");
            BtnBuscar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnBuscar.Cursor = Cursors.Hand;
            BtnBuscar.Location = new Point(109, 22);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(24, 27);
            BtnBuscar.TabIndex = 4;
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // PnlRodaPe
            // 
            PnlRodaPe.BackColor = SystemColors.HotTrack;
            PnlRodaPe.BorderStyle = BorderStyle.Fixed3D;
            PnlRodaPe.Controls.Add(BtnInicarAtendimento);
            PnlRodaPe.Controls.Add(BtnCancelar);
            PnlRodaPe.Controls.Add(BtnFinalizarAtendimento);
            PnlRodaPe.Dock = DockStyle.Bottom;
            PnlRodaPe.Location = new Point(201, 475);
            PnlRodaPe.Name = "PnlRodaPe";
            PnlRodaPe.Size = new Size(763, 59);
            PnlRodaPe.TabIndex = 3;
            // 
            // BtnInicarAtendimento
            // 
            BtnInicarAtendimento.BackColor = Color.LightSeaGreen;
            BtnInicarAtendimento.Cursor = Cursors.Hand;
            BtnInicarAtendimento.FlatAppearance.BorderSize = 0;
            BtnInicarAtendimento.FlatStyle = FlatStyle.Flat;
            BtnInicarAtendimento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnInicarAtendimento.ForeColor = Color.White;
            BtnInicarAtendimento.Image = (Image)resources.GetObject("BtnInicarAtendimento.Image");
            BtnInicarAtendimento.ImageAlign = ContentAlignment.MiddleLeft;
            BtnInicarAtendimento.Location = new Point(-2, 4);
            BtnInicarAtendimento.Margin = new Padding(10, 5, 10, 5);
            BtnInicarAtendimento.Name = "BtnInicarAtendimento";
            BtnInicarAtendimento.Size = new Size(200, 48);
            BtnInicarAtendimento.TabIndex = 5;
            BtnInicarAtendimento.Text = "Iniciar Atendimento";
            BtnInicarAtendimento.TextAlign = ContentAlignment.MiddleRight;
            BtnInicarAtendimento.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnInicarAtendimento.UseVisualStyleBackColor = false;
            BtnInicarAtendimento.Visible = false;
            BtnInicarAtendimento.Click += BtnInicarAtendimento_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.Crimson;
            BtnCancelar.Cursor = Cursors.Hand;
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCancelar.ForeColor = Color.White;
            BtnCancelar.Image = (Image)resources.GetObject("BtnCancelar.Image");
            BtnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancelar.Location = new Point(420, 4);
            BtnCancelar.Margin = new Padding(10, 5, 10, 5);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(190, 48);
            BtnCancelar.TabIndex = 2;
            BtnCancelar.Text = "Cancelar Pedido";
            BtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            BtnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Visible = false;
            BtnCancelar.Click += btnCancelar_Click;
            // 
            // BtnFinalizarAtendimento
            // 
            BtnFinalizarAtendimento.BackColor = Color.SeaGreen;
            BtnFinalizarAtendimento.Cursor = Cursors.Hand;
            BtnFinalizarAtendimento.FlatAppearance.BorderSize = 0;
            BtnFinalizarAtendimento.FlatStyle = FlatStyle.Flat;
            BtnFinalizarAtendimento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnFinalizarAtendimento.ForeColor = Color.White;
            BtnFinalizarAtendimento.Image = (Image)resources.GetObject("BtnFinalizarAtendimento.Image");
            BtnFinalizarAtendimento.ImageAlign = ContentAlignment.MiddleLeft;
            BtnFinalizarAtendimento.Location = new Point(209, 4);
            BtnFinalizarAtendimento.Margin = new Padding(10, 5, 10, 5);
            BtnFinalizarAtendimento.Name = "BtnFinalizarAtendimento";
            BtnFinalizarAtendimento.Size = new Size(200, 48);
            BtnFinalizarAtendimento.TabIndex = 4;
            BtnFinalizarAtendimento.Text = "Finalizar Serviço";
            BtnFinalizarAtendimento.TextAlign = ContentAlignment.MiddleRight;
            BtnFinalizarAtendimento.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnFinalizarAtendimento.UseVisualStyleBackColor = false;
            BtnFinalizarAtendimento.Visible = false;
            BtnFinalizarAtendimento.Click += BtnFinalizarAtendimento_Click;
            // 
            // TelaFuncionariocs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(964, 534);
            Controls.Add(DgvPedidos);
            Controls.Add(PnlRodaPe);
            Controls.Add(PnlCabeca);
            Controls.Add(PnlTelaFuncionario);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaFuncionariocs";
            Text = "TelaFuncionariocs";
            Load += TelaFuncionariocs_Load;
            PnlTelaFuncionario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvPedidos).EndInit();
            PnlCabeca.ResumeLayout(false);
            PnlBuscarNome.ResumeLayout(false);
            PnlBuscarNome.PerformLayout();
            PnlRodaPe.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlTelaFuncionario;
        private Button BtnSairFuncionario;
        private Button BtnFila;
        private PictureBox pictureBox1;
        private Button BtnIniciados;
        private Button BtnConcluidos;
        private DataGridView DgvPedidos;
        private Panel PnlCabeca;
        private Label LblTitulo;
        private TextBox TxtBuscarPorNome;
        private Button BtnBuscar;
        private Panel PnlBuscarNome;
        private Button BtnCancelados;
        private Panel PnlRodaPe;
        private Button BtnCancelar;
        private Button BtnInicarAtendimento;
        private Button BtnFinalizarAtendimento;
        private Label LblNomeFuncionario;
    }
}