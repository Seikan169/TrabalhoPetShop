using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Shop.TelaFuncionarios
{
    public partial class TelaCadastroFuncionarioADM : Form
    {
        public TelaCadastroFuncionarioADM()
        {
            InitializeComponent();
        }

        private void TelaCadastroFuncionarioADM_Load(object sender, EventArgs e)
        {

        }

        private void BtnCadatrarFun_Click(object sender, EventArgs e)
        {
            SalvarCadastroFun();
        }

        private void PnlCadastroFun_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CheKCadastroFun_CheckedChanged(object sender, EventArgs e)
        {

        }


        // Método para salvar o cadastro do funcionário
        private async void SalvarCadastroFun()
        {
            if (string.IsNullOrWhiteSpace(TxtNomeFuncionario.Text) ||
               string.IsNullOrWhiteSpace(TxtEmailFun.Text) ||
               string.IsNullOrWhiteSpace(TxtSenhaFun.Text) ||
               string.IsNullOrWhiteSpace(MskBoxTelefoneFun.Text) ||

                string.IsNullOrWhiteSpace(MaskCepFun.Text) ||
                string.IsNullOrWhiteSpace(TxtRuaFun.Text) ||
                string.IsNullOrWhiteSpace(TxtNumFun.Text) ||
                string.IsNullOrWhiteSpace(TxtBairroFun.Text) ||
                string.IsNullOrWhiteSpace(TxtCidadeFun.Text) ||
                string.IsNullOrWhiteSpace(TxtUfFun.Text) ||
                string.IsNullOrWhiteSpace(TxtCompleFun.Text) ||
                string.IsNullOrWhiteSpace(MskBoxFuncioCPF.Text) ||
                string.IsNullOrWhiteSpace(DatapickFuncNas.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Trava a UI para evitar cliques duplos
            BtnCadatrarFun.Enabled = false;
            BtnCadatrarFun.Text = "Salvando...";
            Cursor = Cursors.WaitCursor;

            try
            {
                string cpf = MskBoxFuncioCPF.Text.Replace(".", "").Replace("-", "").Trim();
                string statususuario;
                if (RdoValidarADM.Checked)
                {
                    statususuario = "adm";
                }
                else
                {
                    statususuario = "funcionario";
                }
                ApiService api = new ApiService();

                bool sucesso = await api.CadastrarUsuario(
                    TxtNomeFuncionario.Text.Trim(),
                    TxtEmailFun.Text.Trim(),
                    TxtSenhaFun.Text.Trim(),
                    MskBoxTelefoneFun.Text.Trim(),
                    MaskCepFun.Text.Trim(),
                    TxtRuaFun.Text.Trim(),
                    TxtNumFun.Text.Trim(),
                    TxtBairroFun.Text.Trim(),
                    TxtCidadeFun.Text.Trim(),
                    TxtUfFun.Text.Trim(),
                    TxtCompleFun.Text.Trim(),
                    cpf,
                    DatapickFuncNas.Value,
                    statususuario,
                    TxtObservaFun.Text.Trim()
                );


                if (sucesso)
                {
                    MessageBox.Show("Cadastro do funcionário realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    // Se falhar, o finally lá embaixo vai destravar o botão para tentar de novo
                    MessageBox.Show("Falha ao cadastrar. Verifique se falta algum campo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // 3. Destrava a UI
                BtnCadatrarFun.Enabled = true;
                BtnCadatrarFun.Text = "Cadastrar";
                Cursor = Cursors.Default;
            }

        }

        private async void MaskCepFun_Leave(object sender, EventArgs e)
        {
            string cep = MaskCepFun.Text.Replace("-", "").Replace(".", "").Trim();

            if (cep.Length == 8)
            {
                Cursor = Cursors.WaitCursor;

                ApiService api = new ApiService();

                var endereco = await api.BuscarEnderecoPorCep(cep);


                if (endereco != null)
                {
                    TxtRuaFun.Text = endereco.Logradouro;
                    TxtBairroFun.Text = endereco.Bairro;
                    TxtCidadeFun.Text = endereco.Localidade;
                    TxtUfFun.Text = endereco.Uf;

                    TxtNumFun.Focus();
                    TxtCompleFun.Focus();

                }
                else
                {
                    MessageBox.Show("CEP não encontrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                Cursor = Cursors.Default;
            }
        }

        private void BtnFecharCadastroFun_Click(object sender, EventArgs e)
        {
            this.Close(); // Isso fecha a tela de cadastro onde você está
        }

        private void TabcEnderecoFun_Click(object sender, EventArgs e)
        {


        }

        private void BtnCancelarCadastroFun_Click(object sender, EventArgs e)
        {

            TxtNomeFuncionario.Clear();
            TxtEmailFun.Clear();
            TxtSenhaFun.Clear();
            MskBoxTelefoneFun.Clear();
            MskBoxFuncioCPF.Clear();
            MskBoxTelefoneFun.Clear();
            TxtObservaFun.Clear();

            MaskCepFun.Clear();
            TxtRuaFun.Clear();
            TxtNumFun.Clear();
            TxtBairroFun.Clear();
            TxtCidadeFun.Clear();
            TxtUfFun.Clear();
            TxtCompleFun.Clear();
        }
    }
}
