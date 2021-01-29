using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemeroteca.Entidades
{
    public class Ciudad
    {
        int id;
        string nombre;
        Provincia provincia;

        public Ciudad()
        { }

        public Ciudad(int id, string nombre, Provincia provincia)
        {
            this.id = id;
            this.nombre = nombre;
            this.provincia = provincia;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Provincia Provincia { get => provincia; set => provincia = value; }
    }
}
