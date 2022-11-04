using System;

namespace Books
{
    class Documento {
        // Setteando parametros
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
        // añadiendo constructor
        public Documento() {
            Console.WriteLine("Estamos en la clase documento.");
        }

        // Definicion de funciones
        public void Mostrar() {
            Console.WriteLine("El autor es " + autor + ", lo escribió en " + localizacion + " y el titulo de la obra es " + titulo);
        }
   }
}