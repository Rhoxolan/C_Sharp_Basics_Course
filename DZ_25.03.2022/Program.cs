using System;
using static MyClassLibrary.MyConsoleFunctional;
using MyClassLibrary;

namespace program
{
    class Program
    {
        static void Main()
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
            foreach (MusicalInstrument m in musicalInstrument)
            {
                Console.WriteLine($"{m.Description()} {m.Name} класса {m.Classification()} по цене {m.Price}");
            }

            Service[] services =
            {
                new Security("Охрана", 10000, "Предоставляем услуги охраны. Недорого."),
                new Security("Охрана", 90000, "Предоставляем услуги охраны супермаркетов и продуктовых складов.")
            };
            Console.WriteLine($"\n\nРаздел услуг:");
            foreach (Service service in services)
            {
                Console.WriteLine("Категория: " + service.Name);
                Console.WriteLine("Оплата: " + service.Price + "/мес");
                service.ShowProvidedWork();
                Console.WriteLine();
            }

            Manager[] managers =
            {
                new President("Управление", 250000, "Услуги управления высшего ранга"),
                new Engineer("Инжнерно-технические работы", 30000, "Пуско-наладочные электротехничские работы")
            };
            Console.WriteLine("Раздел услуг упралвения: ");
            foreach (Manager manager in managers)
            {
                Console.WriteLine("Категория: " + manager.Name);
                Console.WriteLine("Оплата: " + manager.Price + "/мес");
                Console.WriteLine("Уровень: " + manager.GetRank());
                manager.ShowProvidedWork();
                Console.WriteLine();
            };
        }

    }
}