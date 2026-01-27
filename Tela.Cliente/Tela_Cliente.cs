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
            tabControl1.ItemSize = new Size(0, 2);
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
        private async Task CarregarComboPetsNoAgendamento()
        {
            try
            {
                ApiService api = new ApiService();
                // Busca os pets do usuário logado
                var listaPets = await api.GetMeusPets(_usuarioIdLogado);

                // Configura o ComboBox da tela de Agendar
                // (Confira se o nome do seu combobox é CmbPetAgendar ou similar)
                CmbPetAgendar.DataSource = listaPets;
                CmbPetAgendar.DisplayMember = "Nome"; // O que o cliente vê
                CmbPetAgendar.ValueMember = "Id";     // O que o sistema usa (ID do pet)

                CmbPetAgendar.SelectedIndex = -1; // Começa sem nada selecionado (opcional)
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar pets no agendamento: " + ex.Message);
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
                // Formata a coluna para mostrar dia/mês/ano (dd/MM/yyyy)
                // 1. Ajuste da DATA (Nascimento) 📅
                if (DgvMeusPets.Columns["DataNascimento"] != null)
                {
                    DgvMeusPets.Columns["DataNascimento"].HeaderText = "Nascimento"; // Garante o título certo
                    DgvMeusPets.Columns["DataNascimento"].DefaultCellStyle.Format = "dd/MM/yyyy";

                    // O TRUQUE: Faz a coluna ficar exatamente do tamanho da data (nem mais, nem menos)
                    DgvMeusPets.Columns["DataNascimento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }

                // 2. Ajuste do PESO ⚖️
                if (DgvMeusPets.Columns["Peso"] != null)
                {
                    DgvMeusPets.Columns["Peso"].DefaultCellStyle.Format = "0.00 'kg'";

                    // Faz a coluna crescer para o "kg" não cair para a linha de baixo
                    DgvMeusPets.Columns["Peso"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                // 3. ESPÉCIE, RAÇA e COR (Para não cortar nada!)
                string[] colunasAjustaveis = { "Especie", "Raca", "Cor" }; // Lista das colunas
                foreach (var col in colunasAjustaveis)
                {
                    if (DgvMeusPets.Columns[col] != null)
                        DgvMeusPets.Columns[col].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }

                if (DgvMeusPets.Columns["Nome"] != null)
                {
                    DgvMeusPets.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    DgvMeusPets.Columns["Nome"].MinimumWidth = 100; // <--- O SEGREDO: Impede que o nome suma
                }
                // Adicione isso para Espécie e Raça não cortarem:
                if (DgvMeusPets.Columns["Especie"] != null)
                    DgvMeusPets.Columns["Especie"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                if (DgvMeusPets.Columns["Raca"] != null)
                    DgvMeusPets.Columns["Raca"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                // DICA: Deixe APENAS a coluna "Nome" com o modo Fill para ocupar o resto do espaço
                if (DgvMeusPets.Columns["Nome"] != null)
                    DgvMeusPets.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                // 3. Ajuste das Ações (Lápis e Lixeira)
                if (DgvMeusPets.Columns["btnEditar"] != null)
                    DgvMeusPets.Columns["btnEditar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                if (DgvMeusPets.Columns["btnExcluir"] != null)
                    DgvMeusPets.Columns["btnExcluir"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                // --- ADICIONA OS BOTÕES (SÓ SE AINDA NÃO EXISTIREM) ---
                if (DgvMeusPets.Columns["btnEditar"] == null)
                {
                    // 1. Coluna EDITAR (Imagem)
                    DataGridViewImageColumn imgEdit = new DataGridViewImageColumn();
                    imgEdit.Name = "btnEditar"; // Mantivemos o nome para o clique funcionar
                    imgEdit.HeaderText = "Ações"; // Um Cabalho legal pode colocar um ícone aqui
                    // Pega a imagem dos recursos que você acabou de adicionar
                    imgEdit.Image = Properties.Resources.icone_editar;
                    imgEdit.Width = 50;

                    imgEdit.DefaultCellStyle.BackColor = Color.White;
                    imgEdit.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke; // Não fica azulão quando seleciona
                    // Centraliza a imagem na célula
                    imgEdit.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    // Tira a borda feia de botão quando clica
                    imgEdit.ImageLayout = DataGridViewImageCellLayout.Zoom; // Garante que o ícone não distorça

                    DgvMeusPets.Columns.Add(imgEdit);

                    // 2. Coluna EXCLUIR (Imagem)
                    DataGridViewImageColumn imgDel = new DataGridViewImageColumn();
                    imgDel.Name = "btnExcluir"; // Mantivemos o nome
                    imgDel.HeaderText = "";
                    // Pega a imagem dos recursos
                    imgDel.Image = Properties.Resources.icone_excluir;
                    imgDel.Width = 50;
                    imgDel.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    imgDel.CellTemplate.Style.BackColor = Color.White;
                    imgDel.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
                    imgDel.ImageLayout = DataGridViewImageCellLayout.Zoom;

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


        private async void FrmCliente_Load(object sender, EventArgs e)
        {

            await CarregarComboPetsNoAgendamento();
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
            DgvCarrinho.RowTemplate.Height = 45; // <--- AUMENTA A ALTURA DA LINHA (Era padrão ~22)
            DgvCarrinho.AllowUserToAddRows = false;

            // Cria as colunas manualmente para elas aparecerem antes de adicionar itens
            if (DgvCarrinho.Columns.Count == 0)
            {
                DgvCarrinho.Columns.Add("Nome", "Serviço");
                DgvCarrinho.Columns.Add("Preco", "Preço");
            }

            // Configuração da Coluna Lixeira
            if (DgvCarrinho.Columns["btnRemover"] == null)
            {
                DataGridViewImageColumn imgLixeira = new DataGridViewImageColumn();
                imgLixeira.Name = "btnRemover";
                imgLixeira.HeaderText = "";
                imgLixeira.Image = Properties.Resources.icone_excluir;

                imgLixeira.Width = 60; // <--- AUMENTA A LARGURA (Era 40)

                imgLixeira.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                imgLixeira.CellTemplate.Style.BackColor = Color.White;
                imgLixeira.ImageLayout = DataGridViewImageCellLayout.Zoom; // O Zoom vai aproveitar a altura nova de 45px!

                DgvCarrinho.Columns.Add(imgLixeira);
            }



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
            // 1. VALIDAÇÕES INICIAIS (Mantém igual)
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

            if (DtpData.Value < DateTime.Now)
            {
                MessageBox.Show("Por favor, selecione uma data válida para o agendamento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            // Travamos o botão para evitar cliques duplos
            BtnFinalizar.Enabled = false;
            BtnFinalizar.Text = "Processando...";

            try
            {
                // 2. CALCULAR O TOTAL (Precisamos dele AGORA para mandar pra tela de pagamento)
                decimal valortotal = carrinho.Sum(x => x.Preco);
                int idPetSelecionado = Convert.ToInt32(CmbPetAgendar.SelectedValue);

                // =================================================================
                // AQUI ENTRA A MÁGICA DA TELA DE PAGAMENTO 💳
                // =================================================================

                // Cria a tela passando o valor total
                TelaPagamento telaPag = new TelaPagamento(valortotal);

                // Exibe a tela e PAUSA o código aqui até o usuário fechar a janelinha
                var resultado = telaPag.ShowDialog();

                // Se o usuário fechou ou clicou em Cancelar, abortamos o salvamento
                if (resultado != DialogResult.OK)
                {
                    // Reabilita o botão e sai
                    BtnFinalizar.Enabled = true;
                    BtnFinalizar.Text = "Finalizar Agendamento";
                    return;
                }

                // Se chegou aqui, ele escolheu uma forma de pagamento!
                string formaPagamentoEscolhida = telaPag.MetodoEscolhido;

                // =================================================================
                // CONTINUA O PROCESSO DE SALVAR (Agora com o pagamento)
                // =================================================================

                var listaItens = carrinho.Select(item => new
                {
                    ServicoId = item.Id,
                    PrecoUnitario = item.Preco
                }).ToList();

               
                
                
                
                // Montamos o DTO para enviar a API
                var pedidoDto = new
                {
                    ClienteId = _usuarioIdLogado,
                    PetId = idPetSelecionado,
                    DataPedido = DateTime.Now,
                    DataAgendamento = DtpData.Value,
                    ValorTotal = valortotal,
                    Observacoes = TxtObservacoes.Text,
                    Itens = listaItens,
                    

                    // ---> CAMPO NOVO AQUI <---
                    FormaPagamento = formaPagamentoEscolhida
                };

                // Chama a API 
                ApiService api = new ApiService();
                bool sucesso = await api.SalvarPedido(pedidoDto);

                if (sucesso)
                {
                    // Mostra a mensagem confirmando também o pagamento
                    MessageBox.Show($"Agendamento realizado com sucesso!\nPagamento: {formaPagamentoEscolhida}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpa tudo
                    carrinho.Clear();
                    TxtObservacoes.Clear();
                    DgvCarrinho.Rows.Clear();
                    AtualizarTotal();
                    CmbPetAgendar.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Falha ao realizar o agendamento no sistema. O pagamento não foi processado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro técnico: " + ex.Message);
            }
            finally
            {
                // Garante que o botão volta ao normal sempre
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
            BtnSalvar.Text = "Cadastrat Pet";
            BtnSalvar.BackColor = Color.SeaGreen; // Volta para a cor original (verde)
            BtnCancelar.Visible = false;
            LblStatusEdicao.Text = ""; // Limpa o status de edição
        }


        private async void BtnSalvar_Click(object sender, EventArgs e)
        {

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
                DtpNascimentoPet.Value = petSelecionado.dataNascimento;
                // txtPeso.Text = petSelecionado.Peso.ToString(); // Se for TextBox
                NumericUpPESO.Value = petSelecionado.Peso;           // Se for NumericUpDown

                // 2. Guarda o ID para sabermos qual atualizar
                _idPetEmEdicao = petSelecionado.Id;

                // 3. Muda o texto do botão para o usuário saber
                BtnSalvar.Text = "Atualizar Pet";
                BtnSalvar.BackColor = Color.Orange; // Destaque visual

            }
            if (DgvMeusPets.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                // ... (seu código que preenche os TextBoxes continua igual) ...
                _idPetEmEdicao = petSelecionado.Id;

                // --- AS NOVIDADES VISUAIS AQUI ---

                // 1. Muda a cor e texto do botão principal
                BtnSalvar.Text = "Salvar Alterações";
                BtnSalvar.BackColor = Color.DarkOrange; // Cor de destaque!

                // 2. Mostra o Label de aviso
                LblStatusEdicao.Text = $"✏️ Editando: {petSelecionado.Nome}";

                // 3. Mostra o botão cancelar
                BtnCancelar.Visible = true;
            }

        }

        private async void BtnSalvar_Click_1(object sender, EventArgs e)
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
                dataNascimento = DtpNascimentoPet.Value,
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
                await CarregarComboPetsNoAgendamento();
            }
            else
            {
                MessageBox.Show("Erro ao processar. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BtnSalvar.Enabled = true;
            BtnSalvar.Text = "Salvar"; // Volta o texto ao normal
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            limparCamposPet();
        }

        private void DgvMeusPets_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Se for a coluna do lápis
            if (DgvMeusPets.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                // Adiciona a dica
                DgvMeusPets.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = "Clique para Editar este Pet";
            }
            // Se for a coluna da lixeira
            if (DgvMeusPets.Columns[e.ColumnIndex].Name == "btnExcluir")
            {
                DgvMeusPets.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = "Excluir Pet permanentemente";
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saindo...");
            this.Hide();
        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            string termo = TxtBuscarPorNome.Text;

            // 1. Muda o cursor
            Cursor = Cursors.WaitCursor;

            try
            {
                ApiService api = new ApiService();

                // 2. Tenta buscar
                var listaFiltrada = await api.PesquisarServicos(termo);

                // 3. Atualiza a tela
                DgvServicos.DataSource = listaFiltrada;

                // 4. Avisa se não achou nada
                if (listaFiltrada == null || listaFiltrada.Count == 0)
                {
                    MessageBox.Show("Nenhum serviço encontrado com esse nome.");
                    CarregarServicosReais(); // Recarrega a lista completa
                }
            }
            catch (Exception ex)
            {
                // Se der erro, mostra qual foi!
                MessageBox.Show("Erro na pesquisa: " + ex.Message);
            }
            finally
            {
                // 5. OBRIGA o cursor a voltar ao normal (aconteça o que acontecer)
                Cursor = Cursors.Default;
            }
        }

        private void TxtBuscarPorNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnBuscar.PerformClick(); // Clica no botão via código

                // Evita aquele barulhinho de "plim" do Windows
                e.SuppressKeyPress = true;
            }
        }

        private async void BtnMeusPedidos_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2; // Vai para a terceira aba
            await CarregarAcompanhar();
        }

        private async Task CarregarAcompanhar()
        {
            try
            {
                // Limpa visualmente antes de buscar
                DgvAcompanhar.DataSource = null;

                ApiService api = new ApiService();
                // Busca os pedidos do usuário logado
                var dados = await api.GetMeusPedidosCliente(_usuarioIdLogado);

                if (dados != null)
                {
                    DgvAcompanhar.DataSource = dados;
                    ConfigurarGridAcompanhamento(); // Chama a formatação visual
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar seus pedidos: " + ex.Message);
            }
        }
        private void ConfigurarGridAcompanhamento()
        {
            // 1. Configurações Gerais do Grid
            DgvAcompanhar.EnableHeadersVisualStyles = false;
            DgvAcompanhar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvAcompanhar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvAcompanhar.ReadOnly = true;
            DgvAcompanhar.AllowUserToAddRows = false;
            DgvAcompanhar.RowHeadersVisible = false;
            DgvAcompanhar.RowTemplate.Height = 40; // Altura boa para visualização
            DgvAcompanhar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing; // Trava a altura
            DgvAcompanhar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centraliza o texto verticalmente também

            if (DgvAcompanhar.Columns.Contains("status"))
            {
                DgvAcompanhar.Columns["Status"].HeaderText = "Situação Atual"; // Texto mais amigável
                DgvAcompanhar.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            // 4. Formatação das Colunas (R$, Data, Títulos)
            if (DgvAcompanhar.Columns.Contains("Total"))
            {
                DgvAcompanhar.Columns["Total"].DefaultCellStyle.Format = "C2"; // R$
                DgvAcompanhar.Columns["Total"].HeaderText = "Valor Total";
                DgvAcompanhar.Columns["Total"].Width = 100;
                DgvAcompanhar.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (DgvAcompanhar.Columns.Contains("Data"))
            {
                DgvAcompanhar.Columns["Data"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                DgvAcompanhar.Columns["Data"].HeaderText = "Data do Agendamento";
                DgvAcompanhar.Columns["Data"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (DgvAcompanhar.Columns.Contains("Pet"))
            {
                DgvAcompanhar.Columns["Pet"].HeaderText = "Pet";
                DgvAcompanhar.Columns["Pet"].Width = 80;
            }

            if (DgvAcompanhar.Columns.Contains("Servicos"))
            {
                DgvAcompanhar.Columns["Servicos"].HeaderText = "Serviços Solicitados";
                // Quebra de linha automática para caber todos os serviços
                DgvAcompanhar.Columns["Servicos"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                DgvAcompanhar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }

            // Esconde ID se aparecer
            if (DgvAcompanhar.Columns.Contains("Id")) DgvAcompanhar.Columns["Id"].Visible = false;

            // Remove e adiciona para garantir que está ligado
            DgvAcompanhar.CellFormatting -= DgvAcompanhar_CellFormatting;
            DgvAcompanhar.CellFormatting += DgvAcompanhar_CellFormatting;


        }

        private void DgvAcompanhar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica se a coluna é "Status"
            if (DgvAcompanhar.Columns[e.ColumnIndex].Name == "status" && e.Value != null)
            {
                string statusBruto = e.Value.ToString().ToLower();

                // 1. Limpa o texto (Tira o _ e deixa a primeira letra maiúscula)
                // Dica: Você pode forçar o texto exato que quer que apareça
                if (statusBruto == "em_andamento") e.Value = "Em Andamento";
                else if (statusBruto == "concluido") e.Value = "Concluído";
                else if (statusBruto == "pendente") e.Value = "Pendente";
                else if (statusBruto == "cancelado") e.Value = "Cancelado";

                // 2. As cores (Mantenha ou ajuste)
                e.CellStyle.Font = new Font(DgvAcompanhar.Font, FontStyle.Bold);

                if (statusBruto == "concluido") e.CellStyle.ForeColor = Color.Green;
                else if (statusBruto == "cancelado") e.CellStyle.ForeColor = Color.Red;
                else if (statusBruto == "em_andamento") e.CellStyle.ForeColor = Color.Blue;
                else e.CellStyle.ForeColor = Color.DarkOrange;
            }
        }
    }

}
