using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemeroteca.Entidades
{
    public class Pais
    {
        int id;
        string nombre;
        Continente continente;

        public Pais()
        { }

        public Pais(int id, string nombre, Continente continente)
        {
            this.id = id;
            this.nombre = nombre;
            this.continente = continente;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Continente Continente { get => continente; set => continente = value; }
    }
}
