using System;
using System.Text;

namespace program
{
    using MyException;

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
            AnyKey();
        }

        static void Task2()
        {
            AnyKey();
        }

        static void Task3()
        {
            AnyKey();
        }

        static void Task4()
        {
            AnyKey();
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

        static void AnyKey()
        {
            Console.WriteLine("\nPress any key");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
