using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagLogIntelligence.Domain.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Role { get; set; }


        public Usuario Get(string Login, string Senha)
        {
            List<Usuario> usuarios = new List<Usuario>()
            {
                new Usuario (){ID =1, Login ="tiago@email.com",Senha ="tiago", Nome = "Tiago", Role= "Usuario"},
                new Usuario (){ID =2, Login ="sergio@email.com",Senha ="sergio", Nome = "Sergio", Role= "Admin"}
            };
            return usuarios.Find(x => x.Login == Login && x.Senha == Senha);

        }
    }
}
