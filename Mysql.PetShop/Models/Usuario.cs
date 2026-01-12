using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mysql.PetShop.Models
{
    [Table("usuarios")] // Diz pro C# que essa classe é a tabela tb_usuarios
    public class Usuario
    {
        [Key] // Diz que é a Chave Primária
        [Column("id")] // Diz o nome exato da coluna no banco
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("cpf")]
        public string Cpf { get; set; }

        [Column("dataNascimento")]
        public DateTime dataNascimento { get; set; }

        [Column("observacao")]
        public string Observacao { get; set; }

        [Column("senha")]
        public string Senha { get; set; }

        [Column("tipo_usuario")]
        public string TipoUsuario { get; set; } // 'cliente' ou 'funcionario'

        [Column("telefone")]
        public string Telefone { get; set; }

        [Column("data_cadastro")]
        public DateTime DataCadastro { get; set; } 
    }

}
