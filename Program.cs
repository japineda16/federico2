using System;

namespace Books
{
    class Program {
        public static void Main(string[] args) 
        {
            agregarLibros();
        }
        public static void agregarLibros() {
            // se inicializa la clase y se le pasan los parametros de la clase Libro
            Libros[] l1 = new Libros[50];
            Console.WriteLine("Para detener la iteración, deje sin rellenar el formulario en curso.");
            // Iteracion para llenar arreglo de libros
            for (int i = 0; i < 51; i++)
            {
                // Y se solicita los campos a conformar el arreglo de datos.
                Console.WriteLine("Ingrese el titulo de la obra");
                string titulo = Console.ReadLine();
                Console.WriteLine("Ingrese la ubicación de la obra");
                string ubicacion = Console.ReadLine();
                Console.WriteLine("Ingrese el autor de la obra");
                string autor = Console.ReadLine();
                // Se valida el estado del formulario
                // Es decir, si se cancela el formulario, o si se continua.
                if (titulo.Length == 0 || ubicacion.Length == 0 || autor.Length == 0) {
                    break;
                }
                // Se definen las propiedades de la clase.
                l1[i] = new Libros(autor, titulo, ubicacion);
                l1[i].Autor = autor;
                l1[i].Localizacion = ubicacion;
                l1[i].Titulo = titulo;
                l1[i].Mostrar();
            }
        }
   }
}