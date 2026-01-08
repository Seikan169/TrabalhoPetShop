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
            PnlLateral = new Panel();
            BtnSair = new Button();
            BtnMeusPets = new Button();
            BtnAgendar = new Button();
            PnlCabeca = new Panel();
            PnlPricipal = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            DgvServicos = new DataGridView();
            PnlLateral.SuspendLayout();
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
            tabPage1.Controls.Add(DgvServicos);
            tabPage1.ForeColor = SystemColors.ControlText;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1243, 515);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "TbpAgendar";
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
            // DgvServicos
            // 
            DgvServicos.BackgroundColor = Color.White;
            DgvServicos.BorderStyle = BorderStyle.None;
            DgvServicos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(0, 0, 40, 0);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlText;
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
            DgvServicos.EnableHeadersVisualStyles = false;
            DgvServicos.Location = new Point(6, 6);
            DgvServicos.Name = "DgvServicos";
            DgvServicos.Size = new Size(240, 150);
            DgvServicos.TabIndex = 0;
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
            PnlPricipal.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
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
    }
}