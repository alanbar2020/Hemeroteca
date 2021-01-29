using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hemeroteca.Entidades;
using System.Data.SQLite;
using System.Data;


namespace Hemeroteca.Controladores
{
    class pIngreso
    {
        public static List<Ingreso> GetAll()
        {
            List<Ingreso> ingreso = new List<Ingreso>();
            //creo el comando sql a utiliza
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, idAtributoIngreso, fecha, idRevista, idProveedor, Cantidad from INGRESO;");
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                AtributosIngreso ti = pAtributosIngreso.GetById(obdr.GetInt32(1));
                Revista r = pRevista.GetById(obdr.GetInt32(3));
                Proveedor p = pProveedor.GetById(obdr.GetInt32(4));
                Ingreso c = new Ingreso(obdr.GetInt32(0), ti, obdr.GetDateTime(2), r, p, obdr.GetInt32(5));
                ingreso.Add(c);

            }
            return ingreso;


        }

        public static Ingreso GetbyId(int id)
        {
            Ingreso c = new Ingreso();
            //creo el comando sql a utilizar
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, idAtributoIngreso, fecha, idRevista, idProveedor, Cantidad from INGRESO where id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();// Devuelve algo por eso se llama data reader
            //recorro el datareader

            while (obdr.Read())
            {
                AtributosIngreso ti = pAtributosIngreso.GetById(obdr.GetInt32(1));
                Revista r = pRevista.GetById(obdr.GetInt32(3));
                Proveedor p = pProveedor.GetById(obdr.GetInt32(4));
                // p = new Marca(obdr.GetInt32(0), obdr.GetString(1));
                c.Id = obdr.GetInt32(0);
                c.Atributoingreso = ti;
                c.Fecha = obdr.GetDateTime(2);
                c.Revista = r;
                c.Proveedor = p;
                c.Cantidad = obdr.GetInt32(5);



            }
            return c;


        }

        public static void Update(Ingreso c, AtributosIngreso ti, Revista r, Proveedor p)
        {
            SQLiteCommand cmd = new SQLiteCommand("UPDATE INGRESO SET idAtributoIngreso = @idti, Fecha = @fecha, idRevista = @idr, idProveedor = @idp, Cantidad = @cant where id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", c.Id));
            cmd.Parameters.Add(new SQLiteParameter("@idti", ti.Id));
            cmd.Parameters.Add(new SQLiteParameter("@fecha", c.Fecha));
            cmd.Parameters.Add(new SQLiteParameter("@idr", r.Id));
            cmd.Parameters.Add(new SQLiteParameter("@idp", p.Id));
            cmd.Parameters.Add(new SQLiteParameter("@cant", c.Cantidad));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;

            cmd.ExecuteNonQuery();// no devuevlve nada :)

        }

        public static void Save(Ingreso c, AtributosIngreso ti, Revista r, Proveedor p)
        {
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO INGRESO (idAtributoIngreso, Fecha, IdRevista, idProveedor, Cantidad) VALUES (@idti, @fecha, @idr, @idp, @cant);");
            cmd.Parameters.Add(new SQLiteParameter("@idti", ti.Id));
            cmd.Parameters.Add(new SQLiteParameter("@fecha", c.Fecha));
            cmd.Parameters.Add(new SQLiteParameter("@idr", r.Id));
            cmd.Parameters.Add(new SQLiteParameter("@idp", p.Id));
            cmd.Parameters.Add(new SQLiteParameter("@cant", c.Cantidad));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;

            cmd.ExecuteNonQuery();// no devuevlve nada :)

        }

        public static void Delete(Ingreso c)
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM INGRESO where id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", c.Id));

            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;

            cmd.ExecuteNonQuery();// no devuevlve nada :)

        }



        public static List<Ingreso> Buscar(string text)
        {
            List<Ingreso> ingreso = new List<Ingreso>();
            //creo el comando sql a utiliza
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM INGRESO WHERE fecha LIKE @texto + '%';");
            cmd.Parameters.Add(new SQLiteParameter("@texto", text));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                AtributosIngreso ti = pAtributosIngreso.GetById(obdr.GetInt32(1));
                Revista r = pRevista.GetById(obdr.GetInt32(3));
                Proveedor p = pProveedor.GetById(obdr.GetInt32(4));
                Ingreso c = new Ingreso(obdr.GetInt32(0), ti, obdr.GetDateTime(2), r, p, obdr.GetInt32(5));
                ingreso.Add(c);

            }
            return ingreso;


        }


    }
}
