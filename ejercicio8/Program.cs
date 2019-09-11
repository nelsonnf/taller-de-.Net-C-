/*
 * Creado por SharpDevelop.
 * Usuario: nelson nuñez
 * Fecha: 10/09/2019
 * Hora: 9:38 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio8
{
	class Program
	{
		public static void Main(string[] args)
		{
			double costo_art,descuento=0;
			
			
			Console.WriteLine("ingrese el costo del erticulo");
			costo_art=double.Parse(Console.ReadLine());
			
			if(costo_art>=200){
				descuento=costo_art*0.15;
				
			}else if(costo_art>=100 && costo_art<200){
				descuento=costo_art*0.12;
			
			} else if(costo_art<100){
			descuento=costo_art*0.10;
			
			}
			Console.WriteLine("el descuento del articulo es de: "+descuento);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}