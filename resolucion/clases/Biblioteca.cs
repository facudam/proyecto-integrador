
using System;
using System.Collections;

namespace resolucion.clases
{
	
	public class Biblioteca
	{
		private string nombre, direccion;
		private ArrayList listaDeLibros, listaDeSocios;
		
		public Biblioteca(string nombre, string direccion)
		{
			this.nombre = nombre;
			this.direccion = direccion;
			listaDeLibros = new ArrayList();
			listaDeSocios = new ArrayList();
		}
		
		public string Nombre {
			get { return nombre; }
			set { nombre = value; }
		}
		
		public string Direccion {
			get { return direccion; }
			set { direccion = value; }
		}
		
		public ArrayList ListaDeLibros {
			get { return listaDeLibros; }
		}
		
		public ArrayList ListaDeSocios {
			get { return listaDeSocios; }
		}
		
		public void agregarLibro(Libro unLibro) {
			listaDeLibros.Add(unLibro);
		}
		
		public void eliminarUnLibro(Libro unLibro) {
			listaDeLibros.Remove(unLibro);
		}
		
		public void agregarUnSocio(Socio unSocio) {
			listaDeSocios.Add(unSocio);
		}
		
		public void eliminarUnSocio(Socio unSocio) {
			listaDeSocios.Remove(unSocio);
		}	
		
	}
}
