using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hemeroteca.Entidades;
using System.Data.SQLite;
namespace Hemeroteca.Controladores
{
    class pTipoIngreso
    {
        public static List<TipoIngreso> GetAll()
        {
            List<TipoIngreso> list = new List<TipoIngreso>();
            //creo el comando sql a utilizar
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, Nombre from TIPOINGRESO;");
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {

                TipoIngreso c = new TipoIngreso(obdr.GetInt32(0), obdr.GetString(1));
                list.Add(c);

            }
            return list;


        }

        public static TipoIngreso GetbyId(int id)
        {
            TipoIngreso c = new TipoIngreso();
            //creo el comando sql a utilizar
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, Nombre from TIPOINGRESO where id = @id;");
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

        public static void Update(TipoIngreso c)
        {
            SQLiteCommand cmd = new SQLiteCommand("UPDATE TIPOINGRESO SET Nombre = @Nombre where id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@Nombre", c.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@id", c.Id));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;

            cmd.ExecuteNonQuery();// no devuevlve nada :)

        }

        public static void Save(TipoIngreso c)
        {
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO TIPOINGRESO (Nombre) VALUES (@Nombre);");
            cmd.Parameters.Add(new SQLiteParameter("@Nombre", c.Nombre));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;

            cmd.ExecuteNonQuery();// no devuevlve nada :)

        }

        public static void Delete(TipoIngreso c)
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM TIPOINGRESO where id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", c.Id));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;

            cmd.ExecuteNonQuery();// no devuevlve nada :)

        }

        public static List<TipoIngreso> Buscar(string text)
        {
            List<TipoIngreso> list = new List<TipoIngreso>();
            //creo el comando sql a utilizar
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM TIPOINGRESO WHERE nombre LIKE @texto + '%';");
            cmd.Parameters.Add(new SQLiteParameter("@texto", text));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {

                TipoIngreso c = new TipoIngreso(obdr.GetInt32(0), obdr.GetString(1));
                list.Add(c);

            }
            return list;


        }

    }
}
