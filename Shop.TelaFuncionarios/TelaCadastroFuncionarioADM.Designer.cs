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
            TxtDataNascimentoFun = new TextBox();
            label2 = new Label();
            TxtRGFun = new TextBox();
            TxtCpf = new Label();
            label1 = new Label();
            MskBoxFuncioCPF = new MaskedTextBox();
            TxtNomeFuncionario = new TextBox();
            TabcEnderecoFun = new TabPage();
            MaskCepFun = new MaskedTextBox();
            BtnConsultarCepFun = new Button();
            BtnTelaADM = new Button();
            TxtBairroFun = new TextBox();
            TxtRuaFun = new TextBox();
            textBox3 = new TextBox();
            TxtNumFun = new TextBox();
            TxtCidadeFun = new TextBox();
            TxtCompleFun = new TextBox();
            label7 = new Label();
            label8 = new Label();
            TxtUfFun = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            CheKCadastroFun = new CheckBox();
            TabCInformacoesFuncionario.SuspendLayout();
            TacInfoPessoal.SuspendLayout();
            TabcEnderecoFun.SuspendLayout();
            SuspendLayout();
            // 
            // TabCInformacoesFuncionario
            // 
            TabCInformacoesFuncionario.Controls.Add(TacInfoPessoal);
            TabCInformacoesFuncionario.Controls.Add(TabcEnderecoFun);
            TabCInformacoesFuncionario.Location = new Point(80, 12);
            TabCInformacoesFuncionario.Name = "TabCInformacoesFuncionario";
            TabCInformacoesFuncionario.SelectedIndex = 0;
            TabCInformacoesFuncionario.Size = new Size(753, 458);
            TabCInformacoesFuncionario.TabIndex = 1;
            // 
            // TacInfoPessoal
            // 
            TacInfoPessoal.BackgroundImage = (Image)resources.GetObject("TacInfoPessoal.BackgroundImage");
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
            TacInfoPessoal.Controls.Add(TxtDataNascimentoFun);
            TacInfoPessoal.Controls.Add(label2);
            TacInfoPessoal.Controls.Add(TxtRGFun);
            TacInfoPessoal.Controls.Add(TxtCpf);
            TacInfoPessoal.Controls.Add(label1);
            TacInfoPessoal.Controls.Add(MskBoxFuncioCPF);
            TacInfoPessoal.Controls.Add(TxtNomeFuncionario);
            TacInfoPessoal.Location = new Point(4, 29);
            TacInfoPessoal.Name = "TacInfoPessoal";
            TacInfoPessoal.Padding = new Padding(3);
            TacInfoPessoal.Size = new Size(745, 425);
            TacInfoPessoal.TabIndex = 2;
            TacInfoPessoal.Text = "Dados Gerais";
            TacInfoPessoal.UseVisualStyleBackColor = true;
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
            BtnFecharCadastroFun.Location = new Point(689, 15);
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
            TxtObservaFun.Size = new Size(635, 134);
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
            label3.Location = new Point(537, 15);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 7;
            label3.Text = "Data Nascimento";
            // 
            // TxtDataNascimentoFun
            // 
            TxtDataNascimentoFun.Location = new Point(537, 38);
            TxtDataNascimentoFun.Name = "TxtDataNascimentoFun";
            TxtDataNascimentoFun.Size = new Size(125, 27);
            TxtDataNascimentoFun.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(379, 15);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 5;
            label2.Text = "RG";
            // 
            // TxtRGFun
            // 
            TxtRGFun.Location = new Point(379, 38);
            TxtRGFun.Name = "TxtRGFun";
            TxtRGFun.Size = new Size(119, 27);
            TxtRGFun.TabIndex = 4;
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
            TabcEnderecoFun.Controls.Add(BtnConsultarCepFun);
            TabcEnderecoFun.Controls.Add(BtnTelaADM);
            TabcEnderecoFun.Location = new Point(4, 29);
            TabcEnderecoFun.Name = "TabcEnderecoFun";
            TabcEnderecoFun.Padding = new Padding(3);
            TabcEnderecoFun.Size = new Size(745, 425);
            TabcEnderecoFun.TabIndex = 3;
            TabcEnderecoFun.Text = "Endereço";
            TabcEnderecoFun.UseVisualStyleBackColor = true;
            // 
            // MaskCepFun
            // 
            MaskCepFun.Location = new Point(33, 31);
            MaskCepFun.Mask = "00000-000";
            MaskCepFun.Name = "MaskCepFun";
            MaskCepFun.Size = new Size(125, 27);
            MaskCepFun.TabIndex = 19;
            // 
            // BtnConsultarCepFun
            // 
            BtnConsultarCepFun.BackColor = SystemColors.HotTrack;
            BtnConsultarCepFun.FlatStyle = FlatStyle.Popup;
            BtnConsultarCepFun.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnConsultarCepFun.Location = new Point(174, 31);
            BtnConsultarCepFun.Name = "BtnConsultarCepFun";
            BtnConsultarCepFun.Size = new Size(100, 27);
            BtnConsultarCepFun.TabIndex = 18;
            BtnConsultarCepFun.Text = "Consultar ";
            BtnConsultarCepFun.UseVisualStyleBackColor = false;
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
            BtnTelaADM.Location = new Point(677, 19);
            BtnTelaADM.Name = "BtnTelaADM";
            BtnTelaADM.Size = new Size(50, 50);
            BtnTelaADM.TabIndex = 17;
            BtnTelaADM.UseVisualStyleBackColor = false;
            // 
            // TxtBairroFun
            // 
            TxtBairroFun.Location = new Point(33, 127);
            TxtBairroFun.Name = "TxtBairroFun";
            TxtBairroFun.Size = new Size(230, 27);
            TxtBairroFun.TabIndex = 20;
            // 
            // TxtRuaFun
            // 
            TxtRuaFun.Location = new Point(33, 190);
            TxtRuaFun.Name = "TxtRuaFun";
            TxtRuaFun.Size = new Size(230, 27);
            TxtRuaFun.TabIndex = 21;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(41, 255);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 22;
            // 
            // TxtNumFun
            // 
            TxtNumFun.Location = new Point(357, 127);
            TxtNumFun.Name = "TxtNumFun";
            TxtNumFun.Size = new Size(125, 27);
            TxtNumFun.TabIndex = 23;
            // 
            // TxtCidadeFun
            // 
            TxtCidadeFun.Location = new Point(33, 323);
            TxtCidadeFun.Name = "TxtCidadeFun";
            TxtCidadeFun.Size = new Size(125, 27);
            TxtCidadeFun.TabIndex = 23;
            // 
            // TxtCompleFun
            // 
            TxtCompleFun.Location = new Point(357, 190);
            TxtCompleFun.Name = "TxtCompleFun";
            TxtCompleFun.Size = new Size(125, 27);
            TxtCompleFun.TabIndex = 24;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 167);
            label8.Name = "label8";
            label8.Size = new Size(34, 20);
            label8.TabIndex = 26;
            label8.Text = "Rua";
            // 
            // TxtUfFun
            // 
            TxtUfFun.Location = new Point(33, 255);
            TxtUfFun.Name = "TxtUfFun";
            TxtUfFun.Size = new Size(125, 27);
            TxtUfFun.TabIndex = 22;
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(33, 300);
            label10.Name = "label10";
            label10.Size = new Size(56, 20);
            label10.TabIndex = 28;
            label10.Text = "Cidade";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(357, 167);
            label11.Name = "label11";
            label11.Size = new Size(104, 20);
            label11.TabIndex = 29;
            label11.Text = "Complemento";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(357, 104);
            label12.Name = "label12";
            label12.Size = new Size(63, 20);
            label12.TabIndex = 29;
            label12.Text = "Número";
            // 
            // CheKCadastroFun
            // 
            CheKCadastroFun.AutoSize = true;
            CheKCadastroFun.Location = new Point(473, 116);
            CheKCadastroFun.Name = "CheKCadastroFun";
            CheKCadastroFun.Size = new Size(180, 24);
            CheKCadastroFun.TabIndex = 19;
            CheKCadastroFun.Text = "Aplicar Usuário Admin";
            CheKCadastroFun.UseVisualStyleBackColor = true;
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
        private Label label2;
        private TextBox TxtRGFun;
        private Label label3;
        private TextBox TxtDataNascimentoFun;
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
        private Button BtnConsultarCepFun;
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
    }
}