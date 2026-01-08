using BCrypt.Net; // Importante para criptografia
using Microsoft.AspNetCore.Mvc;
using Mysql.PetShop.Data;
using Mysql.PetShop.Models;
using System.Linq;

namespace PetShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly PetShopContext _context;

        public AuthController(PetShopContext context)
        {
            _context = context;
        }

        // POST: api/auth/cadastro
        // Usado para criar usuários com senha segura
        [HttpPost("cadastro")]
        public IActionResult Cadastrar([FromBody] Usuario usuario)
        {
            // 1. Verificar se email já existe
            if (_context.TbUsuarios.Any(u => u.Email == usuario.Email))
            {
                return BadRequest("Este e-mail já está cadastrado.");
            }

            // 2. CRIPTOGRAFAR A SENHA (HASH)
            // O BCrypt gera um 'salt' automático, tornando impossível reverter
            usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);

            // 3. Salvar no banco
            _context.TbUsuarios.Add(usuario);
            _context.SaveChanges();

            // Retorna sucesso (mas não retorna a senha!)
            usuario.Senha = "";
            return Ok(usuario);
        }

        // POST: api/auth/login
        // O Windows Forms vai chamar isso aqui
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest dadosLogin)
        {
            // 1. Busca o usuário pelo e-mail
            var usuarioBanco = _context.TbUsuarios
                .FirstOrDefault(u => u.Email == dadosLogin.Email);

            if (usuarioBanco == null)
            {
                return Unauthorized("Usuário ou senha inválidos.");
            }

            // 2. VERIFICA A SENHA
            // Compara a senha que veio do Windows Form com o HASH do banco
            bool senhaValida = BCrypt.Net.BCrypt.Verify(dadosLogin.Senha, usuarioBanco.Senha);

            if (!senhaValida)
            {
                return Unauthorized("Usuário ou senha inválidos.");
            }

            // 3. Se chegou aqui, login deu certo!
            // Retornamos os dados essenciais para o Windows Forms saber qual tela abrir
            return Ok(new
            {
                Id = usuarioBanco.Id,
                Nome = usuarioBanco.Nome,
                TipoUsuario = usuarioBanco.TipoUsuario, // Aqui está o segredo (Cliente ou Funcionario)
                Mensagem = "Login realizado com sucesso"
            });
        }
    }

    // Classe auxiliar só para receber os dados do JSON de login
    public class LoginRequest
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}