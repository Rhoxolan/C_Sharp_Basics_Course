using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace program
{
    class Program
    {
        static void Main()
        {
            short choice;
            do
            {
                Console.WriteLine($"Пожалуйста, выбирите задание (от 1-го до 9-и)\n" +
                $"0 - Выход\n\n");
                choice = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                if (choice > 9)
                {
                    Console.WriteLine("Такого задания нет!");
                    AnyKey();
                }
                else if (choice > 8)
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
                else if (choice < 0)
                {
                    Console.WriteLine("Такого задания нет!");
                    AnyKey();
                }
            } while (choice != 0);
        }

        static void Task1()
        {
            Random rand = new Random();
            int[] myarr = new int[10];
            for (int i = 0; i < myarr.Length; i++)
            {
                myarr[i] = rand.Next(1, 100);
            }
            int even = 0, odd = 0, unique = 0, val = 0; ;
            foreach (var i in myarr)
            {
                if (i % 2 == 0)
                {
                    even++;
                }
                if (i % 2 != 0)
                {
                    odd++;
                }
                val = 0;
                foreach (var y in myarr)
                {
                    if (y == i)
                    {
                        val++;
                    }
                }
                if (val == 1)
                {
                    unique++;
                }
            }
            Console.Write("Все элементы массива: ");
            foreach (var i in myarr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nЧетные элементы: " + even);
            Console.WriteLine("Нечетные элементы: " + odd);
            Console.WriteLine("Уникальные элементы: " + unique);
            AnyKey();
        }

        static void Task2()
        {
            Random rand = new Random();
            int[] myarr = new int[10];
            for (int i = 0; i < myarr.Length; i++)
            {
                myarr[i] = rand.Next(1, 10);
            }
            short num, am = 0;
            Console.Write("Пожалуйста, введите число до 10-и: ");
            num = Convert.ToInt16(Console.ReadLine());
            foreach (var i in myarr)
            {
                Console.Write(i + " ");
                if (i < num)
                {
                    am++;
                }
            }
            Console.Write($"\nВ массиве {am} элементов меньше числа {num}.\n");
            AnyKey();
        }

        static void Task3()
        {
            Random rand = new Random();
            int[] myarr = new int[15];
            int[] cs = new int[3];
            short amount = 0;
            for (int i = 0; i < myarr.Length; i++)
            {
                myarr[i] = rand.Next(0, 5);
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Пожалуйста, введите число {i + 1}/3 (до 5-и):");
                cs[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < myarr.Length; i++)
            {
                if (myarr[i] == cs[0])
                {
                    for (int y = i + 1; y < myarr.Length; y++)
                    {
                        if (myarr[y] == cs[1] && myarr[++y] == cs[2])
                        {
                            amount++;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            foreach (var i in myarr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine($"\nПоследовательность встречается {amount} раз!");
            AnyKey();
        }

        static void Task4()
        {
            Random rand = new Random();
            int[] myarr1 = new int[5];
            int[] myarr2 = new int[10];
            ArrayList myAl = new ArrayList();
            for (int i = 0; i < myarr1.Length; i++)
            {
                myarr1[i] = rand.Next(0, 10);
            }
            for (int i = 0; i < myarr2.Length; i++)
            {
                myarr2[i] = rand.Next(0, 10);
            }

            foreach (var i in myarr1)
            {
                if (myarr2.Contains(i) && !myAl.Contains(i))
                {
                    myAl.Add(i);
                }
            }

            Console.WriteLine("Наш первый массив: ");
            foreach (var i in myarr1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nНаш второй массив: ");
            foreach (var i in myarr2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nНаш третий массив: ");
            foreach (var i in myAl)
            {
                Console.Write(i + " ");
            }
            AnyKey();
        }

        static void Task5()
        {
            Random rand = new Random();
            int[] myarr = new int[10];
            for (int i = 0; i < myarr.Length; i++)
            {
                myarr[i] = rand.Next(1, 10);
            }
            Console.WriteLine("Наш массив: ");
            foreach (var i in myarr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine($"\nМинимум: {myarr.Min()}");
            Console.WriteLine($"Максимум: {myarr.Max()}");
            AnyKey();
        }

        static void Task6()
        {
            Console.WriteLine("Пожалуйста, введите предложение: ");
            string? sentense = Console.ReadLine();
            int amount = sentense.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine($"В введённом вами предложении содержится {amount} слов");
            AnyKey();
        }

        static void Task7()
        {
            Console.WriteLine("Пожалуйста, введите предложение: ");
            string? sentense = Console.ReadLine();
            string[] revsen = sentense.Split();
            for (int i = 0; i < revsen.Length; i++)
            {
                revsen[i] = new string(revsen[i].Reverse().ToArray());
            }
            Console.WriteLine(string.Join(" ", revsen));
            AnyKey();
        }

        static void Task8()
        {
            Console.WriteLine("Пожалуйста, введите предложение: ");
            string? sentense = Console.ReadLine();
            int count = Regex.Matches(sentense, @"[ауоыиэяюёеeuoai]", RegexOptions.IgnoreCase).Count;
            Console.WriteLine($"Количество гласных - {count}");
            AnyKey();
        }

        static void Task9()
        {
            Console.WriteLine("Пожалуйста, введите предложение: ");
            string? sentense = Console.ReadLine();
            Console.WriteLine("Пожалуйста, введит слово для поиска: ");
            string? word = Console.ReadLine();
            int amount = new Regex(word).Matches(sentense).Count;
            Console.WriteLine($"Слово {word} встретилось в предложении {amount} раз.");
            AnyKey();
        }

        static void AnyKey()
        {
            Console.WriteLine("\nPress any key");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

// 2/5