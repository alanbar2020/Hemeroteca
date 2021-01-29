using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemeroteca.Entidades
{
    public class Stock
    {
        int id;
        Revista revista;
        int cantidadExhibida;
        int cantidadGuardada;

        public Stock()
        { }

        public Stock(int id, Revista revista, int cantidadExhibida, int cantidadGuardada)
        {
            this.id = id;
            this.revista = revista;
            this.cantidadExhibida = cantidadExhibida;
            this.cantidadGuardada = cantidadGuardada;
        }

        public int Id { get => id; set => id = value; }
        public int CantidadExhibida { get => cantidadExhibida; set => cantidadExhibida = value; }
        public int CantidadGuardada { get => cantidadGuardada; set => cantidadGuardada = value; }
        public Revista Revista { get => revista; set => revista = value; }
    }
}
