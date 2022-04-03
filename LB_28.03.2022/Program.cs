using System;
using static MyClassLibrary.MyConsoleFunctional;
using MyClassLibrary;

namespace program
{
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
                Console.WriteLine("Пожалуйста, выбирите задание (1 - 2)\n0 - Выход\n\n");
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
            Client client = new("Серёжа");
            client.AddMoney(11000);
            client.SubstractMoney(1000);
            client.Show();
            AnyKey();
        }

        static void Task2()
        {
            Random rand = new Random();
            Team brigada = new();
            House house = new();
            brigada.AddWorker(new TeamLeader("Павел"));
            brigada.AddWorker(new Worker("Петя"));
            brigada.AddWorker(new Worker("Вася"));
            brigada.AddWorker(new Worker("Коля"));
            brigada.AddWorker(new Worker("Саша"));
            brigada.AddWorker(new Worker("Сережа"));
            int basements_amount = 1;
            int walls_amount = 4;
            int doors_amount = 1;
            int windows_amount = 1;
            int roofs_amount = 1;

            for (int i = 0; i < basements_amount; i++)
            {
                while (true)
                {
                    int index = rand.Next(0, brigada.Workers.Count());
                    if (brigada.Workers[index].GetType() == typeof(Worker))
                    {
                        Console.WriteLine($"{brigada.Workers[index].Work} " +
                            $"{brigada.Workers[index].Rank} {brigada.Workers[index].Name} строит фасад");
                        house.AddPart(new Basement());
                        break;
                    }
                }
            }
            for (int i = 0; i < walls_amount; i++)
            {
                while (true)
                {
                    int index = rand.Next(0, brigada.Workers.Count());
                    if (brigada.Workers[index].GetType() == typeof(Worker))
                    {
                        Console.WriteLine($"{brigada.Workers[index].Work} " +
                            $"{brigada.Workers[index].Rank} {brigada.Workers[index].Name} строит стену");
                        house.AddPart(new Wall());
                        break;
                    }
                }
            }
            for (int i = 0; i < doors_amount; i++)
            {
                while (true)
                {
                    int index = rand.Next(0, brigada.Workers.Count());
                    if (brigada.Workers[index].GetType() == typeof(Worker))
                    {
                        Console.WriteLine($"{brigada.Workers[index].Work} " +
                            $"{brigada.Workers[index].Rank} {brigada.Workers[index].Name} строит дверь");
                        house.AddPart(new Door());
                        break;
                    }
                }
            }
            for (int i = 0; i < windows_amount; i++)
            {
                while (true)
                {
                    int index = rand.Next(0, brigada.Workers.Count());
                    if (brigada.Workers[index].GetType() == typeof(Worker))
                    {
                        Console.WriteLine($"{brigada.Workers[index].Work} " +
                            $"{brigada.Workers[index].Rank} {brigada.Workers[index].Name} строит дверь");
                        house.AddPart(new Window());
                        break;
                    }
                }
            }
            for (int i = 0; i < roofs_amount; i++)
            {
                while (true)
                {
                    int index = rand.Next(0, brigada.Workers.Count());
                    if (brigada.Workers[index].GetType() == typeof(Worker))
                    {
                        Console.WriteLine($"{brigada.Workers[index].Work} " +
                            $"{brigada.Workers[index].Rank} {brigada.Workers[index].Name} строит крышу");
                        house.AddPart(new Roof());
                        break;
                    }
                }
            }

            basements_amount = 0;
            walls_amount = 0;
            doors_amount = 0;
            windows_amount = 0;
            roofs_amount = 0;

            for (int i = 0; i < house.Parts.Count(); i++)
            {
                if(house.Parts[i].GetType() == typeof(Basement))
                {
                    basements_amount++;
                }
                if(house.Parts[i].GetType() == typeof(Wall))
                {
                    walls_amount++;
                }
                if (house.Parts[i].GetType() == typeof(Door))
                {
                    doors_amount++;
                }
                if(house.Parts[i].GetType() == typeof(Window))
                {
                    windows_amount++;
                }
                if(house.Parts[i].GetType() == typeof(Roof))
                {
                    roofs_amount++;
                }
            }

            Console.WriteLine($"\n\n\n{brigada.Workers[0].Work} {brigada.Workers[0].Rank} {brigada.Workers[0].Name} предоставил отчет:\n" +
                $"{basements_amount} построенных фасадов;\n" +
                $"{walls_amount} построенных стен;\n" +
                $"{doors_amount} поставленных дверей;\n" +
                $"{windows_amount} поставленных окон;\n" +
                $"{roofs_amount} построенных крыш.");
            AnyKey();
        }
    }
}