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
            DateTime horaBrasilia = DateTime.UtcNow.AddHours(-3);
            // 1. Cria o Cabeçalho do Pedido (TbPedido)
            var novoPedido = new Pedido
            {
                ClienteId = dados.ClienteId,
                PetId = dados.PetId,
                DataPedido = horaBrasilia,
                DataAgendamento = dados.DataAgendamento,
                ValorTotal = dados.ValorTotal,
                Status = "pendente", // Como definimos aqui, a API parará de exigir que venha do front
                Observacoes = dados.Observacoes,
                FormaPagamento = dados.FormaPagamento,
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
                .Include(p => p.Funcionario) // <--- 1. NOVIDADE: Traz os dados do funcionário
                .Include(p => p.Itens)
                    .ThenInclude(i => i.Servico)
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
                    Descricao = string.Join(", ", p.Itens.Select(i => i.Servico.Nome)),
                    Data = p.DataAgendamento,
                    Total = p.ValorTotal,
                    Status = p.Status,
                    Pagamento = p.FormaPagamento,

                    // <--- 2. NOVIDADE: Lógica do LEFT JOIN (Se for nulo, manda '---')
                    Funcionario = p.Funcionario != null ? p.Funcionario.Nome : "---"
                })
                .ToListAsync();

            return Ok(listaFinal);
        }

        // PUT: api/pedidos/5/status
        [HttpPut("{id}/status")]
        public async Task<IActionResult> AtualizarStatus(int id, [FromBody] AtualizarStatusDto dados)
        {
            // 1. Busca o pedido no banco
            var pedido = await _context.TbPedidos.FindAsync(id);

            if (pedido == null)
            {
                return NotFound();
            }

            // 2. Atualiza o Status
            pedido.Status = dados.Status;

            // 3. Atualiza o Funcionário (Se veio um ID válido)
            // Verifica se veio valor e se é maior que 0
            if (dados.FuncionarioId.HasValue && dados.FuncionarioId.Value > 0)
            {
                pedido.FuncionarioId = dados.FuncionarioId.Value;
            }

            // 4. Salva no banco
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Dica: Se der erro aqui, geralmente é porque o ID do funcionário não existe na tabela usuarios
                return BadRequest("Erro ao salvar: " + ex.Message);
            }

            return NoContent(); // Sucesso
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
        // Relatorio 
        [HttpGet("relatorio-completo")]
        public async Task<IActionResult> GetRelatorioCompleto()
        {
            try
            {
                var hoje = DateTime.Today;
                var data7Dias = hoje.AddDays(-7);
                var primeiroDiaMes = new DateTime(hoje.Year, hoje.Month, 1);

                // =================================================================================
                // A MÁGICA ACONTECE AQUI: O .Select vem ANTES de trazer os dados
                // Isso impede que o erro de conversão aconteça nas suas Classes de Entidade
                // =================================================================================
                var dadosBrutos = await _context.TbPedidos
                    .Where(p => p.Status != null && p.Status != "cancelado")
                    .Select(p => new
                    {
                        p.Id,
                        p.DataAgendamento,
                        p.ValorTotal,
                        p.Status,

                        // Tratamento de Nulos DIRETO NO BANCO
                        FormaPagamento = p.FormaPagamento ?? "Não Informado",
                        Observacoes = p.Observacoes ?? "",

                        // Cliente (Garante que se telefone for null, venha vazio)
                        NomeCliente = p.Cliente.Nome,
                        TelefoneCliente = p.Cliente.Telefone ?? "Não Inf.",

                        // Funcionário (Se for null, retorna texto padrão)
                        NomeFuncionario = p.Funcionario != null ? p.Funcionario.Nome : "Sem Atendente",

                        // Serviços (Traz apenas a lista de nomes para evitar trazer o objeto inteiro)
                        NomesServicos = p.Itens.Select(i => i.Servico.Nome).ToList(),

                        // Preços para o Top Serviços
                        ItensInfo = p.Itens.Select(i => new { NomeServico = i.Servico.Nome, Preco = i.PrecoUnitario }).ToList()
                    })
                    .ToListAsync(); // <--- Agora o ToListAsync roda seguro!

                // =================================================================================
                // DAQUI PRA BAIXO É SÓ CÁLCULO NA MEMÓRIA (MUITO RÁPIDO)
                // =================================================================================

                var relatorio = new Relatorio
                {
                    // Cálculos Financeiros
                    FaturamentoHoje = dadosBrutos.Where(p => p.DataAgendamento.Date == hoje).Sum(p => p.ValorTotal),
                    Faturamento7Dias = dadosBrutos.Where(p => p.DataAgendamento.Date >= data7Dias).Sum(p => p.ValorTotal),
                    FaturamentoMes = dadosBrutos.Where(p => p.DataAgendamento.Date >= primeiroDiaMes).Sum(p => p.ValorTotal),

                    // Contagem de Pedidos
                    PedidosHoje = dadosBrutos.Count(p => p.DataAgendamento.Date == hoje),
                    Pedidos7Dias = dadosBrutos.Count(p => p.DataAgendamento.Date >= data7Dias),
                    PedidosMes = dadosBrutos.Count(p => p.DataAgendamento.Date >= primeiroDiaMes),
                };

                // Monta Top Serviços (Desmembrando a lista que trouxemos)
                var todosItensFlat = dadosBrutos.SelectMany(p => p.ItensInfo).ToList();

                relatorio.TopServicos = todosItensFlat
                    .Where(i => i.NomeServico != null)
                    .GroupBy(i => i.NomeServico)
                    .Select(grupo => new TopServicoDTO
                    {
                        NomeServico = grupo.Key,
                        Quantidade = grupo.Count(),
                        ValorTotal = grupo.Sum(x => x.Preco)
                    })
                    .OrderByDescending(x => x.Quantidade)
                    .Take(5)
                    .ToList();

                // Monta a Lista Completa
                relatorio.ListaCompleta = dadosBrutos
                    .OrderByDescending(p => p.DataAgendamento)
                    .Select(p => new PedidoRelatorioDTO
                    {
                        Id = p.Id,
                        Cliente = p.NomeCliente ?? "Cliente Removido",
                        Data = p.DataAgendamento.ToString("dd/MM/yyyy HH:mm"),
                        Valor = p.ValorTotal,
                        Status = p.Status,
                        FormaPagamento = p.FormaPagamento,
                        // Junta os nomes dos serviços numa string só
                        Itens = string.Join(", ", p.NomesServicos.Where(s => s != null))
                    }).ToList();

                return Ok(relatorio);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO CRÍTICO: " + ex.ToString()); // Mostra o erro detalhado no console
                return StatusCode(500, new { message = "Erro ao gerar relatório", error = ex.Message });
            }
        }

        [HttpGet("ultimos-pedidos")]
        public async Task<IActionResult> GetUltimosPedidos()
        {
            var lista = await _context.TbPedidos
                .Include(p => p.Cliente)
                .OrderByDescending(p => p.DataAgendamento) // Do mais novo para o mais antigo
                .Take(10) // Só os 10 últimos
                .Select(p => new
                {
                    Hora = p.DataAgendamento.ToString("HH:mm"), // Só a hora
                    Cliente = p.Cliente.Nome,
                    Servico = p.Status, // Ou p.Itens...
                    Valor = p.ValorTotal
                })
                .ToListAsync();

            return Ok(lista);
        }

        public class PedidoRequestDto
        {
            public int ClienteId { get; set; }
            public int PetId { get; set; }
            public DateTime DataAgendamento { get; set; }
            public DateTime DataPedido { get; set; }
            public decimal ValorTotal { get; set; }
            public string Observacoes { get; set; }
            public List<ItemPedidoRequestDto> Itens { get; set; }
            public string FormaPagamento { get; set; }

        }

        public class ItemPedidoRequestDto
        {
            public int ServicoId { get; set; }
            public decimal PrecoUnitario { get; set; }
        }

        public class AtualizarStatusDto
        {
            public string Status { get; set; }
            public int? FuncionarioId { get; set; }
        }



    }
}
