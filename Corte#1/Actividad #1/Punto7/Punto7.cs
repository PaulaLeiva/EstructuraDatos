using System;
//Autor:María Paula Leiva Agudelo
//Jornada:Diurna 
//Grupo:239-2a
class Punto7
{
static void Main(string[] args)

 {
 int a,b,c;
 Console.Write("Bienvenido a control de ventas");

 Console.Write("Por favor ingrese el numero de ventas de A ");
 a = int.Parse(Console.ReadLine());
 Console.Write("Por favor ingrese el numero de ventas de B ");
 b = int.Parse(Console.ReadLine());
 Console.Write("Por favor ingrese el numero de ventas de C ");
 c = int.Parse(Console.ReadLine());
 if (a>b && a>c)
 Console.WriteLine("Las ventas del producto A son las más elevadas.");
 if (a>200 && b>200 && c>200)
 Console.WriteLine("Ningún producto tiene unas ventas inferiores a 200.")
;
 if (a<400 || b<400 || c<400)
 Console.WriteLine("Algún producto tiene unas ventas superiores a 400.");
 if ((a+b+c)/3>=500)
 Console.WriteLine("La media de ventas es superior a 500.");
 if (b<a && b<c)
 Console.WriteLine("El producto B no es el más vendido.");
 if((a+b+c)>=500 || (a+b+c)<=1000 )
 Console.WriteLine("El total de ventas esta entre 500 y 1000.");

 }
}

