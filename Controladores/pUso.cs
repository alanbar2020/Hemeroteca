using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Hemeroteca.Entidades;

namespace Hemeroteca.Controladores
{
    class pUso
    {

        public static void Insert(Uso u)
        {
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO USOREVISTA(idRevista, fecha, cantidad) VALUES (@idRevista, @fecha, @cantidad)");
            cmd.Parameters.Add(new SQLiteParameter("@idRevista", u.Revista.Id));
            cmd.Parameters.Add(new SQLiteParameter("@fecha", u.Fecha));
            cmd.Parameters.Add(new SQLiteParameter("@cantidad", u.Cantidad));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static void Update(Uso u)
        {

            SQLiteCommand cmd = new SQLiteCommand("UPDATE USOREVISTA SET idRevista= @idRevista, fecha= @fecha, cantidad=@cantidad WHERE id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@idRevista", u.Revista.Id));
            cmd.Parameters.Add(new SQLiteParameter("@fecha", u.Fecha));
            cmd.Parameters.Add(new SQLiteParameter("@cantidad", u.Cantidad));
            cmd.Parameters.Add(new SQLiteParameter("@id", u.Id));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static void Delete(Uso u)
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM USOREVISTA where id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", u.Id));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();

        }

        public static Uso GetById(int id)
        {
            Uso u = new Uso();
            Conexion.OpenConnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, idRevista, fecha, cantidad FROM USOREVISTA WHERE id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                u.Id = obdr.GetInt32(0);
                u.Revista = pRevista.GetById(obdr.GetInt32(1));
                u.Fecha = obdr.GetDateTime(2);
                u.Cantidad = obdr.GetInt32(3);
            }
            return u;

        }

        public static List<Uso> GetAll()  //SELECT 
        {
            List<Uso> usos = new List<Uso>();
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, idRevista, fecha, cantidad FROM USOREVISTA;");
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                usos.Add(new Uso(obdr.GetInt32(0), pRevista.GetById(1), obdr.GetDateTime(2), obdr.GetInt32(3)));
            }
            return usos;
        }





    }
}
