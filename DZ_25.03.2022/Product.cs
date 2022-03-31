using System;

namespace program
{
    internal class Product : MoneyOperations
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            AddMoney((int)(price * 100));
            Price = (double)GetMoney() / 100;
        }
    }
}
