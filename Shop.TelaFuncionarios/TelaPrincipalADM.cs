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
            this.Close();
            sairlogin.Show();
        }

        private async void BtnBuscarADM_Click(object sender, EventArgs e)
        {
            await CarregarGrid();
            FlowPanelGrafico.Visible = false; // Esconde os cards
            DgvPricipal.Visible = true;
            LblTitulo.Text = "👥 Gestão de Funcionários";

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
                DgvPricipal.Columns.Clear();
                DgvPricipal.AutoGenerateColumns = true;

                // 2. Chama a API
                ApiService api = new ApiService();
                var lista = await api.GetFuncionarios();
                ConfigurarGridPadrao();
                // 3. Joga os dados no Grid
                DgvPricipal.DataSource = lista;


                if (DgvPricipal.Columns["Id"] != null)
                    DgvPricipal.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar funcionários: " + ex.Message);
            }
        }

        private async void TelaPrincipalADM_Load(object sender, EventArgs e)
        {
            // 1. Esconde o Grid e mostra o Dashboard
            DgvPricipal.Visible = false;
            FlowPanelGrafico.Visible = true;
            FlowPanelGrafico.Dock = DockStyle.Fill; // Garante que ocupe tudo
            

            LblTitulo.Text = "PAINEL ADMINISTRATIVO";

            // 2. Carrega os dados
            await CarregarDashboard();
            await CarregarUltimosPedidos();
        }
        private async Task CarregarUltimosPedidos()
        {
            try
            {
                ApiService api = new ApiService();
                // 1. Busca todos os pedidos (reaproveita o método que já existe)
                var todosPedidos = await api.GetTodosAgendamentos();

                if (todosPedidos != null && todosPedidos.Rows.Count > 0)
                {
                    // 2. A MÁGICA: Pega apenas os 5 primeiros registros
                    // O .AsEnumerable() permite usar LINQ no DataTable
                    var top5 = todosPedidos.AsEnumerable()
                                           .Take(5)
                                           .CopyToDataTable();

                    // 3. Joga no Grid
                    DgvUltimosPedidos.DataSource = top5;

                    // 4. Aplica o visual bonito (Criaremos esse método ajustado abaixo)
                    ConfigurarEstiloResumo(DgvUltimosPedidos);
                }
                else
                {
                    // Se não tiver pedidos, esconde o grid ou não faz nada
                    DgvUltimosPedidos.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar últimos pedidos: " + ex.Message);
            }
        }
        private void ConfigurarEstiloResumo(DataGridView dgv)
        {
            // Limpa estilo anterior
            dgv.EnableHeadersVisualStyles = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersVisible = false;
            dgv.BorderStyle = BorderStyle.None;

            // Cabeçalho Discreto (Cinza Claro ou Branco)
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black; // Texto Preto
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 30;

            // Linhas
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            dgv.DefaultCellStyle.SelectionBackColor = Color.AliceBlue; // Azul bem clarinho ao selecionar
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dgv.RowsDefaultCellStyle.BackColor = Color.White;

            // --- ESCONDER COLUNAS DESNECESSÁRIAS ---
            // No resumo, só precisamos ver: Cliente, Pet, Serviço, Valor e Status
            if (dgv.Columns.Contains("Id")) dgv.Columns["Id"].Visible = false;
            if (dgv.Columns.Contains("Data")) dgv.Columns["Data"].Visible = false; // Opcional: Se quiser economizar espaço

            // Formatação de Moeda
            if (dgv.Columns.Contains("Total"))
            {
                dgv.Columns["Total"].HeaderText = "Valor";
                dgv.Columns["Total"].DefaultCellStyle.Format = "C2";
                dgv.Columns["Total"].Width = 80;
            }

            // --- LIGA O EVENTO DE CORES DO STATUS ---
            dgv.CellFormatting -= DgvPrincipal_CellFormatting; // Reaproveita o formatador que já criamos!
            dgv.CellFormatting += DgvPrincipal_CellFormatting;
        }
        private async Task CarregarDashboard()
        {
            try
            {
                ApiService api = new ApiService();
                var dados = await api.GetDadosDashboard();

                // CARD 1 - Vendas Hoje
                LblVendaHj.Text = dados.VendasHoje.ToString("C2");

                // CARD 2 - Vendas Mês (Crie o label lblValorMes no design!)
                LblValorMes.Text = dados.VendasMes.ToString("C2");

                // CARD 3 - Pendentes
                LblQtdPendentes.Text = dados.Pendentes.ToString();

                // CARD 4 - Clientes
                LblQTDClientes.Text = dados.NovosClientes.ToString();
            }
            catch (Exception ex)
            {
                // ... erro ...
            }
        }

        private async void BtnClentesCadastradosADM_Click(object sender, EventArgs e)
        {

            LblTitulo.Text = "👥 Gestão de Clientes";
            FlowPanelGrafico.Visible = false; // Esconde os cards
            DgvPricipal.Visible = true;


            ApiService api = new ApiService();

            var dados = await api.GetListaClientes();

            DgvPricipal.DataSource = dados;

            ConfigurarGridPadrao();

            if (DgvPricipal.Columns.Contains("Telefone")) DgvPricipal.Columns["Telefone"].Width = 120;

        }

        //------------------------------------------- Configurando datagridview -------------------------------------------

        // --- MÉTODO DE ESTILO GERAL ---
        private void ConfigurarGridPadrao()
        {
            // 1. Bloqueios de edição e Seleção
            DgvPricipal.ReadOnly = true;
            DgvPricipal.AllowUserToAddRows = false;
            DgvPricipal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvPricipal.MultiSelect = false;
            DgvPricipal.RowHeadersVisible = false;

            // 2. Cores das Células (Garante que os dados apareçam sem precisar clicar)
            DgvPricipal.BackgroundColor = Color.White;
            DgvPricipal.DefaultCellStyle.BackColor = Color.White;
            DgvPricipal.DefaultCellStyle.ForeColor = Color.Black; // Texto sempre preto
            DgvPricipal.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            // 3. Cores de Seleção (Quando você clica na linha)
            DgvPricipal.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215); // Azul destaque
            DgvPricipal.DefaultCellStyle.SelectionForeColor = Color.White; // Texto branco na seleção

            // 4. Cabeçalho (Estilo igual ao da sua imagem)
            DgvPricipal.EnableHeadersVisualStyles = false;
            DgvPricipal.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
            DgvPricipal.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DgvPricipal.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            DgvPricipal.ColumnHeadersHeight = 40;
            DgvPricipal.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // 5. Organização das Colunas
            DgvPricipal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Esconder colunas que poluem o visual
            string[] ocultar = { "Id", "Senha", "Observacao", "TipoUsuario", "Cpf", "dataNascimento" };
            foreach (var col in ocultar)
            {
                if (DgvPricipal.Columns.Contains(col)) DgvPricipal.Columns[col].Visible = false;
            }

            // Nomes amigáveis
            if (DgvPricipal.Columns.Contains("DataCadastro"))
                DgvPricipal.Columns["DataCadastro"].HeaderText = "Data de Cadastro";

            // Garante que o evento de colorir status esteja ligado
            DgvPricipal.CellFormatting -= DgvPrincipal_CellFormatting;
            DgvPricipal.CellFormatting += DgvPrincipal_CellFormatting;
        }

        // --- MÉTODO PARA PINTAR O STATUS (Igual fizemos nas outras telas) ---
        private void DgvPrincipal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica se a coluna é "Status" ou "status"
            if (DgvPricipal.Columns[e.ColumnIndex].Name.Equals("status", StringComparison.OrdinalIgnoreCase) && e.Value != null)
            {
                string status = e.Value.ToString().ToLower();
                e.CellStyle.Font = new Font(DgvPricipal.Font, FontStyle.Bold);

                if (status == "pendente")
                {
                    e.CellStyle.ForeColor = Color.DarkOrange;
                    e.Value = "Pendente";
                }
                else if (status == "em_andamento")
                {
                    e.CellStyle.ForeColor = Color.DodgerBlue;
                    e.Value = "Em Andamento";
                }
                else if (status == "concluido")
                {
                    e.CellStyle.ForeColor = Color.SeaGreen;
                    e.Value = "Concluído";
                }
                else if (status == "cancelado")
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.Value = "Cancelado";
                }
            }
        }

        private async void BtnAgendamentoADM_Click(object sender, EventArgs e)
        {
            LblTitulo.Text = "📅 Histórico Geral de Agendamentos";
            FlowPanelGrafico.Visible = false; // Esconde os cards
            DgvPricipal.Visible = true;

            ApiService api = new ApiService();
            // Traz tudo (Pendentes, Concluídos, Cancelados)
            var dados = await api.GetTodosAgendamentos();

            DgvPricipal.DataSource = dados;

            ConfigurarGridPadrao(); // Aplica cores e fontes
        }

        private void DgvPricipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblDATA.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
