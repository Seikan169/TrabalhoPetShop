using Mysql.PetShop.Models;
using Newtonsoft.Json;
using Shop.TelaFuncionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mysql.PetShop.Models;

namespace Shop.TelaFuncionarios
{
    public class ApiService
    {
        
        private readonly string _baseUrl = "https://localhost:7214";


        
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
        public async Task<bool> EnviarPedido(int clienteId, DateTime dataAgendamento, List<int> idsServicos, decimal total)
        {
            using (var client = new HttpClient())
            {
                var pacote = new
                {
                    ClienteId = clienteId,
                    DataAgendamento = dataAgendamento,
                    ValorTotal = total,
                    ServicosIds = idsServicos
                };

                var json = JsonConvert.SerializeObject(pacote);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    var response = await client.PostAsync($"{_baseUrl}/api/pedidos", content);
                    return response.IsSuccessStatusCode;
                }
                catch
                {
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
                 string cep, string rua, string numero, string bairro, string cidade, string uf, string complemento)
        {
            using (var client = new HttpClient())
            {
                // Monta o pacote igualzinho ao DTO da API
                var dados = new
                {
                    Nome = nome,
                    Email = email,
                    Senha = senha,
                    Telefone = telefone,
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
                    return response.IsSuccessStatusCode;
                }
                catch
                {
                    return false;
                }
            }
        }
    }


    public class Servico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int TempoEstimado { get; set; }
    }
    public class FuncionarioDTO // DTO = Data Transfer Object
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        // A senha geralmente NÃO deve ser retornada para o DataGrid por segurança
        public string Telefone { get; set; }

        public async Task<List<FuncionarioDTO>> BuscarFuncionariosAsync() // Novo método para buscar funcionários
        {
            using (var client = new HttpClient())
            {
                try
                {
                    // Note que usei a rota /api/usuarios. Ajuste se sua rota for diferente (ex: /api/funcionarios)
                    var response = await client.GetAsync($"{_baseUrl}/api/usuarios/funcionarios");

                    if (response.IsSuccessStatusCode)
                    {
                        var responseString = await response.Content.ReadAsStringAsync();

                        // Usando JsonConvert (Newtonsoft) que você já usa no resto da classe
                        return JsonConvert.DeserializeObject<List<FuncionarioDTO>>(responseString);
                    }
                }
                catch (Exception ex)
                {
                    // Log de erro para depuração
                    Console.WriteLine("Erro ao buscar funcionários: " + ex.Message);
                }

                return null;
            }
        }


        // Se o JSON vier como "tipo_usuario" (snake_case), use a anotação abaixo.
        // Se você configurou a API para retornar camelCase (tipoUsuario), não precisa.
        [System.Text.Json.Serialization.JsonPropertyName("tipo_usuario")]
        public string TipoUsuario { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("data_cadastro")]
        public DateTime DataCadastro { get; set; }
    }

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

public class FuncionarioDTO // DTO = Data Transfer Object
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    // A senha geralmente NÃO deve ser retornada para o DataGrid por segurança
    public string Telefone { get; set; }

    // Se o JSON vier como "tipo_usuario" (snake_case), use a anotação abaixo.
    // Se você configurou a API para retornar camelCase (tipoUsuario), não precisa.
    [System.Text.Json.Serialization.JsonPropertyName("tipo_usuario")]
    public string TipoUsuario { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("data_cadastro")]
    public DateTime DataCadastro { get; set; }
}





