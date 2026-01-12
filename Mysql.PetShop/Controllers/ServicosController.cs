using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mysql.PetShop.Data;
using Mysql.PetShop.Models;
using Microsoft.EntityFrameworkCore; 

namespace Mysql.PetShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicosController : ControllerBase
    {
        private readonly PetShopContext _context;

        public ServicosController(PetShopContext context)
        {
            _context = context;
        }

        // É esse cara aqui que o seu Windows Forms está tentando chamar!
        // Endereço: GET api/servicos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Servico>>> GetServicos()
        {
            return await _context.TbServicos.ToListAsync();
        }
        // GET: api/servicos/buscar?termo=banho
        [HttpGet("buscar")]
        public async Task<ActionResult<IEnumerable<Servico>>> BuscarServicos([FromQuery] string termo)
        {
            // Se não digitar nada, retorna tudo
            if (string.IsNullOrWhiteSpace(termo))
            {
                return await _context.TbServicos.ToListAsync();
            }

            // O "Contains" vira um "LIKE '%termo%'" no SQL automaticamente
            var resultados = await _context.TbServicos
                                           .Where(s => s.Nome.Contains(termo) || s.Descricao.Contains(termo))
                                           .ToListAsync();

            return resultados;
        }
    }
}
