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
    public partial class TelaCadastroUser : Form
    {
        public TelaCadastroUser()
        {
            InitializeComponent();
        }

        private void TelaCadastroUser_Load(object sender, EventArgs e)
        {

        }

        private async void BtnSalvarCadastroCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNomeCliente.Text) || 
                (string.IsNullOrWhiteSpace(TxtEmailCliente.Text) || 
                (string.IsNullOrWhiteSpace(TxtSenhaCliente.Text) || 
                (string.IsNullOrWhiteSpace(MkBoxTeleCLiente.Text) || 
                (string.IsNullOrWhiteSpace(MkBoxCep.Text) || 
                (string.IsNullOrWhiteSpace(TxtNúmeroCliente.Text) || 
                (string.IsNullOrWhiteSpace(TxtComplementoCliente.Text))))))))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios, incluindo o endereço!");
                return;

            }

            BtnSalvarCadastroCliente.Enabled = false;
            BtnSalvarCadastroCliente.Text = "Salvando...";
            Cursor = Cursors.WaitCursor;

            try
            {
                ApiService api = new ApiService();

                bool sucesso = await api.CadastrarUsuario(
                    TxtNomeCliente.Text,
                    TxtEmailCliente.Text,
                    TxtSenhaCliente.Text,
                    MkBoxTeleCLiente.Text,
                    MkBoxCep.Text,
                    TxtLogCliente.Text,
                    TxtNúmeroCliente.Text,
                    TxtComplementoCliente.Text,
                    TxtBairroCliente.Text,
                    TxtCidadeCliente.Text,
                    TxtUfCliente.Text
                );


                if (sucesso)
                {
                    MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao cadastrar o usuário. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                BtnSalvarCadastroCliente.Enabled = true;
                BtnSalvarCadastroCliente.Text = "Salvar Cadastro";
                Cursor = Cursors.Default;
            }




        }

        private async void MkBoxCep_Leave(object sender, EventArgs e)
        {
            string cep = MkBoxCep.Text.Replace("-", "").Replace(".", "").Trim();

            if (cep.Length == 8)
            {
                Cursor = Cursors.WaitCursor;

                ApiService api = new ApiService();

                var endereco = await api.BuscarEnderecoPorCep(cep);


                if (endereco != null)
                {
                    TxtLogCliente.Text = endereco.Logradouro;
                    TxtBairroCliente.Text = endereco.Bairro;
                    TxtCidadeCliente.Text = endereco.Localidade;
                    TxtUfCliente.Text = endereco.Uf;

                    TxtNúmeroCliente.Focus();
                    TxtComplementoCliente.Focus();

                }
                else
                {
                    MessageBox.Show("CEP não encontrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                Cursor = Cursors.Default;
            }
        }

        private void TxtConfirSenhaCliente_Leave(object sender, EventArgs e)
        {
            if (TxtSenhaCliente.Text != TxtConfirSenhaCliente.Text)
            {
                MessageBox.Show("As senhas não coincidem. Por favor, verifique.", "Erro de Senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtSenhaCliente.Clear();
                TxtConfirSenhaCliente.Clear();
                TxtSenhaCliente.Focus();

            }
        }
    }
}
