using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tela.Cliente;

namespace Shop.TelaFuncionarios
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Desativa o botão de maximizar
            this.MaximizeBox = false;

            // Opcional: Centraliza a tela ao abrir
            this.StartPosition = FormStartPosition.CenterScreen;
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
                        Tela_Cliente tela = new Tela_Cliente(resultado.Nome, resultado.Id);
                        tela.Show();
                        MessageBox.Show("Abrindo painel do Cliente...");
                        this.Hide(); // Esconde o login
                    }
                    else if (resultado.TipoUsuario == "funcionario")
                    {

                        MessageBox.Show("Abrindo painel do Funcionário...");
                        this.Hide(); // Esconde o login
                    }
                    else if (resultado.TipoUsuario == "adm")
                    {
                        // Abre tela do Administrador
                        var telaAdm = new TelaPrincipalADM(resultado.Nome, resultado.Id);
                        telaAdm.Show();
                        this.Hide(); // Esconde o login

                    }


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

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnContato_Click(object sender, EventArgs e)
        {
            InformacaoContatocs conta = new InformacaoContatocs();
            conta.ShowDialog();
        }
    }
}
