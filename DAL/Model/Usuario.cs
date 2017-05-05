using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Usuario
    {
        public int CodUsuario { get; set; }// ficar de olho aqui.
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
