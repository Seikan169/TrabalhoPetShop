using System.ComponentModel.DataAnnotations;

namespace Mysql.PetShop.Models
{
    public class Usuario
    {
       
            [Key]
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Email { get; set; }
            public string SenhaHash { get; set; } // Aqui vai o hash do BCrypt
            public string TipoUsuario { get; set; } = "Cliente"; // Padrão

            // Dados Sensíveis (Vão receber o texto criptografado pelo AES)
            public string CpfCriptografado { get; set; }
            public string TelefoneCriptografado { get; set; }

            // Endereço Público
            public string Cep { get; set; }
            public string Cidade { get; set; }
            public string Uf { get; set; }

            // Endereço Sensível (Criptografado)
            public string LogradouroCriptografado { get; set; }
            public string NumeroCriptografado { get; set; }
            public string ComplementoCriptografado { get; set; }

    }
}
