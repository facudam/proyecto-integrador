
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
		
		public virtual void incrementarCantidadDeLibros() {
			if (cantidadLibrosPrestados == 0) cantidadLibrosPrestados += 1;
		}
		
		public virtual void decrementarCantidadDeLibros() {
			if (cantidadLibrosPrestados == 1) cantidadLibrosPrestados -= 1;
		}
	}
}
