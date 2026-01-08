using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mysql.PetShop.Models
{
    [Table("tb_itens_pedido")]
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

        // Referência para saber qual serviço é
        [ForeignKey("ServicoId")]
        public Servico Servico { get; set; }
    }
}
