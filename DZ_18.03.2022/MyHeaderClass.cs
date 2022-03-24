namespace MyHeaderNamespace
{
    using System;
    using MyException;

    public class MyHeaderClass
    {
        public static int NumberInput(int min, int max)
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

        public static bool ExitTo(int number, int exit_number)
        {
            return number == exit_number;
        }

        public static void AnyKey()
        {
            Console.WriteLine("\nPress any key");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
