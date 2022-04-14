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
                Console.WriteLine("Пожалуйста, выберите задание (1 или 2)\n0 - Выход\n\n");
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
            Console.WriteLine("Пожалуйста, введите начало диапазона: ");
            int begin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите конец диапазона: ");
            int end = Convert.ToInt32(Console.ReadLine());
            ArrayRange<int> ar = new(begin, end);
            for (int i = begin; i <= end; i++)
            {
                Console.WriteLine($"Пожалуйста, введите элемент {i}: ");
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Наш массив на {ar.Capacity} элементов c индексами от " +
                $"{ar.Begin} до {ar.End}: ");
            foreach (var i in ar)
            {
                Console.Write(i + " ");
            }
            AnyKey();
        }

        static void Task2()
        {
            Collective people = new(7);
            people[5] = new Person { Age = 31, Name = "Petro", Profession = "Fitter" };
            Console.WriteLine(people[5]);
            AnyKey();
        }
    }
}