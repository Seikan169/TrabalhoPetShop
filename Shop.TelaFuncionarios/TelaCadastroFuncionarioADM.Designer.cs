namespace Shop.TelaFuncionarios
{
    partial class TelaCadastroFuncionarioADM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroFuncionarioADM));
            TabCInformacoesFuncionario = new TabControl();
            TacInfoPessoal = new TabPage();
            label2 = new Label();
            TxtSenhaFun = new TextBox();
            MkboxDataFun = new MaskedTextBox();
            CheKCadastroFun = new CheckBox();
            BtnCancelarCadastroFun = new Button();
            BtnCadatrarFun = new Button();
            BtnFecharCadastroFun = new Button();
            label6 = new Label();
            TxtObservaFun = new TextBox();
            label5 = new Label();
            TxtEmailFun = new TextBox();
            label4 = new Label();
            ComBGeneroFun = new ComboBox();
            label3 = new Label();
            TxtCpf = new Label();
            label1 = new Label();
            MskBoxFuncioCPF = new MaskedTextBox();
            TxtNomeFuncionario = new TextBox();
            TabcEnderecoFun = new TabPage();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            TxtCompleFun = new TextBox();
            TxtCidadeFun = new TextBox();
            TxtNumFun = new TextBox();
            TxtUfFun = new TextBox();
            textBox3 = new TextBox();
            TxtRuaFun = new TextBox();
            TxtBairroFun = new TextBox();
            MaskCepFun = new MaskedTextBox();
            BtnTelaADM = new Button();
            label14 = new Label();
            MskBoxTelefoneFun = new MaskedTextBox();
            TabCInformacoesFuncionario.SuspendLayout();
            TacInfoPessoal.SuspendLayout();
            TabcEnderecoFun.SuspendLayout();
            SuspendLayout();
            // 
            // TabCInformacoesFuncionario
            // 
            TabCInformacoesFuncionario.Controls.Add(TacInfoPessoal);
            TabCInformacoesFuncionario.Controls.Add(TabcEnderecoFun);
            TabCInformacoesFuncionario.Dock = DockStyle.Fill;
            TabCInformacoesFuncionario.Location = new Point(0, 0);
            TabCInformacoesFuncionario.Name = "TabCInformacoesFuncionario";
            TabCInformacoesFuncionario.SelectedIndex = 0;
            TabCInformacoesFuncionario.Size = new Size(1011, 514);
            TabCInformacoesFuncionario.TabIndex = 1;
            // 
            // TacInfoPessoal
            // 
            TacInfoPessoal.BackgroundImage = (Image)resources.GetObject("TacInfoPessoal.BackgroundImage");
            TacInfoPessoal.Controls.Add(label14);
            TacInfoPessoal.Controls.Add(MskBoxTelefoneFun);
            TacInfoPessoal.Controls.Add(label2);
            TacInfoPessoal.Controls.Add(TxtSenhaFun);
            TacInfoPessoal.Controls.Add(MkboxDataFun);
            TacInfoPessoal.Controls.Add(CheKCadastroFun);
            TacInfoPessoal.Controls.Add(BtnCancelarCadastroFun);
            TacInfoPessoal.Controls.Add(BtnCadatrarFun);
            TacInfoPessoal.Controls.Add(BtnFecharCadastroFun);
            TacInfoPessoal.Controls.Add(label6);
            TacInfoPessoal.Controls.Add(TxtObservaFun);
            TacInfoPessoal.Controls.Add(label5);
            TacInfoPessoal.Controls.Add(TxtEmailFun);
            TacInfoPessoal.Controls.Add(label4);
            TacInfoPessoal.Controls.Add(ComBGeneroFun);
            TacInfoPessoal.Controls.Add(label3);
            TacInfoPessoal.Controls.Add(TxtCpf);
            TacInfoPessoal.Controls.Add(label1);
            TacInfoPessoal.Controls.Add(MskBoxFuncioCPF);
            TacInfoPessoal.Controls.Add(TxtNomeFuncionario);
            TacInfoPessoal.Location = new Point(4, 29);
            TacInfoPessoal.Name = "TacInfoPessoal";
            TacInfoPessoal.Padding = new Padding(3);
            TacInfoPessoal.Size = new Size(1003, 481);
            TacInfoPessoal.TabIndex = 2;
            TacInfoPessoal.Text = "Dados Gerais";
            TacInfoPessoal.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(446, 91);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 23;
            label2.Text = "Senha";
            // 
            // TxtSenhaFun
            // 
            TxtSenhaFun.Location = new Point(446, 115);
            TxtSenhaFun.Name = "TxtSenhaFun";
            TxtSenhaFun.Size = new Size(158, 27);
            TxtSenhaFun.TabIndex = 22;
            // 
            // MkboxDataFun
            // 
            MkboxDataFun.Location = new Point(549, 38);
            MkboxDataFun.Mask = "00/00/0000";
            MkboxDataFun.Name = "MkboxDataFun";
            MkboxDataFun.Size = new Size(125, 27);
            MkboxDataFun.TabIndex = 21;
            MkboxDataFun.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // CheKCadastroFun
            // 
            CheKCadastroFun.AutoSize = true;
            CheKCadastroFun.Location = new Point(799, 326);
            CheKCadastroFun.Name = "CheKCadastroFun";
            CheKCadastroFun.Size = new Size(180, 24);
            CheKCadastroFun.TabIndex = 19;
            CheKCadastroFun.Text = "Aplicar Usuário Admin";
            CheKCadastroFun.UseVisualStyleBackColor = true;
            // 
            // BtnCancelarCadastroFun
            // 
            BtnCancelarCadastroFun.BackColor = Color.Red;
            BtnCancelarCadastroFun.FlatStyle = FlatStyle.Popup;
            BtnCancelarCadastroFun.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCancelarCadastroFun.Location = new Point(159, 344);
            BtnCancelarCadastroFun.Name = "BtnCancelarCadastroFun";
            BtnCancelarCadastroFun.Size = new Size(121, 47);
            BtnCancelarCadastroFun.TabIndex = 18;
            BtnCancelarCadastroFun.Text = "Cancelar";
            BtnCancelarCadastroFun.UseVisualStyleBackColor = false;
            // 
            // BtnCadatrarFun
            // 
            BtnCadatrarFun.BackColor = Color.LimeGreen;
            BtnCadatrarFun.FlatStyle = FlatStyle.Popup;
            BtnCadatrarFun.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCadatrarFun.Location = new Point(18, 344);
            BtnCadatrarFun.Name = "BtnCadatrarFun";
            BtnCadatrarFun.Size = new Size(121, 47);
            BtnCadatrarFun.TabIndex = 17;
            BtnCadatrarFun.Text = "Cadastrar";
            BtnCadatrarFun.UseVisualStyleBackColor = false;
            BtnCadatrarFun.Click += BtnCadatrarFun_Click;
            // 
            // BtnFecharCadastroFun
            // 
            BtnFecharCadastroFun.BackColor = Color.Transparent;
            BtnFecharCadastroFun.BackgroundImage = (Image)resources.GetObject("BtnFecharCadastroFun.BackgroundImage");
            BtnFecharCadastroFun.BackgroundImageLayout = ImageLayout.Stretch;
            BtnFecharCadastroFun.FlatAppearance.BorderSize = 0;
            BtnFecharCadastroFun.FlatStyle = FlatStyle.Flat;
            BtnFecharCadastroFun.ForeColor = Color.SteelBlue;
            BtnFecharCadastroFun.ImageAlign = ContentAlignment.MiddleRight;
            BtnFecharCadastroFun.Location = new Point(945, 15);
            BtnFecharCadastroFun.Name = "BtnFecharCadastroFun";
            BtnFecharCadastroFun.Size = new Size(50, 50);
            BtnFecharCadastroFun.TabIndex = 16;
            BtnFecharCadastroFun.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 154);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 13;
            label6.Text = "Observações";
            // 
            // TxtObservaFun
            // 
            TxtObservaFun.Location = new Point(18, 177);
            TxtObservaFun.Multiline = true;
            TxtObservaFun.Name = "TxtObservaFun";
            TxtObservaFun.Size = new Size(961, 143);
            TxtObservaFun.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(209, 92);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 11;
            label5.Text = "Email";
            // 
            // TxtEmailFun
            // 
            TxtEmailFun.Location = new Point(209, 115);
            TxtEmailFun.Name = "TxtEmailFun";
            TxtEmailFun.Size = new Size(207, 27);
            TxtEmailFun.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 91);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 9;
            label4.Text = "Gênero";
            // 
            // ComBGeneroFun
            // 
            ComBGeneroFun.FormattingEnabled = true;
            ComBGeneroFun.Items.AddRange(new object[] { "Masculino", "Feminino", "Outros" });
            ComBGeneroFun.Location = new Point(18, 114);
            ComBGeneroFun.Name = "ComBGeneroFun";
            ComBGeneroFun.Size = new Size(151, 28);
            ComBGeneroFun.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(549, 15);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 7;
            label3.Text = "Data Nascimento";
            // 
            // TxtCpf
            // 
            TxtCpf.AutoSize = true;
            TxtCpf.Location = new Point(209, 15);
            TxtCpf.Name = "TxtCpf";
            TxtCpf.Size = new Size(33, 20);
            TxtCpf.TabIndex = 3;
            TxtCpf.Text = "CPF";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 15);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // MskBoxFuncioCPF
            // 
            MskBoxFuncioCPF.Location = new Point(209, 38);
            MskBoxFuncioCPF.Mask = "000.000.000-00";
            MskBoxFuncioCPF.Name = "MskBoxFuncioCPF";
            MskBoxFuncioCPF.Size = new Size(125, 27);
            MskBoxFuncioCPF.TabIndex = 1;
            MskBoxFuncioCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // TxtNomeFuncionario
            // 
            TxtNomeFuncionario.Location = new Point(18, 38);
            TxtNomeFuncionario.Name = "TxtNomeFuncionario";
            TxtNomeFuncionario.Size = new Size(157, 27);
            TxtNomeFuncionario.TabIndex = 0;
            // 
            // TabcEnderecoFun
            // 
            TabcEnderecoFun.BackgroundImage = (Image)resources.GetObject("TabcEnderecoFun.BackgroundImage");
            TabcEnderecoFun.Controls.Add(label13);
            TabcEnderecoFun.Controls.Add(label12);
            TabcEnderecoFun.Controls.Add(label11);
            TabcEnderecoFun.Controls.Add(label10);
            TabcEnderecoFun.Controls.Add(label9);
            TabcEnderecoFun.Controls.Add(label8);
            TabcEnderecoFun.Controls.Add(label7);
            TabcEnderecoFun.Controls.Add(TxtCompleFun);
            TabcEnderecoFun.Controls.Add(TxtCidadeFun);
            TabcEnderecoFun.Controls.Add(TxtNumFun);
            TabcEnderecoFun.Controls.Add(TxtUfFun);
            TabcEnderecoFun.Controls.Add(textBox3);
            TabcEnderecoFun.Controls.Add(TxtRuaFun);
            TabcEnderecoFun.Controls.Add(TxtBairroFun);
            TabcEnderecoFun.Controls.Add(MaskCepFun);
            TabcEnderecoFun.Controls.Add(BtnTelaADM);
            TabcEnderecoFun.Location = new Point(4, 29);
            TabcEnderecoFun.Name = "TabcEnderecoFun";
            TabcEnderecoFun.Padding = new Padding(3);
            TabcEnderecoFun.Size = new Size(1003, 481);
            TabcEnderecoFun.TabIndex = 3;
            TabcEnderecoFun.Text = "Endereço";
            TabcEnderecoFun.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(33, 8);
            label13.Name = "label13";
            label13.Size = new Size(35, 20);
            label13.TabIndex = 30;
            label13.Text = "Cep";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(255, 232);
            label12.Name = "label12";
            label12.Size = new Size(63, 20);
            label12.TabIndex = 29;
            label12.Text = "Número";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(255, 300);
            label11.Name = "label11";
            label11.Size = new Size(104, 20);
            label11.TabIndex = 29;
            label11.Text = "Complemento";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(33, 300);
            label10.Name = "label10";
            label10.Size = new Size(56, 20);
            label10.TabIndex = 28;
            label10.Text = "Cidade";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(33, 232);
            label9.Name = "label9";
            label9.Size = new Size(26, 20);
            label9.TabIndex = 27;
            label9.Text = "UF";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 167);
            label8.Name = "label8";
            label8.Size = new Size(34, 20);
            label8.TabIndex = 26;
            label8.Text = "Rua";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 104);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 25;
            label7.Text = "Bairro";
            // 
            // TxtCompleFun
            // 
            TxtCompleFun.Location = new Point(255, 323);
            TxtCompleFun.Name = "TxtCompleFun";
            TxtCompleFun.Size = new Size(125, 27);
            TxtCompleFun.TabIndex = 24;
            // 
            // TxtCidadeFun
            // 
            TxtCidadeFun.Location = new Point(33, 323);
            TxtCidadeFun.Name = "TxtCidadeFun";
            TxtCidadeFun.Size = new Size(125, 27);
            TxtCidadeFun.TabIndex = 23;
            // 
            // TxtNumFun
            // 
            TxtNumFun.Location = new Point(255, 255);
            TxtNumFun.Name = "TxtNumFun";
            TxtNumFun.Size = new Size(125, 27);
            TxtNumFun.TabIndex = 23;
            // 
            // TxtUfFun
            // 
            TxtUfFun.Location = new Point(33, 255);
            TxtUfFun.Name = "TxtUfFun";
            TxtUfFun.Size = new Size(125, 27);
            TxtUfFun.TabIndex = 22;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(41, 255);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 22;
            // 
            // TxtRuaFun
            // 
            TxtRuaFun.Location = new Point(33, 190);
            TxtRuaFun.Name = "TxtRuaFun";
            TxtRuaFun.Size = new Size(570, 27);
            TxtRuaFun.TabIndex = 21;
            // 
            // TxtBairroFun
            // 
            TxtBairroFun.Location = new Point(33, 127);
            TxtBairroFun.Name = "TxtBairroFun";
            TxtBairroFun.Size = new Size(570, 27);
            TxtBairroFun.TabIndex = 20;
            // 
            // MaskCepFun
            // 
            MaskCepFun.Location = new Point(33, 31);
            MaskCepFun.Mask = "00000-000";
            MaskCepFun.Name = "MaskCepFun";
            MaskCepFun.Size = new Size(125, 27);
            MaskCepFun.TabIndex = 19;
            // 
            // BtnTelaADM
            // 
            BtnTelaADM.BackColor = Color.Transparent;
            BtnTelaADM.BackgroundImage = (Image)resources.GetObject("BtnTelaADM.BackgroundImage");
            BtnTelaADM.BackgroundImageLayout = ImageLayout.Stretch;
            BtnTelaADM.FlatAppearance.BorderSize = 0;
            BtnTelaADM.FlatStyle = FlatStyle.Flat;
            BtnTelaADM.ForeColor = Color.SteelBlue;
            BtnTelaADM.ImageAlign = ContentAlignment.MiddleRight;
            BtnTelaADM.Location = new Point(922, 31);
            BtnTelaADM.Name = "BtnTelaADM";
            BtnTelaADM.Size = new Size(50, 50);
            BtnTelaADM.TabIndex = 17;
            BtnTelaADM.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(384, 15);
            label14.Name = "label14";
            label14.Size = new Size(66, 20);
            label14.TabIndex = 25;
            label14.Text = "Telefone";
            // 
            // MskBoxTelefoneFun
            // 
            MskBoxTelefoneFun.Location = new Point(384, 38);
            MskBoxTelefoneFun.Mask = "(00) 00000-0000";
            MskBoxTelefoneFun.Name = "MskBoxTelefoneFun";
            MskBoxTelefoneFun.Size = new Size(125, 27);
            MskBoxTelefoneFun.TabIndex = 24;
            MskBoxTelefoneFun.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // TelaCadastroFuncionarioADM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 514);
            Controls.Add(TabCInformacoesFuncionario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaCadastroFuncionarioADM";
            Text = "TelaCadastroFuncionarioADM";
            Load += TelaCadastroFuncionarioADM_Load;
            TabCInformacoesFuncionario.ResumeLayout(false);
            TacInfoPessoal.ResumeLayout(false);
            TacInfoPessoal.PerformLayout();
            TabcEnderecoFun.ResumeLayout(false);
            TabcEnderecoFun.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl TabCInformacoesFuncionario;
        private TabPage TacInfoPessoal;
        private TabPage TabcEnderecoFun;
        private TextBox TxtNomeFuncionario;
        private Label label1;
        private MaskedTextBox MskBoxFuncioCPF;
        private Label TxtCpf;
        private Label label4;
        private ComboBox ComBGeneroFun;
        private Label label5;
        private TextBox TxtEmailFun;
        private TextBox TxtObservaFun;
        private Label label6;
        private Button BtnFecharCadastroFun;
        private Button BtnCancelarCadastroFun;
        private Button BtnCadatrarFun;
        private MaskedTextBox MaskCepFun;
        private Button BtnTelaADM;
        private TextBox TxtCompleFun;
        private TextBox TxtCidadeFun;
        private TextBox TxtNumFun;
        private TextBox textBox3;
        private TextBox TxtRuaFun;
        private TextBox TxtBairroFun;
        private Label label7;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox TxtUfFun;
        private CheckBox CheKCadastroFun;
        private Label label3;
        private MaskedTextBox MkboxDataFun;
        private Label label2;
        private TextBox TxtSenhaFun;
        private Label label13;
        private Label label14;
        private MaskedTextBox MskBoxTelefoneFun;
    }
}