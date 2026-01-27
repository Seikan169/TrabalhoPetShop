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
            MkBoxCpf = new MaskedTextBox();
            label4 = new Label();
            DatapickNascimento = new DateTimePicker();
            label14 = new Label();
            PnlCadastroUser = new Panel();
            PnlCadastroUser.SuspendLayout();
            SuspendLayout();
            // 
            // TxtNomeCliente
            // 
            TxtNomeCliente.Cursor = Cursors.IBeam;
            TxtNomeCliente.Location = new Point(3, 21);
            TxtNomeCliente.Margin = new Padding(3, 2, 3, 2);
            TxtNomeCliente.Name = "TxtNomeCliente";
            TxtNomeCliente.Size = new Size(160, 23);
            TxtNomeCliente.TabIndex = 0;
            // 
            // TxtEmailCliente
            // 
            TxtEmailCliente.Cursor = Cursors.IBeam;
            TxtEmailCliente.Location = new Point(3, 158);
            TxtEmailCliente.Margin = new Padding(3, 2, 3, 2);
            TxtEmailCliente.Name = "TxtEmailCliente";
            TxtEmailCliente.Size = new Size(347, 23);
            TxtEmailCliente.TabIndex = 3;
            TxtEmailCliente.Leave += TxtEmailCliente_Leave;
            // 
            // TxtSenhaCliente
            // 
            TxtSenhaCliente.Cursor = Cursors.IBeam;
            TxtSenhaCliente.Location = new Point(220, 21);
            TxtSenhaCliente.Margin = new Padding(3, 2, 3, 2);
            TxtSenhaCliente.Name = "TxtSenhaCliente";
            TxtSenhaCliente.Size = new Size(134, 23);
            TxtSenhaCliente.TabIndex = 4;
            TxtSenhaCliente.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(3, 141);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 6;
            label2.Text = "E-mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(3, 45);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 7;
            label3.Text = "Telefone";
            // 
            // TxtConfirSenhaCliente
            // 
            TxtConfirSenhaCliente.Cursor = Cursors.IBeam;
            TxtConfirSenhaCliente.Location = new Point(220, 63);
            TxtConfirSenhaCliente.Margin = new Padding(3, 2, 3, 2);
            TxtConfirSenhaCliente.Name = "TxtConfirSenhaCliente";
            TxtConfirSenhaCliente.Size = new Size(134, 23);
            TxtConfirSenhaCliente.TabIndex = 5;
            TxtConfirSenhaCliente.UseSystemPasswordChar = true;
            TxtConfirSenhaCliente.Leave += TxtConfirSenhaCliente_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(220, 45);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 11;
            label5.Text = "Confirmar Senha";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(220, 3);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 12;
            label6.Text = "Senha";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.HotTrack;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(-4, 183);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(398, 9);
            textBox1.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(8, 196);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 15;
            label7.Text = "CEP";
            // 
            // TxtUfCliente
            // 
            TxtUfCliente.Cursor = Cursors.IBeam;
            TxtUfCliente.Location = new Point(8, 256);
            TxtUfCliente.Margin = new Padding(3, 2, 3, 2);
            TxtUfCliente.Name = "TxtUfCliente";
            TxtUfCliente.Size = new Size(97, 23);
            TxtUfCliente.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(8, 238);
            label8.Name = "label8";
            label8.Size = new Size(21, 15);
            label8.TabIndex = 17;
            label8.Text = "UF";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(134, 199);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 19;
            label9.Text = "Logradouro";
            // 
            // TxtLogCliente
            // 
            TxtLogCliente.Cursor = Cursors.IBeam;
            TxtLogCliente.Location = new Point(134, 214);
            TxtLogCliente.Margin = new Padding(3, 2, 3, 2);
            TxtLogCliente.Name = "TxtLogCliente";
            TxtLogCliente.Size = new Size(221, 23);
            TxtLogCliente.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Location = new Point(133, 249);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 21;
            label10.Text = "Bairro";
            // 
            // TxtBairroCliente
            // 
            TxtBairroCliente.Cursor = Cursors.IBeam;
            TxtBairroCliente.Location = new Point(134, 266);
            TxtBairroCliente.Margin = new Padding(3, 2, 3, 2);
            TxtBairroCliente.Name = "TxtBairroCliente";
            TxtBairroCliente.Size = new Size(222, 23);
            TxtBairroCliente.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Location = new Point(8, 280);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 23;
            label11.Text = "Cidade";
            // 
            // TxtCidadeCliente
            // 
            TxtCidadeCliente.Cursor = Cursors.IBeam;
            TxtCidadeCliente.Location = new Point(8, 297);
            TxtCidadeCliente.Margin = new Padding(3, 2, 3, 2);
            TxtCidadeCliente.Name = "TxtCidadeCliente";
            TxtCidadeCliente.Size = new Size(97, 23);
            TxtCidadeCliente.TabIndex = 8;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Location = new Point(8, 323);
            label12.Name = "label12";
            label12.Size = new Size(51, 15);
            label12.TabIndex = 25;
            label12.Text = "Número";
            // 
            // TxtNúmeroCliente
            // 
            TxtNúmeroCliente.Cursor = Cursors.IBeam;
            TxtNúmeroCliente.Location = new Point(8, 340);
            TxtNúmeroCliente.Margin = new Padding(3, 2, 3, 2);
            TxtNúmeroCliente.Name = "TxtNúmeroCliente";
            TxtNúmeroCliente.Size = new Size(97, 23);
            TxtNúmeroCliente.TabIndex = 9;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Location = new Point(131, 292);
            label13.Name = "label13";
            label13.Size = new Size(84, 15);
            label13.TabIndex = 27;
            label13.Text = "Complemento";
            // 
            // TxtComplementoCliente
            // 
            TxtComplementoCliente.Cursor = Cursors.IBeam;
            TxtComplementoCliente.Location = new Point(132, 309);
            TxtComplementoCliente.Margin = new Padding(3, 2, 3, 2);
            TxtComplementoCliente.Name = "TxtComplementoCliente";
            TxtComplementoCliente.Size = new Size(97, 23);
            TxtComplementoCliente.TabIndex = 10;
            // 
            // BtnSalvarCadastroCliente
            // 
            BtnSalvarCadastroCliente.BackColor = SystemColors.MenuHighlight;
            BtnSalvarCadastroCliente.Cursor = Cursors.Hand;
            BtnSalvarCadastroCliente.FlatStyle = FlatStyle.Popup;
            BtnSalvarCadastroCliente.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSalvarCadastroCliente.Location = new Point(262, 309);
            BtnSalvarCadastroCliente.Margin = new Padding(3, 2, 3, 2);
            BtnSalvarCadastroCliente.Name = "BtnSalvarCadastroCliente";
            BtnSalvarCadastroCliente.Size = new Size(88, 29);
            BtnSalvarCadastroCliente.TabIndex = 28;
            BtnSalvarCadastroCliente.Text = "Salvar";
            BtnSalvarCadastroCliente.UseVisualStyleBackColor = false;
            BtnSalvarCadastroCliente.Click += BtnSalvarCadastroCliente_Click;
            // 
            // MkBoxCep
            // 
            MkBoxCep.Cursor = Cursors.IBeam;
            MkBoxCep.Location = new Point(8, 214);
            MkBoxCep.Mask = "00000-000";
            MkBoxCep.Name = "MkBoxCep";
            MkBoxCep.Size = new Size(100, 23);
            MkBoxCep.TabIndex = 7;
            MkBoxCep.Leave += MkBoxCep_Leave;
            // 
            // MkBoxTeleCLiente
            // 
            MkBoxTeleCLiente.Cursor = Cursors.IBeam;
            MkBoxTeleCLiente.Location = new Point(3, 63);
            MkBoxTeleCLiente.Margin = new Padding(3, 2, 3, 2);
            MkBoxTeleCLiente.Mask = "(00) 00000-0000";
            MkBoxTeleCLiente.Name = "MkBoxTeleCLiente";
            MkBoxTeleCLiente.Size = new Size(160, 23);
            MkBoxTeleCLiente.TabIndex = 1;
            // 
            // MkBoxCpf
            // 
            MkBoxCpf.Cursor = Cursors.IBeam;
            MkBoxCpf.Location = new Point(4, 110);
            MkBoxCpf.Margin = new Padding(3, 2, 3, 2);
            MkBoxCpf.Mask = "000.000.000-00";
            MkBoxCpf.Name = "MkBoxCpf";
            MkBoxCpf.Size = new Size(159, 23);
            MkBoxCpf.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(3, 92);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 31;
            label4.Text = "Cpf (Opcional)";
            // 
            // DatapickNascimento
            // 
            DatapickNascimento.Cursor = Cursors.Hand;
            DatapickNascimento.Format = DateTimePickerFormat.Short;
            DatapickNascimento.Location = new Point(220, 106);
            DatapickNascimento.Name = "DatapickNascimento";
            DatapickNascimento.Size = new Size(134, 23);
            DatapickNascimento.TabIndex = 6;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Location = new Point(220, 92);
            label14.Name = "label14";
            label14.Size = new Size(98, 15);
            label14.TabIndex = 34;
            label14.Text = "Data Nascimento";
            // 
            // PnlCadastroUser
            // 
            PnlCadastroUser.BackColor = Color.Transparent;
            PnlCadastroUser.Controls.Add(TxtNomeCliente);
            PnlCadastroUser.Controls.Add(label14);
            PnlCadastroUser.Controls.Add(TxtEmailCliente);
            PnlCadastroUser.Controls.Add(DatapickNascimento);
            PnlCadastroUser.Controls.Add(TxtSenhaCliente);
            PnlCadastroUser.Controls.Add(MkBoxCpf);
            PnlCadastroUser.Controls.Add(label1);
            PnlCadastroUser.Controls.Add(label4);
            PnlCadastroUser.Controls.Add(label2);
            PnlCadastroUser.Controls.Add(MkBoxTeleCLiente);
            PnlCadastroUser.Controls.Add(label3);
            PnlCadastroUser.Controls.Add(MkBoxCep);
            PnlCadastroUser.Controls.Add(TxtConfirSenhaCliente);
            PnlCadastroUser.Controls.Add(BtnSalvarCadastroCliente);
            PnlCadastroUser.Controls.Add(label5);
            PnlCadastroUser.Controls.Add(label13);
            PnlCadastroUser.Controls.Add(label6);
            PnlCadastroUser.Controls.Add(TxtComplementoCliente);
            PnlCadastroUser.Controls.Add(textBox1);
            PnlCadastroUser.Controls.Add(label12);
            PnlCadastroUser.Controls.Add(label7);
            PnlCadastroUser.Controls.Add(TxtNúmeroCliente);
            PnlCadastroUser.Controls.Add(TxtUfCliente);
            PnlCadastroUser.Controls.Add(label11);
            PnlCadastroUser.Controls.Add(label8);
            PnlCadastroUser.Controls.Add(TxtCidadeCliente);
            PnlCadastroUser.Controls.Add(TxtLogCliente);
            PnlCadastroUser.Controls.Add(label10);
            PnlCadastroUser.Controls.Add(label9);
            PnlCadastroUser.Controls.Add(TxtBairroCliente);
            PnlCadastroUser.Location = new Point(0, 0);
            PnlCadastroUser.Margin = new Padding(3, 2, 3, 2);
            PnlCadastroUser.Name = "PnlCadastroUser";
            PnlCadastroUser.Size = new Size(387, 478);
            PnlCadastroUser.TabIndex = 35;
            // 
            // TelaCadastroUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(395, 486);
            Controls.Add(PnlCadastroUser);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(411, 525);
            MinimizeBox = false;
            MinimumSize = new Size(411, 525);
            Name = "TelaCadastroUser";
            Text = "TelaCadastroUser";
            Load += TelaCadastroUser_Load;
            PnlCadastroUser.ResumeLayout(false);
            PnlCadastroUser.PerformLayout();
            ResumeLayout(false);
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
        private MaskedTextBox MkBoxCpf;
        private Label label4;
        private DateTimePicker DatapickNascimento;
        private Label label14;
        private Panel PnlCadastroUser;
    }
}