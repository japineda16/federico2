using System;

namespace Books
{
    class Libros: Documento {

        // Setteando parametros
        // Los campos ahora son protegidos
        protected string autor = "";
        protected string titulo = "";
        protected string localizacion = "";
        protected string paginas = "";
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
        public string Paginas
        {
            get {
                return paginas;
            }
            set {
                paginas = value;
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
        // Funcion mostrar, devuelve el autor, localizacion y titulo del libro
        public void Mostrar() {
            Console.WriteLine("El autor es " + autor + ", lo escribió en " + localizacion + " y el titulo de la obra es " + titulo);
        }

        public Boolean Contiene(string palabra) {
            if (palabra == autor || palabra == titulo)
            {
                return true;
            }
            return false;
        }

        // Migrada todas las instrucciones a la clase documento
        // Ahora la clase libro heredara todas las funcionalidades de la clase
        // documento
        
        // Se define el constructor de la clase y se le pasa los parametros del constructor.
        public Libros(string autor, string titulo) {

        }
        // Añadida el segundo constructor con el parametro por de fecto de localización
        // Para evitar un error de compilado tuvo que eliminarse del primero constructor el parametro
        // de localización.
        public Libros(string titulo, string autor, string localizacion = "no detallada" ) {

        }
   }
}