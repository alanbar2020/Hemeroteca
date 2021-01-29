using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hemeroteca.Entidades;
using System.Data.SQLite;
namespace Hemeroteca.Controladores
{
    class pFacultad
    {
        public static List<Facultad> GetAll()
        {
            List<Facultad> facultad = new List<Facultad>();
            //creo el comando sql a utilizar
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, nombre from FACULTAD;");
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                Facultad c = new Facultad(obdr.GetInt32(0), obdr.GetString(1));
                facultad.Add(c);

            }
            return facultad;


        }

        public static Facultad GetbyId(int id)
        {
            Facultad c = new Facultad();
            //creo el comando sql a utilizar
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, nombre from FACULTAD where id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();// Devuelve algo por eso se llama data reader
            //recorro el datareader

            while (obdr.Read())
            {
                // p = new Marca(obdr.GetInt32(0), obdr.GetString(1));
                c.Id = obdr.GetInt32(0);
                c.Nombre = obdr.GetString(1);



            }
            return c;


        }

        public static void Update(Facultad c)
        {
            SQLiteCommand cmd = new SQLiteCommand("UPDATE FACULTAD SET nombre = @nombre where id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@nombre", c.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@id", c.Id));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;

            cmd.ExecuteNonQuery();// no devuevlve nada :)

        }

        public static void Save(Facultad c)
        {
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO FACULTAD (nombre) VALUES (@nombre);");
            cmd.Parameters.Add(new SQLiteParameter("@nombre", c.Nombre));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;

            cmd.ExecuteNonQuery();// no devuevlve nada :)

        }

        public static void Delete(Facultad c)
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM FACULTAD where id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", c.Id));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;

            cmd.ExecuteNonQuery();// no devuevlve nada :)

        }

        public static List<Facultad> Buscar(string text)
        {
            List<Facultad> facultad = new List<Facultad>();
            //creo el comando sql a utilizar
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM FACULTAD WHERE nombre LIKE @texto + '%';");
            cmd.Parameters.Add(new SQLiteParameter("@texto", text));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                Facultad c = new Facultad(obdr.GetInt32(0), obdr.GetString(1));
                facultad.Add(c);

            }
            return facultad;


        }
    }
}
