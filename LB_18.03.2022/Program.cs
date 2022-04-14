using System;
using System.Text;

namespace program
{
    using MyException;
    using Bank;

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
                Console.WriteLine("Пожалуйста, выберите задание (от 1-го до 4-и)\n0 - Выход\n\n");
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
            Console.WriteLine($"Пожалуйста, введите число от {Int32.MinValue} до {Int32.MaxValue}\n" +
                $"0 - Выход в главное меню");
            int number = NumberInput(Int32.MinValue, Int32.MaxValue);
            if (ExitTo(number, 0))
            {
                Console.Clear();
                return;
            }
            Console.WriteLine($"Вы ввели число {number}!");
            AnyKey();
        }

        static void Task2()
        {
            Console.WriteLine($"Пожалуйста, введите число в двоичном формате " +
                $"(2 - Выход в главное меню):");
            int binary_number = NumberInput(Int32.MinValue, Int32.MaxValue);
            if(ExitTo(binary_number, 2))
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
            catch(FormatException fex)
            {
                Console.WriteLine(fex.Message);
                AnyKey();
                return;
            }
        }

        static void Task3()
        {
            try
            {
                Console.WriteLine("Пожалуйста, введите номер карты: ");
                string card_number = Console.ReadLine();
                if (card_number.Length != 16)
                {
                    throw new MyExceptionToString("\nОшибка ввода номера карты!\n");
                }
                Console.WriteLine("Пожалуйста, введите ваше ФИО: ");
                string full_name = Console.ReadLine();
                Console.WriteLine("Пожалуйста, введите год, до которого действительна карта: ");
                List<int> dateto = new List<int>();
                dateto.Add(NumberInput(2022, 2032));
                Console.WriteLine("Пожалуйста, введите месяц, до которого действительна карта: ");
                dateto.Add(NumberInput(1, 12));
                BankCard card = new BankCard(full_name, card_number, dateto);
                Console.WriteLine($"\n{card.full_name}\n" +
                    $"{card.card_number}");
                AnyKey();
            }
            catch (MyExceptionToString mexts)
            {
                Console.WriteLine(mexts.Message);
                AnyKey();
            }
            catch
            {
                Console.WriteLine("\nНеопределенная ошибка!\n");
                AnyKey();
            }
        }

        static void Task4()
        {
            try
            {
                Console.WriteLine("Пожалуйста, введите выражение вида a*b*c... :");
                string expression = Console.ReadLine();
                string[] subs = expression.Split('*');
                int[] nums = new int[subs.Length];
                for (int i = 0; i < subs.Length; i++)
                {
                    nums[i] = Convert.ToInt32(subs[i]);
                }
                int res = 1;
                for (int i = 0; i < nums.Length; i++)
                {
                    res *= nums[i];
                }
                Console.WriteLine($"Результат: {res}");
                AnyKey();
            }
            catch
            {
                Console.WriteLine("\nНепредвиденная ошибка!\n");
                AnyKey();
            }
        }

        static int NumberInput(int min, int max)
        {
            while (true)
            {
                try
                {
                    string s_number = Console.ReadLine();
                    int number = 0;
                    checked
                    {
                        number = Convert.ToInt32(s_number);
                        if (number < min || number > max)
                        {
                            throw new MyExceptionToString("\nВведено неверное значение!\n");
                        }
                        return number;
                    }
                }
                catch (MyExceptionToString ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch
                {
                    Console.WriteLine("\nНепредвиденная ошибка!\n");
                }
            }
        }

        static bool ExitTo(int number, int exit_number)
        {
            return number == exit_number;
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
