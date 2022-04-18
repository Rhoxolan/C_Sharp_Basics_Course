using System;
using static MyClassLibrary.MyConsoleFunctional;
using MyClassLibrary;
using System.Text.RegularExpressions;

namespace program
{
    class Program
    {
        static void Main()
        {
            {
                var letters = new Letter[]
                {
                new Letter("A"),
                new Letter("B"),
                new Letter("C"),
                new Letter("D"),
                new Letter("E"),
                new Letter("F"),
                new Letter("G")

                };
                var alphabet = new Alphabet(letters);
                foreach (Letter character in alphabet)
                {
                    Console.Write(character.Character + " ");
                }
                Console.WriteLine("\n\n");
            }

            {
                var cars = new Car[]
                {
                new Car("ZAZ 968M"),
                new Car("Mercedes-Benz E-Class"),
                };
                var garage = new Garage(cars);
                foreach (Car model in garage)
                {
                    Console.WriteLine(model.Model);
                }
                Console.WriteLine("\n\n");
            }

            {
                var apartaments = new Apartament[]
                {
                new Apartament("Ivanovy"),
                new Apartament("Tarasenko"),
                new Apartament("Petrovy")
                };
                var house = new House(apartaments);
                foreach (Apartament apartament in apartaments)
                {
                    Console.WriteLine(apartament.Family);
                }
            }
        }
    }

    class Letter
    {
        public string Character { get; }
        public Letter(string character) => Character = character;
    }

    class Alphabet
    {
        Letter[] letters;
        public Alphabet(Letter[] letters) => this.letters = letters;
        public int Length => letters.Length;
        public IEnumerator<Letter> GetEnumerator()
        {
            for (int i = 0; i < letters.Length; i++)
            {
                yield return letters[i];
            }
        }
    }

    class Car
    {
        public string Model { get; }
        public Car(string model) => Model = model;
    }

    class Garage
    {
        Car[] cars;
        public Garage(Car[] cars) => this.cars = cars;
        public int Length => cars.Length;
        public IEnumerator<Car> GetEnumerator()
        {
            for (int i = 0; i < cars.Length; i++)
            {
                yield return cars[i];
            }
        }
    }

    class Apartament
    {
        public string Family { get; }
        public Apartament(string family) => Family = family;
    }

    class House
    {
        Apartament[] apartaments;
        public House(Apartament[] apartaments) => this.apartaments = apartaments;
        public int Length => apartaments.Length;
        public IEnumerator<Apartament> GetEnumerator()
        {
            for (int i = 0; i < apartaments.Length; i++)
            {
                yield return apartaments[i];
            }
        }
    }
}