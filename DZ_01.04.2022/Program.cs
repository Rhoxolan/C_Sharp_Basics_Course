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
                Console.WriteLine("Пожалуйста, выбирите задание (1 - 3)\n0 - Выход\n\n");
                choice = NumberInput(0, 3);
                Console.Clear();
                if (choice > 2)
                {
                    Task3();
                }
                else if (choice > 1)
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
            AnyKey();
        }

        static void Task3()
        {
            AnyKey();
        }
    }
}