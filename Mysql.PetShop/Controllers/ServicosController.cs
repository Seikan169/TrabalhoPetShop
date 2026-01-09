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
    }
}
