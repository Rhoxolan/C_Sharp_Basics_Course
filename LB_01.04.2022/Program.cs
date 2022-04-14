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
            Predicate<double> IS = null;
            Console.WriteLine("Пожалуйста, введите число в пределах целочисленного 32-х битного диапазона: ");
            int number = NumberInput(int.MinValue, int.MaxValue);
            Console.WriteLine("Пожалуйста, выберите проверку:\n1 - Is Even\n2 - Isn't Even\n3 - Is Fibonacci\n" +
                "4 - Is Simple\n0 - выход");
            int choice = NumberInput(1, 4);
            if (ExitTo(choice, 0))
            {
                Console.Clear();
                return;
            }
            if (choice > 3)
            {
                IS = IsSimple;
                Console.WriteLine(IS(number));
            }  
            else if (choice > 2)
            {
                IS = IsFibonacci;
                Console.WriteLine(IS(number));
            }
            else if (choice > 1)
            {
                IS = IsEven;
                Console.WriteLine(!IS(number));
            }
            else if (choice > 0)
            {
                IS = IsEven;
                Console.WriteLine(IS(number));
            }
            AnyKey();
        }

        static void Task4()
        {
            Operation? op = null;
            if (op is null)
            {
                Console.WriteLine("op is null");
            }
            else
            {
                Console.WriteLine($"Сложение {1} и {3}: {op.Invoke(1, 3)}");
            }
            op = Add;
            if (op is null)
            {
                Console.WriteLine("op is null");
            }
            else
            {
                Console.WriteLine($"Сложение {1} и {3}: {op.Invoke(1, 3)}");
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

        static int Add(int a, int b)
        {
            return a + b;
        }
        
        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Mult(int a, int b)
        {
            return a * b;
        }

        static bool IsFibonacci(double num)
        {
            List<double> al = new List<double>();
            al.Add(0);
            al.Add(1);
            for (int i = 0; i < num; i++)
            {
                al.Add(al[al.Count - 1] + al[al.Count - 2]);
            }
            if (al.Contains(num))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsEven(double num)
        {
            if (num % 2 != 0)
            {
                return false;
            }
            return true;
        }

        static bool IsSimple(double num)
        {
            for (int i = (int)num - 1; i <= (int)num; i++)
            {
                double y = i;
                if (y == num)
                {
                    return true;
                }
            }
            return false;
        }

    }
}