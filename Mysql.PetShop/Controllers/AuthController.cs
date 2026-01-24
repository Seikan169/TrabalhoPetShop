using BCrypt.Net; // Importante para criptografia
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public IActionResult Cadastrar([FromBody] CadastroCompletoRequest dados)
        {
            // 1. Verifica se e-mail existe
            if (_context.TbUsuarios.Any(u => u.Email == dados.Email))
            {
                return BadRequest("Este e-mail já está cadastrado.");
            }

            // 2. Cria o Usuário
            var novoUsuario = new Usuario
            {
                Nome = dados.Nome,
                Email = dados.Email,
                Senha = BCrypt.Net.BCrypt.HashPassword(dados.Senha), // Criptografa
                Telefone = dados.Telefone,
                TipoUsuario = dados.TipoUsuario,
                Cpf = dados.Cpf,
                dataNascimento = dados.DataNascimento,
                DataCadastro = DateTime.UtcNow,
                Observacao = dados.Observacao

            };

            _context.TbUsuarios.Add(novoUsuario);
            _context.SaveChanges(); // AQUI o banco gera o ID do usuário!

            // 3. Cria o Endereço usando o ID do usuário recém-criado
            var novoEndereco = new Endereco
            {
                UsuarioId = novoUsuario.Id, // Pega o ID gerado acima
                Cep = dados.Cep,
                Logradouro = dados.Logradouro,
                Numero = dados.Numero,
                Bairro = dados.Bairro,
                Cidade = dados.Cidade,
                Uf = dados.Uf,
                Complemento = dados.Complemento
            };

            _context.TbEnderecos.Add(novoEndereco);
            _context.SaveChanges();

            return Ok(new { mensagem = "Usuário e endereço cadastrados com sucesso!" });
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
        // GET: api/auth/funcionarios
        [HttpGet("funcionarios")]
        public IActionResult GetFuncionarios()
        {
            // Busca no banco apenas quem é 'funcionario'
            var lista = _context.TbUsuarios
                .Where(u => u.TipoUsuario == "funcionario")
                .Select(u => new
                {
                    // Selecionamos apenas os dados seguros (sem senha!)
                    Id = u.Id,
                    Nome = u.Nome,
                    Email = u.Email,
                    Telefone = u.Telefone,
                    Cpf = u.Cpf,  // Garanta que no seu TbUsuario o nome é esse
                    Data_Nascimento = u.dataNascimento,
                    Tipo_Usuario = u.TipoUsuario,
                    Data_Cadastro = u.DataCadastro // Se tiver esse campo no banco
                })
                .ToList();

            return Ok(lista);
        }

        // GET: api/usuarios/clientes
        [HttpGet("clientes")]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetClientes()
        {
            var clientes = await _context.TbUsuarios
                .Where(u => u.TipoUsuario.ToLower() == "cliente")
                .Select(u => new
                {
                    // Use os nomes exatamente como estão na sua classe Usuario
                    Id = u.Id,
                    Nome = u.Nome,
                    Email = u.Email,
                    Telefone = u.Telefone,
                    DataCadastro = u.DataCadastro, 
                    TipoUsuario = u.TipoUsuario,
                    DataNascimento = u.dataNascimento,


                })
                .ToListAsync();

            return Ok(clientes);
        }
    }




    // Classe auxiliar só para receber os dados do JSON de login
    public class LoginRequest
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
    public class CadastroCompletoRequest
    {
        // Dados do Usuário
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public string TipoUsuario { get; set; }
        public string Cpf { get; set; } 
        public DateTime DataNascimento { get; set; }

        public string Observacao { get; set; }

        // Dados do Endereço
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Complemento { get; set; }
    }
}