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
                $"1 - Цитата Бёрна Страуструпа{Environment.NewLine}" +
                $"2 - Вычисления из 5-и чисел{Environment.NewLine}" +
                $"3 - Перевернуть 6-и значное число{Environment.NewLine}" +
                $"4 - Показать числа Фибоначчи{Environment.NewLine}" +
                $"5 - Вывести все целые числа от A до B {Environment.NewLine}" +
                $"6 - Линия {Environment.NewLine}" +
                $"0 - Выход из программы: {Environment.NewLine}{Environment.NewLine}");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (choice > 5)
                {
                    Console.Write("Пожалуйста, введите длину строки :");
                    int lenght = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Пожалуйста, выберите - горизотальный вывод (1)" +
                        "или вертикальный (2) :");
                    int output = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Пожалуйста, выберите символ: ");
                    string? c = Console.ReadLine();
                    if (output == 2) { c += "\n"; }
                    for (int i = 0; i < lenght; i++)
                    {
                        Console.Write(c);
                    }
                    Console.WriteLine($"{Environment.NewLine}Press any key");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice > 4)
                {
                    Console.Write("Пожалуйста, введите первое число: ");
                    int A = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Пожалуйста, введите второе число: ");
                    int B = Convert.ToInt32(Console.ReadLine());
                    for (int i = A; i <= B; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write(i + " ");
                        }
                        Console.Write($"{Environment.NewLine}");
                    }
                    Console.WriteLine($"{Environment.NewLine}Press any key");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice > 3)
                {
                    Console.WriteLine($"Пожалуйста, введите конец диапазона чисел: {Environment.NewLine}");
                    int end = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Числа Фиббоначи: ");
                    int j = 1;
                    for (int i = 1; i <= end; i += j)
                    {
                        Console.Write(i + " ");
                        j = i - j;
                    }
                    Console.WriteLine($"{Environment.NewLine}Press any key");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice > 2)
                {
                    Console.WriteLine("Пожалуйста, введите шестизначное число: ");
                    string? c_number = Console.ReadLine();
                    Console.WriteLine($"Строка наоборот: {Environment.NewLine}");
                    for (int i = c_number.Length - 1; i > -1; --i)
                    {
                        Console.Write(c_number[i]);
                    }
                    Console.WriteLine($"{Environment.NewLine}Press any key");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice > 1)
                {
                    int[] number = new int[5];
                    int sum = 0;
                    int top = int.MinValue;
                    int min = int.MaxValue;
                    for (int i = 0; i < number.Length; i++)
                    {
                        Console.WriteLine($"Пожалуста, введите значение {i + 1}/5: ");
                        number[i] = Convert.ToInt32(Console.ReadLine());
                        sum += number[i];
                        if (number[i] > top)
                        {
                            top = number[i];
                        }
                        if (number[i] < min)
                        {
                            min = number[i];
                        }
                    }
                    Console.WriteLine($"{Environment.NewLine}Sum = {sum}{Environment.NewLine}" +
                            $"Min = {min}{Environment.NewLine}" +
                            $"Max = {top}{Environment.NewLine}");
                    Console.WriteLine($"{Environment.NewLine}Press any key");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice > 0)
                {
                    Console.WriteLine($"It's easy to win forgiveness for being wrong;{Environment.NewLine}" +
                        $"being right is what gets you into real trouble.{Environment.NewLine}" +
                        $"Bjarne Stroustrup{Environment.NewLine}{Environment.NewLine}{Environment.NewLine}" +
                        $"Press any key");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (choice != 0);
        }
    }
}
