using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Hemeroteca.Entidades;

namespace Hemeroteca.Controladores
{
    class pCiudad
    {
        public static void Insert(Ciudad c)
        {
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO CIUDAD(nombre, idProvincia) VALUES (@nombre, @idProvincia)");
            cmd.Parameters.Add(new SQLiteParameter("@nombre", c.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@idProvincia", c.Provincia.Id));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }


        public static void Update(Ciudad c)
        {

            SQLiteCommand cmd = new SQLiteCommand("UPDATE CIUDAD SET nombre = @nombre, idProvincia = @idProvincia WHERE id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@nombre", c.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@idProvincia", c.Provincia.Id));
            cmd.Parameters.Add(new SQLiteParameter("@id", c.Id));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static void Delete(Ciudad c)
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM CIUDAD where id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", c.Id));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();

        }

        public static Ciudad GetById(int id)
        {
            Ciudad c = new Ciudad();
            Conexion.OpenConnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, nombre, idProvincia FROM CIUDAD WHERE id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                c.Id = obdr.GetInt32(0);
                c.Nombre = obdr.GetString(1);
                c.Provincia = pProvincia.GetById(obdr.GetInt32(2));
            }
            return c;

        }

        public static List<Ciudad> GetAll()  //SELECT 
        {
            List<Ciudad> ciudades = new List<Ciudad>();
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, nombre, idProvincia FROM CIUDAD;");
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                ciudades.Add(new Ciudad(obdr.GetInt32(0), obdr.GetString(1), pProvincia.GetById(2)));
            }
            return ciudades;
        }



    }
}
