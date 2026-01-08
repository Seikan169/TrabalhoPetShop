using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mysql.PetShop.Models
{
    [Table("tb_pets")]
    public class Pet
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("cliente_id")]
        public int ClienteId { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("idade")]
        public int Idade { get; set; }

        [Column("porte")]
        public string Porte { get; set; }

        [Column("comportamento")]
        public string Comportamento { get; set; } // Manso, Agressivo

        [Column("observacoes")]
        public string Observacoes { get; set; }

        // Relacionamento (Opcional, mas ajuda)
        [ForeignKey("ClienteId")]
        public Usuario Cliente { get; set; }
    }
}
