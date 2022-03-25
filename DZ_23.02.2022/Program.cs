using System;

namespace program
{
    class Program
    {
        static void Main()
        {
            int choice;
            do
            {
                Console.WriteLine($"Пожалуйста, выбирите:{Environment.NewLine}" +
                $"1 - Fizz/Buzz{Environment.NewLine}" +
                $"2 - Проценты{Environment.NewLine}" +
                $"3 - Число из цифер{Environment.NewLine}" +
                $"4 - Разряды шестизначного числа{Environment.NewLine}" +
                $"5 - Дата{Environment.NewLine}" +
                $"6 - Температура{Environment.NewLine}" +
                $"7 - Четные числа{Environment.NewLine}" +
                $"0 - Выход{Environment.NewLine}{Environment.NewLine}");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (choice > 6)
                {
                    Console.Write("Пожалуйста, введите начало диапазона: ");
                    int first = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Пожалуйста, введите конец диапазона: ");
                    int second = Convert.ToInt32(Console.ReadLine());
                    if (first > second)
                    {
                        int buf = first;
                        first = second;
                        second = buf;
                    }
                    for (int i = first; i <= second; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write(i + " ");
                        }
                    }
                    Console.WriteLine($"{Environment.NewLine}Press any key");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice > 5)
                {
                    Console.WriteLine("Пожалуйста, введите температуру: ");
                    double t = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Пожалуйста, выберите - перевести в °C (1) или в °F (2)");
                    double c = Convert.ToDouble(Console.ReadLine());
                    if (c == 1) //Из °F в °C
                    {
                        t = (t - 32) / 1.8;
                    }
                    if (c == 2) //Из °С в °F
                    {
                        t = (t * 1.8) + 32;
                    }
                    Console.WriteLine($"{Environment.NewLine}Res = {t}");
                    Console.WriteLine($"{Environment.NewLine}Press any key");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice > 4)
                {
                    Console.WriteLine("Пожалуйста, введите день в формате XX");
                    int day = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Пожалуйста, введите месяц в формате XX");
                    int month = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Пожалуйста, введите год в формате XXXX");
                    int year = Convert.ToInt32(Console.ReadLine());
                    Console.Write(day + "." + month + "." + year + " ");
                    if (month < 3 || month > 11)
                    {
                        Console.WriteLine("Winter");
                    }
                    else if (month > 2 && month < 6)
                    {
                        Console.WriteLine("Spring");
                    }
                    else if (month > 5 && month < 9)
                    {
                        Console.WriteLine("Summer!");
                    }
                    Console.WriteLine($"{Environment.NewLine}Press any key");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice > 3)
                {
                    char[] c_num = new char[6];
                    for (int i = 0; i < c_num.Length; i++)
                    {
                        Console.Write($"Пожалуйста, введите цифру {i + 1}/6: ");
                        c_num[i] = (char)Console.Read();
                        Console.ReadLine();
                    }
                    Console.Write($"Пожалуйста, введите первую цифру для обмена: ");
                    int first = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"Пожалуйста, введите вторую цифру для обмена: ");
                    int second = Convert.ToInt32(Console.ReadLine());
                    int buf = c_num[first - 1];
                    c_num[first - 1] = c_num[second - 1];
                    c_num[second - 1] = (char)buf;
                    Console.Write($"{Environment.NewLine}Ваше число: ");
                    foreach (char c in c_num)
                    {
                        Console.Write(c);
                    }
                    Console.WriteLine($"{Environment.NewLine}Press any key");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice > 2)
                {
                    char[] c_num = new char[4];
                    for (int i = 0; i < 4; i++)
                    {
                        Console.Write($"Пожалуйста, введите цифру {i + 1}/4: ");
                        c_num[i] = (char)Console.Read();
                        Console.ReadLine();
                    }
                    Console.Write($"{Environment.NewLine}Ваше число: ");
                    foreach (char c in c_num)
                    {
                        Console.Write(c);
                    }
                    Console.WriteLine($"{Environment.NewLine}Press any key");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice > 1)
                {
                    Console.Write("Пожалуйста, введите первое число (значение): ");
                    double first = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Пожалуйста, введите второе число (число процент): ");
                    double second = Convert.ToDouble(Console.ReadLine());
                    double res = first * (second / 100);
                    Console.Write($"{second} процентов от {first}: {res}{Environment.NewLine}");
                    Console.WriteLine($"{Environment.NewLine}Press any key");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice > 0)
                {
                    Console.WriteLine("Пожалуйста, число от 1 до 100");
                    int num = Convert.ToInt32(Console.ReadLine());
                    while (num < 1 || num > 100)
                    {
                        Console.WriteLine($"{Environment.NewLine}Ошибка ввода! Введите, пожалуста, еще раз!");
                        num = Convert.ToInt32(Console.ReadLine());
                    }
                    if (num % 5 == 0 && num % 3 == 0)
                    {
                        Console.WriteLine("Fizz Buzz");
                    }
                    else if (num % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else if (num % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else
                    {
                        Console.WriteLine(num);
                    }
                    Console.WriteLine($"{Environment.NewLine}Press any key");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (choice != 0);
        }
    }
}

// 4/5