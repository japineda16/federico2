﻿using System;

namespace Books
{
    class Program {
        public static void Main(string[] args) 
        {
            // Creando la instancia libros por primera vez, definiendo sus campos
            Libros l1 = new Libros();
            l1.Autor = "Jose";
            l1.Localizacion = "Venecozuela";
            l1.Titulo = "Sexo";
            l1.Mostrar();
        }
   }
}