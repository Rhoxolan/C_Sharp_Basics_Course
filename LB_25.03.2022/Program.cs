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
            Human ordinary_person = new("Петя", 31);
            Builder builder = new("Коля", 23, "Каменщик", 10000);
            Pilot pilot1 = new("Сергей", 37, "Сельскохозяйственная авиация", "Grumman Ag Cat", 12500);
            Pilot pilot2 = new("Хьюберт", 27, "Боевая авиация", "B-52 Stratofortress", 75000);
            Console.WriteLine($"Встретилиь как-то в баре {ordinary_person}, {builder}, {pilot1} и {pilot2}");
            AnyKey();
        }

        static void Task2()
        {
            Person pavel = new();
            try
            {
                pavel.AddForeignPassport("XXXXXXXXXXX", new int[] { 1, 7, 2017 });
            }
            catch(MyExceptionToString MEXTS)
            {
                Console.WriteLine($"\n{MEXTS.Message}\n");
            }
            pavel.AddPassport("Pavel", "Batsemakin", "Andriyovuch", "XXXXXXXXX", "XXXX", new int[] { 1, 2, 2016 });
            try
            {
                Console.WriteLine(pavel.GetForeignPassportName());
            }
            catch (MyExceptionToString MEXTS)
            {
                Console.WriteLine($"\n{MEXTS.Message}\n");
            }
            pavel.AddForeignPassport("XXXXXXXXXXX", new int[] { 1, 7, 2017 });

            Console.WriteLine("Пасспорт:");
            Console.WriteLine(pavel.GetPassportName());
            Console.WriteLine(pavel.GetPassportSurname());
            Console.WriteLine(pavel.GetPassportPatronymic());
            Console.WriteLine($"Номер паспорта: {pavel.GetPassportNumber()}");
            Console.WriteLine($"Кем выдан: {pavel.GetPassportIssuedBy()}");
            Console.WriteLine($"Дата выдачи: {pavel.GetPassportDate()[0]}.{pavel.GetPassportDate()[1]}." +
                $"{pavel.GetPassportDate()[2]}");
            Console.WriteLine();
            Console.WriteLine("Загран паспорт:");
            Console.WriteLine(pavel.GetForeignPassportName());
            Console.WriteLine(pavel.GetForeignPassportSurname());
            Console.WriteLine($"Номер паспорта: {pavel.GetForeignPassportNumber()}");
            Console.WriteLine($"Дата выдачи: {pavel.GetForeignPassportDate()[0]}.{pavel.GetForeignPassportDate()[1]}." +
                $"{pavel.GetForeignPassportDate()[2]}");
            pavel.AddVisas("Working visa category D, Poland, 2018");
            pavel.AddVisas("Visa free work travel, Poland, 2019");
            Console.WriteLine("Визы: ");
            foreach (var el in pavel.GetVisas())
            {
                Console.WriteLine(el);
            }
            AnyKey();
        }

        static void Task3()
        {
            Cat ruzhyk = new("Рыжий", "Мяу", "Кот Рыжик");
            ruzhyk.Says();
            Tiger vitalya = new("Полосатый", "Ррр", "Тигр");
            vitalya.Name = "Тигр Виталя";
            vitalya.Says();
            Console.WriteLine("\n:)");
            AnyKey();
        }

        static void Task4()
        {
            Figure[] figures =
            {
                new Square(10),
                new Rectangle(10,20),
                new Circle(3),
                new Trapezoid(70, 77, 78)
            };
            foreach (Figure f in figures)
            {
                Console.WriteLine($"Area of {f.GetType().Name} is {f.GetArea()}");
            }
            AnyKey();
        }
    }
}
