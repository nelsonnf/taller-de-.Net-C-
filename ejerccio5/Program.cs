/*
 * Creado por SharpDevelop.
 * Usuario: nelson nuñez
 * Fecha: 10/09/2019
 * Hora: 8:49 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejerccio5
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			string caracter;
			
			Console.WriteLine("ingrese un caracter");
			caracter=Console.ReadLine();
			
			if(caracter=="a"||caracter=="A"||caracter=="e"||caracter=="E"||caracter=="i"||caracter=="I"||caracter=="o"||caracter=="O"||caracter=="u"||caracter=="U"){
			
				Console.WriteLine("el caracter ingresado es una vocal");
			
			} else{
			
				Console.WriteLine("el caracter ingresado es una consonante ");
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}