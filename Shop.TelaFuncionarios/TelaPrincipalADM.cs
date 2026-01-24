using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


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


            ChartPedidos.Titles.Clear();
            // 2. Adiciona o título novo
            Title titulo = ChartPedidos.Titles.Add("Status dos Pedidos");

            // 3. Estiliza para ficar bonito (Fonte Segoe UI, Negrito, Cinza Escuro)
            titulo.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            titulo.ForeColor = Color.Black;
            titulo.Alignment = ContentAlignment.TopCenter;




            LblTitulo.Text = "PAINEL ADMINISTRATIVO";

            // 2. Carrega os dados
            await CarregarDashboard();
            // 3. Carrega o gráfico de status
            try
            {
                ApiService api = new ApiService();
                var dadosPedidos = await api.GetTodosAgendamentos();
                CarregarGraficoStatus(dadosPedidos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar gráfico de status: " + ex.Message);
            }

        }


        private async Task CarregarDashboard()
        {
            try
            {
                ApiService api = new ApiService();

                // Essa linha busca TUDO do banco (Vem uma tabela cheia de dados)
                var todosPedidos = await api.GetTodosAgendamentos();

                var PnlCard = await api.GetDadosDashboard();

                LblValorMes.Text = PnlCard.VendasMes.ToString("C2");
                LblVendaHj.Text = PnlCard.VendasHoje.ToString("C2");
                LblQTDClientes.Text = PnlCard.NovosClientes.ToString();



                if (todosPedidos != null && todosPedidos.Rows.Count > 0)
                {
                    // 1. Usa a tabela para pintar a Rosca (Status)
                    CarregarGraficoStatus(todosPedidos);



                }
            }
            catch (Exception ex)
            {

            }
        }

        private void CarregarGraficoStatus(DataTable dados)
        {
            // 1. Limpa dados antigos
            ChartPedidos.Series[0].Points.Clear();

            // 2. Conta os Status (Usando a coluna exata do seu banco: "status")
            var contagem = dados.AsEnumerable()
                .GroupBy(row => row.Field<string>("status")) // "status" minúsculo igual no banco
                .Select(g => new { StatusDoBanco = g.Key, Qtd = g.Count() })
                .ToList();

            // 3. Adiciona os pontos no gráfico
            foreach (var item in contagem)
            {
                string nomeExibicao = item.StatusDoBanco;
                Color corBarra = Color.Gray;

                // --- TRADUÇÃO DOS TERMOS DO BANCO PARA O VISUAL ---
                switch (item.StatusDoBanco.ToLower())
                {
                    case "pendente":
                        nomeExibicao = "Pendente";
                        corBarra = Color.DarkOrange;
                        break;

                    case "confirmado":
                        nomeExibicao = "Confirmado";
                        corBarra = Color.Gold;
                        break;

                    case "em_andamento": // O termo exato do seu SQL
                        nomeExibicao = "Em Andamento"; // Texto bonito para o usuário
                        corBarra = Color.RoyalBlue;
                        break;

                    case "concluido":
                        nomeExibicao = "Concluído";
                        corBarra = Color.SeaGreen;
                        break;

                    case "cancelado":
                        nomeExibicao = "Cancelado";
                        corBarra = Color.Red;
                        break;
                }

                // 4. Adiciona ao Gráfico
                int pontoIndex = ChartPedidos.Series[0].Points.AddY(item.Qtd);

                // Define o texto que aparece na legenda
                ChartPedidos.Series[0].Points[pontoIndex].LegendText = nomeExibicao;

                // Define a cor
                ChartPedidos.Series[0].Points[pontoIndex].Color = corBarra;

                // Define o rótulo (número) em cima da fatia
                ChartPedidos.Series[0].Points[pontoIndex].Label = item.Qtd.ToString();
            }

            // Deixa a rosca mais grossa e bonita
            ChartPedidos.Series[0]["DoughnutRadius"] = "60";
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


            // Esconder colunas que poluem o visual
            string[] ocultar = { "Id", "Senha", "Observacao", "TipoUsuario" };
            foreach (var col in ocultar)
            {
                if (DgvPricipal.Columns.Contains(col)) DgvPricipal.Columns[col].Visible = false;
            }

            // Nomes amigáveis
            if (DgvPricipal.Columns.Contains("Nome")) DgvPricipal.Columns["Nome"].HeaderText = "Nome Completo";


            // --- FORMATAR DATAS ---
            if (DgvPricipal.Columns.Contains("DataNascimento"))
            {
                DgvPricipal.Columns["DataNascimento"].HeaderText = "Data Nascimento";
                DgvPricipal.Columns["DataNascimento"].DefaultCellStyle.Format = "dd/MM/yyyy"; // Só dia/mes/ano
                DgvPricipal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centraliza // Ajusta a largura se quiser
            }

            if (DgvPricipal.Columns.Contains("DataCadastro"))
            {
                DgvPricipal.Columns["DataCadastro"].HeaderText = "Data de Cadastro";
                DgvPricipal.Columns["DataCadastro"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (DgvPricipal.Columns.Contains("cpf"))
            {
                DgvPricipal.Columns["cpf"].Visible = false; // <--- Tchau CPF!
            }


            // Pode ser que venha como "DataNasc" ou "dataNascimento", confira o nome exato se não sumir.

            // 3. Aproveita para renomear e bonificar o resto (Opcional)
            if (DgvPricipal.Columns.Contains("nome"))
                DgvPricipal.Columns["nome"].HeaderText = "Nome Completo";

            if (DgvPricipal.Columns.Contains("email"))
                DgvPricipal.Columns["email"].HeaderText = "E-mail";

            if (DgvPricipal.Columns.Contains("telefone"))
            {
                DgvPricipal.Columns["telefone"].HeaderText = "Contato / WhatsApp";
                var col = DgvPricipal.Columns["Telefone"];
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                // Centraliza para ficar bonito
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                ;
            }
            // Garante que o evento de colorir status esteja ligado
            DgvPricipal.CellFormatting -= DgvPrincipal_CellFormatting;
            DgvPricipal.CellFormatting += DgvPrincipal_CellFormatting;
        }

        // --- MÉTODO PARA PINTAR O STATUS (Igual fizemos nas outras telas) ---
        private void DgvPrincipal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Recupera o grid de forma segura
            var grid = sender as DataGridView;

            // Verificações de segurança básicas
            if (grid != null && e.ColumnIndex >= 0 && e.ColumnIndex < grid.Columns.Count)
            {
                string nomeColuna = grid.Columns[e.ColumnIndex].Name;

                // -------------------------------------------------------
                // 1. LÓGICA DO STATUS (Cores e Texto)
                // -------------------------------------------------------
                if (nomeColuna.Equals("status", StringComparison.OrdinalIgnoreCase) && e.Value != null)
                {
                    string status = e.Value.ToString().ToLower();

                    // Aplica Negrito
                    e.CellStyle.Font = new Font(grid.Font, FontStyle.Bold);

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

                // -------------------------------------------------------
                // 2. LÓGICA DA DATA DE NASCIMENTO (Esconder 01/01/0001)
                // -------------------------------------------------------
                // Verifica se é a coluna Data_Nascimento (Use o nome exato que vem do Controller)
                else if (nomeColuna.Equals("Data_Nascimento", StringComparison.OrdinalIgnoreCase) && e.Value != null)
                {
                    if (DateTime.TryParse(e.Value.ToString(), out DateTime data))
                    {
                        // Se o ano for 1 (significa que veio vazio do banco), limpa o texto
                        if (data.Year == 1)
                        {
                            e.Value = "";
                            e.FormattingApplied = true; // Avisa o grid que a formatação está pronta
                        }
                    }
                }
            }
        }

        private void DgvPricipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblDATA.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }



        private void PnlBotoes_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void BtnBuscarADM_Click_1(object sender, EventArgs e)
        {

            DgvPricipal.Visible = true;
            PnlConteudoBaixo.Visible = false;

            await CarregarGrid();
            LblTitulo.Text = "👥 Gestão de Funcionários";

        }

        private void AtualizargridAgendamento()
        {


            // 2. AGORA COLE ISSO EMBAIXO PARA RENOMEAR:
            // Verifica se a coluna existe antes de renomear para não dar erro

            if (DgvPricipal.Columns.Contains("cliente"))
                DgvPricipal.Columns["cliente"].HeaderText = "Cliente";

            if (DgvPricipal.Columns.Contains("pet"))
                DgvPricipal.Columns["pet"].HeaderText = "Nome do Pet";

            if (DgvPricipal.Columns.Contains("descricao"))
                DgvPricipal.Columns["descricao"].HeaderText = "Serviços Realizados";

            if (DgvPricipal.Columns.Contains("data"))
            {
                DgvPricipal.Columns["data"].HeaderText = "Data e Hora";
                DgvPricipal.Columns["data"].Width = 140; // Dá uma ajustada na largura se quiser
            }

            if (DgvPricipal.Columns.Contains("total"))
            {
                DgvPricipal.Columns["total"].HeaderText = "Valor Total";
                DgvPricipal.Columns["total"].DefaultCellStyle.Format = "C2"; // Já coloca o R$ automático
                DgvPricipal.Columns["total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                DgvPricipal.Columns["total"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (DgvPricipal.Columns.Contains("status"))
            {
                DgvPricipal.Columns["status"].HeaderText = "Situação";
                DgvPricipal.Columns["status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }

            if (DgvPricipal.Columns.Contains("funcionario"))
            {
                DgvPricipal.Columns["funcionario"].HeaderText = "Atendido Por";
                DgvPricipal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
        }

        private async void BtnAgendamentoADM_Click(object sender, EventArgs e)
        {
            LblTitulo.Text = "📅 Histórico Geral de Agendamentos";
            DgvPricipal.Visible = true;
            PnlConteudoBaixo.Visible = false;

            ApiService api = new ApiService();
            // Traz tudo (Pendentes, Concluídos, Cancelados)
            var dados = await api.GetTodosAgendamentos();

            DgvPricipal.DataSource = dados;

            AtualizargridAgendamento();

            ConfigurarGridPadrao(); // Aplica cores e fontes
        }

        private async void BtnClentesCadastradosADM_Click(object sender, EventArgs e)
        {
            LblTitulo.Text = "👥 Gestão de Clientes";
            DgvPricipal.Visible = true;
            PnlConteudoBaixo.Visible = false;

            ApiService api = new ApiService();

            var dados = await api.GetListaClientes();

            DgvPricipal.DataSource = dados;

            ConfigurarGridPadrao();

        }

        private void BtnSairADM_Click_1(object sender, EventArgs e)
        {
            this.Close();
            TelaLogin sairlogin = new TelaLogin();

            sairlogin.Show();
        }

        private async void BtnPainelFinanceiroADM_Click(object sender, EventArgs e)
        {
            await CarregarDashboard();
            PnlConteudoBaixo.Visible = true; // Mostra os cards
            DgvPricipal.Visible = false;
            LblTitulo.Text = "Relatorio";
        }

        private async void BtnRelatorioADM_Click(object sender, EventArgs e)
        {
            try
            {
                BtnRelatorioADM.Enabled = false; // Trava o botão
                MessageBox.Show("Gerando relatório... Aguarde.", "Aguarde");

                // 1. Busca os dados da API
                ApiService api = new ApiService();
                // Crie esse método no ApiService parecido com os outros, retornando RelatorioDTO
                // var dados = await api.GetRelatorioGeral(); 
                // *** PARA TESTE, VOU SIMULAR OS DADOS ABAIXO, MAS VOCÊ DEVE BUSCAR DA API ***
                var dados = await api.GetRelatorioDashboard(); // <--- Crie esse método no ApiService chamando a rota nova

                if (dados == null) return;

                // 2. CRIA O ARQUIVO EXCEL NA MEMÓRIA
                using (var workbook = new XLWorkbook())
                {
                    // ==========================================
                    // ABA 1: DASHBOARD (Resumo e Top Serviços)
                    // ==========================================
                    var wsDash = workbook.Worksheets.Add("Dashboard Financeiro");

                    // --- Título ---
                    wsDash.Cell("B2").Value = "RELATÓRIO GERENCIAL - PET SHOP";
                    wsDash.Range("B2:E2").Merge().Style.Font.Bold = true;
                    wsDash.Range("B2:E2").Style.Font.FontSize = 16;
                    wsDash.Range("B2:E2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    wsDash.Range("B2:E2").Style.Fill.BackgroundColor = XLColor.FromHtml("#0078D7"); // Azul
                    wsDash.Range("B2:E2").Style.Font.FontColor = XLColor.White;

                    // --- Card: Vendas Hoje ---
                    wsDash.Cell("B4").Value = "Vendas Hoje";
                    wsDash.Cell("B5").Value = dados.FaturamentoHoje;
                    wsDash.Cell("B5").Style.NumberFormat.Format = "R$ #,##0.00";
                    wsDash.Cell("B6").Value = $"{dados.PedidosHoje} Pedidos";
                    EstilizarCard(wsDash, "B4", XLColor.LightBlue);

                    // --- Card: 7 Dias ---
                    wsDash.Cell("D4").Value = "Últimos 7 Dias";
                    wsDash.Cell("D5").Value = dados.Faturamento7Dias;
                    wsDash.Cell("D5").Style.NumberFormat.Format = "R$ #,##0.00";
                    wsDash.Cell("D6").Value = $"{dados.Pedidos7Dias} Pedidos";
                    EstilizarCard(wsDash, "D4", XLColor.LightGreen);

                    // --- Card: Mês ---
                    wsDash.Cell("F4").Value = "Este Mês";
                    wsDash.Cell("F5").Value = dados.FaturamentoMes;
                    wsDash.Cell("F5").Style.NumberFormat.Format = "R$ #,##0.00";
                    wsDash.Cell("F6").Value = $"{dados.PedidosMes} Pedidos";
                    EstilizarCard(wsDash, "F4", XLColor.LightCoral);

                    // --- Tabela: TOP SERVIÇOS (O "Gráfico" em forma de tabela) ---
                    wsDash.Cell("B9").Value = "TOP 5 SERVIÇOS MAIS VENDIDOS";
                    wsDash.Range("B9:D9").Merge().Style.Font.Bold = true;

                    // Cabeçalhos
                    wsDash.Cell("B10").Value = "Serviço";
                    wsDash.Cell("C10").Value = "Qtd";
                    wsDash.Cell("D10").Value = "Total Gerado";
                    wsDash.Range("B10:D10").Style.Fill.BackgroundColor = XLColor.Gray;
                    wsDash.Range("B10:D10").Style.Font.FontColor = XLColor.White;

                    int linha = 11;
                    foreach (var item in dados.TopServicos)
                    {
                        wsDash.Cell($"B{linha}").Value = item.NomeServico;
                        wsDash.Cell($"C{linha}").Value = item.Quantidade;
                        wsDash.Cell($"D{linha}").Value = item.ValorTotal;
                        wsDash.Cell($"D{linha}").Style.NumberFormat.Format = "R$ #,##0.00";
                        linha++;
                    }
                    // Borda na tabela
                    var tabelaTop = wsDash.Range($"B10:D{linha - 1}");
                    tabelaTop.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    tabelaTop.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                    // Ajusta larguras
                    wsDash.Columns().AdjustToContents();

                    // ==========================================
                    // ABA 2: LISTAGEM COMPLETA
                    // ==========================================
                    var wsLista = workbook.Worksheets.Add("Histórico Detalhado");

                    // Cabeçalho
                    wsLista.Cell("A1").Value = "ID";
                    wsLista.Cell("B1").Value = "Data";
                    wsLista.Cell("C1").Value = "Cliente";
                    wsLista.Cell("D1").Value = "Itens / Serviços";
                    wsLista.Cell("E1").Value = "Valor";
                    wsLista.Cell("F1").Value = "Status";

                    var header = wsLista.Range("A1:F1");
                    header.Style.Font.Bold = true;
                    header.Style.Fill.BackgroundColor = XLColor.DarkBlue;
                    header.Style.Font.FontColor = XLColor.White;

                    int l = 2;
                    foreach (var p in dados.ListaCompleta)
                    {
                        wsLista.Cell($"A{l}").Value = p.Id;
                        wsLista.Cell($"B{l}").Value = p.Data;
                        wsLista.Cell($"C{l}").Value = p.Cliente;
                        wsLista.Cell($"D{l}").Value = p.Itens;
                        wsLista.Cell($"E{l}").Value = p.Valor;
                        wsLista.Cell($"E{l}").Style.NumberFormat.Format = "R$ #,##0.00";
                        wsLista.Cell($"F{l}").Value = p.Status;

                        // Pinta de vermelho se cancelado
                        if (p.Status == "cancelado")
                            wsLista.Row(l).Style.Font.FontColor = XLColor.Red;

                        l++;
                    }

                    wsLista.Columns().AdjustToContents();

                    // 3. SALVAR O ARQUIVO
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "Excel Files|*.xlsx";
                    saveDialog.FileName = $"Relatorio_PetShop_{DateTime.Now:ddMMyyyy}.xlsx";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(saveDialog.FileName);
                        MessageBox.Show("Relatório gerado com sucesso!", "Sucesso");

                        // Tenta abrir o arquivo automaticamente
                        try { System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(saveDialog.FileName) { UseShellExecute = true }); } catch { }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar relatório: " + ex.Message);
            }
            finally
            {
                BtnRelatorioADM.Enabled = true;
            }
        }
        // Método auxiliar para deixar os cards bonitos
        private void EstilizarCard(IXLWorksheet ws, string cellInicio, XLColor corFundo)
        {
            // Pega a linha e a coluna base (ex: "B4" -> linha 4, col 2)
            var cell = ws.Cell(cellInicio);
            int r = cell.Address.RowNumber;
            int c = cell.Address.ColumnNumber;

            // Define o intervalo do card (3 linhas de altura)
            var range = ws.Range(r, c, r + 2, c + 1); // Pega 2 colunas de largura

            range.Style.Border.OutsideBorder = XLBorderStyleValues.Medium;
            range.Style.Fill.BackgroundColor = corFundo;
            range.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            range.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

            // Negrito no título (1ª linha do card)
            ws.Cell(r, c).Style.Font.Bold = true;
            ws.Cell(r, c).Style.Font.FontSize = 11;

            // Tamanho grande no valor (2ª linha)
            ws.Cell(r + 1, c).Style.Font.Bold = true;
            ws.Cell(r + 1, c).Style.Font.FontSize = 14;

            // Mescla as células horizontalmente
            ws.Range(r, c, r, c + 1).Merge();   // Título
            ws.Range(r + 1, c, r + 1, c + 1).Merge(); // Valor
            ws.Range(r + 2, c, r + 2, c + 1).Merge(); // Qtd
        }

        private async void BtnAtualizar_Click(object sender, EventArgs e)
        {
            BtnAtualizar.Enabled = false; // Trava o botão para não clicar mil vezes
            Cursor = Cursors.WaitCursor;  // Muda o mouse para "Carregando"

            // 2. Chama a função que busca no banco (REAPROVEITAMENTO)
            await CarregarDashboard();

            // 3. Atualiza a hora
            lblUltimaAtualizacao.Text = "Atualizado às: " + DateTime.Now.ToString("HH:mm:ss");

            // 4. Destrava tudo
            BtnAtualizar.Enabled = true;
            Cursor = Cursors.Default;
        }
    }
}