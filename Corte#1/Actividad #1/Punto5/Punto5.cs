using System;
//Autor:María Paula Leiva Agudelo
//Jornada:Diurna 
//Grupo:239-2a
namespace Punto1
{
    class Punto1
    {
        static void Main(string[] args)
        {
          double num= 0;
          double raiz= 0;
          string val= "";

          Console.WriteLine("Bienvenido a encuentra la raiz, Por favor escriba un número:");
          val=Console.ReadLine();
          num=Convert.ToDouble(val);

          raiz=Math.Sqrt(num);

          Console.WriteLine("La raiz de {0} es {1}", num,raiz);
        
        }
    }
}
		
		
