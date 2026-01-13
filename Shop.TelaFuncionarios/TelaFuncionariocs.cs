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
    public partial class TelaFuncionariocs : Form
    {
        public TelaFuncionariocs()
        {
            InitializeComponent();

        }

        private async Task CarregarPedidos()
        {
            // Configura o visual do Grid (se ainda não fez)
            ConfigurarGridPedidos();

            ApiService api = new ApiService();
            var tabelaPedidos = await api.GetPedidosPendentes();

            if (tabelaPedidos != null)
            {
                DgvPedidos.DataSource = tabelaPedidos;
            }
        }

        private void ConfigurarGridPedidos()
        {
            DgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvPedidos.ReadOnly = true;
            DgvPedidos.AllowUserToAddRows = false;

            // Formatações bonitas
            // (Isso só funciona depois que os dados carregam, ou use o evento DataBindingComplete)
            DgvPedidos.DataBindingComplete += (s, e) =>
            {
                if (DgvPedidos.Columns["Total"] != null)
                    DgvPedidos.Columns["Total"].DefaultCellStyle.Format = "C2"; // Dinheiro

                if (DgvPedidos.Columns["Data"] != null)
                    DgvPedidos.Columns["Data"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

                // Esconde colunas feias se vierem
                if (DgvPedidos.Columns["Id"] != null)
                    DgvPedidos.Columns["Id"].Width = 50;
            };
        }
        private void BtnProximosAtendimentos_Click(object sender, EventArgs e)
        {

        }

        private async void TelaFuncionariocs_Load(object sender, EventArgs e)
        {
            await CarregarPedidos();
        }
    }
}
