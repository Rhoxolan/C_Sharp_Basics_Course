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
                Console.WriteLine("Пожалуйста, выберите задание (1 - 2)\n0 - Выход\n\n");
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
            Random rand = new Random();
            IHawk tiger = new Tiger("Вася");
            IPray capreolus = new Capreolus("Бэмби");
            IHawk jackal = new Jackal("Шарик");
            if (tiger.Attack && capreolus.Run
                && tiger is Tiger && capreolus is Capreolus)
            {
                Console.WriteLine("Тигр нападает на косулю: ");
                int rnd = rand.Next(0,2);
                if (rnd > 0)
                {
                    Console.WriteLine($"{(capreolus as Capreolus).Name} {(capreolus as Capreolus).AnimalName} " +
                        $"успела спастись!");
                }
                else if (rnd > -1)
                {
                    Console.WriteLine($"{(tiger as Tiger).Name} {(tiger as Tiger).AnimalName} " +
                        $"хорошо покушал!");
                }
            }
            Console.WriteLine();
            if(tiger.Attack && (jackal as IPray).Run
                && tiger is Tiger && jackal is IPray)
            {
                Console.WriteLine("Тигр нападает на шакала: ");
                int rnd = rand.Next(0, 2);
                if (rnd > 0)
                {
                    Console.WriteLine($"{(tiger as Tiger).Name} {(tiger as Tiger).AnimalName} " +
                        $"Остался голодным!");
                }
                else if (rnd > -1)
                {
                    Console.WriteLine($"Ой! {(jackal as Jackal).Name} {(jackal as Jackal).AnimalName} " +
                        $"не успела убежать!");
                }
            }
            AnyKey();
        }

        static void Task2()
        {
            Shop MyShop = new(new List<Laptop> { new Laptop("HP", 300), new Laptop("Asus", 250) });
            MyShop.AddLaptop(new Laptop("Vinga", 400));
            MyShop.AddLaptop(new Laptop("Vinga", 500));
            MyShop[1] = new Laptop("Asus", 270);
            foreach (Laptop laptop in MyShop)
            {
                Console.WriteLine(laptop);
            }
            Console.WriteLine();
            foreach (Laptop laptop in MyShop["Vinga"]) //Благодаря перегруженному индексатору мы можем через цикл foreach
            {                                          //Отобразить все эелементы с указанным названием!
                Console.WriteLine(laptop);
            }
            MyShop["Vinga", "set"] = "Sienems"; //Эксперементальная конструкция - редактирование вcех элементов
            Console.WriteLine();                //с указанным значением с использованием флага.
            foreach (Laptop laptop in MyShop)
            {
                Console.WriteLine(laptop);
            }
            AnyKey();
        }
    }
}