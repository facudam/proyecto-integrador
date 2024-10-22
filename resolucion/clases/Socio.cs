
using System;

namespace resolucion.clases
{
	
	public class Socio
	{
		protected string dni, nombreCompleto, telefono, direccion;
		protected int cantidadLibrosPrestados;
		
		
		public Socio(string dni, string nombreCompleto, string telefono, string direccion)
		{
			this.dni = dni;
			this.nombreCompleto = nombreCompleto;
			this.telefono = telefono;
			this.direccion = direccion;
			cantidadLibrosPrestados = 0;
		}
		
		public string Dni {
			get { return dni; }
			set { dni = value; }
		}
		
		public string NombreCompleto {
			get { return nombreCompleto; }
			set { nombreCompleto = value; }
		}
		
		public string Telefono {
			get { return telefono; }
			set { telefono = value; }
		}
		
		public string Direccion {
			get { return direccion; }
			set { direccion = value; }
		}
		
		public int CantidadLibrosPrestados {
			get { return cantidadLibrosPrestados; }
		}
		
		public virtual void devolverLibro(Biblioteca biblioteca ,int codigoLibro) {
			foreach(Libro libro in biblioteca.ListaDeLibros) {
				if (libro.Codigo == codigoLibro) {
					libro.Estado = "disponible";
					libro.FechaPrestamo = DateTime.MinValue; // Establecemos el valor mínimo para referirnos que está disponible.
					libro.FechaDevolucion = DateTime.MinValue;
					cantidadLibrosPrestados = 0; // El socio al devolver el libro vuelve a tener 0 librosPrestados.
					break;
				}
			}
		}
	}
}
