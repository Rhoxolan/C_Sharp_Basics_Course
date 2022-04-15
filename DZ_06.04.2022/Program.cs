using System;
using static MyClassLibrary.MyConsoleFunctional;
using MyClassLibrary;
using System.Text.RegularExpressions;

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
            int a = 1, b = 7;
            Console.WriteLine($"{a} is Fibonacci - {a.IsFibonacci()}");
            Console.WriteLine($"{b} is Fibonacci - {b.IsFibonacci()}");
            AnyKey();
        }

        static void Task2()
        {
            Console.Write("Пожалуйста, введите вашу строку: ");
            string? _str = Console.ReadLine();
            Console.Write($"В вашей строке {_str.WordsCount()} слов.");
            AnyKey();
        }

        static void Task3()
        {
            Console.Write("Пожалуйста, введите вашу строку: ");
            string? _str = Console.ReadLine();
            Console.Write($"В последнем слове {_str.LastWordLength()} символов.");
            AnyKey();
        }

        static void Task4()
        {
            AnyKey();
        }

        static void Task5()
        {
            int[] arr = { -8, -7, -0, 0, 2, 10, 1, 3 };
            Console.WriteLine("Массив: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nОтображаем массив с четными числами нашего массива: ");
            foreach (int i in arr.IS(x => x % 2 == 0))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nОтображаем массив с числами Фибоначчи нашего массива: ");
            foreach (int i in arr.IS(x => x.IsFibonacci()))  //Применяем наш же метод расширения!
            {
                Console.Write(i + " ");
            }
            AnyKey();
        }

        static void Task6()
        {
            DailyTemperature day1 = new(new(2022, 4, 15), 6, 16);
            DailyTemperature day2 = new(new(2022, 4, 16), 7, 16);
            DailyTemperature day3 = new(new(2022, 4, 17), 6, 10);
            DailyTemperature[] days = { day1, day2, day3 };
            Console.WriteLine($"День с наибольшей разницей в температуре: {days.GetBiggestDifference()}");
            AnyKey();
        }

        static void Task7()
        {
            StudentMarks Pasha = new("Pasha", new());
            StudentMarks Vasya = new("Vasya", new());
            Pasha.Marks.Add(12);
            Pasha.Marks.Add(12);
            Pasha.Marks.Add(12);
            Vasya.Marks.Add(3);
            Vasya.Marks.Add(5);
            Vasya.Marks.Add(7);
            Console.WriteLine($"Информаця по оценками студента {Pasha.Name}: Максимальная - {Pasha.GetMarksInfo().Max}; " +
                $"Средняя - {Pasha.GetMarksInfo().Average}");
            Console.WriteLine($"Информаця по оценками студента {Vasya.Name}: Максимальная - {Vasya.GetMarksInfo().Max}; " +
                $"Средняя - {Vasya.GetMarksInfo().Average}");
            AnyKey();
        }
    }

    public static class Int32Extension
    {
        public static bool IsFibonacci(this Int32 num)
        {
            List<int> al = new List<int>();
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

        public static Int32[] IS(this Int32[] arr, Predicate<Int32> _is)
        {
            List<Int32> truevalues = new();
            foreach(int i in arr)
            {
                if(_is(i))
                {
                    truevalues.Add(i);
                }
            }
            return truevalues.ToArray();
        }
    }

    public static class StringExtension
    {
        public static int WordsCount(this String _str)
        {
            return _str.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static int LastWordLength(this String _str)
        {
            string[] words = _str.Split(new char[] { ' ' });
            return words[words.Length - 1].Length;
        }
    }
}