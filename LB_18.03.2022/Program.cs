using System;
using System.Text;

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
                Console.WriteLine("Пожалуйста, выбирите задание (от 1-го до 4-и)\n0 - Выход\n\n");
                choice = NumberInput(0, 4);
                Console.Clear();
                if (choice > 3)
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

        static int NumberInput(int min, int max)
        {
            return 0;
        }

        static void AnyKey()
        {
            Console.WriteLine("\nPress any key");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
