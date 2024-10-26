
using System;
using System.Collections;

namespace resolucion.clases
{
	
	public class LectorDeSala: Socio
	{
		private ArrayList listaLibrosPedidosEnSala;
		
		public LectorDeSala(string dni, string nombreCompleto, string telefono, string direccion): base(dni, nombreCompleto, telefono, direccion)
		{
			listaLibrosPedidosEnSala = new ArrayList();
		}
		
		public ArrayList ListaLibrosPedidosEnSala {
			get { return listaLibrosPedidosEnSala; }
		}
		
		public void agregarLibroALista(Libro unLibro) {
			listaLibrosPedidosEnSala.Add(unLibro);
		}
		
		public void quitarLibroDeLista(Libro unLibro) {
			listaLibrosPedidosEnSala.Remove(unLibro);
		}
		
		public override void incrementarCantidadDeLibros() {
			cantidadLibrosPrestados += 1;
		}
		
		public override void decrementarCantidadDeLibros() {
			if (cantidadLibrosPrestados > 0) cantidadLibrosPrestados -= 1;
		}
	}
}
