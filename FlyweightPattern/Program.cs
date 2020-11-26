using System;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FastFoodFactory fastFoodFactory = new FastFoodFactory();

            for(int i = 9; i <= 30; i++)
            {
                var product = fastFoodFactory.GetProduct("Hamburger");
                product.Price = i;
                Console.Write($"Erzeuge Hamburger mit Preis {i}: ");
                product.Display();
            }

            for (int i = 7; i <= 30; i++)
            {
                var product = fastFoodFactory.GetProduct("Cheeseburger");
                product.Price = i;
                Console.Write($"Erzeuge Cheeseburger mit Preis {i}: ");
                product.Display();
            }

            for (int i = 11; i <= 30; i++)
            {
                var product = fastFoodFactory.GetProduct("Hamburger");
                product.Price = i;
                Console.Write($"Erzeuge Hamburger mit Preis {i}: ");
                product.Display();
            }

            for (int i = 11; i <= 30; i++)
            {
                var product = fastFoodFactory.GetProduct("Dürüm");
                product.Price = i;
                Console.Write($"Erzeuge Dürüm mit Preis {i}: ");
                product.Display();
            }

            Console.WriteLine("Anzahl Elemente in der Dictionary: " + fastFoodFactory.fastFoodProducts.Count); 

            Console.ReadKey();
        }
    }
}
