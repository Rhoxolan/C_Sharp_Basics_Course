using System;
using static MyClassLibrary.MyConsoleFunctional;
using MyClassLibrary;

namespace program
{
    delegate int Operation(int a, int b);

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
                Console.WriteLine("Пожалуйста, выбирите задание (1 - 4)\n0 - Выход\n\n");
                choice = NumberInput(0, 2);
                Console.Clear();
                if (choice > 4)
                {
                    Task4();
                }
                else if (choice > 3)
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
            HeightDeterminant.Run();
            AnyKey();
        }

        static void Task2()
        {
            Operation? op = null;
            if (op is null)
            {
                Console.WriteLine("op is null");
            }
            else
            {
                Console.WriteLine($"Сложение {1} и {3}: {op(1, 3)}");
            }
            op = Add;
            if (op is null)
            {
                Console.WriteLine("op is null");
            }
            else
            {
                Console.WriteLine($"Сложение {1} и {3}: {op(1, 3)}");
            }
            op = null;
            int? res = op?.Invoke(1, 3);
            Console.WriteLine($"Умножение {1} и {3}: ");
            Console.WriteLine(res ?? null);
            op = Mult;
            res = op?.Invoke(1, 3);
            Console.WriteLine($"Умножение {1} и {3}: ");
            Console.WriteLine(res ?? null);
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

        private static int Add(int a, int b)
        {
            return a + b;
        }
        
        private static int Subtract(int a, int b)
        {
            return a - b;
        }

        private static int Mult(int a, int b)
        {
            return a * b;
        }
    }
}