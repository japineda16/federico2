using System;

namespace Books
{
    class Articulo: Documento {
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
   }
}