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
                Console.WriteLine("Пожалуйста, выберите задание (1 - 9)\n0 - Выход\n\n");
                choice = NumberInput(0, 9);
                Console.Clear();
                if (choice > 8)
                {
                    Task9();
                }
                else if (choice > 7)
                {
                    Task8();
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
            } while (choice != 0);
        }

        static void Task1()
        {
            int a = 15, b = 8;
            Console.WriteLine($"{a} isn't even - {!a.IsEven()}");
            Console.WriteLine($"{b} isn't even - {!b.IsEven()}");
            AnyKey();
        }

        static void Task2()
        {
            int a = 10, b = 11;
            Console.WriteLine($"{a} is even - {a.IsEven()}");
            Console.WriteLine($"{b} is even - {b.IsEven()}");
            AnyKey();
        }

        static void Task3()
        {
            double a = 7;
            double b = 7.5;
            Console.WriteLine($"{a} is simple - {a.IsSimple()}");
            Console.WriteLine($"{b} is simple - {b.IsSimple()}");
            AnyKey();
        }

        static void Task4()
        {
            Console.Write("Пожалуйста, введите вашу строку: ");
            string? _str = Console.ReadLine();
            Console.Write($"В вашей строке {_str.VowelCount()} гласных.");
            AnyKey();
        }

        static void Task5()
        {
            Console.Write("Пожалуйста, введите вашу строку: ");
            string? _str = Console.ReadLine();
            Console.Write($"В вашей строке {_str.ConsonantCount()} согласных.");
            AnyKey();
        }

        static void Task6()
        {
            Console.Write("Пожалуйста, введите вашу строку: ");
            string? _str = Console.ReadLine();
            Console.Write($"В вашей строке {_str.SentenceCount()} предложений.");
            AnyKey();
        }

        static void Task7()
        {
            List<Person> people = new();
            people.Add(new("Pavel", 23));
            people.Add(new("Andrew", 25));
            people.Add(new("Vlad", 22));
            people.Add(new("Denis", 23));
            people.Add(new("Alexandr", 26));
            people.Add(new("Dima", 23));
            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }
            Console.WriteLine($"Минимальный возраст: {people.MinAge()}");
            Console.WriteLine($"Максимальный возраст: {people.MaxAge()}");
            Console.WriteLine($"Средний возраст: {people.AgeMean()}");
            AnyKey();
        }

        static void Task8()
        {
            var Point1 = new Point2D(1f, 5f);
            var Point2 = Point1 with { Y = 7f }; //https://metanit.com/sharp/tutorial/3.51.php
            var Point3 = Point1 with { X = 2.5f };
            Console.WriteLine($"Расстояние между {Point1} и {Point2}: {Point1.PointDistance(Point2)}");
            Point2D[] points = { Point1, Point2, Point3 };
            Console.WriteLine($"Максимальное расстояние от {Point2} по отношению {points}: " +
                $"{points.PointsDistance(Point2)}");
            AnyKey();
        }

        static void Task9()
        {
            Fraction fraction1 = new(7, 8);
            Fraction fraction2 = new(7, 8);
            Fraction fraction3 = new(3, 100);
            Console.WriteLine(fraction1 == fraction2); //True
            Console.WriteLine(fraction1 == fraction3); //False
            Console.WriteLine(fraction1.Equals(fraction2)); //True
            Console.WriteLine(fraction1 != fraction2); //False
            Fraction fraction4 = new(1, 25);
            Fraction fraction5 = new(100, 2);
            Fraction[] fractions = { fraction1, fraction2, fraction3, fraction4, fraction5 };
            try
            {
                Console.WriteLine($"Наименьший результат дроби в {fractions}: {fractions.GetMinMaxResult().Min}, " +
                    $"наибольший: {fractions.GetMinMaxResult().Max}.");
            }
            catch (StackOverflowException SOVEX)
            {
                Console.WriteLine(SOVEX.Message);
            }
            AnyKey();
        }
    }

    public static class Int32Extension
    {
        public static bool IsEven(this Int32 num)
        {
            if (num % 2 != 0)
            {
                return false;
            }
            return true;
        }
    }

    public static class DoubleExtension
    {
        public static bool IsSimple(this Double num)
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

    public static class StringExtension
    {
        public static int VowelCount(this String _str)
        {
            return Regex.Matches(_str, @"[ауоыиэяюёеeuoai]", RegexOptions.IgnoreCase).Count;
        }

        public static int ConsonantCount(this String _str)
        {
            return Regex.Matches(_str, @"[йцкнгшщзхфвпрлджчсмтбqwrtpsdfghjklzxcvbnm]", RegexOptions.IgnoreCase).Count;
        }

        public static int SentenceCount(this String _str)
        {
            return _str.Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}