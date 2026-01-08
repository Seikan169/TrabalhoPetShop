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

            try
            {
                // 3. Chama a API
                ApiService api = new ApiService();
                var resultado = await api.FazerLogin(TxtUsuario.Text, TxtSenha.Text);

                if (resultado != null)
                {
                    MessageBox.Show($"Bem-vindo, {resultado.Nome}!", "Sucesso");

                    // 4. Redirecionamento INTELIGENTE
                    if (resultado.TipoUsuario == "cliente")
                    {
                        // Abre tela do Cliente
                        //FrmCliente tela = new FrmCliente();
                        //tela.Show();
                    }
                    else if (resultado.TipoUsuario == "funcionario")
                    {
                        // Abre tela do Funcionário (ainda vamos criar, mas já deixa pronto)
                        // FrmFuncionario tela = new FrmFuncionario();
                        // tela.Show();
                        MessageBox.Show("Abrindo painel do Funcionário...");
                    }
                    else if (resultado.TipoUsuario == "adm")
                    {
                        // Abre tela do Administrador
                        TelaPrincipalADM telaadm = new TelaPrincipalADM();
                        telaadm.Show();

                    }

                    this.Hide(); // Esconde o login
                }
                else
                {
                    MessageBox.Show("Email ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro técnico: " + ex.Message);
            }
            finally
            {
                // Libera o botão de novo
                BtnEntrarLogin.Enabled = true;
                BtnEntrarLogin.Text = "Entrar";
            }



        }

        private void BtnCadastrarCliente_Click(object sender, EventArgs e)
        {
            TelaCadastroUser cliente = new TelaCadastroUser();

            cliente.ShowDialog();

        }
    }
}
