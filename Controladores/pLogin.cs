using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hemeroteca.Entidades;
using System.Data.SQLite;


namespace Hemeroteca.Controladores
{
    class pLogin
    {
        public static List<Login> GetAll()
        {
            List<Login> login = new List<Login>();
            //creo el comando sql a utilizar
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, usuario, clave from LOGIN;");
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                Login c = new Login(obdr.GetInt32(0), obdr.GetString(1), obdr.GetString(2));
                login.Add(c);

            }
            return login;


        }

        public static Login GetbyId(int id)
        {
            Login c = new Login();
            //creo el comando sql a utilizar
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, usuario, clave from LOGIN where id = @id;");
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
                c.Usuario = obdr.GetString(1);
                c.Clave = obdr.GetString(2);


            }
            return c;


        }

        public static void Update(Login c)
        {
            SQLiteCommand cmd = new SQLiteCommand("UPDATE LOGIN SET usuario = @Usuario, clave= @clave where id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@Usuario", c.Usuario));
            cmd.Parameters.Add(new SQLiteParameter("@clave", c.Clave));
            cmd.Parameters.Add(new SQLiteParameter("@id", c.Id));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;

            cmd.ExecuteNonQuery();// no devuevlve nada :)

        }

        public static void Save(Login c)
        {
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO LOGIN (usuario, clave) VALUES (@Usuario, @Clave);");
            cmd.Parameters.Add(new SQLiteParameter("@Usuario", c.Usuario));
            cmd.Parameters.Add(new SQLiteParameter("@Clave", c.Clave));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;

            cmd.ExecuteNonQuery();// no devuevlve nada :)

        }

        public static void Delete(Login c)
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM LOGIN where id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", c.Id));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;

            cmd.ExecuteNonQuery();// no devuevlve nada :)

        }

        public static List<Login> Buscar(string text)
        {
            List<Login> login = new List<Login>();
            //creo el comando sql a utilizar
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM LOGIN WHERE usuario LIKE @texto + '%';");
            cmd.Parameters.Add(new SQLiteParameter("@texto", text));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                Login c = new Login(obdr.GetInt32(0), obdr.GetString(1), obdr.GetString(2));
                login.Add(c);

            }
            return login;


        }




    }
}
