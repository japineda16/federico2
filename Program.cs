using System;

namespace Books
{
    class Program {
        public static void Main(string[] args) 
        {
            // Seleccion multiple si el usuario desea agregar libros o bien articulos.
            Console.WriteLine("Seleccione 1 si desea agregar un libro, 2 si desea agregar un articulo");
            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                agregarLibros();
            }
            if (opcion == "2")
            {
                agregarArticulos();
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
                Console.WriteLine("Ingrese el titulo de la obra, seleccione 1 para cancelar o 2 para buscar alguna palabra");
                string titulo = Console.ReadLine();
                // Se valida el estado del formulario
                // Es decir, si se cancela el formulario, o si se continua.
                if (titulo == "1") {
                    break;
                }
                if (titulo == "2")
                {
                    BuscarLibros(l1);
                    break;
                }
                Console.WriteLine("Ingrese la ubicación de la obra");
                string ubicacion = Console.ReadLine();
                Console.WriteLine("Ingrese el autor de la obra");
                string autor = Console.ReadLine();
                // Se definen las propiedades de la clase.
                l1[i] = new Libros(autor, titulo, ubicacion);
                l1[i].Autor = autor;
                l1[i].Localizacion = ubicacion;
                l1[i].Titulo = titulo;
                l1[i].ToStringLibro(autor, ubicacion, titulo);
            }
        }
        // Definicion de funcion agregarArticulos, el cual tiene como tarea agregar y enseñar hasta un maximo de 50 articulos
        public static void agregarArticulos() {
            // se inicializa la clase y se le pasan los parametros de la clase Documento
            Articulo[] a1 = new Articulo[50];
            Console.WriteLine("Para detener la iteración, escriba 1 en todas las opciones");
            // Iteracion para llenar arreglo de libros
            for (int i = 0; i < 51; i++)
            {
                // Y se solicita los campos a conformar el arreglo de datos.
                Console.WriteLine("Ingrese el titulo del articulo");
                string procedencia = Console.ReadLine();
                // Se valida el estado del formulario
                // Es decir, si se cancela el formulario, o si se continua.
                if (procedencia == "1") {
                    break;
                }
                // Se definen las propiedades de la clase.
                a1[i] = new Articulo();
                a1[i].Procedencia = procedencia;
                a1[i].ToStringArticulo(procedencia);
            }
        }

        // Funcion para invocar la busqueda de strings
        public static void BuscarLibros(Libros[] libro) {
            Console.WriteLine("Por favor ingrese alguna palabra a buscar en el arreglo de datos.");
            string? texto = Console.ReadLine();
            int cuentas = 0;
            for (var i = 0; i <= libro.Length; i++)
            {
                bool? encontrar = Libros.Contiene(texto);
                if (encontrar == true) cuentas++;
            }
            if (cuentas > 0)
            {
                Console.WriteLine("Ha habido " + cuentas + " coincidencias.");
            }
            if (cuentas <= 0)
            {
                Console.WriteLine("No ha habido coincidencias");
            }
        }
   }
}