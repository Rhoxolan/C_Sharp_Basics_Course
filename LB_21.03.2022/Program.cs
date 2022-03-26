namespace program
{
    using System;
    using static MyClassLibrary.MyConsoleFunctional;

    class Program
    {
        static void Main()
        {
            Menu();
        }

        static void Menu()
        {
            int choice;
            do
            {
                Console.WriteLine("Пожалуйста, выбирите задание (1 или 2)\n0 - Выход\n\n");
                choice = NumberInput(0, 2);
                Console.Clear();
                if (choice > 1)
                {
                    Task2();
                }
                else if (choice > 0)
                {
                    Task1();
                }
            } while (choice != 0);
        }

        static void Task1()
        {
            AnyKey();
        }

        static void Task2()
        {
            List<FinancialInstitutionClient> client = new();

            client.Add(new("Human1"));
            client[0].AddMoney(10000);
            client[0].ShowMoneyInfo();

            client.Add(new("Human2"));
            client[1].AddMoney(10000);
            client[1].ShowMoneyInfo();

            if(client[0] == client[1])
            {
                Console.WriteLine("Кошельки клиентов равны!");
            }

            client[1].SubstractMoney(1000);
            client[0].ShowMoneyInfo();
            client[1].ShowMoneyInfo();
            if (client[0] != client[1])
            {
                Console.WriteLine("Кошельки клиентов не равны!");
            }

            Console.WriteLine("Human1 переводит 30 долларов Human-у2");
            FinancialInstitutionClient.MoneyTransfer(client[0], client[1], 3000);
            client[0].ShowMoneyInfo();
            client[1].ShowMoneyInfo();

            AnyKey();
        }
    }
}
