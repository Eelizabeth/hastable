using System;

namespace practica
{
  class Principal
	{
		public static void Main (string[] args)
		{
			Programa programa = new Programa();
			programa.capturar();
			Console.Clear();
			programa.editar();
			Console.Clear();
			programa.eliminar();
			Console.Clear();
			programa.imprimirTodos();
		}
	}
}

