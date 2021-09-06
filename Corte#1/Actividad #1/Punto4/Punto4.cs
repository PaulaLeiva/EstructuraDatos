using System;
//Autor:María Paula Leiva Agudelo
//Jornada:Diurna 
//Grupo:239-2a

class Punto4
{
	static void Main(string[] args)
	{
		
		Console.WriteLine("¡Bienvenido, en este programa podrá cumplir la congetura de Collatz!");
		int C,c;

		    Console.WriteLine("Porfavor Escriba un número: ");
		    C = int.Parse(Console.ReadLine());
		    c=C;

		    if (C == 1)
			{
				Console.WriteLine("No se puede llevar a cabo la conjetura Collatz cuando el valor inicial es 1");
				System.Console.ReadLine();
			}
		    else
			{
				 Console.WriteLine("La conjetura de Collatz es: ");
                    System.Console.ReadLine();
				
				while (c > 1) 
					
				{
				if (c % 2 == 0)
					
					
				{
					c = (c / 2);
					Console.WriteLine("" + c);
					System.Console.ReadLine();
				}
				else
				{
					c = (c * 3) + 1;
					Console.WriteLine("" + c);
				}
				}
				
			}
					
			
		
	}
}