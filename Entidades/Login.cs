using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemeroteca.Entidades
{
    public class Login
    {
        int id;
        string usuario;
        string clave;

        public Login()
        { }

        public Login(int id, string usuario, string clave)
        {
            this.id = id;
            this.usuario = usuario;
            this.clave = clave;
        }
        public int Id { get => id; set => id = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Clave { get => clave; set => clave = value; }
    }
}
