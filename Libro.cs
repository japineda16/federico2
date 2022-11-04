using System;

namespace Books
{
    class Libros: Documento {
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