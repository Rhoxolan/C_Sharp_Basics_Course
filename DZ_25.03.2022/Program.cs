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
                Console.WriteLine("Пожалуйста, выбирите задание (1 - 4)\n0 - Выход\n\n");
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
            Device[] devices = {
                new Kettle("Philips HD9339/80", 1999),
                new Microwave("BOSCH FFL020MW0", 2699),
                new Automobile("Renault Megane", 700000),
                new Steamship("Скадовск", 100000)
            };
            Console.WriteLine("Отдел устройств: ");
            foreach (Device d in devices)
            {
                Console.WriteLine($"{d.Description()} {d.Name} по цене {d.Price}");
            }

            MusicalInstrument[] musicalInstrument =
            {
                new Violin("Yamaha V3SKA", 13199),
                new DoubleBass("Stentor 1438/A", 49797),
                new Viola("Hora A-100", 8375),
                new TubularBells("ADAMS BK 5216L", 75000)
            };
            Console.WriteLine("\n\nОтдел музыкальных инструментов: ");
            foreach(MusicalInstrument m in musicalInstrument)
            {
                Console.WriteLine($"{m.Description()} {m.Name} класса {m.Classification()} по цене {m.Price}");
            }
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
}