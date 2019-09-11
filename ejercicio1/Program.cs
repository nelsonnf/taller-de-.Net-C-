/*
 * Creado por SharpDevelop.
 * Usuario: nelson nuñez
 * Fecha: 6/09/2019
 * Hora: 12:27 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio1
{
	
	
	class Program
	{
		public static void Main(string[] args)
		{
			int num1,num2,result,select;
			
			Console.Write("digite un numero: ");
			num1=int.Parse(Console.ReadLine());
			
			Console.Write("digite un segundo numero: ");
			num2=int.Parse(Console.ReadLine());
			
			Console.WriteLine("las opciones son:\n"+"1 - Adicion.\n"+"2 - Sustraccion.\n"+"3 - Multiplicacion.\n"+"4 - Divicion.\n");
			
			Console.Write("Introduzca su eleccion: ");
			select=int.Parse(Console.ReadLine());
			
			
			if(select==1){
				result=num1+num2;
				Console.WriteLine("el resultado de: "+num1+" + "+num2+" = "+result);
			
			}else if(select==2){
				result=num1-num2;
				Console.WriteLine("el resultado de: "+num1+" - "+num2+" = "+result);
			
			}else if(select==3){
				result=num1*num2;
				Console.WriteLine("el resultado de: "+num1+" * "+num2+" = "+result);
			
			}else if(select==4){
				result=num1/num2;
				Console.WriteLine("el resultado de: "+num1+" / "+num2+" = "+result);
			
			}else{
				Console.WriteLine("la seleccion ingresada no existe");
			
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}