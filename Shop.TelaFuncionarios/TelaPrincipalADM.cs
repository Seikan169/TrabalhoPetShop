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

        }

        private void BtnSairADM_Click(object sender, EventArgs e)
        {
            TelaLogin sairlogin = new TelaLogin();
            sairlogin.Show();
        }

        private async void BtnBuscarADM_Click(object sender, EventArgs e)
        {
            try
            {
               
                this.Cursor = Cursors.WaitCursor;

                ApiService apiService = new ApiService();

                
                var lista = await apiService.BuscarFuncionariosAsync();

                if (lista != null && lista.Count > 0)
                {
                    DgwBuscarDados.DataSource = lista;
                    DgwBuscarDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("A API respondeu, mas a lista de funcionários está vazia.");
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
               
                this.Cursor = Cursors.Default;
            }
        }

    }
}
