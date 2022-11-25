using System;

namespace Books
{
    class Program {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Seleccione 1 si desea agregar un libro, 2 si desea agregar un documento");
            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                agregarLibros();
            }
            if (opcion == "2")
            {
                agregarDocumentos();
            }
            if (opcion != "2" && opcion != "1")
            {
               Console.WriteLine("Ninguna de las opciones fue valida, vuelva a intentarlo"); 
            }
        }
        // Definicion de funcion agregarLibros, el cual tiene como tarea agregar y enseñar hasta un maximo de 50 libros
        public static void agregarLibros() {
            // se inicializa la clase y se le pasan los parametros de la clase Libro
            Libros[] l1 = new Libros[50];
            Console.WriteLine("Para detener la iteración, escriba 1 en todas las opciones");
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
                if (titulo == "1" || ubicacion == "1" || autor == "1") {
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
        // Definicion de funcion agregarDocumentos, el cual tiene como tarea agregar y enseñar hasta un maximo de 50 documentos
        public static void agregarDocumentos() {
            // se inicializa la clase y se le pasan los parametros de la clase Documento
            Documento[] d1 = new Documento[50];
            Console.WriteLine("Para detener la iteración, escriba 1 en todas las opciones");
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
                if (titulo == "1" || ubicacion == "1" || autor == "1") {
                    break;
                }
                // Se definen las propiedades de la clase.
                d1[i] = new Documento();
                d1[i].Autor = autor;
                d1[i].Localizacion = ubicacion;
                d1[i].Titulo = titulo;
                d1[i].Mostrar();
            }
        }
   }
}