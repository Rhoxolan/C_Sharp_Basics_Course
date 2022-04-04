using System;

namespace program
{
    interface IHawk
    {
        bool Attack
        {
            get
            {
                return true;
            }
        }
    }

    interface IPray
    {
        bool Run
        {
            get
            {
                return true;
            }
        }
    }

    internal class Tiger : IHawk
    {
        string AnimalName { get; set; }

        public Tiger(string animalName)
        {
            AnimalName = animalName;
        }

        public string Name
        {
            get
            {
                return "Тигр";
            }
        }
    }

    internal class Capreolus : IPray
    {
        string AnimalName { get; set; }

        public Capreolus(string animalName)
        {
            AnimalName = animalName;
        }

        public string Name
        {
            get
            {
                return "Косуля";
            }
        }
    }

    internal class Dog : IHawk, IPray
    {
        string AnimalName { get; set; }

        public Dog(string animalName)
        {
            AnimalName = animalName;
        }

        public string Name
        {
            get
            {
                return "Собачка";
            }
        }
    }
}
