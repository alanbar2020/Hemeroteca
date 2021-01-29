using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Hemeroteca.Entidades;


namespace Hemeroteca.Controladores
{
    class pStock
    {
        public static List<Stock> GetAll()
        {
            List<Stock> list = new List<Stock>();
            //creo el comando sql a utilizar
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, idRevista, cantidadExhibida, cantidadGuardada from STOCK;");
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                Revista ai = pRevista.GetById(obdr.GetInt32(1));
                Stock c = new Stock(obdr.GetInt32(0), ai, obdr.GetInt32(1), obdr.GetInt32(2));
                list.Add(c);

            }
            return list;


        }

        public static Stock GetbyId(int id)
        {
            Stock c = new Stock();
            //creo el comando sql a utilizar
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, idRevista, cantidadExhibida, cantidadGuardada from STOCK where id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();// Devuelve algo por eso se llama data reader
            //recorro el datareader

            while (obdr.Read())
            {
                // p = new Marca(obdr.GetInt32(0), obdr.GetString(1));

                Revista ai = pRevista.GetById(obdr.GetInt32(1));
                c.Id = obdr.GetInt32(0);
                c.Revista = ai;
                c.CantidadExhibida = obdr.GetInt32(2);
                c.CantidadGuardada = obdr.GetInt32(3);


            }
            return c;


        }

        public static void Update(Stock c, Revista r)
        {
            SQLiteCommand cmd = new SQLiteCommand("UPDATE STOCK SET idRevista = @idr, cantidadExhibdia = @cante, cantidadGuardada = @cantg where id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@cante", c.CantidadExhibida));
            cmd.Parameters.Add(new SQLiteParameter("@cantg", c.CantidadGuardada));
            cmd.Parameters.Add(new SQLiteParameter("@d", c.Id));
            cmd.Parameters.Add(new SQLiteParameter("@idr", r.Id));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;

            cmd.ExecuteNonQuery();// no devuevlve nada :)

        }

        public static void Save(Stock c, Revista r)
        {
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO STOCK (idRevista, cantidadExhibida, cantidadGuardada) VALUES (@idr, @cante, @cantg);");
            cmd.Parameters.Add(new SQLiteParameter("@cante", c.CantidadExhibida));
            cmd.Parameters.Add(new SQLiteParameter("@cantg", c.CantidadGuardada));
            cmd.Parameters.Add(new SQLiteParameter("@d", c.Id));
            cmd.Parameters.Add(new SQLiteParameter("@idr", r.Id));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;

            cmd.ExecuteNonQuery();// no devuevlve nada :)

        }

        public static void Delete(Stock c)
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM STOCK where id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", c.Id));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;

            cmd.ExecuteNonQuery();// no devuevlve nada :)

        }

        public static List<Stock> Buscar(string text)
        {
            List<Stock> list = new List<Stock>();
            //creo el comando sql a utilizar
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM STOCK INNER JOIN REVISTA on stock.id = revista.id where revista.titulo LIKE @texto + '%';");
            cmd.Parameters.Add(new SQLiteParameter("@texto", text));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                Revista ai = pRevista.GetById(obdr.GetInt32(1));
                Stock c = new Stock(obdr.GetInt32(0), ai, obdr.GetInt32(1), obdr.GetInt32(2));
                list.Add(c);

            }
            return list;


        }
    }
}

