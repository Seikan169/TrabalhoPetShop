using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mysql.PetShop.Models
{
    [Table("pedidos")]
    public class Pedido
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("pet_id")]
        public int PetId { get; set; } // A coluna nova

        [Column("cliente_id")]
        public int ClienteId { get; set; }

        [Column("data_pedido")]
        public DateTime DataPedido { get; set; }

        [Column("data_agendamento")]
        public DateTime DataAgendamento { get; set; }

        [Column("valor_total")]
        public decimal ValorTotal { get; set; }

        [Column("status")]
        public string Status { get; set; } // pendente, confirmado, etc.

        // Lista de itens dentro desse pedido
        public List<ItemPedido> Itens { get; set; }
        public string Observacoes { get;  set; }

        [ForeignKey("PetId")]
        public virtual Pet Pet { get; set; }
        [ForeignKey("ClienteId")]
        public virtual Usuario Cliente { get; set; }
    }
}
