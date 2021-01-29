using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemeroteca.Entidades
{
   public class AtributosIngreso
    {
        int id;
        FormaDePago formadepago;
        DateTime fechainicial;
        DateTime fechacierre;
        Moneda moneda;
        DateTime year;
        double costo;
        double costoenvio;
        string observaciones;

        public AtributosIngreso()
        {
        }

        public AtributosIngreso(int id, FormaDePago formadepago, DateTime fechainicial, DateTime fechacierre, Moneda moneda, DateTime year, double costo, double costoenvio, string observaciones)
        {
            this.id = id;
            this.formadepago = formadepago;
            this.fechainicial = fechainicial;
            this.fechacierre = fechacierre;
            this.moneda = moneda;
            this.year = year;
            this.costo = costo;
            this.costoenvio = costoenvio;
            this.observaciones = observaciones;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Fechainicial { get => fechainicial; set => fechainicial = value; }
        public DateTime Fechacierre { get => fechacierre; set => fechacierre = value; }
        public DateTime Year { get => year; set => year = value; }
        public double Costo { get => costo; set => costo = value; }
        public double Costoenvio { get => costoenvio; set => costoenvio = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public FormaDePago Formadepago { get => formadepago; set => formadepago = value; }
        public Moneda Moneda { get => moneda; set => moneda = value; }
    }
}
