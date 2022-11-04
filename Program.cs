using System;

namespace Books
{
    class Program {
        public static void Main(string[] args) 
        {
            // se inicializa la clase y se le pasan los parametros de la clase Libro
            Libros l1 = new Libros("Jose", "<Titulo del libro>", "Venezuela");
            // Se definen las propiedades de la clase libro.
            l1.Autor = "Jose";
            l1.Localizacion = "Venezuela";
            l1.Titulo = "<Titulo del libro>";
            // se invoca la funcion mostrar de la case usando el objeto l1.
            l1.Mostrar();
        }
   }
}