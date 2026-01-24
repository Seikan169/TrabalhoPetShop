namespace Mysql.PetShop.Models
{
    public class Relatorio
    {
        // Totais Financeiros
        public decimal FaturamentoHoje { get; set; }
        public decimal Faturamento7Dias { get; set; }
        public decimal FaturamentoMes { get; set; }

        // Contagem de Pedidos
        public int PedidosHoje { get; set; }
        public int Pedidos7Dias { get; set; }
        public int PedidosMes { get; set; }

        // Lista dos Top Serviços (Para fazer a análise)
        public List<TopServicoDTO> TopServicos { get; set; } = new List<TopServicoDTO>();

        // Lista Completa para a segunda aba
        public List<PedidoRelatorioDTO> ListaCompleta { get; set; } = new List<PedidoRelatorioDTO>();
    }

    public class TopServicoDTO
    {
        public string NomeServico { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorTotal { get; set; }
    }

    public class PedidoRelatorioDTO
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string Data { get; set; }
        public decimal Valor { get; set; }
        public string Status { get; set; }
        public string Itens { get; set; }
    }
}
