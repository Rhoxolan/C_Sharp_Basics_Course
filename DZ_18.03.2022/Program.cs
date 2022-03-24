namespace program
{
    using System;
    using MyHeaderNamespace;
    using static MyHeaderNamespace.MyHeaderClass;
    using MyException;
    using PasportNamespace;

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
                Console.WriteLine("Пожалуйста, выбирите задание (от 1-го до 4-и)\n0 - Выход\n\n");
                choice = NumberInput(0, 4);
                Console.Clear();
                if (choice > 3)
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
            Console.WriteLine($"Пожалуйста, введите число в двоичном формате " +
                $"(2 - Выход в главное меню):");
            int binary_number = NumberInput(Int32.MinValue, Int32.MaxValue);
            if (ExitTo(binary_number, 2))
            {
                Console.Clear();
                return;
            }
            int decimal_number;
            try
            {
                decimal_number = Convert.ToInt32(Convert.ToString(Convert.ToInt32(Convert.ToString(binary_number), 2), 10));
                Console.WriteLine($"Число в десятичном представлении: {decimal_number}");
                AnyKey();
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
                AnyKey();
                return;
            }
        }

        static void Task2()
        {
            Console.WriteLine("Пожалуйста, введите словами цифру from one to nine: ");
            string s_number = Console.ReadLine();
            Tuple<string, int>[] tuple = {
                new Tuple<string, int>("one", 1),
                new Tuple<string, int>("two", 2),
                new Tuple<string, int>("three", 3),
                new Tuple<string, int>("four", 4),
                new Tuple<string, int>("five", 5),
                new Tuple<string, int>("six", 6),
                new Tuple<string, int>("seven", 7),
                new Tuple<string, int>("eight", 8),
                new Tuple<string, int>("nine", 9),
            };
            foreach (var t in tuple)
            {
                if(s_number == t.Item1)
                {
                    Console.WriteLine($"Вы ввели цифру {t.Item2}!");
                    AnyKey();
                    return;
                }
            }
            Console.WriteLine("Вы ввели что-то не то!");
            AnyKey();
        }

        static void Task3()
        {
            try
            {
                Console.WriteLine("Пожалуйста, введите имя (0 - Выход в главное меню):");
                string name = Console.ReadLine();
                if(ExitTo(name, '0'))
                {
                    Console.Clear();
                    return;
                }
                Console.WriteLine("Пожалуйста, введите фамилию (0 - Выход в главное меню):");
                string surname = Console.ReadLine();
                if (ExitTo(surname, '0'))
                {
                    Console.Clear();
                    return;
                }
                Console.WriteLine("Пожалуйста, введите номер паспорта (0 - Выход в главное меню):");
                string passportNumber = Console.ReadLine();
                if (ExitTo(passportNumber, '0'))
                {
                    Console.Clear();
                    return;
                }
                if (passportNumber.Length != 8)
                {
                    throw new MyExceptionToString("Ошибка ввода номера паспорта!");
                }
                ForeignPassport foreignPassport = new ForeignPassport(name, surname, passportNumber);
                Console.Clear();
                Console.WriteLine(foreignPassport.name);
                Console.WriteLine(foreignPassport.surname);
                Console.WriteLine(foreignPassport.passportNumber);
                AnyKey();
            }
            catch (MyExceptionToString ex)
            {
                Console.WriteLine(ex.Message);
                AnyKey();
            }
            catch
            {
                Console.WriteLine("\nНепредвиденная ошибка!\n");
                AnyKey();
            }
        }

        static void Task4()
        {
            try
            {
                Console.WriteLine("Пожалуйста, введите логическое выражение вида a < b:");
                string expression = Console.ReadLine();
                string[] subs = expression.Split('>', '<');
                if (subs.Length != 2)
                {
                    throw new MyExceptionToString("\nОшибка ввода выражения!\n");
                }
                int leftoperand = Convert.ToInt32(subs[0]);
                int rightoperand = Convert.ToInt32(subs[1]);
                if (expression.Contains('>'))
                {
                    if (leftoperand > rightoperand)
                    {
                        Console.WriteLine("Уравнение верно!");
                    }
                    else
                    {
                        Console.WriteLine("Уравнение неверно!");
                    }
                }
                if (expression.Contains('<'))
                {
                    if (leftoperand < rightoperand)
                    {
                        Console.WriteLine("Уравнение верно!");
                    }
                    else
                    {
                        Console.WriteLine("Уравнение неверно!");
                    }
                }
                AnyKey();
            }
            catch (MyExceptionToString ex)
            {
                Console.WriteLine(ex.Message);
                AnyKey();
            }
            catch
            {
                Console.WriteLine("\nНепредвиденная ошибка!\n");
                AnyKey();
            }
        }
    }
}