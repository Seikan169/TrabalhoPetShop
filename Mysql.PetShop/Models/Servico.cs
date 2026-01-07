using System.ComponentModel.DataAnnotations;

namespace Mysql.PetShop.Models
{
    public class Servico
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; } // Ex: Banho Premium
        public decimal Preco { get; set; }
        public int TempoEstimadoMinutos { get; set; }
        public bool Ativo { get; set; } = true;

    }
}
