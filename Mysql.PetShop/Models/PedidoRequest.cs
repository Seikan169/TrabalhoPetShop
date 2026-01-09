namespace Mysql.PetShop.Models
{
    public class PedidoRequest
    {
        public int ClienteId { get; set; }
        public DateTime DataAgendamento { get; set; }
        public decimal ValorTotal { get; set; }

        // A lista de serviços que ele comprou
        public List<int> ServicosIds { get; set; }
        public string Observacoes { get; set; }
    }
}
