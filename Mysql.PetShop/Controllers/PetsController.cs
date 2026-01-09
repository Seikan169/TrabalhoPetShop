using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mysql.PetShop.Data;
using Mysql.PetShop.Models;
using Microsoft.EntityFrameworkCore;

namespace Mysql.PetShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly PetShopContext _context;

        public PetsController(PetShopContext context)
        {
            _context = context;
        }

        // 1. SALVAR NOVO PET
        [HttpPost]
        public async Task<IActionResult> CadastrarPet([FromBody] Pet pet)
        {
            _context.TbPets.Add(pet);
            await _context.SaveChangesAsync();
            return Ok(pet);
        }

        // 2. BUSCAR MEUS PETS (Filtrar pelo ID do dono)
        [HttpGet("meus-pets/{clienteId}")]
        public async Task<ActionResult<List<Pet>>> GetMeusPets(int clienteId)
        {
            var lista = await _context.TbPets
                                      .Where(p => p.ClienteId == clienteId)
                                      .ToListAsync();
            return lista;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> AtualizarPet(int id, [FromBody] Pet pet)
        {
            // 1. Verifica se o ID da URL bate com o ID do objeto
            if (id != pet.Id)
            {
                return BadRequest("ID inconsistente.");
            }

            // 2. O PULO DO GATO: Avisa o EF que este objeto foi modificado
            // SE FALTAR ESSA LINHA, NADA É SALVO!
            _context.Entry(pet).State = EntityState.Modified;

            try
            {
                // 3. Salva as mudanças
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                // Verifica se o pet ainda existe antes de dar erro
                if (!_context.TbPets.Any(e => e.Id == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            // 4. Retorna "Sem Conteúdo" (Sucesso padrão para update)
            return NoContent();
        }
        // 4. EXCLUIR PET (DELETE)
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletarPet(int id)
        {
            var pet = await _context.TbPets.FindAsync(id);
            if (pet == null) return NotFound();

            _context.TbPets.Remove(pet);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

