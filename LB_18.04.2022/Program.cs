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
                Console.WriteLine("Пожалуйста, выберите задание (1 - 4)\n0 - Выход\n\n");
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
            int[] values1 = new int[5] { 1, 10, 5, 13, 4 };
            int[] values2 = new int[5] { 19, 1, 4, 9, 8 };
            int[] values3 = values1.Concat(values2).ToArray();
            foreach (int value in values3)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
            int[] values4 = values3.Where(x => x % 2 == 0).ToArray();
            int average = 0;
            foreach (int value in values4)
            {
                average += value;
            }
            average /= values4.Count();
            Console.WriteLine(average);
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
    }
}