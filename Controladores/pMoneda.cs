using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Hemeroteca.Entidades;

namespace Hemeroteca.Controladores
{
    class pMoneda
    {
        public static void Insert(Moneda c)
        {
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Moneda(nombre) VALUES (@nombre)");
            cmd.Parameters.Add(new SQLiteParameter("@nombre", c.Nombre));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static void Update(Moneda c)
        {
            SQLiteCommand cmd = new SQLiteCommand("UPDATE Moneda SET nombre = @nombre where id = @id;");

            cmd.Parameters.Add(new SQLiteParameter("@nombre", c.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@id", c.Id));
            cmd.Connection = Conexion.Connection;

            cmd.ExecuteNonQuery();

        }

        public static void Delete(Moneda c)
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Moneda where id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", c.Id));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();

        }


        public static List<Moneda> GetAll()  //SELECT 
        {
            List<Moneda> monedas = new List<Moneda>();
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, nombre FROM Moneda;");
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                monedas.Add(new Moneda(obdr.GetInt32(0), obdr.GetString(1)));
            }
            return monedas;
        }

        public static Moneda GetById(int id)
        {
            Moneda c = new Moneda();
            Conexion.OpenConnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, nombre FROM Moneda where id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                c.Id = obdr.GetInt32(0);
                c.Nombre = obdr.GetString(1);
            }
            return c;
        }
    }
}
