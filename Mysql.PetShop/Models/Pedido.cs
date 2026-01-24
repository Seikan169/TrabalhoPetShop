using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mysql.PetShop.Models
{
    [Table("pedidos")] // Confirme se no banco é 'tb_pedidos' ou só 'pedidos'
    public class Pedido
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("pet_id")]
        public int PetId { get; set; }

        [Column("cliente_id")]
        public int ClienteId { get; set; }

        [Column("data_pedido")]
        public DateTime DataPedido { get; set; }

        [Column("data_agendamento")]
        public DateTime DataAgendamento { get; set; }

        [Column("valor_total")]
        public decimal ValorTotal { get; set; }

        [Column("status")]
        public string? Status { get; set; }

        [Column("observacoes")] // Adicionei o mapeamento da coluna caso falte
        public string? Observacoes { get; set; }

        // --- RELACIONAMENTOS ---
        [Column("funcionario_id")] // Caso o nome no banco seja snake_case
        public int? FuncionarioId { get; set; }
        [ForeignKey("FuncionarioId")]
        public virtual Usuario Funcionario { get; set; }

        [ForeignKey("PetId")]
        public virtual Pet Pet { get; set; }

        [ForeignKey("ClienteId")]
        public virtual Usuario Cliente { get; set; }

        // Mantenha APENAS esta linha para a lista de itens
        public virtual ICollection<ItemPedido> Itens { get; set; }
    }
}