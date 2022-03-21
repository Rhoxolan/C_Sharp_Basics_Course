using System;
using System.Text;

namespace program
{
    using WebSites;
    using Journals;
    using markets;

    class Program
    {
        static void Main()
        {
            Menu();
        }

        static void Menu()
        {
            short choice;
            do
            {
                Console.WriteLine("Пожалуйста, выбирите задание (от 1-го до 7-и)\n0 - Выход\n\n");
                choice = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                if (choice > 6)
                {
                    Console.WriteLine("Такого задания нет!");
                    AnyKey();
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
            Console.WriteLine("Пожалуйста, введите символ для отображения квадрата: ");
            char ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите длину стороны квадрата: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            ShowCharactersSquare(length, ch);
            AnyKey();
        }

        static void Task2()
        {
            Console.WriteLine("Пожалуйста, введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if(IsPalindrome(num))
            {
                Console.WriteLine("Число - Палиндром!");
            }
            if (!IsPalindrome(num))
            {
                Console.WriteLine("Число - не палиндром!");
            }
            AnyKey();
        }

        static void Task3()
        {
            List<int> l = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> cleaningL = new List<int> { 2, 4, 6, 8 };
            foreach (int i in l)
            {
                Console.Write(i + " ");
            }
            CleanedList(ref l, ref cleaningL);
            Console.WriteLine();
            foreach (int i in l)
            {
                Console.Write(i + " ");
            }
            AnyKey();
        }

        static void Task4()
        {
            WebSite website = new WebSite("google.com", "http://google.com", "Поисковая система");
            website.siteName = "Google";
            Console.WriteLine("Название: " + website.siteName);
            Console.WriteLine("URL: " + website.URL);
            Console.WriteLine("Назначение: " + website.description);
            AnyKey();
        }

        static void Task5()
        {
            Journal journal1 = new Journal("Otdokhni", 0.50);
            journal1.EuroPrice = 0.55; //Подорожал!
            Console.WriteLine($"Price of {journal1.JournalName} is {journal1.EuroPrice} EUR");
            Journal journal2 = new Journal("Mirovaya Aviatsia", 0.75);
            Console.WriteLine($"Price of {journal2.JournalName} is {journal2.EuroPrice} EUR");
            AnyKey();
        }

        static void Task6()
        {
            List<Market> l = new List<Market>();
            l.Add(new Market("ATB", "Продукты", "Электрическая 3" ));
            l.Add(new Market("Хозяйственный", "Хоз-товары", "Электрическая 2а"));
            foreach (Market m in l)
            {
                Console.WriteLine($"Название: {m.marketName}\n" +
                    $"Назначение: {m.marketProfile}\n" +
                    $"Адрес: {m.marketAddress}\n");
            }
            AnyKey();
        }

        static void ShowCharactersSquare(int length, char ch)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(ch);
            }
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine();
                Console.Write(ch);
                for (int y = 0; y < length-2; y++)
                {
                    Console.Write(' ');
                }
                Console.Write(ch);
            }
            Console.WriteLine();
            for (int i = 0; i < length; i++)
            {
                Console.Write(ch);
            }

        }

        static bool IsPalindrome(int num)
        {
            string snum = num.ToString();
            if (snum.Length % 2 != 0)
            {
                return false;
            }
            StringBuilder s1 = new StringBuilder(snum.Substring(0, snum.Length / 2));
            StringBuilder s2 = new StringBuilder(snum.Substring(snum.Length - snum.Length / 2));
            StringBuilder s3 = new StringBuilder(s2.ToString());
            for (int i = s2.Length - 1, y = 0; i >= 0; i--, y++)
            {
                s2[y] = s3[i];
            }
            if (s1.Equals(s2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void CleanedList(ref List<int> l, ref List<int> cleaningL)
        {
            foreach (var i in cleaningL)
            {
                if (l.Contains(i))
                {
                    l.Remove(i);
                }
            }
        }

        static void AnyKey()
        {
            Console.WriteLine("\nPress any key");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

// 5/5