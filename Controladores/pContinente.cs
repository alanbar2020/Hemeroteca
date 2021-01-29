using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Hemeroteca.Entidades;


namespace Hemeroteca.Controladores
{
    class pContinente
    {
        public static void Insert(Continente c)
        {
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO CONTINENTE(nombre) VALUES (@nombre)");
            cmd.Parameters.Add(new SQLiteParameter("@nombre", c.Nombre));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static void Update(Continente c)
        {
            SQLiteCommand cmd = new SQLiteCommand("UPDATE CONTINENTE SET nombre = @nombre where id = @id;");

            cmd.Parameters.Add(new SQLiteParameter("@nombre", c.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@id", c.Id));
            cmd.Connection = Conexion.Connection;

            cmd.ExecuteNonQuery();

        }

        public static void Delete(Continente c)
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM CONTINENTE where id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", c.Id));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();

        }


        public static List<Continente> GetAll()  //SELECT 
        {
            List<Continente> continentes = new List<Continente>();
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, nombre FROM CONTINENTE;");
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                continentes.Add(new Continente(obdr.GetInt32(0), obdr.GetString(1)));
            }
            return continentes;
        }

        public static Continente GetById(int id)
        {
            Continente c = new Continente();
            Conexion.OpenConnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, nombre FROM CONTINENTE where id = @id;");
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
