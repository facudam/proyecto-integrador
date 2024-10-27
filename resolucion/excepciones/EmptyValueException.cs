using System;

namespace resolucion.excepciones
{
	
	public class EmptyValueException : Exception
	{
		public string mensaje;
		
		public EmptyValueException(string mensaje)
		{
			this.mensaje = mensaje;
		}
	}
}