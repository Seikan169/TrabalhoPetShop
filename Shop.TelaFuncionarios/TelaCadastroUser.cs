using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            // 1. Validação (Removi excesso de parênteses e tirei a obrigatoriedade do Complemento)
            if (string.IsNullOrWhiteSpace(TxtNomeCliente.Text) ||
                string.IsNullOrWhiteSpace(TxtEmailCliente.Text) ||
                string.IsNullOrWhiteSpace(TxtSenhaCliente.Text) ||
                string.IsNullOrWhiteSpace(MkBoxTeleCLiente.Text) ||
                string.IsNullOrWhiteSpace(MkBoxCep.Text) ||
                string.IsNullOrWhiteSpace(TxtNúmeroCliente.Text)) // Complemento costuma ser opcional
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string email = TxtEmailCliente.Text.Trim(); // Trim remove espaços acidentais no começo/fim
            string senha = TxtSenhaCliente.Text.Trim();

           if(DatapickNascimento.Value >= DateTime.Now)
           {
                MessageBox.Show("Data de nascimento inválida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
           }

            // 2. Trava a UI para evitar cliques duplos
            BtnSalvarCadastroCliente.Enabled = false;
            BtnSalvarCadastroCliente.Text = "Salvando...";
            Cursor = Cursors.WaitCursor;

            try
            {
                // Limpeza do CPF
                string cpf = MkBoxCpf.Text.Replace(".", "").Replace("-", "").Trim();


                ApiService api = new ApiService();

                // 3. ATENÇÃO AQUI: A ordem dos parâmetros foi corrigida para bater com o ApiService
                // Ordem: Nome, Email, Senha, Tel, Cep, Rua, Num, BAIRRO, CIDADE, UF, COMPLEMENTO, Cpf, Data, Tipo
                bool sucesso = await api.CadastrarUsuario(
                    TxtNomeCliente.Text,
                    email,
                    senha,
                    MkBoxTeleCLiente.Text,

                    MkBoxCep.Text,
                    TxtLogCliente.Text,
                    TxtNúmeroCliente.Text,

                    // CORREÇÃO: Bairro, Cidade e UF vêm ANTES do Complemento
                    TxtBairroCliente.Text,
                    TxtCidadeCliente.Text,
                    TxtUfCliente.Text,
                    TxtComplementoCliente.Text,

                    cpf,
                    DatapickNascimento.Value,
                    "cliente",
                    ""
                );

                if (sucesso)
                {
                    MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    // Se falhar, o finally lá embaixo vai destravar o botão para tentar de novo
                    MessageBox.Show("Falha ao cadastrar. Verifique se o e-mail já existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // 4. IMPORTANTE: Isso roda sempre, dando certo ou errado, para destravar a tela
                BtnSalvarCadastroCliente.Enabled = true;
                BtnSalvarCadastroCliente.Text = "Salvar"; // Ou o texto original do botão
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

            if (TxtSenhaCliente.Text.Length <= 8)
            {
                MessageBox.Show("A senha deve ter MAIS de 8 caracteres.", "Senha Fraca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtSenhaCliente.Focus();
            }

            // 3. Validação de Caractere Especial (Ex: @, #, !, $)
            // Verifica se NÃO tem nenhum símbolo
            if (!Regex.IsMatch(TxtSenhaCliente.Text, @"[!@#$%^&*(),.?""{}|<>]"))
            {
                MessageBox.Show("A senha precisa ter pelo menos um caractere especial (Ex: @, #, !).", "Senha Fraca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtSenhaCliente.Focus();
            }

            if (TxtSenhaCliente.Text != TxtConfirSenhaCliente.Text)
            {
                MessageBox.Show("As senhas não coincidem. Por favor, verifique.", "Erro de Senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtSenhaCliente.Clear();
                TxtConfirSenhaCliente.Clear();
                TxtSenhaCliente.Focus();

            }
        }

        private void TxtEmailCliente_Leave(object sender, EventArgs e)
        {
            string modeloEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(TxtEmailCliente.Text, modeloEmail))
            {
                MessageBox.Show("Por favor, insira um e-mail válido (ex: nome@gmail.com).", "E-mail Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtEmailCliente.Focus(); // Falhou
            }
        }
    }
}
