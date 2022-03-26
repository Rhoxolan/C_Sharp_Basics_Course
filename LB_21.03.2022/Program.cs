namespace program
{
    using System;
    using static MyClassLibrary.MyConsoleFunctional;

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
                Console.WriteLine("Пожалуйста, выбирите задание (1 или 2)\n0 - Выход\n\n");
                choice = NumberInput(0, 2);
                Console.Clear();
                if (choice > 1)
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
    }
}
