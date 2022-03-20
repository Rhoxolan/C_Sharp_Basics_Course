using System;

namespace program
{
    class Program
    {
        static void Main()
        {
            short choice;
            do
            {
                Console.WriteLine("Пожалуйста, выбирите задание (от 1-го до 7-и)\n0 - Выход\n\n");
                choice = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                if (choice > 7)
                {
                    Console.WriteLine("Такого задания нет!");
                    AnyKey();
                }
                else if (choice > 6)
                {
                    Task7();
                }
                else if (choice > 5)
                {
                    Task6();
                }
                else if (choice > 4)
                {
                    Task5();
                }
                else if (choice > 3)
                {
                    Task4();
                }
                else if (choice > 2)
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
                else if (choice < 0)
                {
                    Console.WriteLine("Такого задания нет!");
                    AnyKey();
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

        static void Task4()
        {
            AnyKey();
        }

        static void Task5()
        {
            AnyKey();
        }

        static void Task6()
        {
            AnyKey();
        }

        static void Task7()
        {
            AnyKey();
        }

        static void AnyKey()
        {
            Console.WriteLine("\nPress any key");
            Console.ReadKey();
            Console.Clear();
        }
    }
}