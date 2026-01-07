using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Mysql.PetShop.Models
{
    public class Pet
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }
        public string Raca { get; set; }
        public decimal Peso { get; set; }

        // Relacionamento: Um Pet tem um Dono (Usuario)
        public int DonoId { get; set; }
        [JsonIgnore] // Oculta o objeto Dono no JSON para não ficar cíclico
        public Usuario? Dono { get; set; }
    }
}
