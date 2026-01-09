using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult CriarPedido([FromBody] PedidoRequest dados)
        {
            // 1. Cria o Cabeçalho do Pedido
            var novoPedido = new Pedido
            {
                ClienteId = dados.ClienteId,
                DataPedido = DateTime.Now,
                DataAgendamento = dados.DataAgendamento,
                ValorTotal = dados.ValorTotal,
                Status = "pendente"
            };

            _context.TbPedidos.Add(novoPedido);
            _context.SaveChanges(); // Salva para gerar o ID do pedido (ex: Pedido #55)

            // 2. Cria os Itens (loop nos serviços)
            // Primeiro, buscamos os preços atuais no banco para garantir segurança
            var servicosDoBanco = _context.TbServicos
                                    .Where(s => dados.ServicosIds.Contains(s.Id))
                                    .ToList();

            foreach (var servicoId in dados.ServicosIds)
            {
                var infoServico = servicosDoBanco.FirstOrDefault(s => s.Id == servicoId);

                if (infoServico != null)
                {
                    var novoItem = new ItemPedido
                    {
                        PedidoId = novoPedido.Id, // Usa o ID gerado acima
                        ServicoId = servicoId,
                        PrecoUnitario = infoServico.Preco
                    };
                    _context.TbItensPedido.Add(novoItem);
                }
            }

            _context.SaveChanges(); // Salva todos os itens

            return Ok(new { mensagem = $"Pedido #{novoPedido.Id} realizado com sucesso!" });
        }
    }
}
