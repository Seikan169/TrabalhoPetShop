using Mysql.PetShop.Models;
using Shop.TelaFuncionarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Mysql.PetShop.Models;







namespace Tela.Cliente
{
    public partial class Tela_Cliente : Form
    {
        List<Shop.TelaFuncionarios.Servico> carrinho = new List<Shop.TelaFuncionarios.Servico>();
        public Tela_Cliente(string usuario, int id)
        {
            InitializeComponent();
            this.Load += FrmCliente_Load;

            LblBemvindo.Text = $"Olá, {usuario}! Vamos agendar um cuidado para seu pet hoje?";
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

        }

        private void BtnAgendar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0; // Vai para a primeira aba
        }

        private void BtnMeusPets_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1; // Vai para a segunda aba
        }
        public class PetComboItem
        {
            public int Id { get; set; }
            public string Nome { get; set; }

            // O ComboBox exibe o que o método ToString retorna
            public override string ToString()
            {
                return Nome;
            }
        }

        // 2. Método para buscar os pets do cliente na API
        private async Task CarregarPetsDoCliente()
        {
            try
            {
                // ApiService api = new ApiService();
                // Você precisará criar esse método 'GetMeusPets' na ApiService depois
                // Ou usar um endpoint que filtre por cliente
                // Por enquanto, vamos simular que a API devolveu:

                List<PetComboItem> meusPets = new List<PetComboItem>();

                // --- AQUI VOCÊ VAI CHAMAR SUA API NO FUTURO ---
                // var petsApi = await api.GetPets(_usuarioIdLogado);

                // Simulação pra você ver o design funcionando agora:
                meusPets.Add(new PetComboItem { Id = 1, Nome = "Rex (Teste)" });
                meusPets.Add(new PetComboItem { Id = 2, Nome = "Lulu (Teste)" });

                CmbPetAgendar.DataSource = meusPets;
                CmbPetAgendar.DisplayMember = "Nome";
                CmbPetAgendar.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar pets: " + ex.Message);
            }
        }
        private async Task CarregarServicosReais()
        {
            try
            {
                // --- CORREÇÃO DO ERRO AQUI ---
                // Muda o modo de seleção para selecionar a LINHA inteira, 
                // o que resolve o conflito com a ordenação das colunas.
                DgvServicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DgvServicos.MultiSelect = false; // (Opcional) Impede selecionar vários de uma vez
                                                 // -----------------------------

                ApiService api = new ApiService();
                var listaDoBanco = await api.GetServicos();

                // 1. Vincula os dados
                DgvServicos.DataSource = listaDoBanco;

                DgvServicos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(65, 105, 225);
                DgvServicos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                DgvServicos.EnableHeadersVisualStyles = false;

                DgvServicos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                DgvServicos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                DgvServicos.RowTemplate.Height = 35;

                // Configurações das Colunas
                if (DgvServicos.Columns["Id"] != null)
                    DgvServicos.Columns["Id"].Visible = false;

                if (DgvServicos.Columns["Nome"] != null)
                {
                    DgvServicos.Columns["Nome"].HeaderText = "Serviço";
                    DgvServicos.Columns["Nome"].FillWeight = 25;
                }

                if (DgvServicos.Columns["Descricao"] != null)
                {
                    DgvServicos.Columns["Descricao"].HeaderText = "Descrição";
                    DgvServicos.Columns["Descricao"].FillWeight = 50;
                }

                if (DgvServicos.Columns["Preco"] != null)
                {
                    DgvServicos.Columns["Preco"].HeaderText = "Valor";
                    DgvServicos.Columns["Preco"].DefaultCellStyle.Format = "C2";
                    DgvServicos.Columns["Preco"].FillWeight = 15;
                }

                if (DgvServicos.Columns["TempoEstimado"] != null)
                {
                    DgvServicos.Columns["TempoEstimado"].HeaderText = "Minutos";
                    DgvServicos.Columns["TempoEstimado"].FillWeight = 18;
                    DgvServicos.Columns["TempoEstimado"].MinimumWidth = 70;
                    DgvServicos.Columns["TempoEstimado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                DgvServicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        // 3. Chame isso no Load
        private async void FrmCliente_Load(object sender, EventArgs e)
        {
            await CarregarServicosReais(); // Já tínhamos esse
            await CarregarPetsDoCliente(); // Novo
            BtnFinalizar.BackColor = Color.FromArgb(0, 184, 148); // Verde água
            BtnFinalizar.Font = new Font("Bold ", 12, FontStyle.Bold);


            DgvCarrinho.BackgroundColor = Color.WhiteSmoke; // Ou a mesma cor do fundo
            DgvCarrinho.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(65, 105, 225); // Azul
            DgvCarrinho.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DgvCarrinho.EnableHeadersVisualStyles = false;
            DgvCarrinho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Cria as colunas manualmente para elas aparecerem antes de adicionar itens
            if (DgvCarrinho.Columns.Count == 0)
            {
                DgvCarrinho.Columns.Add("Nome", "Serviço");
                DgvCarrinho.Columns.Add("Preco", "Preço");
            }

            DataGridViewButtonColumn btnRemover = new DataGridViewButtonColumn();
            btnRemover.Name = "btnRemover";
            btnRemover.HeaderText = "";
            btnRemover.Text = "X";
            btnRemover.UseColumnTextForButtonValue = true;

            // 1. Estilo Básico
            btnRemover.FlatStyle = FlatStyle.Flat;

            // 2. Cores Normais (Sem estar selecionado)
            btnRemover.DefaultCellStyle.ForeColor = Color.Red;
            btnRemover.DefaultCellStyle.BackColor = Color.WhiteSmoke;

            // 3. O PULO DO GATO: Cores QUANDO ESTÁ SELECIONADO (Evita ficar azul)
            btnRemover.DefaultCellStyle.SelectionForeColor = Color.Red;       // Continua Vermelho
            btnRemover.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;// Continua Branco/Cinza

            DgvCarrinho.Columns.Add(btnRemover);

            // Alinhamentos
            DgvCarrinho.Columns["Preco"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DgvCarrinho.Columns["btnRemover"].Width = 40;
            


            // --- Configuração da Tabela de Serviços (Esquerda) ---
            DgvServicos.ReadOnly = true;              // Ninguém edita texto
            DgvServicos.AllowUserToAddRows = false;   // Remove a linha vazia do final
            DgvServicos.AllowUserToDeleteRows = false;// Remove a opção de deletar com 'Delete' do teclado
            DgvServicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleciona a linha toda
            DgvServicos.MultiSelect = false;          // Só pode selecionar um por vez

            // --- Configuração da Tabela do Carrinho (Direita) ---
            DgvCarrinho.ReadOnly = true;              // Bloqueia edição de texto
            DgvCarrinho.AllowUserToAddRows = false;
            DgvCarrinho.AllowUserToDeleteRows = false;// Obriga a usar o botão X
            DgvCarrinho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvCarrinho.MultiSelect = false;
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if (DgvServicos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um serviço primeiro!");
                return;
            }
            // 2. Pega o objeto 'Servico' da linha selecionada
            // (O DataBoundItem é a mágica que recupera o objeto inteiro que veio do banco)
            var servicoSelecionado = (Shop.TelaFuncionarios.Servico)DgvServicos.CurrentRow.DataBoundItem;

            // 3. Adiciona na lista da memória (Carrinho)
            carrinho.Add(servicoSelecionado);

            // 4. Adiciona visualmente no Grid da Direita
            // Como criamos as colunas manualmente, adicionamos a linha manualmente:
            DgvCarrinho.Rows.Add(servicoSelecionado.Nome, servicoSelecionado.Preco.ToString("C2"));
            DgvCarrinho.Columns["Preco"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // 5. Atualiza o Total
            AtualizarTotal();
        }

        // Crie este método auxiliar para somar tudo
        private void AtualizarTotal()
        {
            decimal total = carrinho.Sum(x => x.Preco);
            // Formata como dinheiro (R$ 100,00) e coloca no Label
            LblTotal.Text = $"Total: {total:C2}";
        }

        private void DgvCarrinho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique foi na coluna do botão "btnRemover"
            if (e.RowIndex >= 0 && DgvCarrinho.Columns[e.ColumnIndex].Name == "btnRemover")
            {
                // 1. Remove da Lista da Memória (Carrinho)
                carrinho.RemoveAt(e.RowIndex);

                // 2. Remove Visualmente do Grid
                DgvCarrinho.Rows.RemoveAt(e.RowIndex);

                // 3. Atualiza o Total
                AtualizarTotal();
            }
        }
    }

}
