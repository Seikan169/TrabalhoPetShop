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
        public async Task<IActionResult> CriarPedido([FromBody] Pedido dados)
        {
            // 1. Cria o Cabeçalho do Pedido (TbPedido)
            var novoPedido = new Pedido
            {
                ClienteId = dados.ClienteId,
                PetId = dados.PetId,            // <--- O CAMPO NOVO IMPORTANTE
                DataPedido = DateTime.Now,
                DataAgendamento = dados.DataAgendamento,
                ValorTotal = dados.ValorTotal,
                Status = "pendente",
                Observacoes = dados.Observacoes
            };

            _context.TbPedidos.Add(novoPedido);

            // Salva assincronamente para gerar o ID
            await _context.SaveChangesAsync();

            // 2. Cria os Itens do Pedido
            // O Front-end já mandou a lista com IDs e Preços (dados.Itens)
            foreach (var item in dados.Itens)
            {
                var novoItem = new ItemPedido
                {
                    PedidoId = novoPedido.Id,      // ID gerado acima
                    ServicoId = item.ServicoId,    // ID que veio do Front
                    PrecoUnitario = item.PrecoUnitario // Preço que veio do Front (Snapshot)
                };

                _context.TbItensPedido.Add(novoItem);
            }

            await _context.SaveChangesAsync(); // Salva os itens

            return Ok(new { mensagem = $"Pedido #{novoPedido.Id} realizado com sucesso!", id = novoPedido.Id });
        }



    }
}
