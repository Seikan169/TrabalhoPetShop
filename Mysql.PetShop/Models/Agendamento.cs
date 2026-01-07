using System.ComponentModel.DataAnnotations;

namespace Mysql.PetShop.Models
{
    public class Agendamento
    {
        [Key]
        public int Id { get; set; }

        public int ClienteId { get; set; } // Quem pediu
        public Usuario? Cliente { get; set; }

        public int PetId { get; set; } // Qual cachorro
        public Pet? Pet { get; set; }

        public int ServicoId { get; set; } // O que vai fazer
        public Servico? Servico { get; set; }

        public DateTime DataHora { get; set; }

        // Status: "Pendente", "Aceito", "Concluido", "Cancelado"
        public string Status { get; set; } = "Pendente";

        public int? AtendenteId { get; set; } // Quem aceitou (pode ser nulo no começo)
        public Usuario? Atendente { get; set; }
    }
}
