using System;
//Autor:María Paula Leiva Agudelo
//Jornada:Diurna 
//Grupo:239-2a
namespace Punto6
{
    class Punto6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a convertidor.com, Por favor ingrese su valor en segundos:");
            int segT=Convert.ToInt32(Console.ReadLine());
            int d=segT/(60*60*24);
            int segR=segT%(60*60*24);
            int h=segR/(60*60);
            segR=segR%(60*60);
            int m=segR/60;
            int s=segR % 60;
            Console.WriteLine(d+" días "+h+" horas "+m+" minutos "+s+" segundos. ");
            Console.ReadKey();
        }
    }
}
