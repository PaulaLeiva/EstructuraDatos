using System;
//Autor:María Paula Leiva Agudelo
//Jornada:Diurna 
//Grupo:239-2a

namespace Punto3
{
    class Punto3
    {
        static void Main(string[] args)
        {
            

            double cA1, cA2, cA3, cA4, oP;

            Console.WriteLine("Bienvendido a la plataforma de calificaciones de la universidad Rc.");
            Console.WriteLine("Querido usuario por favor ingrese la calificación #1:");
            cA1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Querido usuario por favor ingrese la calificación #2:");
            cA2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Querido usuario por favor ingrese la calificación #3:");
            cA3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Querido usuario por favor ingrese la calificación #4:");
            cA4 = double.Parse(Console.ReadLine());

            oP = (cA1 + cA2 + cA3 + cA4) / 4;
            Console.WriteLine("El promedio del estudiante es " + oP);
            if(cA1 < cA2 && cA1 < cA3 && cA1<cA4)
            {
                Console.WriteLine("Querido usuario, la calificación más baja es la #1");
                Console.ReadLine();
            }
            if(cA2 < cA1 && cA2 < cA3 && cA2 < cA4)
            { 
                Console.WriteLine("Querido usuario, la calificación más baja es la #2");
            Console.ReadLine();
            }
            if (cA3 < cA1 && cA3 < cA2 && cA3 < cA4)
            {
                Console.WriteLine("Querido usuario, la calificación más baja es la #3");
                Console.ReadLine();
            }
            if (cA4 < cA1 && cA4 < cA2 && cA4 < cA3)
            {
                Console.WriteLine("Querido usuario, la calificación más baja es la #4");
                Console.ReadLine();
            }
            if (cA1 > cA2 && cA1 > cA3 && cA1 > cA4)
            {
                Console.WriteLine("Querido usuario, la calificación más alta es la #1");
                Console.ReadLine();
            }
            if (cA2 > cA1 && cA2 > cA3 && cA2 > cA4)
            {
                Console.WriteLine("Querido usuario, la calificación más alta es la #2 ");
                Console.ReadLine();
            }
            if (cA3 > cA1 && cA3 > cA2 && cA3 > cA4)
            {
                Console.WriteLine("Querido usuario, la calificación más alta es la #3 ");
                Console.ReadLine();
            }
            if (cA4 > cA1 && cA4 > cA2 && cA4 > cA3)
            {
                Console.WriteLine("Querido usuario, la calificación más alta es la #4 ");
                Console.ReadLine();
            }
            //Para obtener el número mayor es necesario oprimir un tecla.
        
        }
    }
}
