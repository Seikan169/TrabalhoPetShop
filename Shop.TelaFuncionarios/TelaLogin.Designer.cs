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
            PnlTelaLogin = new Panel();
            PnlTelaLogin.SuspendLayout();
            SuspendLayout();
            // 
            // TxtUsuario
            // 
            TxtUsuario.Cursor = Cursors.IBeam;
            TxtUsuario.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtUsuario.Location = new Point(349, 179);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(234, 28);
            TxtUsuario.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(349, 149);
            label1.Name = "label1";
            label1.Size = new Size(79, 27);
            label1.TabIndex = 1;
            label1.Text = "Email:";
            // 
            // BtnEntrarLogin
            // 
            BtnEntrarLogin.BackColor = SystemColors.ControlDarkDark;
            BtnEntrarLogin.Cursor = Cursors.Hand;
            BtnEntrarLogin.FlatStyle = FlatStyle.Flat;
            BtnEntrarLogin.Font = new Font("Century Gothic", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnEntrarLogin.ForeColor = SystemColors.ButtonHighlight;
            BtnEntrarLogin.Location = new Point(349, 299);
            BtnEntrarLogin.Name = "BtnEntrarLogin";
            BtnEntrarLogin.Size = new Size(94, 29);
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
            label2.Location = new Point(349, 219);
            label2.Name = "label2";
            label2.Size = new Size(88, 27);
            label2.TabIndex = 3;
            label2.Text = "Senha:";
            // 
            // TxtSenha
            // 
            TxtSenha.Cursor = Cursors.IBeam;
            TxtSenha.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtSenha.Location = new Point(349, 249);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(234, 28);
            TxtSenha.TabIndex = 4;
            TxtSenha.UseSystemPasswordChar = true;
            // 
            // BtnCadastrarCliente
            // 
            BtnCadastrarCliente.BackColor = SystemColors.ControlDarkDark;
            BtnCadastrarCliente.Cursor = Cursors.Hand;
            BtnCadastrarCliente.FlatStyle = FlatStyle.Popup;
            BtnCadastrarCliente.Font = new Font("Century Gothic", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnCadastrarCliente.ForeColor = SystemColors.ButtonFace;
            BtnCadastrarCliente.Location = new Point(455, 299);
            BtnCadastrarCliente.Name = "BtnCadastrarCliente";
            BtnCadastrarCliente.Size = new Size(128, 29);
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
            label3.Location = new Point(32, 23);
            label3.Name = "label3";
            label3.Size = new Size(638, 69);
            label3.TabIndex = 6;
            label3.Text = "Bem-Vindo à PetWorld";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(115, 94);
            label4.Name = "label4";
            label4.Size = new Size(664, 36);
            label4.TabIndex = 7;
            label4.Text = "Um Mundo Onde Seu Parceiro(a) se Sente Bem!!";
            // 
            // PnlTelaLogin
            // 
            PnlTelaLogin.BackColor = Color.Transparent;
            PnlTelaLogin.BorderStyle = BorderStyle.Fixed3D;
            PnlTelaLogin.Controls.Add(label3);
            PnlTelaLogin.Controls.Add(BtnCadastrarCliente);
            PnlTelaLogin.Controls.Add(label4);
            PnlTelaLogin.Controls.Add(TxtUsuario);
            PnlTelaLogin.Controls.Add(TxtSenha);
            PnlTelaLogin.Controls.Add(label1);
            PnlTelaLogin.Controls.Add(label2);
            PnlTelaLogin.Controls.Add(BtnEntrarLogin);
            PnlTelaLogin.Location = new Point(2, 0);
            PnlTelaLogin.Name = "PnlTelaLogin";
            PnlTelaLogin.Size = new Size(990, 497);
            PnlTelaLogin.TabIndex = 8;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(994, 493);
            Controls.Add(PnlTelaLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1012, 540);
            MinimumSize = new Size(1012, 540);
            Name = "TelaLogin";
            Text = "TelaLogin";
            Load += TelaLogin_Load;
            PnlTelaLogin.ResumeLayout(false);
            PnlTelaLogin.PerformLayout();
            ResumeLayout(false);
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
        private Panel PnlTelaLogin;
    }
}