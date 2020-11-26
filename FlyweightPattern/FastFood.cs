using System;

namespace FlyweightPattern
{
    class FastFood : IProduct
    {
        private decimal price;
        public string Name { get; set; }
        public decimal Price
        {
            get { return price;}
            // für Vorführungszwecke mit Bedingung
            set
            {
                if (price == decimal.Zero)
                    price = value;
            }
        }

        public FastFood(string name)
        {
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine($"{Name}, CHF {Price}");
        }
    }
}
