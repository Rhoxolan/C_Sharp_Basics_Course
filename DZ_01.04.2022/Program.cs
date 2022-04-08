using System;
using static MyClassLibrary.MyConsoleFunctional;
using MyClassLibrary;

namespace program
{
    public delegate bool IS(double num);

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
            //Вариант 1, на основе авторского делегата IS
            double[] mass = { 8, 1.5, 0, 0.0, 0.001, -3, -0, 17, 2, 77, -0.00000000001, 1, -2, -0.0000002 };
            List<double> evenlist = new();
            List<double> ntevenlist = new();
            List<double> simplelist = new();
            List<double> fibolist = new();
            IS _is = IsEven;
            foreach (double i in mass)
            {
                if (_is(i))
                {
                    evenlist.Add(i);
                }
            }
            foreach (double i in mass)
            {
                if (!_is(i))
                {
                    ntevenlist.Add(i);
                }
            }
            _is = IsSimple;
            foreach (double i in mass)
            {
                if (_is(i))
                {
                    simplelist.Add(i);
                }
            }
            _is = IsFibonacci;
            foreach (double i in mass)
            {
                if (_is(i))
                {
                    fibolist.Add(i);
                }
            }
            Console.Write("Массив: ");
            foreach (double i in mass)
            {
                Console.Write(i + " ");
            }
            Console.Write("\nЧетные числа: ");
            foreach (double i in evenlist)
            {
                Console.Write(i + " ");
            }
            Console.Write("\nНечетные числа: ");
            foreach (double i in ntevenlist)
            {
                Console.Write(i + " ");
            }
            Console.Write("\nПростые числа: ");
            foreach (double i in simplelist)
            {
                Console.Write(i + " ");
            }
            Console.Write("\nЧисла Фибоначчи: ");
            foreach (double i in fibolist)
            {
                Console.Write(i + " ");
            }

            //Вариант 2, с использованием массива обобщенных делигатов Predicate<T>
            Predicate<double>[] Is = { IsEven, IsSimple, IsFibonacci };
            evenlist.Clear();
            ntevenlist.Clear();
            simplelist.Clear();
            fibolist.Clear();
            foreach (double i in mass)
            {
                if (Is[0](i))
                {
                    evenlist.Add(i);
                }
            }
            foreach (double i in mass)
            {
                if (!Is[0](i))
                {
                    ntevenlist.Add(i);
                }
            }
            _is = IsSimple;
            foreach (double i in mass)
            {
                if (Is[1](i))
                {
                    simplelist.Add(i);
                }
            }
            _is = IsFibonacci;
            foreach (double i in mass)
            {
                if (Is[2](i))
                {
                    fibolist.Add(i);
                }
            }
            Console.Write("\n\n\nЧетные числа: ");
            foreach (double i in evenlist)
            {
                Console.Write(i + " ");
            }
            Console.Write("\nНечетные числа: ");
            foreach (double i in ntevenlist)
            {
                Console.Write(i + " ");
            }
            Console.Write("\nПростые числа: ");
            foreach (double i in simplelist)
            {
                Console.Write(i + " ");
            }
            Console.Write("\nЧисла Фибоначчи: ");
            foreach (double i in fibolist)
            {
                Console.Write(i + " ");
            }
            AnyKey();
        }

        static void Task2()
        {
            DateTime dateTime = DateTime.Now;
            ShowCurrentDate(dateTime, ShowCurrentDayOfTheWeek);
            ShowCurrentDate(dateTime, ShowCurrentTime);
            ShowCurrentDate(dateTime, ShowCurrentDate);
            Console.WriteLine($"Площадь равностороннего треугольника со стороной {4}:");
            Console.WriteLine(Area(4, EquilateralTriangleArea));
            Console.WriteLine($"Площадь квадрата со стороной {7.1}:");
            Console.WriteLine(Area(7.1, SquareArea));
            AnyKey();
        }

        static void Task3()
        {
            AnyKey();
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

        static void ShowCurrentDate(DateTime dateTime, Action<DateTime> action)
            => action(dateTime);

        static void ShowCurrentTime(DateTime dateTime)
            => Console.WriteLine($"Сейчас {dateTime.Hour}:{dateTime.Minute}");

        static void ShowCurrentDate(DateTime dateTime)
            => Console.WriteLine($"Сейчас {dateTime.Day}.{dateTime.Month}.{dateTime.Year}");

        static void ShowCurrentDayOfTheWeek(DateTime dateTime)
            => Console.WriteLine($"Today is {dateTime.DayOfWeek}");

        static double Area(double a, Func<double, double> func)
            => func(a);

        static double EquilateralTriangleArea(double a) => (Math.Sqrt(3) / 4) * (a * 2);

        static double SquareArea(double a) => a * a;
    }
}