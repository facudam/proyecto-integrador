
using System;

namespace resolucion.clases
{
	
	public class Libro
	{
		private int codigo;
		private string titulo, autor, editorial, estado, dniSocioPrestado;
		private DateTime fechaPrestamo, fechaDevolucion;
		
		public Libro(int codigo, string titulo, string autor, string editorial, string estado, string dniSocioPrestado, DateTime fechaPrestamo, DateTime fechaDevolucion)
		{
			this.codigo = codigo;
			this.titulo = titulo;
			this.autor = autor;
			this.editorial = editorial;
			this.estado = estado;
			this.dniSocioPrestado = dniSocioPrestado;
			this.fechaPrestamo = fechaPrestamo;
			this.fechaDevolucion = fechaDevolucion;
		}
		
		public int Codigo {
			get { return codigo; }
			set { codigo = value; }
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
			set { estado = value; }
		}
		
		public string DniSocioPrestado {
			get { return dniSocioPrestado; }
			set { dniSocioPrestado = value; }
		}
		
		public DateTime FechaPrestamo {
			get { return fechaPrestamo; }
			set { fechaPrestamo = value; }
		}
		
		public DateTime FechaDevolucion {
			get { return fechaDevolucion; }
			set { fechaDevolucion = value; }
		}
	}
}
