using System;

namespace Books
{
    class Documento {
        // Setteando parametros
        // Los campos ahora son protegidos
        protected string autor = "";
        protected string titulo = "";
        protected string localizacion = "";
        // Definiendo parametros
        public string Autor
        {
            get {
                return autor;
            }
            set {
                autor = value;
            }
        }
        public string Titulo
        {
            get {
                return titulo;
            }
            set {
                titulo = value;
            }
        }
        public string Localizacion
        {
            get {
                return localizacion;
            }
            set {
                localizacion = value;
            }
        }
        // Definicion de funciones
        // Funcion mostrar, devuelve el autor, localizacion y titulo del documento
        public void Mostrar() {
            Console.WriteLine("El autor es " + autor + ", lo escribió en " + localizacion + " y el titulo de la obra es " + titulo);
        }

        // Funcion ToString, devuelve un string con la informacion del documento
        public void ToString() {
            Console.WriteLine(autor + " - " + localizacion + " - " + titulo);
        }
   }
}