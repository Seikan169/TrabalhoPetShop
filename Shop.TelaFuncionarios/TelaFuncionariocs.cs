using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop.TelaFuncionarios; // Garanta que o namespace bate com seu projeto

namespace Shop.TelaFuncionarios
{
    public partial class TelaFuncionariocs : Form
    {
        public TelaFuncionariocs()
        {
            InitializeComponent();
        }

        // --- CARREGAMENTO INICIAL ---
        private void TelaFuncionariocs_Load(object sender, EventArgs e)
        {
            // Começa carregando a fila
            LblTitulo.Text = "⏳ Fila de Atendimentos";
            CarregarGrid("pendente");

        }

        // --- LÓGICA DO GRID ---
        private async void CarregarGrid(string statusDesejado)
        {
            // 1. Muda visual para indicar carregamento
            DgvPedidos.DataSource = null; // Mudei para dgvPedidos (padrão)
            Cursor = Cursors.WaitCursor;

            try
            {
                ConfigurarEstiloVisual();
                ApiService api = new ApiService();

                // 2. Busca direto do banco filtrado
                var dados = await api.GetPedidosPorStatus(statusDesejado);

                // 3. Joga no Grid
                if (dados != null && dados.Rows.Count > 0)
                {
                    DgvPedidos.DataSource = dados;
                    FormatarColunasDados();
                }
                else
                {
                    // Opcional: Se quiser limpar a tela quando não tiver nada
                    // dgvPedidos.DataSource = null; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar: " + ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        private void ConfigurarEstiloVisual()
        {
            // Limpa configurações anteriores para não bugar
            DgvPedidos.EnableHeadersVisualStyles = false;
            DgvPedidos.RowHeadersVisible = false;
            DgvPedidos.AllowUserToAddRows = false;
            DgvPedidos.ReadOnly = true;
            DgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPedidos.BorderStyle = BorderStyle.None;

            // Cabeçalho Escuro
            DgvPedidos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            DgvPedidos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DgvPedidos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 30, 30); // Não muda de cor se clicar no título
            DgvPedidos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            DgvPedidos.ColumnHeadersHeight = 40;



            // Linhas
            DgvPedidos.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            DgvPedidos.DefaultCellStyle.SelectionForeColor = Color.White;
            DgvPedidos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            DgvPedidos.RowsDefaultCellStyle.BackColor = Color.White;
        }
        private void FormatarColunasDados()
        {
            // O segredo: só tenta formatar SE a coluna existir

            // Formata a nova coluna de Descrição
            if (DgvPedidos.Columns.Contains("descricao"))
            {
                DgvPedidos.Columns["descricao"].HeaderText = "Serviços";
                DgvPedidos.Columns["descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Ocupa o espaço livre

                // Dica de Ouro: Move a coluna para ficar logo depois do Pet (posição 2 ou 3)
                DgvPedidos.Columns["descricao"].DisplayIndex = 2;
            }
            // 1. Total (Dinheiro)
            if (DgvPedidos.Columns.Contains("total"))
            {
                DgvPedidos.Columns["total"].HeaderText = "Valor Total";
                DgvPedidos.Columns["total"].DefaultCellStyle.Format = "C2"; // R$
                DgvPedidos.Columns["total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // 2. Data
            if (DgvPedidos.Columns.Contains("data"))
            {
                DgvPedidos.Columns["data"].HeaderText = "Data Agendada";
                DgvPedidos.Columns["data"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                DgvPedidos.Columns["data"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // 3. Status
            if (DgvPedidos.Columns.Contains("status"))
            {
                DgvPedidos.Columns["status"].HeaderText = "Status";
                DgvPedidos.Columns["status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // 4. Nomes
            if (DgvPedidos.Columns.Contains("cliente")) DgvPedidos.Columns["cliente"].HeaderText = "Cliente";
            if (DgvPedidos.Columns.Contains("pet")) DgvPedidos.Columns["pet"].HeaderText = "Pet";

            // 5. Esconder ID
            if (DgvPedidos.Columns.Contains("id")) DgvPedidos.Columns["id"].Visible = false;
        }


        private void DgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // --- BOTÕES LATERAIS (MENU) ---
        private void BtnProximosAtendimentos_Click(object sender, EventArgs e)
        {
            LblTitulo.Text = "⏳ Fila de Atendimentos"; // Verifique se seu Label chama lblTitulo ou label1
            CarregarGrid("pendente");
        }

        private void BtnIniciados_Click(object sender, EventArgs e)
        {
            LblTitulo.Text = "🛁 Atendimentos em Andamento";
            CarregarGrid("em_andamento");
        }

        private void BtnConcluidos_Click(object sender, EventArgs e)
        {
            LblTitulo.Text = "✅ Serviços Concluídos";
            CarregarGrid("concluido");
        }

        private void BtnCancelados_Click(object sender, EventArgs e)
        {
            LblTitulo.Text = "❌ Pedidos Cancelados";
            CarregarGrid("cancelado");
        }

        // --- BOTÕES DE AÇÃO (RODAPÉ) ---

        // Método Genérico que faz a mágica
        private async Task MudarStatusPedido(string novoStatus)
        {
            if (DgvPedidos.SelectedRows.Count == 0) return;

            // Pega o ID
            int idPedido = Convert.ToInt32(DgvPedidos.SelectedRows[0].Cells["Id"].Value);

            // Confirmação
            if (MessageBox.Show($"Deseja mudar o status para {novoStatus.ToUpper()}?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                BtnIniciar.Enabled = false; // Trava botões para não clicar 2x

                ApiService api = new ApiService();

                // AGORA VAI FUNCIONAR (porque criamos no Passo 1)
                bool sucesso = await api.AtualizarStatus(idPedido, novoStatus);

                if (sucesso)
                {
                    MessageBox.Show("Status atualizado!");

                    // Lógica inteligente de recarregar a tela certa
                    if (novoStatus == "em_andamento")
                        BtnIniciados_Click(null, null); // Vai para a tela de Em Andamento
                    else if (novoStatus == "concluido")
                        BtnConcluidos_Click(null, null); // Vai para Concluídos
                    else
                        CarregarGrid("pendente"); // Padrão
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar status na API.");
                }

                BtnIniciar.Enabled = true;
            }
        }

        // Eventos de Clique dos Botões Coloridos
        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            await MudarStatusPedido("concluido");
        }

        private async void btnConcluir_Click(object sender, EventArgs e)
        {
        }

        private async void btnCancelar_Click(object sender, EventArgs e)
        {
            await MudarStatusPedido("cancelado");
        }

        // --- CONTROLE DE VISIBILIDADE (QUEM APARECE QUANDO) ---
        private void DgvPedidos_SelectionChanged(object sender, EventArgs e)
        {
            // 1. Reseta tudo
            BtnIniciar.Visible = false;
            BtnFinalizarServico.Visible = false;
            BtnCancelar.Visible = false;

            if (DgvPedidos.SelectedRows.Count == 0) return;

            // 2. Verifica status da linha
            // IMPORTANTE: O nome da coluna "Status" tem que ser igual ao que vem do banco
            if (DgvPedidos.Columns.Contains("Status") && DgvPedidos.SelectedRows[0].Cells["Status"].Value != null)
            {
                string statusAtual = DgvPedidos.SelectedRows[0].Cells["Status"].Value.ToString();

                switch (statusAtual)
                {
                    case "pendente":
                        BtnIniciar.Visible = true;
                        BtnCancelar.Visible = true;
                        break;

                    case "em_andamento":
                        BtnFinalizarServico.Visible = true;
                        break;
                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (DgvPedidos.DataSource is DataTable tabela)
            {
                string filtro = TxtBuscarPorNome.Text.Trim(); // Remove espaços extras

                // Se estiver vazio ou for o texto placeholder, limpa o filtro
                if (string.IsNullOrEmpty(filtro) || filtro == "Buscar por cliente...")
                {
                    tabela.DefaultView.RowFilter = ""; // Mostra tudo
                }
                else
                {
                    // 2. A MÁGICA DO FILTRO (SQL Simples no Desktop)
                    // Filtra se o nome do Cliente OU do Pet contém o texto digitado
                    tabela.DefaultView.RowFilter = $"cliente LIKE '%{filtro}%' OR pet LIKE '%{filtro}%'";
                }
            }
        }

        private void TxtBuscarPorNome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Verifica se o Grid tem dados e se é do tipo DataTable (padrão do Newtonsoft.Json)
                if (DgvPedidos.DataSource is DataTable tabela)
                {
                    string texto = TxtBuscarPorNome.Text.Trim(); // Remove espaços vazios

                    // Se estiver vazio, limpa o filtro (mostra tudo)
                    if (string.IsNullOrEmpty(texto))
                    {
                        tabela.DefaultView.RowFilter = "";
                    }
                    else
                    {
                        // FILTRO MÁGICO: Busca no Cliente OU no Pet OU nos Serviços
                        // O "LIKE" significa "contém esse texto"
                        tabela.DefaultView.RowFilter = $"cliente LIKE '%{texto}%' OR pet LIKE '%{texto}%' OR descricao LIKE '%{texto}%'";
                    }
                }
            }
            catch (Exception ex)
            {
                // Só para garantir que não feche o app se digitar algo estranho
            }
        }
    }
}