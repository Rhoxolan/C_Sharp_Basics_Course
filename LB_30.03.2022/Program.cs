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
            IHawk tiger = new Tiger("Вася");
            IPray capreolus = new Capreolus("Бэмби");
            IHawk dog = new 
            AnyKey();
        }

        static void Task2()
        {
            AnyKey();
        }
    }
}