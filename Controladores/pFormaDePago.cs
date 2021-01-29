using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Hemeroteca.Entidades;

namespace Hemeroteca.Controladores
{
    class pFormaDePago
    {
        public static void Insert(FormaDePago f)
        {
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO FORMADEPAGO(nombre) VALUES (@nombre)");
            cmd.Parameters.Add(new SQLiteParameter("@nombre", f.Nombre));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static void Update(FormaDePago f)
        {
            SQLiteCommand cmd = new SQLiteCommand("UPDATE FORMADEPAGO SET nombre = @nombre where id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@nombre", f.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@id", f.Id));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();

        }

        public static void Delete(FormaDePago f)
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM FORMADEPAGO where id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", f.Id));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static List<FormaDePago> GetAll()  //SELECT 
        {
            List<FormaDePago> formaDePagos = new List<FormaDePago>();
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, nombre FROM FORMADEPAGO;");
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                formaDePagos.Add(new FormaDePago(obdr.GetInt32(0), obdr.GetString(1)));
            }
            return formaDePagos;
        }

        public static FormaDePago GetById(int id)
        {
            FormaDePago f = new FormaDePago();
            Conexion.OpenConnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, nombre FROM FORMADEPAGO where id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                f.Id = obdr.GetInt32(0);
                f.Nombre = obdr.GetString(1);
            }
            return f;
        }
    }
}
