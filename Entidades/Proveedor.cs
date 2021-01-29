using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemeroteca.Entidades
{
    public class Proveedor
    {
        int id;
        string nombre;
        long telefono;
        string email;
        string web;
        Direccion direccion;

       
        public Proveedor()
        {
          
        }

        public Proveedor(int id, string nombre, int telefono, string email, string web, Direccion direccion)
        {
            this.id = id;
            this.nombre = nombre;
            this.telefono = telefono;
            this.email = email;
            this.web = web;
            this.direccion = direccion;

        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public long Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public string Web { get => web; set => web = value; }
        public Direccion Direccion { get => direccion; set => direccion = value; }
    }
}
