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
    public class AgendamentosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AgendamentosController(AppDbContext context)
        {
            _context = context;
        }

        // 1. CLIENTE: Solicita um serviço (Cria Agendamento)
        [HttpPost("solicitar")]
        [Authorize] // Só quem tem Token entra
        public async Task<IActionResult> SolicitarServico([FromBody] Agendamento pedido)
        {
            // Pega o ID do usuário que está logado (vem de dentro do Token)
            var idUsuarioLogado = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

            // Força o ClienteId ser o do usuário logado (segurança)
            pedido.ClienteId = idUsuarioLogado;
            pedido.Status = "Pendente";
            pedido.AtendenteId = null; // Ninguém aceitou ainda

            _context.Agendamentos.Add(pedido);
            await _context.SaveChangesAsync();

            return Ok(new { mensagem = "Solicitação enviada! Aguarde um atendente aceitar." });
        }

        // 2. ATENDENTE: Vê o que tem pendente
        [HttpGet("pendentes")]
        [Authorize]
        public async Task<IActionResult> VerPendentes()
        {
            // Opcional: Verificar se o usuário é "Atendente" ou "Admin" antes de mostrar

            var lista = await _context.Agendamentos
                .Include(a => a.Cliente) // Traz os dados do Cliente junto
                .Include(a => a.Pet)     // Traz os dados do Pet junto
                .Include(a => a.Servico) // Traz qual é o serviço
                .Where(a => a.Status == "Pendente")
                .ToListAsync();

            return Ok(lista);
        }

        // 3. ATENDENTE: Aceita o serviço
        [HttpPut("{id}/aceitar")]
        [Authorize]
        public async Task<IActionResult> AceitarServico(int id)
        {
            var agendamento = await _context.Agendamentos.FindAsync(id);

            if (agendamento == null) return NotFound("Agendamento não encontrado.");

            // Pega o ID do atendente que está clicando
            var idAtendente = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

            agendamento.Status = "Aceito";
            agendamento.AtendenteId = idAtendente; // Vincula quem aceitou

            await _context.SaveChangesAsync();

            return Ok(new { mensagem = "Serviço aceito com sucesso! Bora trabalhar." });
        }
    }
}

