using Newtonsoft.Json;
using Shop.TelaFuncionarios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.TelaFuncionarios
{
    public class Login
    {

        private readonly string ApiUrl = "https://localhost:7214/api";

        public static string TokenJwt { get; private set; }

        public async Task<bool> FazerLogin(string usuario, string senha)
        {
            using (var client = new HttpClient())
            {
                var loginData = new { Username = usuario, Password = senha }; // Ajuste os nomes conforme sua API espera
                var json = JsonConvert.SerializeObject(loginData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    // ATENÇÃO: Verifique se a rota na sua API é /Auth/login ou /Usuarios/login
                    var response = await client.PostAsync($"{ApiUrl}/Auth/login", content);

                    if (response.IsSuccessStatusCode)
                    {
                        var responseString = await response.Content.ReadAsStringAsync();

                        var dados = JsonConvert.DeserializeObject<LoginUser>(responseString);

                        // Guarda o token para usar nas próximas telas (Listar Pets, etc)
                        TokenJwt = dados.Token;
                        return true;
                    }
                    else
                    {
                        return false; // Login falhou (senha errada)
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro de conexão: {ex.Message}");
                    return false;
                }
            }
        }
    }
}
