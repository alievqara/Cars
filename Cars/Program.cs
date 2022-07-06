using System;

namespace Cars
{


    public class Program
    {
        static void Main()
        {

            Sedan bmw = new Sedan("E46", 320, "Green", "15000");

            Console.WriteLine($"{bmw.Model},{bmw.Color},{bmw.topSpeed},{bmw.Price}");





            Sedan mersedes = new Sedan("G65", 300, "White", "150000Azn");

            Console.WriteLine($"{mersedes.Model},{mersedes.Color},{mersedes.topSpeed},{mersedes.Price}");


        }
    }
}