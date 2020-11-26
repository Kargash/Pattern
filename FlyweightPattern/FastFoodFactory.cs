using System.Collections.Generic;

namespace FlyweightPattern
{
    public class FastFoodFactory
    {
        // für Vorführungszwecke public
        public Dictionary<string, IProduct> fastFoodProducts = new Dictionary<string, IProduct>();

        public IProduct GetProduct(string key)
        {
            if (!fastFoodProducts.ContainsKey(key))
            {
                fastFoodProducts[key] = new FastFood(key);
            }

            return fastFoodProducts[key];
        }
    }
}
