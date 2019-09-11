/*
 * Creado por SharpDevelop.
 * Usuario: nelson nuñez
 * Fecha: 10/09/2019
 * Hora: 9:25 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio7
{
	class Program
	{
		public static void Main(string[] args)
		{
			double num1,num2,num3;
			Console.Write("ingrese numero 1: ");
			num1=double.Parse(Console.ReadLine());
			
			Console.Write("ingrese numero 2: ");
			num2=double.Parse(Console.ReadLine());
			
			Console.Write("ingrese numero 3: ");
			num3=double.Parse(Console.ReadLine());
			
			if(num1>num2||num1>num3){
			
				Console.Write("el numero mayor es: "+num1);
			
			}else if(num2>num1||num2>num3){
				
			Console.Write("el numero mayor es: "+num2);
			
			}else if(num3>num1||num3>num2){
			
			Console.Write("el numero mayor es: "+num3);
			}
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}