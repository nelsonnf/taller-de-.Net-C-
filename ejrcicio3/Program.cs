/*
 * Creado por SharpDevelop.
 * Usuario: nelson nuñez
 * Fecha: 6/09/2019
 * Hora: 1:51 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejrcicio3
{
	class Program
	{
		public static void Main(string[] args)
		{
			int numMes;
			
			
			Console.WriteLine("ingrese el numero de mes: ");
			numMes=int.Parse(Console.ReadLine());
			
			
			if (numMes==1){
			
				Console.WriteLine("el mes de Enero tiene 31 dias");
			}else if (numMes==2){
			
				Console.WriteLine("el mes de febrero tiene 28 dias");
			}else if (numMes==3){
			
				Console.WriteLine("el mes de Marzo tiene 30 dias");
			}else if (numMes==4){
			
				Console.WriteLine("el mes de Abril tiene 30 dias");
			}else if (numMes==5){
			
				Console.WriteLine("el mes de Mayo tiene 31 dias");
			}else if (numMes==6){
			
				Console.WriteLine("el mes de Junio tiene 30 dias");
			}else if (numMes==7){
			
				Console.WriteLine("el mes de Julio tiene 31 dias");
			}else if (numMes==8){
			
				Console.WriteLine("el mes de Agosto tiene 31 dias");
			}else if (numMes==9){
			
				Console.WriteLine("el mes de Septiembre tiene 30 dias");
			}else if (numMes==10){
			
				Console.WriteLine("el mes de Octubre tiene 31 dias");
			}else if (numMes==11){
			
				Console.WriteLine("el mes de Noviembre tiene 30 dias");
			}else if (numMes==12){
			
				Console.WriteLine("el mes de Diciembre tiene 31 dias");
			}
			
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}