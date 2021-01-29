using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Hemeroteca.Entidades;

namespace Hemeroteca.Controladores
{
    class pRevista
    {
        public static void Insert(Revista r)
        {
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO REVISTA(titulo, autor, tema, editor, descripcion, area, edicion, tituloAnterior, fecha, idDireccionPublicacion, anotaciones, otraInfo, fondoLocal) VALUES (@titulo, @autor, @tema, @editor, @descripcion, @area, @edicion, @tituloAnterior, @fecha, @idDireccionPublicacion, @anotaciones, @otraInfo, @fondoLocal)");
            cmd.Parameters.Add(new SQLiteParameter("@titulo", r.Titulo));
            cmd.Parameters.Add(new SQLiteParameter("@autor", r.Autor));
            cmd.Parameters.Add(new SQLiteParameter("@tema", r.Tema));
            cmd.Parameters.Add(new SQLiteParameter("@editor", r.Editor));
            cmd.Parameters.Add(new SQLiteParameter("@tituloAnterior", r.Tituloanterior));
            cmd.Parameters.Add(new SQLiteParameter("@fecha", r.Fecha));
            cmd.Parameters.Add(new SQLiteParameter("@idDireccionPublicacion", r.Direccion.Id));
            cmd.Parameters.Add(new SQLiteParameter("@anotaciones", r.Anotaciones));
            cmd.Parameters.Add(new SQLiteParameter("@otraInfo", r.Otrainfo));
            cmd.Parameters.Add(new SQLiteParameter("@fondoLocal", r.FondoLocal));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static void Update(Revista r)
        {

            SQLiteCommand cmd = new SQLiteCommand("UPDATE REVISTA SET titulo = @titulo, autor=@autor, tema=@tema, editor=@editor, descripcion=@descripcion, area=@area, edicion=@edicion, tituloAnterior=@tituloAnterior, fecha=@fecha, idDireccionPublicacion= @idDireccionPublicacion, anotaciones=@anotaciones, otraInfo=@otraInfo, fondoLocal=@fondoLocal WHERE id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@titulo", r.Titulo));
            cmd.Parameters.Add(new SQLiteParameter("@autor", r.Autor));
            cmd.Parameters.Add(new SQLiteParameter("@tema", r.Tema));
            cmd.Parameters.Add(new SQLiteParameter("@editor", r.Editor));
            cmd.Parameters.Add(new SQLiteParameter("@descripcion", r.Descripcion));
            cmd.Parameters.Add(new SQLiteParameter("@area", r.Area));
            cmd.Parameters.Add(new SQLiteParameter("@edicion", r.Edicion));
            cmd.Parameters.Add(new SQLiteParameter("@tituloAnterior", r.Tituloanterior));
            cmd.Parameters.Add(new SQLiteParameter("@fecha", r.Fecha));
            cmd.Parameters.Add(new SQLiteParameter("@idDireccionPublicacion", r.Direccion.Id));
            cmd.Parameters.Add(new SQLiteParameter("@anotaciones", r.Anotaciones));
            cmd.Parameters.Add(new SQLiteParameter("@otraInfo", r.Otrainfo));
            cmd.Parameters.Add(new SQLiteParameter("@fondoLocal", r.FondoLocal));
            cmd.Parameters.Add(new SQLiteParameter("@id", r.Id));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static void Delete(Revista r)
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM REVISTA where id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", r.Id));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();

        }

        public static List<Revista> GetAll()  //SELECT 
        {
            List<Revista> revistas = new List<Revista>();
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, titulo, autor, tema, editor, descripcion, area, edicion, tituloAnterior, otraInfo, idDireccionPublicacion, anotaciones, fondoLocal fecha FROM REVISTA;");
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                revistas.Add(new Revista(obdr.GetInt32(0), obdr.GetString(1), obdr.GetString(2), obdr.GetString(3), obdr.GetString(4), obdr.GetString(5), obdr.GetString(6), obdr.GetInt32(7), obdr.GetString(8), obdr.GetString(9), pDireccion.GetById(10), obdr.GetString(11), obdr.GetDateTime(12), obdr.GetString(13)));
            }
            return revistas;
        }
        public static Revista GetById(int id)
        {
            Revista r = new Revista();
            Conexion.OpenConnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, titulo, autor, tema, editor, descripcion, area, edicion, tituloAnterior, fecha, idDireccionPublicacion, anotaciones, otraInfo, fondoLocal FROM REVISTA WHERE id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                r.Id = obdr.GetInt32(0);
                r.Titulo = obdr.GetString(1);
                r.Autor = obdr.GetString(2);
                r.Tema = obdr.GetString(3);
                r.Editor = obdr.GetString(4);
                r.Descripcion = obdr.GetString(5);
                r.Area = obdr.GetString(6);
                r.Edicion = obdr.GetInt32(7);
                r.Tituloanterior = obdr.GetString(8);
                r.Fecha = obdr.GetDateTime(9);
                r.Direccion = pDireccion.GetById(obdr.GetInt32(10));
                r.Anotaciones = obdr.GetString(11);
                r.Otrainfo = obdr.GetString(12);
                r.FondoLocal = obdr.GetString(13);
            }
            return r;

        }

    }
}
