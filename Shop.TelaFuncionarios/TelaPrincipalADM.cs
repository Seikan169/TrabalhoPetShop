using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Shop.TelaFuncionarios
{
    public partial class TelaPrincipalADM : Form
    {
        private readonly string _baseUrl = "https://localhost:7214";

        public TelaPrincipalADM()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void BtnControleFuncionario_Click(object sender, EventArgs e)
        {
            TelaCadastroFuncionarioADM telacadfun = new TelaCadastroFuncionarioADM();
            telacadfun.Show();
        }

        private void BtnSairADM_Click(object sender, EventArgs e)
        {
            TelaLogin sairlogin = new TelaLogin();
            sairlogin.Show();
        }

        private async void BtnBuscarADM_Click(object sender, EventArgs e)
        {
            await CarregarGrid();

        }

        private async Task CarregarGrid()
        {
            try
            {
                DgvPricipal.MultiSelect = false;

                // 2. Seleciona a LINHA inteira (resolve o erro e fica visualmente melhor)
                DgvPricipal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                // 1. Configura o visual do Grid (opcional, mas bom pra ficar bonito)
                DgvPricipal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // 2. Chama a API
                ApiService api = new ApiService();
                var lista = await api.GetFuncionarios();

                // 3. Joga os dados no Grid
                DgvPricipal.DataSource = lista;

                DgvPricipal.DefaultCellStyle.ForeColor = Color.Black;
                DgvPricipal.DefaultCellStyle.BackColor = Color.White;

                DgvPricipal.DefaultCellStyle.SelectionBackColor = Color.Orange;
                DgvPricipal.DefaultCellStyle.SelectionForeColor = Color.White;
                // 4. Esconde colunas que não precisa ver (opcional)
                if (DgvPricipal.Columns["Id"] != null)
                    DgvPricipal.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar funcionários: " + ex.Message);
            }
        }

        private void TelaPrincipalADM_Load(object sender, EventArgs e)
        {

        }
    }
}
