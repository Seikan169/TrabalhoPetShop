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
        // GET: api/pedidos/cliente/5
        [HttpGet("cliente/{clienteId}")]
        public async Task<ActionResult<IEnumerable<object>>> GetPedidosDoCliente(int clienteId)
        {
            var pedidos = await _context.TbPedidos
                .Include(p => p.Pet)
                .Include(p => p.Itens).ThenInclude(i => i.Servico)
                .Where(p => p.ClienteId == clienteId) // <--- O FILTRO IMPORTANTE
                .OrderByDescending(p => p.DataAgendamento) // Mais recentes primeiro
                .Select(p => new
                {
                    Id = p.Id,
                    Pet = p.Pet.Nome,
                    Servicos = string.Join(", ", p.Itens.Select(i => i.Servico.Nome)),
                    Data = p.DataAgendamento,
                    Total = p.ValorTotal,
                    Status = p.Status
                })
                .ToListAsync();

            return Ok(pedidos);
        }
        // GET: api/pedidos/dashboard-resumo
        [HttpGet("dashboard-resumo")]
        public async Task<ActionResult<object>> GetResumoDashboard()
        {
            var hoje = DateTime.Today;

            // 1. Vendas Hoje
            var vendasHoje = await _context.TbPedidos
                .Where(p => p.DataAgendamento.Date == hoje && p.Status != "cancelado")
                .SumAsync(p => p.ValorTotal);

            // 2. Vendas Mês (NOVO) - Compara Mês e Ano atual
            var vendasMes = await _context.TbPedidos
                .Where(p => p.DataAgendamento.Month == hoje.Month &&
                            p.DataAgendamento.Year == hoje.Year &&
                            p.Status != "cancelado")
                .SumAsync(p => p.ValorTotal);

            // 3. Pendentes
            var pendentes = await _context.TbPedidos.CountAsync(p => p.Status == "pendente");

            // 4. Clientes
            var totalClientes = await _context.TbUsuarios.CountAsync(u => u.TipoUsuario == "Cliente");

            return Ok(new
            {
                VendasHoje = vendasHoje,
                VendasMes = vendasMes, // <--- Adicionei aqui
                Pendentes = pendentes,
                NovosClientes = totalClientes
            });
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
