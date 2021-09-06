using System;
//Autor:María Paula Leiva Agudelo
//Jornada:Diurna 
//Grupo:239-2a
namespace Punto10
{
    class Punto10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienevenido, escriba su contraseña:");
            string contraseña = Console.ReadLine();
            while(contraseña!="iloveyou123")
            {
                Console.WriteLine("Contraseña incorrecta, vuelva a intentarlo:");
                contraseña=Console.ReadLine();
            }
            Console.WriteLine("¡Contraseña correcta, Bienvenido!");
            Console.ReadKey();
    }    }
}