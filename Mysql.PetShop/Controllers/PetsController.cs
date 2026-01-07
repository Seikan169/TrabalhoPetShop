using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mysql.PetShop.Data;
using Mysql.PetShop.Models;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace Mysql.PetShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PetsController(AppDbContext context)
        {
            _context = context;
        }

        // 1. CADASTRAR UM NOVO PET
        [HttpPost]
        [Authorize] // Só quem está logado pode cadastrar
        public async Task<IActionResult> CadastrarPet([FromBody] Pet pet)
        {
            // Pega o ID do usuário logado através do Token
            var idUsuario = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

            // Força o dono ser o usuário logado (segurança)
            pet.DonoId = idUsuario;
            pet.Dono = null; // Evita erro de validação circular

            _context.Pets.Add(pet);
            await _context.SaveChangesAsync();

            return Ok(new { mensagem = $"Pet {pet.Nome} cadastrado com sucesso!" });
        }

        // 2. LISTAR OS MEUS PETS (Só os do usuário logado)
        [HttpGet("meus-pets")]
        [Authorize]
        public async Task<IActionResult> MeusPets()
        {
            var idUsuario = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

            var meusPets = await _context.Pets.Where(p => p.DonoId == idUsuario).ToListAsync();



            return Ok(meusPets);
        }
    }
}

