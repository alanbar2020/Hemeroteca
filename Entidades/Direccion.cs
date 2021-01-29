using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemeroteca.Entidades
{
    public class Direccion
    {
        int id;
        string calle;
        int numero;
        int dpto;
        int codigopostal;
        Ciudad ciudad;

        public Direccion()
        { }

        public Direccion(int id, string calle, int numero, int dpto, int codigopostal, Ciudad ciudad)
        {
            this.id = id;
            this.calle = calle;
            this.numero = numero;
            this.dpto = dpto;
            this.codigopostal = codigopostal;
            this.ciudad = ciudad;
        }

        public int Id { get => id; set => id = value; }
        public string Calle { get => calle; set => calle = value; }
        public int Numero { get => numero; set => numero = value; }
        public int Dpto { get => dpto; set => dpto = value; }
        public int Codigopostal { get => codigopostal; set => codigopostal = value; }
        public Ciudad Ciudad { get => ciudad; set => ciudad = value; }
    }
}
