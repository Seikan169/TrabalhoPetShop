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

        }

        public void PuxarDadosFuncionario()
        {
            if (string.IsNullOrWhiteSpace(TxtNumFun.Text) ||
               (string.IsNullOrWhiteSpace(MskBoxFuncioCPF.Text) ||
               (string.IsNullOrWhiteSpace(TxtEmailFun.Text) ||
               (string.IsNullOrWhiteSpace(TxtSenhaFun.Text) ||
               (string.IsNullOrWhiteSpace(CheKCadastroFun.Text) ||
               (string.IsNullOrWhiteSpace(MskBoxTelefoneFun.Text) ||
               (string.IsNullOrWhiteSpace(TxtObservaFun.Text)) ||
               (string.IsNullOrWhiteSpace(MkboxDataFun.Text))))))))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!");
                return;
            }

            BtnCadatrarFun.Enabled = false;
            BtnCadatrarFun.Text = "Salvando...";
            Cursor = Cursors.WaitCursor;

            try
            {
                ApiService api = new ApiService();

                bool sucesso = api.CadastrarUsuario(
                    TxtNomeFuncionario.Text,
                    MskBoxFuncioCPF.Text,
                    TxtEmailFun.Text,
                    TxtSenhaFun.Text,
                    CheKCadastroFun.Text,
                    MskBoxTelefoneFun.Text,
                    TxtObservaFun.Text,
                    MkboxDataFun.Text
                );

                if (sucesso)
                {
                    MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar o funcionário. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                BtnCadatrarFun.Enabled = true;
                BtnCadatrarFun.Text = "Cadastrar";
                Cursor = Cursors.Default;

            }
        }
    }
}
