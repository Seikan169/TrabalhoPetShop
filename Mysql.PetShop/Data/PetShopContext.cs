using Microsoft.EntityFrameworkCore;
using Mysql.PetShop.Models;

namespace Mysql.PetShop.Data
{
    public class PetShopContext :DbContext
    {
        public PetShopContext(DbContextOptions<PetShopContext> options) : base(options)
        {
        }

        // Aqui listamos as tabelas que criamos acima
        public DbSet<Usuario> TbUsuarios { get; set; }
        public DbSet<Pet> TbPets { get; set; }
        public DbSet<Servico> TbServicos { get; set; }
        public DbSet<Pedido> TbPedidos { get; set; }
        public DbSet<ItemPedido> TbItensPedido { get; set; }
    }
}
