using System;

namespace resolucion.excepciones
{
	
	public class PrestamoNoPosibleException: Exception
	{
		private string mensaje;
		
		public PrestamoNoPosibleException(string mensaje)
		{
			this.mensaje = mensaje;
		}
		
		public string Mensaje {
			get { return mensaje; }
		}
	}
}
