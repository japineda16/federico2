using System;

namespace Books
{
    class Articulo {
        // Setteando parametros
        // Los campos ahora son protegidos
        protected string procedencia = "";
        // Definiendo parametros
        public string Procedencia
        {
            get {
                return procedencia;
            }
            set {
                procedencia = value;
            }
        }

        // Funcion ToString, devuelve un string con la informacion del articulo
        public void ToString() {
            Console.WriteLine(procedencia);
        }
   }
}