using Mysql.PetShop.Models;
using Mysql.PetShop.Models;
using Newtonsoft.Json;
using Newtonsoft.Json;
using Shop.TelaFuncionarios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop.TelaFuncionarios
{
    public class ApiService
    {
        
        private readonly string _baseUrl = "https://trabalhopetshop-production.up.railway.app";


        
        public async Task<List<Servico>> GetServicos()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    // Chama a sua API
                    var response = await client.GetAsync($"{_baseUrl}/api/servicos");

                    if (response.IsSuccessStatusCode)
                    {
                        var responseString = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<List<Servico>>(responseString);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro ao buscar serviços: " + ex.Message);
                    return new List<Servico>();
                }
                return new List<Servico>();
            }
        }
        
        public async Task<LoginResponse> FazerLogin(string email, string senha)
        {
            using (var client = new HttpClient())
            {
                // 1. Monta o objeto de dados
                var dadosLogin = new
                {
                    Email = email,
                    Senha = senha
                };

                // 2. Transforma em JSON
                var json = JsonConvert.SerializeObject(dadosLogin);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    // 3. Envia para a API (POST)
                    var response = await client.PostAsync($"{_baseUrl}/api/auth/login", content);

                    if (response.IsSuccessStatusCode)
                    {
                        // 4. Se deu certo, lê a resposta
                        var responseString = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<LoginResponse>(responseString);
                    }
                }
                catch (Exception ex)
                {
                    // Se a API estiver desligada, cai aqui
                    throw new Exception("Erro ao conectar na API: " + ex.Message);
                }

                return null; // Login falhou
            }

        }
        // Busca a lista de clientes
        public async Task<List<Usuario>> GetListaClientes()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"{_baseUrl}/api/Auth/clientes");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    // Deserializa usando sua classe Usuario
                    return JsonConvert.DeserializeObject<List<Usuario>>(json);
                }
                return new List<Usuario>();
            }
        }


        // Busca TODOS os agendamentos (reutiliza a lógica do funcionário)
        public async Task<DataTable> GetTodosAgendamentos()
        {
            // Chama a mesma rota que usamos na tela do funcionário
            // Pode passar "todos" ou vazio para trazer o histórico completo
            return await GetPedidosPorStatus("todos");
        }

        public async Task<bool> SalvarPedido(object pedidoCompleto)
        {
            var handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;

            using (var client = new HttpClient(handler))
            {
                var json = JsonConvert.SerializeObject(pedidoCompleto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    var response = await client.PostAsync($"{_baseUrl}/api/pedidos", content);

                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    else
                    {
                        // AQUI ESTÁ A MÁGICA: Lê o erro que a API devolveu
                        string erroDetalhado = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Erro da API: {erroDetalhado}", "Detalhe do Erro");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro de Conexão: {ex.Message}");
                    return false;
                }
            }
        }
        public async Task<List<FuncionarioDTO>> GetFuncionarios()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    // Chama o endpoint que criamos acima
                    var response = await client.GetAsync($"{_baseUrl}/api/auth/funcionarios");

                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        // Transforma o JSON em uma lista de objetos
                        return JsonConvert.DeserializeObject<List<FuncionarioDTO>>(json);
                    }
                }
                catch (Exception ex)
                {
                    // Logar erro ou relançar se necessário
                }

                // Retorna uma lista vazia se der erro, para não quebrar o DataGrid
                return new List<FuncionarioDTO>();
            }
        }

        public async Task<ViaCepResult> BuscarEnderecoPorCep(string cep)
        {
            // 1. Limpa o CEP (deixa só números)
            string cepLimpo = cep.Replace("-", "").Replace(".", "").Trim();

            if (cepLimpo.Length != 8) return null; // CEP inválido

            using (var client = new HttpClient())
            {
                try
                {
                    // 2. Chama a API pública
                    string url = $"https://viacep.com.br/ws/{cepLimpo}/json/";
                    var response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var dados = JsonConvert.DeserializeObject<ViaCepResult>(json);

                        if (dados.Erro) return null; // CEP não existe

                        return dados;
                    }
                }
                catch
                {
                    // Sem internet ou erro na API
                    return null;
                }
            }
            return null;
        }
        public async Task<bool> CadastrarUsuario(
            string nome, string email, string senha, string telefone,
            string cep, string rua, string numero, string bairro, string cidade, string uf, string complemento, string cpf, DateTime datanascimento, string tipouser, string observacao)
        {
            using (var client = new HttpClient())
            {
                // Limpa o CPF antes de enviar
                string cpfLimpo = cpf.Replace(".", "").Replace("-", "").Replace(",", "").Trim();
                string tipoUsuarioAjustado;

                if (tipouser == null)
                {
                    tipoUsuarioAjustado = "cliente"; // Valor padrão se nulo
                    observacao = "Cliente Cadastrado no app";
                }
                else if(tipouser == "cliente")
                {
                    tipoUsuarioAjustado = "cliente"; // Valor padrão se nulo
                    observacao = "Cliente Cadastrado no app";
                }
                else if (tipouser == "funcionario")
                {
                    tipoUsuarioAjustado = "funcionario";
                }
                else 
                {
                    tipoUsuarioAjustado = "adm";

                }

                if (cpf == null)
                {
                    cpfLimpo = "Cliente não quis colocar o cpf";

                }


                var dados = new
                {
                    Nome = nome,
                    Email = email,
                    Senha = senha,
                    Telefone = telefone,
                    Cpf = cpfLimpo,

                    
                    DataNascimento = datanascimento.ToString("yyyy-MM-dd"),

                    TipoUsuario = tipoUsuarioAjustado,
                    Observacao = observacao, 

                    // Endereço
                    Cep = cep,
                    Logradouro = rua,
                    Numero = numero,
                    Bairro = bairro,
                    Cidade = cidade,
                    Uf = uf,
                    Complemento = complemento
                };

                var json = JsonConvert.SerializeObject(dados);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    var response = await client.PostAsync($"{_baseUrl}/api/auth/cadastro", content);

                    // SE DER ERRO, VAMOS LER O MOTIVO REAL:
                    if (!response.IsSuccessStatusCode)
                    {
                        string erroRetorno = await response.Content.ReadAsStringAsync();
                       
                        // (Isso ajuda a ver se é 'Email duplicado' ou 'Data inválida')
                    }

                    return response.IsSuccessStatusCode;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        public async Task<List<Servico>> PesquisarServicos(string termo)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    // Chama a rota nova passando o termo na URL
                    var response = await client.GetAsync($"{_baseUrl}/api/servicos/buscar?termo={termo}");

                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<List<Servico>>(json);
                    }
                }
                catch { } // Se der erro, retorna lista vazia

                return new List<Servico>();
            }
        }
        public async Task<List<PetDTO>> GetMeusPets(int clienteId)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync($"{_baseUrl}/api/pets/meus-pets/{clienteId}");
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<List<PetDTO>>(json);
                    }
                }
                catch { }
                return new List<PetDTO>();
            }
        }
        public async Task<DataTable> GetMeusPedidosCliente(int idCliente)
        {
            using (var client = new HttpClient())
            {
                // ... (seu código padrão de HttpClient aqui) ...
                var response = await client.GetAsync($"{_baseUrl}/api/pedidos/cliente/{idCliente}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<DataTable>(json);
                }
                return null;
            }
        }


        public async Task<bool> CadastrarPet(PetDTO pet)
        {
            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(pet);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    var response = await client.PostAsync($"{_baseUrl}/api/pets", content);
                    return response.IsSuccessStatusCode;
                }
                catch
                {
                    return false;
                }
            }
        }
        public async Task<DataTable> GetPedidosPorStatus(string status)
        {
            using (var client = new HttpClient())
            {
                // Ignora certificado SSL (padrão desenvolvimento)
                var handler = new HttpClientHandler();
                handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;

                using (var clientHttp = new HttpClient(handler))
                {
                    try
                    {
                        // Monta a URL: ex: .../api/pedidos?status=pendente
                        string url = $"{_baseUrl}/api/pedidos?status={status}";

                        var response = await clientHttp.GetAsync(url);
                        if (response.IsSuccessStatusCode)
                        {
                            var json = await response.Content.ReadAsStringAsync();
                            return JsonConvert.DeserializeObject<DataTable>(json);
                        }
                    }
                    catch { }
                    return null;
                }
            }
        }
        // Adicione dentro da classe ApiService
        // Adicione o parâmetro 'idFuncionario' (pode ser nulo caso não tenha funcionário)
        public async Task<bool> AtualizarStatus(int idPedido, string novoStatus, int? idFuncionario = null)
        {
            // Ignora SSL local (Mantenha se estiver usando https localmente)
            var handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;

            using (var client = new HttpClient(handler))
            {
                try
                {
                    // 1. A MUDANÇA PRINCIPAL ESTÁ AQUI
                    // Em vez de mandar só o texto, montamos um objeto com os dois dados
                    var dadosParaEnvio = new
                    {
                        status = novoStatus,
                        funcionarioId = idFuncionario // Envia o ID ou null se não tiver
                    };

                    // 2. Transforma o objeto em JSON (Ex: {"status":"concluido", "funcionarioId":5})
                    var json = JsonConvert.SerializeObject(dadosParaEnvio);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    // Chama a rota PUT
                    var url = $"{_baseUrl}/api/pedidos/{idPedido}/status";
                    var response = await client.PutAsync(url, content);

                    return response.IsSuccessStatusCode;
                }
                catch (Exception ex)
                {
                    // Dica: Adicione um log ou breakpoint aqui para ver o erro se falhar
                    return false;
                }
            }
        }
        public async Task<bool> EditarPet(PetDTO pet)
        {
            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(pet);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                try
                {
                    var response = await client.PutAsync($"{_baseUrl}/api/pets/{pet.Id}", content);
                    return response.IsSuccessStatusCode;
                }
                catch { return false; }
            }
        }

        public async Task<DashboardDTO> GetDadosDashboard()
        {
            using (var client = new HttpClient())
            {
                // ... suas configurações de base address ...
                var response = await client.GetAsync($"{_baseUrl}/api/pedidos/dashboard-resumo");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<DashboardDTO>(json);
                }
                // Se der erro, retorna zerado para não travar o sistema
                return new DashboardDTO { VendasHoje = 0, Pendentes = 0, NovosClientes = 0 };
            }
        }

        // Excluir
        public async Task<bool> ExcluirPet(int id)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.DeleteAsync($"{_baseUrl}/api/pets/{id}");
                    return response.IsSuccessStatusCode;
                }
                catch { return false; }
            }
        }
        public async Task<RelatorioDTO> GetRelatorioDashboard()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync($"{_baseUrl}/api/pedidos/relatorio-completo");
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<RelatorioDTO>(json);
                    }
                }
                catch { }
                return null;
            }
        }
        // Método para buscar os 10 últimos pedidos
        public async Task<List<UltimoPedidoDTO>> GetUltimosPedidos()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    // Chama a rota que criamos no Controller
                    var response = await client.GetAsync($"{_baseUrl}/api/pedidos/ultimos-pedidos");

                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        // Transforma o JSON na lista pronta para o Grid
                        return JsonConvert.DeserializeObject<List<UltimoPedidoDTO>>(json);
                    }
                }
                catch (Exception ex)
                {
                    // Se der erro, retorna lista vazia para não travar o sistema
                    System.Diagnostics.Debug.WriteLine("Erro ao buscar últimos pedidos: " + ex.Message);
                }

                return new List<UltimoPedidoDTO>();
            }
        }


        //------------------------------------------------------------------- Classes para puxar os dados do banco ------------------------------------------------------------------------------------------------
    }

    public class UltimoPedidoDTO
    {
        public string Hora { get; set; }
        public string Cliente { get; set; }
        public string Servico { get; set; } // No controller mapeamos o Status ou Serviço aqui
        public decimal Valor { get; set; }
    }
    public class RelatorioDTO
    {
        // Totais Financeiros
        public decimal FaturamentoHoje { get; set; }
        public decimal Faturamento7Dias { get; set; }
        public decimal FaturamentoMes { get; set; }

        // Contagem de Pedidos
        public int PedidosHoje { get; set; }
        public int Pedidos7Dias { get; set; }
        public int PedidosMes { get; set; }

        // Lista dos Top Serviços (Para fazer a análise)
        public List<TopServicoDTO> TopServicos { get; set; } = new List<TopServicoDTO>();

        // Lista Completa para a segunda aba
        public List<PedidoRelatorioDTO> ListaCompleta { get; set; } = new List<PedidoRelatorioDTO>();
    }

    public class TopServicoDTO
    {
        public string NomeServico { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorTotal { get; set; }
    }

    public class PedidoRelatorioDTO
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string Data { get; set; }
        public decimal Valor { get; set; }
        public string Status { get; set; }
        public string Itens { get; set; }
    }

    public class PetDTO
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Especie { get; set; }
        public string Raca { get; set; }
        public string Cor { get; set; }
        public DateTime dataNascimento { get; set; }
        public decimal Peso { get; set; }
    }
    public class DashboardDTO
    {
        public decimal VendasHoje { get; set; }
        public decimal VendasMes { get; set; } // <--- Nova
        public int Pendentes { get; set; }
        public int NovosClientes { get; set; }
    }

    public class Servico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int TempoEstimado { get; set; }
    }
    public class FuncionarioDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        // O banco manda "cpf", aqui mapeamos para a propriedade 
        public string CPF { get; set; }

        // O banco manda "data_nascimento", mapeamos para DataNascimento (DateTime)
        [JsonProperty("data_nascimento")]
        public DateTime? DataNascimento { get; set; }

        public string Telefone { get; set; }

        [JsonProperty("tipo_usuario")]
        public string TipoUsuario { get; set; }

        [JsonProperty("data_cadastro")]
        public DateTime? DataCadastro { get; set; }

        // Removi a propriedade Observacao como você pediu
    }
    // Classe para receber a resposta da API organizada
    public class LoginResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string TipoUsuario { get; set; } // O mais importante!
        public string Mensagem { get; set; }
    }



    public class ViaCepResult
    {
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; } // O ViaCEP chama Cidade de "Localidade"
        public string Uf { get; set; }
        public bool Erro { get; set; } // O ViaCEP devolve isso se não achar
    }
}







