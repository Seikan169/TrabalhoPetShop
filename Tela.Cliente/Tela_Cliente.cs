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
        private int _usuarioIdLogado;
        public Tela_Cliente(string usuario, int id)
        {
            InitializeComponent();


            this.Load += FrmCliente_Load;

            _usuarioIdLogado = id;

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
        private int _idPetEmEdicao = 0; // 0 significa que é um NOVO cadastro
        private async Task CarregarMeusPets()
        {
            try
            {
                ApiService api = new ApiService();
                var lista = await api.GetMeusPets(_usuarioIdLogado);
                DgvMeusPets.DataSource = lista;

                // Configuração visual básica
                DgvMeusPets.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                // 2. Faz a altura da linha aumentar para caber o texto
                DgvMeusPets.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                DgvMeusPets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DgvMeusPets.RowTemplate.Height = 35; // Altura boa para clicar
                DgvMeusPets.AllowUserToAddRows = false;

                // --- ADICIONA OS BOTÕES (SÓ SE AINDA NÃO EXISTIREM) ---
                if (DgvMeusPets.Columns["btnEditar"] == null)
                {
                    // 1. Coluna EDITAR (Imagem)
                    DataGridViewImageColumn imgEdit = new DataGridViewImageColumn();
                    imgEdit.Name = "btnEditar"; // Mantivemos o nome para o clique funcionar
                    imgEdit.HeaderText = "";
                    // Pega a imagem dos recursos que você acabou de adicionar
                    imgEdit.Image = Properties.Resources.icone_editar;
                    imgEdit.Width = 40;
                    // Centraliza a imagem na célula
                    imgEdit.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    // Tira a borda feia de botão quando clica
                    imgEdit.CellTemplate.Style.BackColor = Color.White; // Ou a cor do seu grid

                    DgvMeusPets.Columns.Add(imgEdit);

                    // 2. Coluna EXCLUIR (Imagem)
                    DataGridViewImageColumn imgDel = new DataGridViewImageColumn();
                    imgDel.Name = "btnExcluir"; // Mantivemos o nome
                    imgDel.HeaderText = "";
                    // Pega a imagem dos recursos
                    imgDel.Image = Properties.Resources.icone_excluir;
                    imgDel.Width = 40;
                    imgDel.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    imgDel.CellTemplate.Style.BackColor = Color.White;

                    DgvMeusPets.Columns.Add(imgDel);
                }

                // Esconde colunas técnicas (ID, ClienteId)
                if (DgvMeusPets.Columns["Id"] != null) DgvMeusPets.Columns["Id"].Visible = false;
                if (DgvMeusPets.Columns["ClienteId"] != null) DgvMeusPets.Columns["ClienteId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar lista: " + ex.Message);
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
            await CarregarMeusPets(); // Novo
            BtnSalvar.BackColor = Color.FromArgb(0, 184, 148); // Verde água
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

        private async void BtnFinalizar_Click(object sender, EventArgs e)
        {
            if (carrinho.Count == 0)
            {
                MessageBox.Show("Seu carrinho está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CmbPetAgendar.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione qual Pet receberá o cuidado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BtnFinalizar.Enabled = false; // Evita cliques múltiplos
            BtnFinalizar.Text = "Processando...";

            try
            {
                decimal valortotal = carrinho.Sum(x => x.Preco);
                List<int> servicosIds = carrinho.Select(x => x.Id).ToList();

                DateTime dataEscolhida = DtpData.Value;

                string Obs = TxtObservacoes.Text;

                //chama a api 

                ApiService api = new ApiService();

                bool sucesso = await api.EnviarPedido(_usuarioIdLogado, dataEscolhida, servicosIds, valortotal, Obs);

                if (sucesso)
                {
                    MessageBox.Show("Agendamento realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    carrinho.Clear();
                    TxtObservacoes.Text = "";
                    DgvCarrinho.Rows.Clear();
                    AtualizarTotal();
                }
                else
                {
                    MessageBox.Show("Falha ao realizar o agendamento. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro técnico: " + ex.Message);
            }
            finally
            {
                BtnFinalizar.Enabled = true;
                BtnFinalizar.Text = "Finalizar Agendamento";
            }
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
        private void limparCamposPet()
        {
            TxtNomePet.Text = "";
            CbmEspecie.SelectedIndex = 0;
            TxtBoxRaca.Text = "";
            TxtBoxCor.Text = "";
            DtpNascimentoPet.Value = DateTime.Now;
            NumericUpPESO.Value = 0;

            _idPetEmEdicao = 0;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.BackColor = Color.SeaGreen; // Volta para a cor original (verde)
        }


        private async void BtnSalvar_Click(object sender, EventArgs e)
        {
            // --- VALIDAÇÕES (Mantenha as suas, estão ótimas) ---
            if (string.IsNullOrWhiteSpace(TxtNomePet.Text))
            {
                MessageBox.Show("O nome do pet é obrigatório!");
                TxtNomePet.Focus();
                return;
            }

            // Validação Espécie (Importante adicionar para não quebrar se estiver vazio)
            if (CbmEspecie.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a espécie do pet.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtBoxRaca.Text))
            {
                MessageBox.Show("Por favor, digite a Raça do pet.");
                TxtBoxRaca.Focus();
                return;
            }

            if (NumericUpPESO.Value <= 0)
            {
                MessageBox.Show("O Peso deve ser maior que zero.");
                NumericUpPESO.Focus();
                return;
            }

            // --- MONTAGEM DO OBJETO ---
            var petDto = new PetDTO
            {
                // 1. AQUI ESTÁ O SEGREDO: Passamos o ID da variável global
                Id = _idPetEmEdicao,

                ClienteId = _usuarioIdLogado,
                Nome = TxtNomePet.Text,
                Especie = CbmEspecie.SelectedItem.ToString(),
                Raca = TxtBoxRaca.Text,
                Cor = TxtBoxCor.Text,
                DataNascimento = DtpNascimentoPet.Value,
                Peso = NumericUpPESO.Value
            };

            // --- PREPARAÇÃO VISUAL ---
            BtnSalvar.Enabled = false;
            BtnSalvar.Text = _idPetEmEdicao == 0 ? "Salvando..." : "Atualizando..."; // Texto dinâmico

            ApiService api = new ApiService();
            bool sucesso;

            // --- 2. A DECISÃO: É NOVO OU É EDIÇÃO? ---
            if (_idPetEmEdicao == 0)
            {
                // Se o ID for 0, é um cadastro NOVO
                sucesso = await api.CadastrarPet(petDto);
            }
            else
            {
                // Se o ID for diferente de 0, é uma EDIÇÃO
                sucesso = await api.EditarPet(petDto);
            }

            // --- RESULTADO ---
            if (sucesso)
            {
                string msg = _idPetEmEdicao == 0 ? "Pet cadastrado!" : "Pet atualizado com sucesso!";
                MessageBox.Show(msg, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limparCamposPet();      // Limpa os campos
                await CarregarMeusPets(); // Atualiza a tabela
            }
            else
            {
                MessageBox.Show("Erro ao processar. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BtnSalvar.Enabled = true;
            BtnSalvar.Text = "Salvar"; // Volta o texto ao normal
        }

        private void Tela_Cliente_Resize(object sender, EventArgs e)
        {

        }
        
        private async void DgvMeusPets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Clicou no cabeçalho

            // Pega o objeto Pet da linha clicada
            var petSelecionado = (PetDTO)DgvMeusPets.Rows[e.RowIndex].DataBoundItem;

            // --- AÇÃO: EXCLUIR 🗑️ ---
            if (DgvMeusPets.Columns[e.ColumnIndex].Name == "btnExcluir")
            {
                var confirmacao = MessageBox.Show($"Tem certeza que deseja remover o {petSelecionado.Nome}?",
                                                  "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacao == DialogResult.Yes)
                {
                    ApiService api = new ApiService();
                    await api.ExcluirPet(petSelecionado.Id);
                    await CarregarMeusPets(); // Atualiza a lista
                }
            }

            // --- AÇÃO: EDITAR ✏️ ---
            if (DgvMeusPets.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                // 1. Joga os dados da tabela para os campos da direita
                TxtNomePet.Text = petSelecionado.Nome;
                CbmEspecie.Text = petSelecionado.Especie;
                TxtBoxRaca.Text = petSelecionado.Raca;
                TxtBoxCor.Text = petSelecionado.Cor;
                DtpNascimentoPet.Value = petSelecionado.DataNascimento;
                // txtPeso.Text = petSelecionado.Peso.ToString(); // Se for TextBox
                NumericUpPESO.Value = petSelecionado.Peso;           // Se for NumericUpDown

                // 2. Guarda o ID para sabermos qual atualizar
                _idPetEmEdicao = petSelecionado.Id;

                // 3. Muda o texto do botão para o usuário saber
                BtnSalvar.Text = "Atualizar Pet";
                BtnSalvar.BackColor = Color.Orange; // Destaque visual
            }

        }

        private void BtnSalvar_Click_1(object sender, EventArgs e)
        {

        }
    }

}
