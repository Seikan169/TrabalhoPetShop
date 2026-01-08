namespace Tela.Cliente
{
    partial class Tela_P_Cliente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_P_Cliente));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            PanelMenuLateral = new Panel();
            BtnSair = new Button();
            BtnMeusPets = new Button();
            this.BtnAgendar = new Button();
            panelCabecalho = new Panel();
            panelPricipal = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            DgvServicos = new DataGridView();
            PanelMenuLateral.SuspendLayout();
            panelPricipal.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvServicos).BeginInit();
            SuspendLayout();
            // 
            // PanelMenuLateral
            // 
            PanelMenuLateral.BackColor = Color.Transparent;
            PanelMenuLateral.BorderStyle = BorderStyle.Fixed3D;
            PanelMenuLateral.Controls.Add(BtnSair);
            PanelMenuLateral.Controls.Add(BtnMeusPets);
            PanelMenuLateral.Controls.Add(this.BtnAgendar);
            PanelMenuLateral.Dock = DockStyle.Left;
            PanelMenuLateral.Location = new Point(0, 0);
            PanelMenuLateral.Name = "PanelMenuLateral";
            PanelMenuLateral.Size = new Size(200, 630);
            PanelMenuLateral.TabIndex = 0;
            // 
            // BtnSair
            // 
            BtnSair.Dock = DockStyle.Top;
            BtnSair.FlatAppearance.BorderColor = Color.Blue;
            BtnSair.FlatAppearance.BorderSize = 0;
            BtnSair.FlatStyle = FlatStyle.Flat;
            BtnSair.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSair.ForeColor = Color.Black;
            BtnSair.Image = (Image)resources.GetObject("BtnSair.Image");
            BtnSair.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSair.Location = new Point(0, 125);
            BtnSair.Name = "BtnSair";
            BtnSair.Padding = new Padding(50, 0, 0, 0);
            BtnSair.Size = new Size(196, 59);
            BtnSair.TabIndex = 2;
            BtnSair.Text = " Sair";
            BtnSair.TextAlign = ContentAlignment.MiddleRight;
            BtnSair.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSair.UseVisualStyleBackColor = true;
            // 
            // BtnMeusPets
            // 
            BtnMeusPets.Dock = DockStyle.Top;
            BtnMeusPets.FlatAppearance.BorderColor = Color.Blue;
            BtnMeusPets.FlatAppearance.BorderSize = 0;
            BtnMeusPets.FlatStyle = FlatStyle.Flat;
            BtnMeusPets.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnMeusPets.ForeColor = Color.Black;
            BtnMeusPets.Image = (Image)resources.GetObject("BtnMeusPets.Image");
            BtnMeusPets.ImageAlign = ContentAlignment.MiddleLeft;
            BtnMeusPets.Location = new Point(0, 62);
            BtnMeusPets.Name = "BtnMeusPets";
            BtnMeusPets.Padding = new Padding(50, 0, 0, 0);
            BtnMeusPets.Size = new Size(196, 63);
            BtnMeusPets.TabIndex = 1;
            BtnMeusPets.Text = "Meus Pets";
            BtnMeusPets.TextAlign = ContentAlignment.MiddleRight;
            BtnMeusPets.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnMeusPets.UseVisualStyleBackColor = true;
            BtnMeusPets.Click += button2_Click;
            // 
            // BtnAgendar
            // 
           
            // 
            // panelCabecalho
            // 
            panelCabecalho.BackColor = Color.Transparent;
            panelCabecalho.BorderStyle = BorderStyle.Fixed3D;
            panelCabecalho.Dock = DockStyle.Top;
            panelCabecalho.Location = new Point(200, 0);
            panelCabecalho.Name = "panelCabecalho";
            panelCabecalho.Size = new Size(1277, 100);
            panelCabecalho.TabIndex = 1;
            // 
            // panelPricipal
            // 
            panelPricipal.BackColor = Color.Transparent;
            panelPricipal.BorderStyle = BorderStyle.Fixed3D;
            panelPricipal.Controls.Add(tabControl1);
            panelPricipal.Dock = DockStyle.Fill;
            panelPricipal.Location = new Point(200, 100);
            panelPricipal.Name = "panelPricipal";
            panelPricipal.Size = new Size(1277, 530);
            panelPricipal.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1273, 526);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.Controls.Add(DgvServicos);
            tabPage1.Location = new Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1265, 494);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1265, 498);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // DgvServicos
            // 
            DgvServicos.BackgroundColor = Color.White;
            DgvServicos.BorderStyle = BorderStyle.None;
            DgvServicos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DgvServicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DgvServicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Goldenrod;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            DgvServicos.DefaultCellStyle = dataGridViewCellStyle4;
            DgvServicos.EnableHeadersVisualStyles = false;
            DgvServicos.Location = new Point(6, 18);
            DgvServicos.Name = "DgvServicos";
            DgvServicos.RowTemplate.DividerHeight = 35;
            DgvServicos.Size = new Size(240, 150);
            DgvServicos.TabIndex = 0;
            // 
            // Tela_P_Cliente
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1477, 630);
            Controls.Add(panelPricipal);
            Controls.Add(panelCabecalho);
            Controls.Add(PanelMenuLateral);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Tela_P_Cliente";
            Text = "Tela Pricipal";
            PanelMenuLateral.ResumeLayout(false);
            panelPricipal.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvServicos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMenuLateral;
        private Panel panelCabecalho;
        private Panel panelPricipal;
        private Button button1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button BtnSair;
        private Button BtnMeusPets;
        private DataGridView DgvServicos;
    }
}
