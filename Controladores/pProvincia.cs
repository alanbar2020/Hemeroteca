using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hemeroteca.Entidades;
using System.Data.SQLite;


namespace Hemeroteca.Controladores
{
    class pProvincia
    {
        public static void Insert(Provincia p)
        {
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO PROVINCIA(nombre, idPais) VALUES (@nombre, @idPais)");
            cmd.Parameters.Add(new SQLiteParameter("@nombre", p.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@idPais", p.Pais.Id));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static void Update(Provincia p)
        {

            SQLiteCommand cmd = new SQLiteCommand("UPDATE PROVINCIA SET nombre = @nombre, idPais = @idPais WHERE id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@nombre", p.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@idPais", p.Pais.Id));
            cmd.Parameters.Add(new SQLiteParameter("@id", p.Id));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static void Delete(Provincia p)
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM PROVINCIA where id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", p.Id));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();

        }

        public static Provincia GetById(int id)
        {
            Provincia p = new Provincia();
            Conexion.OpenConnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, nombre, idPais FROM PROVINCIA WHERE id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                p.Id = obdr.GetInt32(0);
                p.Nombre = obdr.GetString(1);
                p.Pais = pPais.GetById(obdr.GetInt32(2));
            }
            return p;

        }

        public static List<Provincia> GetAll()  //SELECT 
        {
            List<Provincia> provincias = new List<Provincia>();
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, nombre, idPais FROM PROVINCIA;");
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                provincias.Add(new Provincia(obdr.GetInt32(0), obdr.GetString(1), pPais.GetById(2)));
            }
            return provincias;
        }



    }
}
