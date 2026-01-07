using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mysql.PetShop.DTOs;
using System.Text.Json;

namespace Mysql.PetShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CepController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public CepController()
        {
            _httpClient = new HttpClient();
        }

        [HttpGet("consulta-cep/{cep}")]
        public async Task<IActionResult> ConsultarCep(string cep)
        {
            // Remove traços e pontos caso venham
            string cepLimpo = cep.Replace("-", "").Replace(".", "").Trim();

            if (cepLimpo.Length != 8)
                return BadRequest("CEP inválido.");

            try
            {
                // Chama a API pública do ViaCEP
                var response = await _httpClient.GetAsync($"https://viacep.com.br/ws/{cepLimpo}/json/");

                if (!response.IsSuccessStatusCode)
                    return BadRequest("Erro ao consultar ViaCEP.");

                var jsonString = await response.Content.ReadAsStringAsync();

                // Converte o JSON do ViaCEP para nossa classe C#
                var dados = JsonSerializer.Deserialize<ViaCepResult>(jsonString, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                if (dados.Erro)
                    return NotFound("CEP não encontrado.");

                return Ok(dados);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno: {ex.Message}");
            }
        }
    }
}
