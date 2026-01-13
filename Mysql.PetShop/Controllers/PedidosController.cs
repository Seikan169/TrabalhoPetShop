using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mysql.PetShop.Data;
using Mysql.PetShop.Models;

namespace Mysql.PetShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private readonly PetShopContext _context;

        public PedidosController(PetShopContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CriarPedido([FromBody] PedidoRequestDto dados) // <--- MUDOU AQUI
        {
            // 1. Cria o Cabeçalho do Pedido (TbPedido)
            var novoPedido = new Pedido
            {
                ClienteId = dados.ClienteId,
                PetId = dados.PetId,
                DataPedido = DateTime.Now,
                DataAgendamento = dados.DataAgendamento,
                ValorTotal = dados.ValorTotal,
                Status = "pendente", // Como definimos aqui, a API parará de exigir que venha do front
                Observacoes = dados.Observacoes
            };

            _context.TbPedidos.Add(novoPedido);
            await _context.SaveChangesAsync(); // Gera o ID do Pedido

            // 2. Cria os Itens do Pedido
            foreach (var item in dados.Itens)
            {
                var novoItem = new ItemPedido
                {
                    PedidoId = novoPedido.Id,
                    ServicoId = item.ServicoId,
                    PrecoUnitario = item.PrecoUnitario
                };

                _context.TbItensPedido.Add(novoItem);
            }

            await _context.SaveChangesAsync();

            return Ok(new { mensagem = $"Pedido #{novoPedido.Id} realizado com sucesso!", id = novoPedido.Id });
        }
        [HttpGet("pendentes")]
        public async Task<ActionResult<IEnumerable<object>>> GetPedidosPendentes()
        {
            // Busca pedidos que NÃO estão cancelados ou concluídos (ajuste conforme seu status)
            // O .Include é vital para trazer o Nome do Cliente e do Pet junto!
            var pedidos = await _context.TbPedidos
                .Include(p => p.Cliente)
                .Include(p => p.Pet)
                .OrderByDescending(p => p.DataPedido) // Mais recentes primeiro
                .Select(p => new
                {
                    Id = p.Id,
                    Cliente = p.Cliente.Nome,
                    Pet = p.Pet.Nome,
                    Data = p.DataAgendamento, // Ou DataPedido
                    Total = p.ValorTotal,
                    Status = p.Status
                })
                .ToListAsync();

            return Ok(pedidos);
        }

        public class PedidoRequestDto
        {
            public int ClienteId { get; set; }
            public int PetId { get; set; }
            public DateTime DataAgendamento { get; set; }
            public decimal ValorTotal { get; set; }
            public string Observacoes { get; set; }
            public List<ItemPedidoRequestDto> Itens { get; set; }
        }

        public class ItemPedidoRequestDto
        {
            public int ServicoId { get; set; }
            public decimal PrecoUnitario { get; set; }
        }



    }
}
