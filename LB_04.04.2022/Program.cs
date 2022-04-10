using System;
using static MyClassLibrary.MyConsoleFunctional;
using MyClassLibrary;

namespace program
{
    class Program
    {
        public delegate bool IS(double num); //Пример обычного делегата
        public delegate T IST<T, K>(K val); //Пример обобщенного делегата
        public delegate double _MATH(double num);

        static void Main()
        {
            Menu();
        }

        static void Menu()
        {
            int choice;
            do
            {
                Console.WriteLine("Пожалуйста, выбирите задание (1 - 7)\n0 - Выход\n\n");
                choice = NumberInput(0, 7);
                Console.Clear();
                if (choice > 6)
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
            } while (choice != 0);
        }

        static void Task1()
        {
            IS? _is = delegate (double num) //Пример классического анонимного метода
            {
                if (num % 2 != 0)
                {
                    return false;
                }
                return true;
            };
            Console.WriteLine($"{2} = {_is(2)}");
            AnyKey();
        }

        static void Task2()
        {
            ShowSQRT(5, delegate (double num) { return Math.Sqrt(num); }); //Пример передачи анонимного метода в качестве
                                                                           //аргумента для параметра, который представляет
                                                                           //делегат.

            _MATH _sqrt = ReturnSQRT;       //Для примера вариант без использования анонимного метода
            Console.WriteLine(_sqrt(5));
            AnyKey();
        }

        static void Task3()
        {
            _MATH? cube = delegate (double num)  //Вариант 1, с использованием анонимного метода
            {
                return Math.Pow(num, 3);
            };
            Console.WriteLine(cube?.Invoke(3));

            cube = (double num) => Math.Pow(num, 3); //Вариант 2, с использованием лямбда-выражения.
            Console.WriteLine(cube?.Invoke(3));

            cube = ReturnCube;          //Для примера вариант без использования анонимного метода или лямбда-выражения.
            Console.WriteLine(cube?.Invoke(3));
            AnyKey();
        }

        static void Task4()
        {
            IST<bool, DateTime>? ist = (DateTime dt) => dt.Equals(new DateTime(256));
            Console.WriteLine(ist?.Invoke(new DateTime(256)));
            AnyKey();
        }

        static void Task5()
        {
            int[] arr = { -7, -115, -0, 0 };
            IST<int, int[]>? ist = null;
            if (!(ist is null))
            {
                Console.WriteLine(ist?.Invoke(arr));
            }
            ist = (int[] arr) =>
            {
                int max = int.MinValue;
                foreach (var i in arr)
                {
                    if (i > max)
                    {
                        max = i;
                    }
                }
                return max;
            };
            if (!(ist is null))
            {
                Console.WriteLine(ist?.Invoke(arr));
            }
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

        static void ShowSQRT(double num, _MATH _sqrt) => Console.WriteLine(_sqrt(num));

        static double ReturnSQRT(double num) => Math.Sqrt(num);

        static double ReturnCube(double num) => Math.Pow(num, 3);
    }
}
