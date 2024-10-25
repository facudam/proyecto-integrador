
using System;
using resolucion.clases;
using System.Collections;

namespace resolucion
{
	class Program
	{
		public static void Main(string[] args)
		{
			Libro nuevoLibro = new Libro(1, "Cien años de soledad", "Gabriel García Márquez", "Editorial Sudamericana");
			Libro otroLibro = new Libro(2, "El amor en los tiempos del cólera", "Gabriel García Márquez", "Editorial Oveja Negra");
			Libro tercerLibro = new Libro(3,"Don Quijote de la Mancha", "Miguel de Cervantes", "Alfaguara");
			Libro cuartoLibro = new Libro(4, "Los miserables", "Victor Hugo", "G. Charpentier");
			
			Biblioteca biblioteca = new Biblioteca("Biblioteca Nacional Mariano Moreno", "Agüero 2502, C1425EID, Ciudad Autónoma de Buenos Aires, Argentina.");
			
			biblioteca.agregarLibro(nuevoLibro);
			biblioteca.agregarLibro(otroLibro);
			biblioteca.agregarLibro(tercerLibro);
			biblioteca.agregarLibro(cuartoLibro);
			
			bool continuarEligiendoUnaOpcion = true;
			int codigoBase = 5;
			
			do {
				
				Console.WriteLine("\nElija una opción:\n1- Agregar un nuevo libro.\n2- Eliminar un libro.\n3- Ingresar nuevo socio o lector. \n4- Dar de bajar a un socio o lector.\n5- Prestar un libro.\n6- Devolver un libro.\n7- Solicitar información de la biblioteca.\n8- Salir.");
				string respuesta = Console.ReadLine();
				
				switch(respuesta) {
					case "1":
						agregarUnLibroEn_ConCodigoBase_(biblioteca, ref codigoBase);
						break;
					case "2":
						eliminarUnLibroDe_(biblioteca);
						break;
					case "3":
						ingresarNuevoSocioOLectorEn_(biblioteca);
						break;
					case "4":
						eliminarSocioOLectorDe_(biblioteca);
						break;
					case "5":
						prestarUnLibroDe_(biblioteca);
						break;
					case "6":
						devolverUnLibroDe_(biblioteca);
						break;
					case "7":
						imprimirSubmenuDe_(biblioteca);
						break;
					case "8":
						continuarEligiendoUnaOpcion = false;
						Console.WriteLine("Muchas gracias por haber usado nuestro sistema.");
						break;
					default:
						Console.WriteLine("Por favor, ingrese una opción correcta.");
						break;
				}
				
			} while (continuarEligiendoUnaOpcion);
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void agregarUnLibroEn_ConCodigoBase_(Biblioteca unaBiblioteca, ref int codigoParaLibro) {
			
		}
	}
}