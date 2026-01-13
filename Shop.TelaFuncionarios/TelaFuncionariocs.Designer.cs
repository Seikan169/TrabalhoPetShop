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
            BtnProximosAtendimentos = new Button();
            pictureBox1 = new PictureBox();
            BtnSairFuncionario = new Button();
            DgvServicos = new DataGridView();
            PnlCabeca = new Panel();
            LblTitulo = new Label();
            PnlBuscarNome = new Panel();
            TxtBuscarPorNome = new TextBox();
            BtnBuscar = new Button();
            PnlTelaFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvServicos).BeginInit();
            PnlCabeca.SuspendLayout();
            PnlBuscarNome.SuspendLayout();
            SuspendLayout();
            // 
            // PnlTelaFuncionario
            // 
            PnlTelaFuncionario.BackColor = SystemColors.HotTrack;
            PnlTelaFuncionario.BorderStyle = BorderStyle.FixedSingle;
            PnlTelaFuncionario.Controls.Add(BtnCancelados);
            PnlTelaFuncionario.Controls.Add(BtnConcluidos);
            PnlTelaFuncionario.Controls.Add(BtnIniciados);
            PnlTelaFuncionario.Controls.Add(BtnProximosAtendimentos);
            PnlTelaFuncionario.Controls.Add(pictureBox1);
            PnlTelaFuncionario.Controls.Add(BtnSairFuncionario);
            PnlTelaFuncionario.Dock = DockStyle.Left;
            PnlTelaFuncionario.Location = new Point(0, 0);
            PnlTelaFuncionario.Name = "PnlTelaFuncionario";
            PnlTelaFuncionario.Size = new Size(229, 676);
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
            BtnCancelados.Location = new Point(0, 418);
            BtnCancelados.Name = "BtnCancelados";
            BtnCancelados.Size = new Size(227, 65);
            BtnCancelados.TabIndex = 6;
            BtnCancelados.Text = "     Cancelados";
            BtnCancelados.TextAlign = ContentAlignment.MiddleLeft;
            BtnCancelados.UseVisualStyleBackColor = false;
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
            BtnConcluidos.Location = new Point(0, 351);
            BtnConcluidos.Name = "BtnConcluidos";
            BtnConcluidos.Size = new Size(227, 67);
            BtnConcluidos.TabIndex = 5;
            BtnConcluidos.Text = "     Concluídos";
            BtnConcluidos.TextAlign = ContentAlignment.MiddleLeft;
            BtnConcluidos.UseVisualStyleBackColor = false;
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
            BtnIniciados.Location = new Point(0, 283);
            BtnIniciados.Name = "BtnIniciados";
            BtnIniciados.Size = new Size(227, 68);
            BtnIniciados.TabIndex = 4;
            BtnIniciados.Text = "  Atendimento Iniciado";
            BtnIniciados.UseVisualStyleBackColor = false;
            // 
            // BtnProximosAtendimentos
            // 
            BtnProximosAtendimentos.BackColor = SystemColors.ControlDarkDark;
            BtnProximosAtendimentos.Cursor = Cursors.Hand;
            BtnProximosAtendimentos.Dock = DockStyle.Top;
            BtnProximosAtendimentos.FlatStyle = FlatStyle.Flat;
            BtnProximosAtendimentos.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnProximosAtendimentos.ForeColor = Color.White;
            BtnProximosAtendimentos.Image = (Image)resources.GetObject("BtnProximosAtendimentos.Image");
            BtnProximosAtendimentos.ImageAlign = ContentAlignment.MiddleLeft;
            BtnProximosAtendimentos.Location = new Point(0, 209);
            BtnProximosAtendimentos.Name = "BtnProximosAtendimentos";
            BtnProximosAtendimentos.RightToLeft = RightToLeft.No;
            BtnProximosAtendimentos.Size = new Size(227, 74);
            BtnProximosAtendimentos.TabIndex = 1;
            BtnProximosAtendimentos.Text = " Fila de Atendimentos";
            BtnProximosAtendimentos.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 209);
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
            BtnSairFuncionario.Location = new Point(0, 625);
            BtnSairFuncionario.Name = "BtnSairFuncionario";
            BtnSairFuncionario.Size = new Size(227, 49);
            BtnSairFuncionario.TabIndex = 1;
            BtnSairFuncionario.Text = "Sair";
            BtnSairFuncionario.UseVisualStyleBackColor = false;
            // 
            // DgvServicos
            // 
            DgvServicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvServicos.BackgroundColor = Color.Silver;
            DgvServicos.BorderStyle = BorderStyle.Fixed3D;
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
            DgvServicos.Location = new Point(229, 77);
            DgvServicos.Margin = new Padding(3, 4, 3, 4);
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
            DgvServicos.RowHeadersWidth = 51;
            DgvServicos.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            DgvServicos.Size = new Size(813, 599);
            DgvServicos.TabIndex = 1;
            // 
            // PnlCabeca
            // 
            PnlCabeca.BackColor = SystemColors.HotTrack;
            PnlCabeca.BorderStyle = BorderStyle.Fixed3D;
            PnlCabeca.Controls.Add(LblTitulo);
            PnlCabeca.Controls.Add(PnlBuscarNome);
            PnlCabeca.Dock = DockStyle.Top;
            PnlCabeca.Location = new Point(229, 0);
            PnlCabeca.Margin = new Padding(3, 4, 3, 4);
            PnlCabeca.Name = "PnlCabeca";
            PnlCabeca.Size = new Size(813, 77);
            PnlCabeca.TabIndex = 2;
            // 
            // LblTitulo
            // 
            LblTitulo.Dock = DockStyle.Fill;
            LblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.Location = new Point(192, 0);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(617, 73);
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
            PnlBuscarNome.Margin = new Padding(3, 4, 3, 4);
            PnlBuscarNome.Name = "PnlBuscarNome";
            PnlBuscarNome.Size = new Size(192, 73);
            PnlBuscarNome.TabIndex = 5;
            // 
            // TxtBuscarPorNome
            // 
            TxtBuscarPorNome.Cursor = Cursors.Hand;
            TxtBuscarPorNome.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtBuscarPorNome.Location = new Point(5, 29);
            TxtBuscarPorNome.Margin = new Padding(3, 4, 3, 4);
            TxtBuscarPorNome.Name = "TxtBuscarPorNome";
            TxtBuscarPorNome.Size = new Size(117, 32);
            TxtBuscarPorNome.TabIndex = 3;
            // 
            // BtnBuscar
            // 
            BtnBuscar.BackgroundImage = (Image)resources.GetObject("BtnBuscar.BackgroundImage");
            BtnBuscar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnBuscar.Cursor = Cursors.Hand;
            BtnBuscar.Location = new Point(125, 29);
            BtnBuscar.Margin = new Padding(3, 4, 3, 4);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(27, 36);
            BtnBuscar.TabIndex = 4;
            BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // TelaFuncionariocs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1042, 676);
            Controls.Add(DgvServicos);
            Controls.Add(PnlCabeca);
            Controls.Add(PnlTelaFuncionario);
            Name = "TelaFuncionariocs";
            Text = "TelaFuncionariocs";
            PnlTelaFuncionario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvServicos).EndInit();
            PnlCabeca.ResumeLayout(false);
            PnlBuscarNome.ResumeLayout(false);
            PnlBuscarNome.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlTelaFuncionario;
        private Button BtnSairFuncionario;
        private Button BtnProximosAtendimentos;
        private PictureBox pictureBox1;
        private Button BtnIniciados;
        private Button BtnConcluidos;
        private DataGridView DgvServicos;
        private Panel PnlCabeca;
        private Label LblTitulo;
        private TextBox TxtBuscarPorNome;
        private Button BtnBuscar;
        private Panel PnlBuscarNome;
        private Button BtnCancelados;
    }
}