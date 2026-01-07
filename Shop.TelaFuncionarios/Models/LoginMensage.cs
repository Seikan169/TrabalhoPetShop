using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.TelaFuncionarios.Models
{
    public class LoginMensage
    {
        public string Username { get; set; } // Ou "Email", depende de como está na sua API
        public string Password { get; set; }
    }
}
