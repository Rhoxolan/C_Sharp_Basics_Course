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
        public delegate void voidDelegate(ref int[] val1, ref List<int> val2);

        static void Main()
        {
            Menu();
        }

        static void Menu()
        {
            int choice;
            do
            {
                Console.WriteLine("Пожалуйста, выберите задание (1 - 7)\n0 - Выход\n\n");
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
            int[] arr = { 8, 115, -0, 0 };
            var lmbd = (int[] arr) => //Пример неявной типизации (определение переменной с помощью оператора var)
            {
                int max = int.MaxValue;
                foreach (var i in arr)
                {
                    if (i < max)
                    {
                        max = i;
                    }
                }
                return max;
            };
            Console.WriteLine(lmbd(arr));
            AnyKey();
        }

        static void Task7()
        {
            {
                List<int> notevens = new();
                int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                voidDelegate? addtonotevens = (ref int[] arr, ref List<int> l) =>
                {
                    foreach (var i in arr)
                    {
                        if (i % 2 != 0)
                        {
                            l.Add(i);
                        }
                    }
                };
                addtonotevens(ref arr, ref notevens);
                foreach (var i in notevens)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            //Пример "чистого" лямбда-выражения, без делегата
            {
                List<int> notevens = new();
                int[] arr = { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

                var addtonotevens = (ref int[] arr, ref List<int> l) =>
                {
                    foreach (var i in arr)
                    {
                        if (i % 2 != 0)
                        {
                            l.Add(i);
                        }
                    }
                };

                addtonotevens(ref arr, ref notevens);

                foreach (var i in notevens)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            AnyKey();
        }

        static void ShowSQRT(double num, _MATH _sqrt) => Console.WriteLine(_sqrt(num));

        static double ReturnSQRT(double num) => Math.Sqrt(num);

        static double ReturnCube(double num) => Math.Pow(num, 3);
    }
}
