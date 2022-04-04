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
        public string AnimalName { get; set; }

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
        public string AnimalName { get; set; }

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

    internal class  Jackal : IHawk, IPray
    {
        public string AnimalName { get; set; }

        public Jackal(string animalName)
        {
            AnimalName = animalName;
        }

        public string Name
        {
            get
            {
                return "Шакал";
            }
        }
    }
}
