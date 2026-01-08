namespace Shop.TelaFuncionarios
{
    partial class BuscarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarFuncionario));
            PanelBuscarFunCadastrado = new Panel();
            TxtBuscarFuncionario = new TextBox();
            BtnBuscarFun = new Button();
            dataGridView1 = new DataGridView();
            BtnFecharBuscaFun = new Button();
            label1 = new Label();
            PanelBuscarFunCadastrado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // PanelBuscarFunCadastrado
            // 
            PanelBuscarFunCadastrado.BackColor = Color.Transparent;
            PanelBuscarFunCadastrado.Controls.Add(label1);
            PanelBuscarFunCadastrado.Controls.Add(BtnFecharBuscaFun);
            PanelBuscarFunCadastrado.Controls.Add(dataGridView1);
            PanelBuscarFunCadastrado.Controls.Add(BtnBuscarFun);
            PanelBuscarFunCadastrado.Controls.Add(TxtBuscarFuncionario);
            PanelBuscarFunCadastrado.Location = new Point(61, 40);
            PanelBuscarFunCadastrado.Name = "PanelBuscarFunCadastrado";
            PanelBuscarFunCadastrado.Size = new Size(774, 383);
            PanelBuscarFunCadastrado.TabIndex = 0;
            // 
            // TxtBuscarFuncionario
            // 
            TxtBuscarFuncionario.Location = new Point(24, 43);
            TxtBuscarFuncionario.Name = "TxtBuscarFuncionario";
            TxtBuscarFuncionario.Size = new Size(219, 27);
            TxtBuscarFuncionario.TabIndex = 0;
            // 
            // BtnBuscarFun
            // 
            BtnBuscarFun.BackColor = SystemColors.HotTrack;
            BtnBuscarFun.FlatStyle = FlatStyle.Popup;
            BtnBuscarFun.Location = new Point(249, 42);
            BtnBuscarFun.Name = "BtnBuscarFun";
            BtnBuscarFun.Size = new Size(94, 29);
            BtnBuscarFun.TabIndex = 1;
            BtnBuscarFun.Text = "Pesquisar";
            BtnBuscarFun.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(710, 198);
            dataGridView1.TabIndex = 2;
            // 
            // BtnFecharBuscaFun
            // 
            BtnFecharBuscaFun.BackColor = Color.Transparent;
            BtnFecharBuscaFun.BackgroundImage = (Image)resources.GetObject("BtnFecharBuscaFun.BackgroundImage");
            BtnFecharBuscaFun.BackgroundImageLayout = ImageLayout.Stretch;
            BtnFecharBuscaFun.FlatAppearance.BorderSize = 0;
            BtnFecharBuscaFun.FlatStyle = FlatStyle.Flat;
            BtnFecharBuscaFun.ForeColor = Color.SteelBlue;
            BtnFecharBuscaFun.ImageAlign = ContentAlignment.MiddleRight;
            BtnFecharBuscaFun.Location = new Point(709, 9);
            BtnFecharBuscaFun.Name = "BtnFecharBuscaFun";
            BtnFecharBuscaFun.Size = new Size(50, 50);
            BtnFecharBuscaFun.TabIndex = 17;
            BtnFecharBuscaFun.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 20);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 18;
            label1.Text = "Nome ";
            // 
            // BuscarFuncionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(925, 489);
            Controls.Add(PanelBuscarFunCadastrado);
            Name = "BuscarFuncionario";
            Text = "BuscarFuncionario";
            PanelBuscarFunCadastrado.ResumeLayout(false);
            PanelBuscarFunCadastrado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelBuscarFunCadastrado;
        private Button BtnBuscarFun;
        private TextBox TxtBuscarFuncionario;
        private DataGridView dataGridView1;
        private Button BtnFecharBuscaFun;
        private Label label1;
    }
}