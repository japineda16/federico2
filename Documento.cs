using System;

namespace Books
{
    class Documento {
        // Funcion ToString, devuelve un string con la informacion del libro
        public void ToStringLibro(string autor, string localizacion, string titulo) {
            Console.WriteLine(autor + " - " + localizacion + " - " + titulo);
        }
        // Funcion ToString, devuelve un string con la informacion del articulo
        public void ToStringArticulo(string procedencia) {
            Console.WriteLine(procedencia);
        }
   }
}