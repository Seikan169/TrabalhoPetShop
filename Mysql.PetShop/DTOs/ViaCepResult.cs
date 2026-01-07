namespace Mysql.PetShop.DTOs
{
    public class ViaCepResult
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; } // Rua
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; } // Cidade
        public string Uf { get; set; } // Estado
        public bool Erro { get; set; }
    }
}
