/*
 * Creado por SharpDevelop.
 * Usuario: nelson nuñez
 * Fecha: 6/09/2019
 * Hora: 1:28 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio2
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			double opcion,bases,altura,radio,area=0;
			
			
			Console.WriteLine("Digoite 1 para el area del circulo.\n"+"Digite 2 para el el area de rectangulo\n"+"Digite 3 para el area del triangulo\n");
			
			Console.Write("Digite su opcion: ");
			opcion=double.Parse(Console.ReadLine());
		     
			if(opcion==1){
				
				Console.Write("Ingrese el radio del circulo: ");
				radio=double.Parse(Console.ReadLine());
				
				area= (System.Math.PI)*(radio*radio);
			     
			}else if(opcion==2){
				Console.Write("ingrese la base del rectangulo: ");
				bases=double.Parse(Console.ReadLine());
				Console.Write("ingrese la altura del rectangulo: ");
				altura=double.Parse(Console.ReadLine());
				
				area= bases*altura;
			}else if(opcion==3){
			
				Console.Write("ingrese la base del triangulo: ");
				bases=double.Parse(Console.ReadLine());
				
				Console.Write("ingrese la altura del triangulo: ");
				altura=double.Parse(Console.ReadLine());
			
			}
			
			Console.WriteLine("el arae es: "+area);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}