using System;
using System.Collections;

namespace program
{
    internal class Laptop
    {
        public string Model { get; set; }
        
        public int Price { get; set; }

        public Laptop(string model, int price)
        {
            Model = model;
            Price = price;
        }

        public Laptop() { }

        public override string ToString()
        {
            return $"{Model}: {Price}";
        }
    }

    interface IShop
    {
        public void AddLaptop(Laptop laptop);

        Laptop this[int index]
        {
            get;
            set;
        }

        List<Laptop> this[string name]
        {
            get;
        }

        string this[string name, string code]
        {
            set;
        }
    }

    internal class Shop : IShop, IEnumerable
    {
        List<Laptop> laptops;

        public Shop(List<Laptop> laptops)
        {
            this.laptops = laptops;
        }

        public Shop()
        {
            laptops = new();
        }

        public IEnumerator GetEnumerator() => laptops.GetEnumerator();

        public void AddLaptop(Laptop laptop)
        {
            laptops.Add(laptop);
        }

        public Laptop this[int index]
        {
            get 
            {
                return laptops[index];
            }
            set
            {
                laptops[index] = value;
            }
        }

        public List<Laptop> this[string name]
        {
            get
            {
                List<Laptop> l = new();
                foreach (Laptop laptop in laptops)
                {
                    if (laptop.Model == name)
                    {
                        l.Add(laptop);
                    }
                }
                return l;
            }
        }

        public string this[string name, string code]
        {
            set
            {
                for (int i = 0; i < laptops.Count(); i++)
                {
                    if(laptops[i].Model == name && code == "set")
                    {
                        laptops[i].Model = value;
                    }
                }
            }
        }
    }
}
