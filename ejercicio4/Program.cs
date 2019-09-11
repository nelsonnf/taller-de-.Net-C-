/*
 * Creado por SharpDevelop.
 * Usuario: nelson nuñez
 * Fecha: 6/09/2019
 * Hora: 7:54 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio4
{
	class Program
	{
		public static void Main(string[] args)
		{
			double uniConsumo,carga=0,total=0;
			string cliente;
			
			Console.Write("Ingrese el nombre completo del cliente del cliente: ");
			cliente = Console.ReadLine();
			
			Console.Write("Ingrese la unudad de consumidos: ");
			uniConsumo=double.Parse(Console.ReadLine());
			
			if(uniConsumo<=199){
				carga=1.2;
				total=carga*uniConsumo;
				
			}else if(uniConsumo>=200 && uniConsumo<400){
			carga=1.5;
			total=carga*uniConsumo;
			
			} else if(uniConsumo>=400 && uniConsumo<600){
			carga=1.8;
			total=carga*uniConsumo;
			
			}else if(uniConsumo>=600){
			carga=2;
			total=carga*uniConsumo;
			
			}
			
			Console.WriteLine("el total de a pagar es: "+total);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}