using System;
using static MyClassLibrary.MyConsoleFunctional;
using MyClassLibrary;

namespace program
{
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
                Console.WriteLine("Пожалуйста, выберите задание (1 - 4)\n0 - Выход\n\n");
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
            int[] values1 = new int[5] { 1, 10, 5, 13, 4 };
            int[] values2 = new int[5] { 19, 1, 4, 9, 8 };
            int[] values3 = values1.Concat(values2).ToArray();
            foreach (int value in values3)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
            int[] values4 = values3.Where(x => x % 2 == 0).ToArray();
            int average = 0;
            foreach (int value in values4)
            {
                average += value;
            }
            average /= values4.Count();
            Console.WriteLine(average);
            AnyKey();
        }

        static void Task2()
        {
            List<Good> goods1 = new()
            {
                new Good(1, "Nokia 1100", 450.99, "Mobile"),
                new Good(2, "Iphone 4", 5000, "Mobile"),
                new Good(3, "Refregirator 500", 2555, "Kitchen"),
                new Good(4, "Mixer", 150, "Kitchen"),
                new Good(5, "Magnitola", 1499, "Car"),
            };
            List<Good> goods2 = new()
            {
                new Good(6, "Samsung Galaxy", 3100, "Mobile"),
                new Good(7, "Auto cleaner", 2300, "Car"),
                new Good(8, "Owen", 700, "Kitchen"),
                new Good(9, "Siemens Turbo", 3199, "Mobile"),
                new Good(10, "Lighter", 150, "Car"),
            };

            var goods = goods1.Concat(goods2).ToList(); //Соединяем два Листа путем методов расширения Concat и ToList
            foreach (Good good in goods)//Выводим на экран товары
            {
                Console.WriteLine(good);
            }
            Console.WriteLine("\n__________\n");
            var newgoods = goods.Where(i => i.Price > 1000).ToList(); //Где цена больше 1000
            foreach (Good good in newgoods)
            {
                Console.WriteLine(good);
            }
            Console.WriteLine("\n__________\n");
            newgoods = goods.Where(i => i.Price > 1000 && i.Category != "Kitchen").ToList(); //Где цена больше 1000 и не "Kitchen"
            foreach (Good good in newgoods)
            {
                Console.WriteLine(good);
            }
            Console.WriteLine("\n__________\n");
            double max = goods.Max(a => a.Price); //Поиск максимума
            var result = goods.FirstOrDefault(a => a.Price == max);
            Console.WriteLine("Max = " + max.ToString());
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
    }

    public record Good (int Id, string Title, double Price, string Category);
}