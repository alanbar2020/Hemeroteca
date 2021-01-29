using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Hemeroteca.Entidades;

namespace Hemeroteca.Controladores
{
    class pAtributosIngreso
    {
        public static void Insert(AtributosIngreso a)
        {
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO ATRIBUTOSINGRESO(idFormaDePago, fechaInicial, fechaDeCierre, idMoneda, year, costo, costoEnvio, observaciones) VALUES (@idFormaDePago, @fechaInicial, @fechaDeCierre, @idMoneda, @year, @costo, @costoEnvio, @observaciones)");
            cmd.Parameters.Add(new SQLiteParameter("@idFormaDePago", a.Formadepago.Id));
            cmd.Parameters.Add(new SQLiteParameter("@fechaInicial", a.Fechainicial));
            cmd.Parameters.Add(new SQLiteParameter("@fechaDeCierre", a.Fechacierre));
            cmd.Parameters.Add(new SQLiteParameter("@idMoneda", a.Moneda.Id));
            cmd.Parameters.Add(new SQLiteParameter("@year", a.Year));
            cmd.Parameters.Add(new SQLiteParameter("@costo", a.Costo));
            cmd.Parameters.Add(new SQLiteParameter("@costoEnvio", a.Costoenvio));
            cmd.Parameters.Add(new SQLiteParameter("@observaciones", a.Observaciones));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static void Update(AtributosIngreso a)
        {

            SQLiteCommand cmd = new SQLiteCommand("UPDATE ATRIBUTOSINGRESO SET idFormaDePago = @idFormaDePago, fechaInicial=@fechaInicial, fechaDeCierre=@fechaDeCierre, idMoneda=@idMoneda, year=@year, costo=@costo, costoEnvio=@costoEnvio, observaciones=@observaciones WHERE id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@idFormaDePago", a.Formadepago.Id));
            cmd.Parameters.Add(new SQLiteParameter("@fechaInicial", a.Fechainicial));
            cmd.Parameters.Add(new SQLiteParameter("@fechaDeCierre", a.Fechacierre));
            cmd.Parameters.Add(new SQLiteParameter("@idMoneda", a.Moneda.Id));
            cmd.Parameters.Add(new SQLiteParameter("@year", a.Year));
            cmd.Parameters.Add(new SQLiteParameter("@costo", a.Costo));
            cmd.Parameters.Add(new SQLiteParameter("@costoEnvio", a.Costoenvio));
            cmd.Parameters.Add(new SQLiteParameter("@observaciones", a.Observaciones));
            cmd.Parameters.Add(new SQLiteParameter("@id", a.Id));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static void Delete(AtributosIngreso a)
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM ATRIBUTOSINGRESO where id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", a.Id));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();

        }

        public static List<AtributosIngreso> GetAll()  //SELECT 
        {
            List<AtributosIngreso> atributosIngresos = new List<AtributosIngreso>();
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, idFormaDePago, fechaInicial, fechaDeCierre, idMoneda, year, costo, costoEnvio, observaciones FROM ATRIBUTOSINGRESO;");
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                atributosIngresos.Add(new AtributosIngreso(obdr.GetInt32(0), pFormaDePago.GetById(1), obdr.GetDateTime(2), obdr.GetDateTime(3), pMoneda.GetById(4), obdr.GetDateTime(5), obdr.GetDouble(6), obdr.GetDouble(7), obdr.GetString(7)));
            }
            return atributosIngresos;
        }
        public static AtributosIngreso GetById(int id)
        {
            AtributosIngreso a = new AtributosIngreso();
            Conexion.OpenConnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, idFormaDePago, fechaInicial, fechaDeCierre, idMoneda, year, costo, costoEnvio, observaciones FROM ATRIBUTOSINGRESO WHERE id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                a.Id = obdr.GetInt32(0);
                a.Formadepago = pFormaDePago.GetById(obdr.GetInt32(1));
                a.Fechainicial = obdr.GetDateTime(2);
                a.Fechacierre = obdr.GetDateTime(3);
                a.Moneda = pMoneda.GetById(obdr.GetInt32(4));
                a.Year = obdr.GetDateTime(5);
                a.Costo = obdr.GetDouble(6);
                a.Costoenvio = obdr.GetDouble(7);
                a.Observaciones = obdr.GetString(8);
            }
            return a;

        }
    }
}
