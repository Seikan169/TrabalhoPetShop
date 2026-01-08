using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.TelaFuncionarios
{
    public class ApiService
    {
        
        private readonly string _baseUrl = "https://localhost:7214";

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
    }

    // Classe para receber a resposta da API organizada
    public class LoginResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string TipoUsuario { get; set; } // O mais importante!
        public string Mensagem { get; set; }
    }
}
