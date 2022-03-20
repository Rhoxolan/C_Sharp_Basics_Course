using System;
using System.Collections;
using System.Text;
using System.Globalization;

namespace program
{
    class Program
    {
        static void Main()
        {
            short choice;
            do
            {
                Console.WriteLine("Пожалуйста, выбирите задание (от 1-го до 7-и)\n0 - Выход\n\n");
                choice = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                if (choice > 7)
                {
                    Console.WriteLine("Такого задания нет!");
                    AnyKey();
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
            short[] A = new short[5];
            short[,] B = new short[3, 4];
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine($"Пожалуйста, введите элемент {i + 1}/5: ");
                A[i] = Convert.ToInt16(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                for (int y = 0; y < 4; y++)
                {
                    B[i, y] = (short)rand.Next(0, 10);
                }
            }
            Console.WriteLine("\nПервый массив: ");
            foreach (short i in A)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nВторой массив: ");
            for (int i = 0; i < 3; i++)
            {
                for (int y = 0; y < 4; y++)
                {
                    Console.Write(B[i, y] + " ");
                }
                Console.WriteLine();
            }

            int sum = 0;
            foreach (short i in A)
            {
                sum += i;
            }
            for (int i = 0; i < 3; i++)
            {
                for (int y = 0; y < 4; y++)
                {
                    sum += B[i, y];
                }
            }
            Console.WriteLine($"Сумма элементов массивов: {sum}");

            long product = 1;
            foreach (short i in A)
            {
                product *= i;
            }
            for (int i = 0; i < 3; i++)
            {
                for (int y = 0; y < 4; y++)
                {
                    product *= B[i, y];
                }
            }
            Console.WriteLine($"Произведение элементов массивов: {product}");
            AnyKey();
        }

        static void Task2()
        {
            Random rand = new Random();
            short[,] myarr = new short[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int y = 0; y < 5; y++)
                {
                    myarr[i, y] = (short)rand.Next(-100, 100);
                }
            }
            Console.WriteLine("Наш массив: ");
            for (int i = 0; i < 5; i++)
            {
                for (int y = 0; y < 5; y++)
                {
                    Console.Write(myarr[i, y] + " ");
                }
                Console.WriteLine();
            }
            int max = myarr.Cast<short>().Max();
            int min = myarr.Cast<short>().Min();
            Console.WriteLine($"Максимум: {max}");
            Console.WriteLine($"Минимум: {min}");

            ArrayList myAl = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                for (int y = 0; y < 5; y++)
                {
                    if (myarr[i, y] < max && myarr[i, y] > min)
                    {
                        myAl.Add(myarr[i, y]);
                    }
                }
            }
            int sum = 0;
            foreach (short i in myAl)
            {
                sum += i;
            }
            Console.WriteLine($"Сумма элементов массива в диапазоне min-max: {sum}");

            AnyKey();
        }

        static void Task3()
        {
            Console.WriteLine("Пожалуйста, введите ваше предложение: ");
            string sentence = Console.ReadLine();
            Console.WriteLine("Шифруем: ");
            sentence = Encryption(sentence);
            Console.WriteLine(sentence);
            Console.WriteLine("Дешифруем: ");
            sentence = Decryption(sentence);
            Console.WriteLine(sentence);
            AnyKey();
        }

        static void Task4()
        {
            int[] matrixDigit = new int[2] { 5, 10 }; //Допустим... Это матрица 😆
            Console.WriteLine($"{matrixDigit[0]},{matrixDigit[1]}");
            Console.WriteLine("Пожалуйста, введите число-оператор: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] res = new int[2] { matrixDigit[0] + num, matrixDigit[1] + num };
            Console.WriteLine($"Сложение: {res[0]},{res[1]}");
            res[0] = matrixDigit[0] - num;
            res[1] = matrixDigit[1] - num;
            Console.WriteLine($"Вычитание: {res[0]},{res[1]}");
            res[0] = matrixDigit[0] * num;
            res[1] = matrixDigit[1] * num;
            Console.WriteLine($"Умножение: {res[0]},{res[1]}");
            AnyKey();
        }

        static void Task5()
        {
            Console.WriteLine("Пожалуйста, введите выражение \"x + x\"");
            string equation = Console.ReadLine();
            Console.WriteLine($"Результат: {Evaluate(equation)}");
            AnyKey();
        }

        static void Task6()
        {
            Console.WriteLine("Пожалуйста, введите предложение: ");
            string sentence = Console.ReadLine();
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            Console.WriteLine(ti.ToTitleCase(sentence));
            AnyKey();
        }

        static void Task7()
        {
            AnyKey();
        }

        static void AnyKey()
        {
            Console.WriteLine("\nPress any key");
            Console.ReadKey();
            Console.Clear();
        }

        static string Encryption(string _string)
        {
            StringBuilder sb = new StringBuilder(_string);
            for (int i = 0; i < sb.Length; i++)
            {
                sb[i]++;
            }
            _string = sb.ToString();
            return _string;
        }

        static string Decryption(string _string)
        {
            StringBuilder sb = new StringBuilder(_string);
            for (int i = 0; i < _string.Length; i++)
            {
                sb[i]--;
            }
            _string = sb.ToString();
            return _string;
        }

        static int Evaluate(string expression)
        {
            string[] temp = expression.Split();
            int result = int.Parse(temp[0]) + int.Parse(temp[2]);
            return result;
        }
    }
}