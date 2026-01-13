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
        // GET: api/pedidos?status=pendente
        [HttpGet]
        public async Task<ActionResult<IEnumerable<object>>> GetPedidos([FromQuery] string status)
        {
            // 1. Prepara a consulta
            var query = _context.TbPedidos
                .Include(p => p.Cliente)
                .Include(p => p.Pet)
                .Include(p => p.Itens)         // Pega os itens
                    .ThenInclude(i => i.Servico) // Pega o serviço de cada item
                .AsQueryable();

            // 2. Aplica o filtro (se houver)
            if (!string.IsNullOrEmpty(status) && status != "todos")
            {
                query = query.Where(p => p.Status == status);
            }

            // 3. Executa a busca (SELECT)
            var listaFinal = await query
                .OrderByDescending(p => p.DataAgendamento)
                .Select(p => new
                {
                    Id = p.Id,
                    Cliente = p.Cliente.Nome,
                    Pet = p.Pet.Nome,
                    // Truque para juntar os nomes dos serviços numa string só
                    Descricao = string.Join(", ", p.Itens.Select(i => i.Servico.Nome)),
                    Data = p.DataAgendamento,
                    Total = p.ValorTotal,
                    Status = p.Status
                })
                .ToListAsync();

            // 4. RETORNO OBRIGATÓRIO (Fora de qualquer if!)
            return Ok(listaFinal);
        }
        // PUT: api/pedidos/5/status
        [HttpPut("{id}/status")]
        public async Task<IActionResult> AtualizarStatus(int id, [FromBody] string novoStatus)
        {
            var pedido = await _context.TbPedidos.FindAsync(id);

            if (pedido == null)
            {
                return NotFound();
            }

            // Atualiza o status
            pedido.Status = novoStatus;

            // Salva no banco
            await _context.SaveChangesAsync();

            return NoContent(); // Retorna 204 (Sucesso sem conteúdo)
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
