using CosenSecurity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Mysql.PetShop.Data;
using Mysql.PetShop.DTOs;
using Mysql.PetShop.Models;
using PetShopAPI.Helpers;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace Mysql.PetShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }


        [HttpPost("cadastro")]
        public async Task<IActionResult> Cadastro([FromBody] RegistroUsuarioDto dto)
        {
            // 1. Verificar se o e-mail já existe
            if (await _context.Usuarios.AnyAsync(u => u.Email == dto.Email))
            {
                return BadRequest("Este e-mail já está cadastrado.");
            }

            // 2. Criar a entidade Usuario
            var novoUsuario = new Usuario
            {
                Nome = dto.Nome,
                Email = dto.Email,

                // --- SEGURANÇA 1: BCRYPT ---
                SenhaHash = BCrypt.Net.BCrypt.HashPassword(dto.Senha),

                TipoUsuario = "Cliente",

                // --- SEGURANÇA 2: CRIPTOGRAFIA AES ---
                // AQUI ESTAVA O ERRO: Adicionei '?? ""' em TODOS os campos abaixo
                CpfCriptografado = PetShopAPI.Helpers.SecurityHelper.Encrypt(dto.Cpf ?? ""),
                TelefoneCriptografado = PetShopAPI.Helpers.SecurityHelper.Encrypt(dto.Telefone ?? ""),

                // Endereço Público 
                Cep = dto.Cep,
                Cidade = dto.Cidade,
                Uf = dto.Uf,

                // Endereço Privado (Criptografado)
                // A proteção '?? ""' transforma nulo em texto vazio antes de criptografar
                LogradouroCriptografado = PetShopAPI.Helpers.SecurityHelper.Encrypt(dto.Logradouro ?? ""),
                NumeroCriptografado = PetShopAPI.Helpers.SecurityHelper.Encrypt(dto.Numero ?? ""),
                ComplementoCriptografado = PetShopAPI.Helpers.SecurityHelper.Encrypt(dto.Complemento ?? "")
            };

            // 3. Salvar no Banco
            _context.Usuarios.Add(novoUsuario);
            await _context.SaveChangesAsync();

            return Ok("Usuário cadastrado com sucesso!");
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto dto)
        {
            // 1. Busca o usuário pelo e-mail
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == dto.Email);

            if (usuario == null)
                return Unauthorized("Usuário ou senha inválidos."); // Não diga qual errou por segurança

            // 2. Verifica a senha com BCrypt (Compara a senha limpa com o Hash do banco)
            bool senhaValida = BCrypt.Net.BCrypt.Verify(dto.Senha, usuario.SenhaHash);

            if (!senhaValida)
                return Unauthorized("Usuário ou senha inválidos.");

            // 3. Se chegou aqui, logou! Vamos gerar o Token.
            var token = GerarTokenJwt(usuario);

            return Ok(new { token = token, nome = usuario.Nome, tipo = usuario.TipoUsuario });
        }

        // Método privado para gerar o token (fica dentro do Controller mesmo, lá no final)
        private string GerarTokenJwt(Usuario usuario)
        {
            var key = Encoding.ASCII.GetBytes("MinhaChaveSuperSecretaDoPetShop2026!!"); // Mesma do appsettings

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, usuario.Id.ToString()),
                    new Claim(ClaimTypes.Email, usuario.Email),
                    new Claim(ClaimTypes.Role, usuario.TipoUsuario) // Define se é Cliente ou Atendente
                }),
                Expires = DateTime.UtcNow.AddHours(8), // Token vale por 8 horas
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                Issuer = "PetShopAPI",
                Audience = "PetShopFront"
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

    }
}
