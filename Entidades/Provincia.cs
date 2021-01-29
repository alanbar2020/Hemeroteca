using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemeroteca.Entidades
{
    public class Provincia
    {
        int id;
        string nombre;
        Pais pais;

        public Provincia()
        { }

        public Provincia(int id, string nombre, Pais pais)
        {
            this.id = id;
            this.nombre = nombre;
            this.pais = pais;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre= value; }
        public Pais Pais { get => pais; set => pais = value; }
    }
}
