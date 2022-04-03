using System;

namespace program
{
    interface IClient
    {
        string Name { get; set; }
    }

    interface IAccount
    {
        void Show();
        void AddMoney(int sum);
        void SubstractMoney(int sum);
    }

    internal class Client : IClient, IAccount
    {
        private Money money;
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Client(string name)
        {
            Name = name;
            money = new();
        }


        public void AddMoney(int sum)
        {
            money += sum;
        }

        public void SubstractMoney(int sum)
        {
            money -= sum;
        }

        public void Show()
        {
            Console.WriteLine($"{Name} has {money.GetMoney()} денег.");
        }

    }
}
