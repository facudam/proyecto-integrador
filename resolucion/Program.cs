﻿
using System;
using resolucion.clases;
using System.Collections;
using resolucion.excepciones;

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
//					case "6":
//						devolverUnLibroDe_(biblioteca);
//						break;
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
			string titulo = "", nombreAutor = "", editorial = "";
			
			while(titulo.Trim().Length < 1) {
				try {
					Console.WriteLine("\nIngrese el título del libro.");
					titulo = Console.ReadLine();
					if (titulo.Trim().Length < 1) throw new EmptyValueException("El título no puede estar vacío o sólo contener espacios en blanco.");
				} catch(EmptyValueException e) {
					Console.WriteLine(e.Mensaje);
				}	
			}
				
			while(nombreAutor.Trim().Length < 1) {
				try {
					Console.WriteLine("Ingrese el nombre del autor");
					nombreAutor = Console.ReadLine();
					if (nombreAutor.Trim().Length < 1) throw new EmptyValueException("El nombre del autor no puede estar vacío o sólo contener espacios en blanco.");
				} catch(EmptyValueException e) {
					Console.WriteLine(e.Mensaje);
				}
			}
			
			while (editorial.Trim().Length < 1) {
				try {
					Console.WriteLine("Por último, ingrese el nombre de la editorial.");
					editorial = Console.ReadLine();
					if (editorial.Trim().Length < 1) throw new EmptyValueException("La editorial no puede estar vacía o sólo contener espacios en blanco.");
				} catch(EmptyValueException e) {
					Console.WriteLine(e.Mensaje);
				}	
			}
			
			Libro nuevoLibro = new Libro(codigoParaLibro, titulo, nombreAutor, editorial);
			unaBiblioteca.agregarLibro(nuevoLibro);
			Console.WriteLine("¡Se ha añadido el libro {0} correctamente. El código del libro es: {1}.", nuevoLibro.Titulo, nuevoLibro.Codigo);
			codigoParaLibro+= 1; // Incrementamos su valor para el próximo libro a ingresar.
		}
		
		
		public static void eliminarUnLibroDe_(Biblioteca biblioteca) {
			try {
				Console.WriteLine("Ingrese el código del libro");
				int codigo = int.Parse(Console.ReadLine());
				bool existeEseLibro = false;
				
				foreach(Libro unLibro in biblioteca.ListaDeLibros) {
					if (unLibro.Codigo == codigo) {
						if (unLibro.estaDisponible()) {
							biblioteca.eliminarUnLibro(unLibro);
							Console.WriteLine("El libro se ha eliminado exitosamente!");
						} else {
							Console.WriteLine("No se puede eliminar el libro porque se encuentra prestado a un socio.");
						}
						existeEseLibro = true;
						break;
					}
				}
				if (!existeEseLibro) Console.WriteLine("\nEl código ingresado no pertenece a un libro de la biblioteca.");
				
			} catch (FormatException e) {
				Console.WriteLine(e.Message);
			}
		}
		
		public static void ingresarNuevoSocioOLectorDeSalaEn_(Biblioteca biblioteca) {
			string dni = "", nombreCompleto = "", telefono = "", direccion = "";
			
			while (dni.Trim().Length < 1) {
				try {
					Console.WriteLine("\nIngrese el DNI de la persona a asociar.");
					dni = Console.ReadLine();
					if (dni.Trim().Length < 1) throw new EmptyValueException("El DNI no puede estar vacío o sólo contener espacios en blanco.");
				} catch(EmptyValueException e) {
					Console.WriteLine(e.Mensaje);
				}
			}
			
			while (nombreCompleto.Trim().Length < 1) {
				try {
					Console.WriteLine("Ingrese el nombre completo.");
					nombreCompleto = Console.ReadLine();
					if (nombreCompleto.Trim().Length < 1) throw new EmptyValueException("El nombre completo no puede estar vacío o sólo contener espacios en blanco.");
				} catch(EmptyValueException e) {
					Console.WriteLine(e.Mensaje);
				}
			}
			
			while (telefono.Trim().Length < 1) {
				try {
					Console.WriteLine("Ingrese el número de teléfono.");
					telefono = Console.ReadLine();
					if (telefono.Trim().Length < 1) throw new EmptyValueException("El teléfono no puede estar vacío o sólo contener espacios en blanco.");
				} catch(EmptyValueException e) {
					Console.WriteLine(e.Mensaje);
				}
			}
			
			while (direccion.Trim().Length < 1) {
				try {
					Console.WriteLine("Ingrese la dirección.");
					direccion = Console.ReadLine();
					if (direccion.Trim().Length < 1) throw new EmptyValueException("La dirección no puede estar vacía o sólo contener espacios en blanco.");
				} catch(EmptyValueException e) {
					Console.WriteLine(e.Mensaje);
				}
			}
			
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
		
		public static void eliminarSocioOLectorDeSalaEn_(Biblioteca biblioteca) {
			try {
				Console.WriteLine("Ingrese el DNI del socio a eliminar.");
				string dni = Console.ReadLine();
				if (dni.Trim().Length < 1) throw new EmptyValueException("El DNI no puede estar vacío o tener sólo espacios en blanco");
				
				bool existeElSocio = false;
				
				foreach(Socio unSocio in biblioteca.ListaDeSocios) {
					if (unSocio.Dni == dni) {
						if (unSocio.CantidadLibrosPrestados == 0) {
							biblioteca.eliminarUnSocio(unSocio);
							Console.WriteLine("Se ha eliminado el socio correctamente!");
						} else {
							Console.WriteLine("No se puede eliminar al socio ya que aún posee libros prestados.");
						}
						existeElSocio = true;
						break;
					}
				}
				if (!existeElSocio) Console.WriteLine("No se ha encontrado un socio con el dni ingresado.");
				
			} catch (EmptyValueException e) {
				Console.WriteLine(e.Mensaje);
			}
		}
		
		public static void prestarUnLibroDe_(Biblioteca biblioteca) {
			Console.WriteLine("\nIngrese la opción de desee:\n1- Prestar libro a socio lector.\n2- Prestar libro a lector de sala.\n3- Volver a menú principal.");
			string respuesta = Console.ReadLine();
			
			switch(respuesta) {
				case "1":
					prestarLibroASocioLectorEn_(biblioteca);
					break;
				case "2":
//					prestarLibroALectorDeSalaEN_(biblioteca);
					break;
				case "3":
					break;
				default:
					Console.WriteLine("La opción ingresada es incorrecta.");
					break;
			}
		}
		
		public static void prestarLibroASocioLectorEn_(Biblioteca biblioteca) {
			string dni = "";
			
			while (dni.Trim().Length < 1) {
				try {
					Console.WriteLine("\nIngrese el DNI del socio lector a quien se realizará el préstamo de un libro.");
					dni = Console.ReadLine();
					if (dni.Trim().Length < 1) throw new EmptyValueException("El DNI no puede estar vacío o tener sólo espacios vacíos.");
				} catch (EmptyValueException e) {
					Console.WriteLine(e.Mensaje);
				}
			}
			
			bool existeSocio = false;
			
			foreach(Socio socio in biblioteca.ListaDeSocios) {
				if (socio.Dni == dni) {
					existeSocio = true;
					try {
						if (socio.CantidadLibrosPrestados == 0) {
							Console.WriteLine("\nSocio habilitado para préstamo");
							prestarLibroDeBiblioteca_SiPudiereAlSocio_(biblioteca, socio);
						} else {
							throw new PrestamoNoPosibleException("\nEl socio ingresado no puede recibir más préstamos.");
							
						}
					} catch (PrestamoNoPosibleException e) {
						Console.WriteLine(e.Mensaje);
					}
					break;
				}
			}
			
			if (!existeSocio) {
				Console.WriteLine("El DNI ingresado no pertecence a un socio de la {0}", biblioteca.Nombre);
			}
			
		}
		
		
		
		public static void prestarLibroDeBiblioteca_SiPudiereAlSocio_(Biblioteca unaBiblioteca, Socio socio) {
			int codigoLibro;
			
			while (true) {
				try {
					Console.WriteLine("\nIngrese el código del libro a prestar.");
					codigoLibro = int.Parse(Console.ReadLine());
					break;
					
				} catch (FormatException e) {
					Console.WriteLine(e.Message);
				}
			}
			
			bool existeLibro = false;
			
			foreach(Libro libro in unaBiblioteca.ListaDeLibros) {
				if (libro.Codigo == codigoLibro) {
					try {
						if (libro.estaDisponible()) {
							libro.asignarLibroPrestado(socio.Dni);
							socio.incrementarCantidadDeLibros();
							Console.WriteLine("\nPréstamo realizado!");
						} else {
							throw new PrestamoNoPosibleException("El libro solicitado no está disponible para su préstamo.");
						}
					} catch (PrestamoNoPosibleException e) {
						Console.WriteLine(e.Mensaje);
					}
					existeLibro = true;
					break;
				}
			}
			if (!existeLibro) {
				Console.WriteLine("El código del libro solicitado no pertenece a un libro de la biblioteca.");
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