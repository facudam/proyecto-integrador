﻿using System;

namespace resolucion.excepciones
{
	
	public class EmptyValueException : Exception
	{
		private string mensaje;
		
		public EmptyValueException(string mensaje)
		{
			this.mensaje = mensaje;
		}
		
		public string Mensaje {
			get { return mensaje; }
		}
	}
}