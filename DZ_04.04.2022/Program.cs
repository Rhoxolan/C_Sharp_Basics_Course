using System;
using static MyClassLibrary.MyConsoleFunctional;
using MyClassLibrary;
using System.Drawing;

namespace program
{
    public delegate T _delegate<out T>();
    public delegate T1 _delegate<out T1, in T2>(T2 val);
    public delegate T1 _delegate<out T1, in T2, in T3>(T2 val1, T3 val2);
    public delegate void _delegate(ref int[] val1, ref List<int> val2);

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
                Console.WriteLine("Пожалуйста, выберите задание (1 - 6)\n0 - Выход\n\n");
                choice = NumberInput(0, 6);
                Console.Clear();
                if (choice > 5)
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
            } while (choice != 0);
        }

        static void Task1()
        {
            _delegate<Color> toColor = delegate
            {
                Console.WriteLine("Пожалуйста, введите первый цвет (R) в формате RGB:");
                byte R = Convert.ToByte(NumberInput(0, 255));
                Console.WriteLine("Пожалуйста, введите второй цвет (G) в формате RGB:");
                byte G = Convert.ToByte(NumberInput(0, 255));
                Console.WriteLine("Пожалуйста, введите второй цвет (B) в формате RGB:");
                byte B = Convert.ToByte(NumberInput(0, 255));
                Color color = new();
                color = Color.FromArgb(R, G, B);
                return color;
            };
            Color color = toColor();
            AnyKey();
        }

        static void Task2()
        {
            Backpack bag = new("Gray-red", "Cropp", "C-200", "20% polyester, 70% cotton, 10% leather", 1, 10);
            bag.AddThing();
            bag.AddingThing += delegate
            {
                Console.WriteLine("Пожалуйста, введите название вещи: ");
                string? name = Console.ReadLine();
                Console.WriteLine("Пожалуйста, введите объём веши: ");
                int vol = NumberInput(0, int.MaxValue);
                return new Tuple<string?, int>(name, vol);
            };
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    bag.AddThing();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\n{ex.Message}\n");
                }
            }
            Console.WriteLine($"\nВещи рюкзака {bag.Brand} {bag.Model}: ");
            foreach(var i in bag.ListOfThings)
            {
                Console.WriteLine(i);
            }    
            AnyKey();
        }

        static void Task3()
        {
            int[] mas = { -77, -7, -8, 0, 7, 70, 1, 7000 };
            List<int> seven_multiplicity = new();
            _delegate seventhmult = (ref int[] arr, ref List<int> l) =>
            {
                foreach (var i in arr)
                {
                    if (i % 7 == 0)
                    {
                        l.Add(i);
                    }
                }
            };
            seventhmult(ref mas, ref seven_multiplicity);
            foreach(var l in seven_multiplicity)
            {
                Console.Write(l + " ");
            }
            AnyKey();
        }

        static void Task4()
        {
            int[] mas = { -10, -1, -0, 0, 1, 10};
            _delegate<int, int[]> positiveamount = (int[] arr) =>
            {
                int amount = 0;
                foreach(int i in arr)
                {
                    if (i > 0)
                    {
                        amount++;
                    }
                }
                return amount;
            };
            int positive_amount = positiveamount(mas);
            foreach (int i in mas)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine($"\nКоличество позитивных чисел: {positive_amount}");
            AnyKey();
        }

        static void Task5()
        {
            int[] mas = { -10, -10, -8, -7, -5, 0, 7, 70, 1 };
            List<int> uniqueNegative = new();
            _delegate uniqueneg = (ref int[] arr, ref List<int> l) =>
            {
                foreach(int i in arr)
                {
                    if (i < 0 && !l.Contains(i))
                    {
                        l.Add(i);
                    }
                }
            };
            uniqueneg(ref mas, ref uniqueNegative);
            foreach(int i in mas)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nУникальные отрицательные числа: ");
            foreach (int l in uniqueNegative)
            {
                Console.Write(l + " ");
            }
            AnyKey();
        }

        static void Task6()
        {
            Console.WriteLine("Пожалуйста, введите предложение: ");
            string? _str = Console.ReadLine();
            Console.WriteLine("Пожалуйста, введите искомое слово: ");
            string? _word = Console.ReadLine();
            var searhstr = (string? str, string? word) => //Пример неявной типизации
            {
                if (str.Contains(word))
                {
                    return true;
                }
                return false;
            };
            if(searhstr(_str, _word))
            {
                Console.WriteLine("Да!");
            }
            else
            {
                Console.WriteLine("Нет!");
            }
            AnyKey();
        }
    }
}