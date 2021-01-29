using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Hemeroteca.Entidades;

namespace Hemeroteca.Controladores
{
    class pProveedor
    {
        public static void Insert(Proveedor p)
        {
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO PROVEEDOR(nombre, telefono, email, direccionWeb, idDireccion) VALUES (@nombre, @telefono, @email, @direccionWeb, @idDireccion)");
            cmd.Parameters.Add(new SQLiteParameter("@nombre", p.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@telefono", p.Telefono));
            cmd.Parameters.Add(new SQLiteParameter("@email", p.Email));
            cmd.Parameters.Add(new SQLiteParameter("@direccionWeb", p.Web));
            cmd.Parameters.Add(new SQLiteParameter("@idDireccion", p.Direccion.Id));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static void Updated(Proveedor p)
        {
            SQLiteCommand cmd = new SQLiteCommand("UPDATE PROVEEDOR SET nombre = @nombre, telefono = @telefono, email = @email, direccionWeb = @direccionWeb, idDireccion=@idDireccion WHERE id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@nombre", p.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@telefono", p.Telefono));
            cmd.Parameters.Add(new SQLiteParameter("@email", p.Email));
            cmd.Parameters.Add(new SQLiteParameter("@direccionWeb", p.Web));
            cmd.Parameters.Add(new SQLiteParameter("@idDireccion", p.Direccion.Id));
            cmd.Parameters.Add(new SQLiteParameter("@id", p.Id));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }
        public static void Delete(Proveedor p)
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM PROVEEDOR where id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", p.Id));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static Proveedor GetById(int id)
        {
            Proveedor p = new Proveedor();
            Conexion.OpenConnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, nombre, telefono, email, direccionWeb, idDireccion FROM PROVEEDOR WHERE id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                p.Id = obdr.GetInt32(0);
                p.Nombre = obdr.GetString(1);
                p.Telefono = obdr.GetInt32(2);
                p.Email = obdr.GetString(3);
                p.Web = obdr.GetString(4);
                p.Direccion = pDireccion.GetById(obdr.GetInt32(5));
            }
            return p;

        }

        public static List<Proveedor> GetAll()  //SELECT 
        {
            List<Proveedor> proveedores = new List<Proveedor>();
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, nombre, telefono, email, direccionWeb, idDireccion FROM PROVEEDOR;");
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                proveedores.Add(new Proveedor(obdr.GetInt32(0), obdr.GetString(1), obdr.GetInt32(2), obdr.GetString(3), obdr.GetString(4), pDireccion.GetById(5)));
            }
            return proveedores;
        }
    }
}
