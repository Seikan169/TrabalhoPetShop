namespace Shop.TelaFuncionarios
{
    partial class TelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            TxtUsuario = new TextBox();
            label1 = new Label();
            BtnEntrarLogin = new Button();
            label2 = new Label();
            TxtSenha = new TextBox();
            BtnCadastrarCliente = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // TxtUsuario
            // 
            TxtUsuario.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtUsuario.Location = new Point(433, 258);
            TxtUsuario.Margin = new Padding(3, 2, 3, 2);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(205, 24);
            TxtUsuario.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(433, 236);
            label1.Name = "label1";
            label1.Size = new Size(78, 23);
            label1.TabIndex = 1;
            label1.Text = "Usuário";
            // 
            // BtnEntrarLogin
            // 
            BtnEntrarLogin.BackColor = SystemColors.ControlDarkDark;
            BtnEntrarLogin.FlatStyle = FlatStyle.Popup;
            BtnEntrarLogin.Font = new Font("Century Gothic", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnEntrarLogin.ForeColor = SystemColors.ButtonHighlight;
            BtnEntrarLogin.Location = new Point(660, 339);
            BtnEntrarLogin.Margin = new Padding(3, 2, 3, 2);
            BtnEntrarLogin.Name = "BtnEntrarLogin";
            BtnEntrarLogin.Size = new Size(82, 22);
            BtnEntrarLogin.TabIndex = 2;
            BtnEntrarLogin.Text = "Entrar";
            BtnEntrarLogin.UseVisualStyleBackColor = false;
            BtnEntrarLogin.Click += BtnEntrarLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(433, 289);
            label2.Name = "label2";
            label2.Size = new Size(67, 23);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // TxtSenha
            // 
            TxtSenha.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtSenha.Location = new Point(433, 311);
            TxtSenha.Margin = new Padding(3, 2, 3, 2);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(205, 24);
            TxtSenha.TabIndex = 4;
            TxtSenha.UseSystemPasswordChar = true;
            // 
            // BtnCadastrarCliente
            // 
            BtnCadastrarCliente.BackColor = SystemColors.ControlDarkDark;
            BtnCadastrarCliente.FlatStyle = FlatStyle.Popup;
            BtnCadastrarCliente.Font = new Font("Century Gothic", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnCadastrarCliente.ForeColor = SystemColors.ButtonFace;
            BtnCadastrarCliente.Location = new Point(747, 339);
            BtnCadastrarCliente.Margin = new Padding(3, 2, 3, 2);
            BtnCadastrarCliente.Name = "BtnCadastrarCliente";
            BtnCadastrarCliente.Size = new Size(112, 22);
            BtnCadastrarCliente.TabIndex = 5;
            BtnCadastrarCliente.Text = "Cadastre-se";
            BtnCadastrarCliente.UseVisualStyleBackColor = false;
            BtnCadastrarCliente.Click += BtnCadastrarCliente_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(66, 44);
            label3.Name = "label3";
            label3.Size = new Size(539, 55);
            label3.TabIndex = 6;
            label3.Text = "Bem-Vindo à PetWORD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(134, 94);
            label4.Name = "label4";
            label4.Size = new Size(540, 29);
            label4.TabIndex = 7;
            label4.Text = "Um Mundo Onde Seu Parceiro(a) se Sente Bem!!";
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(870, 370);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(BtnCadastrarCliente);
            Controls.Add(TxtSenha);
            Controls.Add(label2);
            Controls.Add(BtnEntrarLogin);
            Controls.Add(label1);
            Controls.Add(TxtUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaLogin";
            Text = "TelaLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtUsuario;
        private Label label1;
        private Button BtnEntrarLogin;
        private Label label2;
        private TextBox TxtSenha;
        private Button BtnCadastrarCliente;
        private Label label3;
        private Label label4;
    }
}