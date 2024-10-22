
using System;
using System.Collections;

namespace resolucion.clases
{
	
	public class Biblioteca
	{
		
		private ArrayList listaDeLibros, listaDeSocios;
		
		public Biblioteca()
		{
			listaDeLibros = new ArrayList();
			listaDeSocios = new ArrayList();
		}
		
		public ArrayList ListaDeLibros {
			get { return listaDeLibros; }
			set { listaDeLibros = value; }
		}
		
		public ArrayList ListaDeSocios {
			get { return listaDeSocios; }
			set { listaDeSocios = value; }
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
