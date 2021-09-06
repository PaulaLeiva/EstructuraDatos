using System;
//Autor:María Paula Leiva Agudelo
//Jornada:Diurna 
//Grupo:239-2a

public class Punto2
{
    static void Main(string[] args)
    {

        Console.WriteLine("Bienvenido al Cinefilosthrone videoclub");
        Console.WriteLine("¡En este mes tenemos promociones especiales, lleva 3 peliculas y paga las 2 más económicas!");

        double P1,P2,P3,Prom;

        Console.WriteLine("Estimado cliente por favor ingrese el primer precio de la película que adquirió: ");
        P1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Estimado cliente por favor ingrese el segundo precio de la película que adquirió: ");
        P2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Estimado cliente por favor ingrese el tercer precio de la película que adquirió: ");
        P3 = double.Parse(Console.ReadLine());
        
        if (P1 > P2 && P1 > P3)
        {
            Prom = P2 + P3;
            Console.WriteLine("El precio total junto a la promoción es: " + Prom);
        }
        else if (P2 > P1 && P2 > P3)
        {
            Prom = P1 + P3;
            Console.WriteLine("El precio total junto a la promoción es: " + Prom);
        }
        else
        {
            Prom = P2 + P1;
            Console.WriteLine("El precio total junto a la promoción es: " + Prom);
        }
        Console.ReadLine();
        Console.WriteLine("Estamos agradecidos por su compra y el uso de nuestras promociones!");
        Console.ReadLine();

        Console.ReadKey();


    }
}

