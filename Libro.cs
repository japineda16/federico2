using System;

namespace Books
{
    class Libros {
        // Setteando parametros
        public string autor = "";
        public string titulo = "";
        public string localizacion = "";
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
        public void Mostrar() {
            Console.WriteLine("El autor es " + autor + ", lo escribió en " + localizacion + " y el titulo de la obra es " + titulo);
        }
   }
}