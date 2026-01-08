using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mysql.PetShop.Models
{
    [Table("tb_servicos")]
    public class Servico
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("preco")]
        public decimal Preco { get; set; }

        [Column("tempo_estimado_minutos")]
        public int TempoEstimado { get; set; }
    }
}
