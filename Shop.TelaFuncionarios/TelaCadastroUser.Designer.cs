namespace Shop.TelaFuncionarios
{
    partial class TelaCadastroUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroUser));
            TxtNomeCliente = new TextBox();
            TxtEmailCliente = new TextBox();
            TxtSenhaCliente = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtConfirSenhaCliente = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            TxtUfCliente = new TextBox();
            label8 = new Label();
            label9 = new Label();
            TxtLogCliente = new TextBox();
            label10 = new Label();
            TxtBairroCliente = new TextBox();
            label11 = new Label();
            TxtCidadeCliente = new TextBox();
            label12 = new Label();
            TxtNúmeroCliente = new TextBox();
            label13 = new Label();
            TxtComplementoCliente = new TextBox();
            BtnSalvarCadastroCliente = new Button();
            MkBoxCep = new MaskedTextBox();
            MkBoxTeleCLiente = new MaskedTextBox();
            MkcboxCpfCliente = new MaskedTextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // TxtNomeCliente
            // 
            TxtNomeCliente.Cursor = Cursors.IBeam;
            TxtNomeCliente.Location = new Point(5, 26);
            TxtNomeCliente.Name = "TxtNomeCliente";
            TxtNomeCliente.Size = new Size(182, 27);
            TxtNomeCliente.TabIndex = 0;
            // 
            // TxtEmailCliente
            // 
            TxtEmailCliente.Location = new Point(4, 209);
            TxtEmailCliente.Name = "TxtEmailCliente";
            TxtEmailCliente.Size = new Size(396, 27);
            TxtEmailCliente.TabIndex = 1;
            // 
            // TxtSenhaCliente
            // 
            TxtSenhaCliente.Location = new Point(254, 26);
            TxtSenhaCliente.Name = "TxtSenhaCliente";
            TxtSenhaCliente.Size = new Size(153, 27);
            TxtSenhaCliente.TabIndex = 4;
            TxtSenhaCliente.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(5, 2);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 5;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(4, 186);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 6;
            label2.Text = "E-mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(4, 58);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 7;
            label3.Text = "Telefone";
            // 
            // TxtConfirSenhaCliente
            // 
            TxtConfirSenhaCliente.Location = new Point(254, 82);
            TxtConfirSenhaCliente.Name = "TxtConfirSenhaCliente";
            TxtConfirSenhaCliente.Size = new Size(153, 27);
            TxtConfirSenhaCliente.TabIndex = 10;
            TxtConfirSenhaCliente.UseSystemPasswordChar = true;
            TxtConfirSenhaCliente.Leave += TxtConfirSenhaCliente_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(254, 59);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 11;
            label5.Text = "Confirmar Senha";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(254, 3);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 12;
            label6.Text = "Senha";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.HotTrack;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(-3, 242);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(455, 12);
            textBox1.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(12, 261);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 15;
            label7.Text = "CEP";
            // 
            // TxtUfCliente
            // 
            TxtUfCliente.Location = new Point(12, 350);
            TxtUfCliente.Name = "TxtUfCliente";
            TxtUfCliente.Size = new Size(110, 27);
            TxtUfCliente.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(12, 326);
            label8.Name = "label8";
            label8.Size = new Size(26, 20);
            label8.TabIndex = 17;
            label8.Text = "UF";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(155, 328);
            label9.Name = "label9";
            label9.Size = new Size(87, 20);
            label9.TabIndex = 19;
            label9.Text = "Logradouro";
            // 
            // TxtLogCliente
            // 
            TxtLogCliente.Location = new Point(156, 350);
            TxtLogCliente.Name = "TxtLogCliente";
            TxtLogCliente.Size = new Size(252, 27);
            TxtLogCliente.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Location = new Point(154, 394);
            label10.Name = "label10";
            label10.Size = new Size(49, 20);
            label10.TabIndex = 21;
            label10.Text = "Bairro";
            // 
            // TxtBairroCliente
            // 
            TxtBairroCliente.Location = new Point(155, 417);
            TxtBairroCliente.Name = "TxtBairroCliente";
            TxtBairroCliente.Size = new Size(253, 27);
            TxtBairroCliente.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Location = new Point(12, 394);
            label11.Name = "label11";
            label11.Size = new Size(56, 20);
            label11.TabIndex = 23;
            label11.Text = "Cidade";
            // 
            // TxtCidadeCliente
            // 
            TxtCidadeCliente.Location = new Point(12, 417);
            TxtCidadeCliente.Name = "TxtCidadeCliente";
            TxtCidadeCliente.Size = new Size(110, 27);
            TxtCidadeCliente.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Location = new Point(12, 452);
            label12.Name = "label12";
            label12.Size = new Size(63, 20);
            label12.TabIndex = 25;
            label12.Text = "Número";
            // 
            // TxtNúmeroCliente
            // 
            TxtNúmeroCliente.Location = new Point(12, 474);
            TxtNúmeroCliente.Name = "TxtNúmeroCliente";
            TxtNúmeroCliente.Size = new Size(110, 27);
            TxtNúmeroCliente.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Location = new Point(152, 452);
            label13.Name = "label13";
            label13.Size = new Size(104, 20);
            label13.TabIndex = 27;
            label13.Text = "Complemento";
            // 
            // TxtComplementoCliente
            // 
            TxtComplementoCliente.Location = new Point(153, 474);
            TxtComplementoCliente.Name = "TxtComplementoCliente";
            TxtComplementoCliente.Size = new Size(110, 27);
            TxtComplementoCliente.TabIndex = 26;
            // 
            // BtnSalvarCadastroCliente
            // 
            BtnSalvarCadastroCliente.BackColor = SystemColors.MenuHighlight;
            BtnSalvarCadastroCliente.FlatStyle = FlatStyle.Popup;
            BtnSalvarCadastroCliente.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSalvarCadastroCliente.Location = new Point(299, 474);
            BtnSalvarCadastroCliente.Name = "BtnSalvarCadastroCliente";
            BtnSalvarCadastroCliente.Size = new Size(101, 31);
            BtnSalvarCadastroCliente.TabIndex = 28;
            BtnSalvarCadastroCliente.Text = "Salvar";
            BtnSalvarCadastroCliente.UseVisualStyleBackColor = false;
            BtnSalvarCadastroCliente.Click += BtnSalvarCadastroCliente_Click;
            // 
            // MkBoxCep
            // 
            MkBoxCep.Location = new Point(12, 285);
            MkBoxCep.Margin = new Padding(3, 4, 3, 4);
            MkBoxCep.Mask = "00000-000";
            MkBoxCep.Name = "MkBoxCep";
            MkBoxCep.Size = new Size(114, 27);
            MkBoxCep.TabIndex = 29;
            MkBoxCep.Leave += MkBoxCep_Leave;
            // 
            // MkBoxTeleCLiente
            // 
            MkBoxTeleCLiente.Location = new Point(5, 82);
            MkBoxTeleCLiente.Mask = "(00) 00000-0000";
            MkBoxTeleCLiente.Name = "MkBoxTeleCLiente";
            MkBoxTeleCLiente.Size = new Size(182, 27);
            MkBoxTeleCLiente.TabIndex = 30;
            // 
            // MkcboxCpfCliente
            // 
            MkcboxCpfCliente.Location = new Point(6, 145);
            MkcboxCpfCliente.Mask = "000.000.000-00";
            MkcboxCpfCliente.Name = "MkcboxCpfCliente";
            MkcboxCpfCliente.Size = new Size(181, 27);
            MkcboxCpfCliente.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(5, 121);
            label4.Name = "label4";
            label4.Size = new Size(32, 20);
            label4.TabIndex = 31;
            label4.Text = "Cpf";
            // 
            // TelaCadastroUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(453, 669);
            Controls.Add(MkcboxCpfCliente);
            Controls.Add(label4);
            Controls.Add(MkBoxTeleCLiente);
            Controls.Add(MkBoxCep);
            Controls.Add(BtnSalvarCadastroCliente);
            Controls.Add(label13);
            Controls.Add(TxtComplementoCliente);
            Controls.Add(label12);
            Controls.Add(TxtNúmeroCliente);
            Controls.Add(label11);
            Controls.Add(TxtCidadeCliente);
            Controls.Add(label10);
            Controls.Add(TxtBairroCliente);
            Controls.Add(label9);
            Controls.Add(TxtLogCliente);
            Controls.Add(label8);
            Controls.Add(TxtUfCliente);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(TxtConfirSenhaCliente);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtSenhaCliente);
            Controls.Add(TxtEmailCliente);
            Controls.Add(TxtNomeCliente);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaCadastroUser";
            Text = "TelaCadastroUser";
            Load += TelaCadastroUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtNomeCliente;
        private TextBox TxtEmailCliente;
        private TextBox TxtSenhaCliente;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtConfirSenhaCliente;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private Label label7;
        private TextBox TxtUfCliente;
        private Label label8;
        private Label label9;
        private TextBox TxtLogCliente;
        private Label label10;
        private TextBox TxtBairroCliente;
        private Label label11;
        private TextBox TxtCidadeCliente;
        private Label label12;
        private TextBox TxtNúmeroCliente;
        private Label label13;
        private TextBox TxtComplementoCliente;
        private Button BtnSalvarCadastroCliente;
        private MaskedTextBox MkBoxCep;
        private MaskedTextBox MkBoxTeleCLiente;
        private MaskedTextBox MkcboxCpfCliente;
        private Label label4;
    }
}