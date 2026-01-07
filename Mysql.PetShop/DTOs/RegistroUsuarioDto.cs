namespace Mysql.PetShop.DTOs
{
    public class RegistroUsuarioDto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; } // Senha pura (123456)
        public string Cpf { get; set; }   // CPF puro
        public string Telefone { get; set; }

        // Endereço
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Logradouro { get; set; } // Rua pura
        public string Numero { get; set; }
        public string Complemento { get; set; }
    }
}
