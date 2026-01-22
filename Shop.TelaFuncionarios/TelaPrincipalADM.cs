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
        private string _nomeadm;
        private int _idadm;


        public TelaPrincipalADM(string Nomeadm, int Idadm)
        {
            InitializeComponent();
            _nomeadm = Nomeadm;
            _idadm = Idadm;

            LblNomeAdm.Text = $"Olá,{_nomeadm}";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void EstilizarMenuLateral()
        {
            // Percorre todos os botões do painel lateral (assumindo que estão num Panel chamado panelMenu)
            // Se não estiverem num painel, você pode configurar um por um:
            // ConfigurarBotao(BtnControleFuncionario);
            // ConfigurarBotao(BtnBuscarADM); ...

            foreach (Control c in this.Controls)
            {
                // Se você tiver um Panel para o menu, mude 'this.Controls' para 'panelMenu.Controls'
                if (c is Button btn && btn.Name != "BtnSairADM") // Ignora o botão sair se quiser manter diferente
                {
                    ConfigurarBotaoMenu(btn);
                }
            }

            // Configuração específica para o botão Sair (vermelho ou destaque)
            BtnSairADM.FlatStyle = FlatStyle.Flat;
            BtnSairADM.FlatAppearance.BorderSize = 0;
            BtnSairADM.BackColor = Color.FromArgb(220, 53, 69); // Vermelho moderno
            BtnSairADM.ForeColor = Color.White;
        }

        private void ConfigurarBotaoMenu(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0; // Remove a borda grossa
            btn.BackColor = Color.FromArgb(64, 64, 64); // Fundo cinza escuro (ou a cor do seu menu)
            btn.ForeColor = Color.White; // Texto Branco
            btn.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            btn.TextAlign = ContentAlignment.MiddleLeft; // Texto alinhado à esquerda
            btn.Padding = new Padding(15, 0, 0, 0); // Espaço entre a borda esquerda e o texto/ícone
            btn.Cursor = Cursors.Hand; // Mãozinha ao passar o mouse

            // Efeito Hover (Opcional se quiser fazer via código, ou use as propriedades do Designer)
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 120, 215); // Azul ao passar o mouse
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
                ApiService api = new ApiService();
                var lista = await api.GetFuncionarios();

                // 1. Limpa e prepara
                DgvPricipal.DataSource = null;
                DgvPricipal.Columns.Clear();
                DgvPricipal.AutoGenerateColumns = true;

                // 2. JOGA OS DADOS PRIMEIRO (Isso cria as colunas automaticamente)
                DgvPricipal.DataSource = lista;

                // 3. AGORA SIM configura o visual (Esconde colunas, muda nomes, etc)
                ConfigurarGridPadrao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar funcionários: " + ex.Message);
            }
        }

        private async void TelaPrincipalADM_Load(object sender, EventArgs e)
        {
            EstilizarMenuLateral();// 1. Esconde o Grid e mostra o Dashboard
            DgvPricipal.Visible = false;
            FlowPanelGrafico.Visible = true;
            FlowPanelGrafico.Dock = DockStyle.Fill; // Garante que ocupe tudo



            LblTitulo.Text = "PAINEL ADMINISTRATIVO";

            // 2. Carrega os dados
            await CarregarDashboard();

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

            DgvPricipal.EnableHeadersVisualStyles = false;
            DgvPricipal.RowHeadersVisible = false;
            DgvPricipal.AllowUserToAddRows = false;
            DgvPricipal.ReadOnly = true;
            DgvPricipal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvPricipal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPricipal.BorderStyle = BorderStyle.None;


            // Permite que o texto quebre para a linha de baixo
            DgvPricipal.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Ajusta a altura da linha automaticamente conforme o conteúdo
            DgvPricipal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            // 5. Organização das Colunas
            DgvPricipal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Esconder colunas que poluem o visual
            string[] ocultar = { "Id", "Senha", "Observacao", "TipoUsuario" };
            foreach (var col in ocultar)
            {
                if (DgvPricipal.Columns.Contains(col)) DgvPricipal.Columns[col].Visible = false;
            }

            // Nomes amigáveis
            if (DgvPricipal.Columns.Contains("Nome")) DgvPricipal.Columns["Nome"].HeaderText = "Nome Completo";
            if (DgvPricipal.Columns.Contains("Cpf")) DgvPricipal.Columns["Cpf"].HeaderText = "CPF";
            if (DgvPricipal.Columns.Contains("Telefone")) DgvPricipal.Columns["Telefone"].HeaderText = "Contato";

            // --- FORMATAR DATAS ---
            if (DgvPricipal.Columns.Contains("DataNascimento"))
            {
                DgvPricipal.Columns["DataNascimento"].HeaderText = "Data Nasc.";
                DgvPricipal.Columns["DataNascimento"].DefaultCellStyle.Format = "dd/MM/yyyy"; // Só dia/mes/ano
            }

            if (DgvPricipal.Columns.Contains("DataCadastro"))
            {
                DgvPricipal.Columns["DataCadastro"].HeaderText = "Cadastro";
                DgvPricipal.Columns["DataCadastro"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            // Garante que o evento de colorir status esteja ligado
            DgvPricipal.CellFormatting -= DgvPrincipal_CellFormatting;
            DgvPricipal.CellFormatting += DgvPrincipal_CellFormatting;
        }

        // --- MÉTODO PARA PINTAR O STATUS (Igual fizemos nas outras telas) ---
        private void DgvPrincipal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Recupera o grid que chamou o evento de forma segura
            var grid = sender as DataGridView;

            // CORREÇÃO DE SEGURANÇA:
            // Verifica se o grid existe, se não é cabeçalho (index -1) e se o índice existe na coleção atual
            if (grid != null && e.ColumnIndex >= 0 && e.ColumnIndex < grid.Columns.Count)
            {
                // Verifica se a coluna é "Status" ou "status" usando o objeto 'grid'
                if (grid.Columns[e.ColumnIndex].Name.Equals("status", StringComparison.OrdinalIgnoreCase) && e.Value != null)
                {
                    string status = e.Value.ToString().ToLower();

                    // Aplica Negrito (usando a fonte do grid atual)
                    e.CellStyle.Font = new Font(grid.Font, FontStyle.Bold);

                    if (status == "pendente")
                    {
                        e.CellStyle.ForeColor = Color.DarkOrange;
                        e.Value = "Pendente";
                    }
                    else if (status == "em_andamento")
                    {
                        e.CellStyle.ForeColor = Color.DodgerBlue;
                        e.Value = "Em Andamento"; // Notei que no código original tinha um espaço extra aqui, mantive corrigido
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

        private async void BtnRelatorioADM_Click(object sender, EventArgs e)
        {
            await CarregarDashboard();
            FlowPanelGrafico.Visible = true; // Mostra os cards
            DgvPricipal.Visible = false;
            LblTitulo.Text = "Relatorio";
        }
    }
}
