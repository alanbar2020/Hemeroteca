using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemeroteca.Entidades
{
    public class Uso
    {
        int id;
        Revista revista;
        DateTime fecha;
        int cantidad;

        public Uso()
        { }

        public Uso(int id, Revista revista, DateTime fecha, int cantidad)
        {
            this.id = id;
            this.revista = revista;
            this.fecha = fecha;
            this.cantidad = cantidad;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public Revista Revista { get => revista; set => revista = value; }
    }
}
