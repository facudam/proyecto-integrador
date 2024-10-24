
using System;

namespace resolucion.clases
{
	
	public class Libro
	{
		private int codigo;
		private string titulo, autor, editorial, estado, dniSocioPrestado;
		private int cantidadDeDiasDePrestamo;
		private DateTime fechaPrestamo, fechaDevolucion;
		
		public Libro(int codigo, string titulo, string autor, string editorial)
		{
			this.codigo = codigo;
			this.titulo = titulo;
			this.autor = autor;
			this.editorial = editorial;
			estado = "disponible"; // Todo libro al crearse está disponible.
			dniSocioPrestado = "0"; // Al crearse y estar libre es 0.
			cantidadDeDiasDePrestamo = 15;
			fechaPrestamo = DateTime.MinValue; // Inicializamos la fecha minima para indicar que está disponible.
			fechaDevolucion = DateTime.MinValue;
		}
		
		public int Codigo {
			get { return codigo; }
		}
		
		public string Titulo {
			get { return titulo; }
			set { titulo = value; }
		}
		
		public string Autor {
			get { return autor; }
			set { autor = value; }
		}
		
		public string Editorial {
			get { return editorial; }
			set { editorial = value; }
		}
		
		public string Estado {
			get { return estado; }
		}
		
		public string DniSocioPrestado {
			get { return dniSocioPrestado; }
		}
		
		public int CantidadDeDiasDePrestamo {
			get { return cantidadDeDiasDePrestamo; }
		}
		
		public DateTime FechaPrestamo {
			get { return fechaPrestamo; }
		}
		
		public DateTime FechaDevolucion {
			get { return fechaDevolucion; }
		}
		
		public bool estaDisponible() {
			return fechaPrestamo == DateTime.MinValue;
		}
		
		public void asignarLibroPrestado(string dni) {
			dniSocioPrestado = dni;
			fechaPrestamo = DateTime.Now;
			FechaDevolucion = fechaPrestamo.AddDays(cantidadDeDiasDePrestamo);
			estado = "prestado";
		}
		
		public void volverADisponible() {
			dniSocioPrestado = "0";
			fechaPrestamo = DateTime.MinValue;
			fechaDevolucion = DateTime.MinValue;
			estado = "disponible";
		}
	}
}
