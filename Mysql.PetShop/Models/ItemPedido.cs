using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mysql.PetShop.Models
{
    [Table("itens_pedido")]
    public class ItemPedido
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("pedido_id")]
        public int PedidoId { get; set; }

        [Column("servico_id")]
        public int ServicoId { get; set; }

        [Column("preco_unitario")]
        public decimal PrecoUnitario { get; set; }

        // --- RELACIONAMENTOS ---

        // Isso permite o .Include(p => p.Itens) funcionar na volta
        [ForeignKey("PedidoId")]
        public virtual Pedido Pedido { get; set; }

        // --- ISSO É CRUCIAL PARA APARECER A DESCRIÇÃO "BANHO" ---
        [ForeignKey("ServicoId")]
        public virtual Servico Servico { get; set; }
    }
}