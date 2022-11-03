using System;

namespace Books
{
    class Program {
        public static void Main(string[] args) 
        {
            Libros l1 = new Libros("Jose", "<Titulo del libro>", "Venezuela");
            l1.Autor = "Jose";
            l1.Localizacion = "Venezuela";
            l1.Titulo = "<Titulo del libro>";
            l1.Mostrar();
        }
   }
}