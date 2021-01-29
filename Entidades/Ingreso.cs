using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemeroteca.Entidades
{
    public class Ingreso
    {
        int id;
        DateTime fecha;
        int cantidad;
        AtributosIngreso atributoingreso;
        Proveedor proveedor;
        Revista revista;


        public Ingreso()
        { }

        public Ingreso(int id, AtributosIngreso atributoingreso, DateTime fecha, Revista revista, Proveedor proveedor, int cantidad)
        {
            this.id = id;
            this.fecha = fecha;
            this.cantidad = cantidad;
            this.proveedor = proveedor;
            this.revista = revista;
            this.atributoingreso = atributoingreso;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public Proveedor Proveedor { get => proveedor; set => proveedor = value; }
        public Revista Revista { get => revista; set => revista = value; }
        public AtributosIngreso Atributoingreso { get => atributoingreso; set => atributoingreso = value; }


    }
}
