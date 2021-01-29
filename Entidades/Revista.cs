using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemeroteca.Entidades
{
    public class Revista
    {
        int id;
        string titulo;
        string autor;
        string tema;
        string editor;
        string descripcion;
        string area;
        int edicion;
        string tituloanterior;
        string otrainfo;
        Direccion direccion;
        string anotaciones;
        DateTime fecha;
        string fondolocal;

        public Revista()
        { }
        

        public Revista(int id, string titulo, string autor, string tema, string editor, string descripcion, string area, int edicion, string tituloanterior, string otrainfo, Direccion direccion, string anotaciones, DateTime fecha, string fondolocal)
        {
            this.id = id;
            this.titulo = titulo;
            this.autor = autor;
            this.tema = tema;
            this.editor = editor;
            this.descripcion = descripcion;
            this.area = area;
            this.edicion = edicion;
            this.tituloanterior = tituloanterior;
            this.otrainfo = otrainfo;
            this.direccion = direccion;
            this.anotaciones = anotaciones;
            this.fecha = fecha;
            this.fondolocal = fondolocal;
            
        }

        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Tema { get => tema; set => tema = value; }
        public string Editor { get => editor; set => editor = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Area { get => area; set => area = value; }
        public int Edicion { get => edicion; set => edicion = value; }
        public string Tituloanterior { get => tituloanterior; set => tituloanterior = value; }
        public string Otrainfo { get => otrainfo; set => otrainfo = value; }
        public string Anotaciones { get => anotaciones; set => anotaciones = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Direccion Direccion { get => direccion; set => direccion = value; }
        public string FondoLocal { get => fondolocal; set => fondolocal = value; }
    }
}
