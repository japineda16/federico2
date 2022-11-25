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

        public Boolean Contiene(string palabra) {
            if (palabra == procedencia)
            {
                return true;
            }
            return false;
        }
   }
}