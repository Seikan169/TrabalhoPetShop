using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mysql.PetShop.Models
{
    [Table("tb_pets")]
    public class Pet
    {
        public int Id { get; set; }

        [Column("cliente_id")]
        public int ClienteId { get; set; }

        public string Nome { get; set; }
        public string Especie { get; set; } // Cachorro, Gato...
        public string Raca { get; set; }
        public string Cor { get; set; }

        [Column("data_nascimento")]
        public DateTime DataNascimento { get; set; }

        public decimal Peso { get; set; }
    }
}
