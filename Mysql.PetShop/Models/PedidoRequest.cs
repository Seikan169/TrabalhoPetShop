using System.ComponentModel.DataAnnotations.Schema;

namespace Mysql.PetShop.Models
{
    public class PedidoRequest
    {
        public int ClienteId { get; set; }
        public int PetId { get; set; } // <--- ADICIONE ISSO
        public DateTime DataAgendamento { get; set; }
        public decimal ValorTotal { get; set; }
        public string Observacoes { get; set; }
        [Column("forma_pagamento")]
        public string? FormaPagamento { get; set; }
        public List<Pedido> Itens { get; set; }
    }
}
