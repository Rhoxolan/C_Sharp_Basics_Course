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
            Team brigada = new();
            House house = new();
            brigada.AddWorker(new TeamLeader());
            brigada.AddWorker(new Worker());
            brigada.AddWorker(new Worker());
            brigada.AddWorker(new Worker());
            brigada.AddWorker(new Worker());
            brigada.AddWorker(new Worker());
            int basements_amount = 1;
            int walls_amount = 4;
            int doors_amount = 1;
            int windows_amount = 1;
            int roofs_amount = 1;

            for (int i = 0; i < 4; i++)
            {
                house.AddPart(new Basement());
                Console.WriteLine(brigada.Workers[1].GetWork()); //Добавить имя рабочему, сделать проверку на тип
            }
            AnyKey();
        }
    }
}