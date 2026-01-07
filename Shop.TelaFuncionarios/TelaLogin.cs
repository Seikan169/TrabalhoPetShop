using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop.TelaFuncionarios
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private async void BtnEntrarLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtUsuario.Text) || string.IsNullOrEmpty(TxtSenha.Text))
            {
                MessageBox.Show("Preencha usuário e senha!");
                return;
            }


            BtnEntrarLogin.Enabled = false;

            BtnEntrarLogin.Text = "Verificando...";

            Login login = new Login();

            bool sucesso = await login.FazerLogin(TxtUsuario.Text, TxtSenha.Text);


            if (sucesso)
            {
                // telaPrincipal = new TelaPrincipal();
                // telaPrincipal.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!");
                BtnEntrarLogin.Enabled = true;
                BtnEntrarLogin.Text = "Entrar";
            }
        }
    }
}
