using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Hemeroteca.Entidades;

namespace Hemeroteca.Controladores
{
    class pPais
    {
        public static void Insert(Pais p)
        {
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO PAIS(nombre, idContinente) VALUES (@nombre, @idContinente)");
            cmd.Parameters.Add(new SQLiteParameter("@nombre", p.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@idContinente", p.Continente.Id));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static void Update(Pais p)
        {

            SQLiteCommand cmd = new SQLiteCommand("UPDATE PAIS SET nombre = @nombre, idContinente = @idContinente WHERE id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@nombre", p.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@idContinente", p.Continente.Id));
            cmd.Parameters.Add(new SQLiteParameter("@id", p.Id));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static void Delete(Pais p)
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM PAIS where id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", p.Id));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();

        }

        public static Pais GetById(int id)
        {
            Pais p = new Pais();
            Conexion.OpenConnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, nombre, idContinente FROM PAIS WHERE id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                p.Id = obdr.GetInt32(0);
                p.Nombre = obdr.GetString(1);
                p.Continente = pContinente.GetById(obdr.GetInt32(2));
            }
            return p;

        }
        public static List<Pais> GetAll()  //SELECT 
        {
            List<Pais> paises = new List<Pais>();
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, nombre, idContinente FROM PAIS;");
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                paises.Add(new Pais(obdr.GetInt32(0), obdr.GetString(1), pContinente.GetById(2)));
            }
            return paises;
        }

        


    }
}
