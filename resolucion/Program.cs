
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
			
			while (continuarEligiendoUnaOpcion) {
				
				Console.WriteLine("\nElija una opción:\n1- Agregar un nuevo libro.\n2- Eliminar un libro.\n3- Ingresar nuevo socio o lector de sala. \n4- Dar de bajar a un socio o lector.\n5- Prestar un libro.\n6- Devolver un libro.\n7- Solicitar información de la biblioteca.\n8- Salir.");
				string respuesta = Console.ReadLine();
				
				switch(respuesta) {
					case "1":
						agregarUnLibroEn_ConCodigoBase_(biblioteca, ref codigoBase);
						break;
					case "2":
						eliminarUnLibroDe_(biblioteca);
						break;
					case "3":
						ingresarNuevoSocioOLectorDeSalaEn_(biblioteca);
						break;
					case "4":
						eliminarSocioOLectorDeSalaEn_(biblioteca);
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
						Console.WriteLine("\nPor favor, ingrese una opción correcta.");
						break;
				}
			};
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void agregarUnLibroEn_ConCodigoBase_(Biblioteca unaBiblioteca, ref int codigoParaLibro) {
			Console.WriteLine("\nIngrese el título del libro.");
			string titulo = Console.ReadLine();
			Console.WriteLine("Ingrese el nombre del autor");
			string nombreAutor = Console.ReadLine();
			Console.WriteLine("Por último, ingrese el nombre de la editorial.");
			string editorial = Console.ReadLine();
			Libro nuevoLibro = new Libro(codigoParaLibro, titulo, nombreAutor, editorial);
			unaBiblioteca.agregarLibro(nuevoLibro);
			Console.WriteLine("¡Se ha añadido el libro {0} correctamente. El código del libro es: {1}.", nuevoLibro.Titulo, nuevoLibro.Codigo);
			codigoParaLibro+= 1; // Incrementamos su valor para el próximo libro a ingresar.
		}
		
		public static void ingresarNuevoSocioOLectorDeSalaEn_(Biblioteca biblioteca) {
			Console.WriteLine("\nIngrese el DNI de la persona a asociar.");
			string dni = Console.ReadLine();
			Console.WriteLine("Ingrese el nombre completo.");
			string nombreCompleto = Console.ReadLine();
			Console.WriteLine("Ingrese el número de teléfono.");
			string telefono = Console.ReadLine();
			Console.WriteLine("Ingrese la dirección.");
			string direccion = Console.ReadLine();
			
			Console.WriteLine("Y finalmente, elija el tipo de socio que será:\n1- Ingresarlo como nuevo socio lector.\n2- Ingresarlo como nuevo lector de sala.\n3- Volver a menú principal.");
			string opcionElegida = Console.ReadLine();
			
			switch(opcionElegida) {
				case "1":
					Socio nuevoSocio = new Socio(dni, nombreCompleto, telefono, direccion);
					biblioteca.agregarUnSocio(nuevoSocio);
					Console.WriteLine("\nEl socio {0} ha sido añadido exitosamente!", nuevoSocio.NombreCompleto);
					break;
				case "2":
					LectorDeSala nuevoLectorDeSala = new LectorDeSala(dni, nombreCompleto, telefono, direccion);
					biblioteca.agregarUnSocio(nuevoLectorDeSala);
					Console.WriteLine("\nEl lector de sala {0} ha sido añadido exitosamente!", nuevoLectorDeSala.NombreCompleto);
					break;
				case "3":
					break; // No hay mensaje, solo termina y vuelve al menú principal.
				default:
					Console.WriteLine("La opción elegida es incorrecta.");
					break;
			}
		}
		
		public static void imprimirSubmenuDe_(Biblioteca biblioteca) {
			Console.WriteLine("Ingrese la opción de desee:\n1- Ver lista de libros prestados.\n2- Ver lista de libros de la biblioteca.\n3- Ver lista de socios de la biblioteca.\n4- Volver a menú principal.");
			string respuesta = Console.ReadLine();
			
			switch(respuesta) {
				case "1":
					listarLibrosPrestadosDe_(biblioteca);
					break;
				case "2":
					listarLibrosDe_(biblioteca);
					break;
				case "3":
					listarSociosDe_(biblioteca);
					break;
				case "4":
					break;
				default:
					Console.WriteLine("La opción ingresada es incorrecta.");
					break;
			}
		}
		
		public static void listarLibrosPrestadosDe_(Biblioteca biblioteca) {
			Console.WriteLine("\nLista de libros prestados:");
			int cantidadLibrosPrestados = 0;
			
			foreach(Libro unLibro in biblioteca.ListaDeLibros) {
				if (!unLibro.estaDisponible()) {
					Console.WriteLine("Titulo: {0}, autor: {1}, fecha de devolución: {2}", unLibro.Titulo, unLibro.Autor, unLibro.FechaDevolucion);
					cantidadLibrosPrestados += 1; // Para controlar si no hay libros prestados aún.
				}
			}
			if (cantidadLibrosPrestados == 0) Console.WriteLine("Aún no hay libros prestados.");
		}
		
		public static void listarLibrosDe_(Biblioteca biblioteca) {
			Console.WriteLine("\nLista de libros de la biblioteca:");
			foreach(Libro unLibro in biblioteca.ListaDeLibros) {
				Console.WriteLine("Titulo: {0}, autor: {1}, editorial: {2}", unLibro.Titulo, unLibro.Autor, unLibro.Editorial);
			}
			
			if (biblioteca.ListaDeLibros.Count == 0) Console.WriteLine("Aún no hay libros en la biblioteca.");
		}
		
		public static void listarSociosDe_(Biblioteca unaBiblioteca) {
			Console.WriteLine("Lista de socios de la biblioteca:");
			
			foreach(Socio unSocio in unaBiblioteca.ListaDeSocios) {
				Console.WriteLine("Nombre completo: {0}, DNI: {1}, dirección: {2}.", unSocio.NombreCompleto, unSocio.Dni, unSocio.Direccion);
			}
			
			if (unaBiblioteca.ListaDeSocios.Count == 0) Console.WriteLine("Aún no hay socios ingresados en la biblioteca.");
		}
	}
}