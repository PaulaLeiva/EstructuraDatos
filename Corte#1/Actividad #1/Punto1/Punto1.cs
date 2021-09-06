using System;
//Autor:María Paula Leiva Agudelo
//Jornada:Diurna 
//Grupo:239-2a

namespace Punto_4
{
    class Punto_4
    {
        static void Main(string[] args)
        {
            Double num;

          Console.WriteLine ("¡Bienvenido a VALOR ABSOLUTO en este programa podrá obtener el valor absoluto de un número!");
          Console.WriteLine ("Por favor escriba el número que desea consultar: (recuerde que si quiere consultar decimales debe agregarles su respectiva coma) ");
          num=double.Parse(Console.ReadLine());

          if (num>0)
          {
              Console.WriteLine("El número "+ num + " tiene como valor absoluto " + Math.Abs(num));
          }else
          {
                Console.WriteLine("El valor absoluto es: " + num);
                Console.WriteLine("Gracias por usar VALOR ABSOLUTO");
          }
          Console.ReadKey();
        }
    }
}
