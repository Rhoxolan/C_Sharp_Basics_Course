using System;

namespace program
{
    internal class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

    }

    internal abstract class Cats : Animal
    {
        public string Voice { get; set; }

        public Cats(string voice, string name) : base(name)
        {
            Voice = voice;
        }

        public abstract void Says();
    }

    internal class Cat : Cats
    {
        public string Color { get; set; }

        public Cat(string color, string voice, string name) : base (voice, name)
        {
            Color = color;
        }

        public override void Says()
        {
            Console.WriteLine($"{Color} {Name} says {Voice}");
        }

    }

    internal class Tiger: Cats
    {
        public string Color { get; set; }

        public Tiger(string color, string voice, string name) : base(voice, name)
        {
            Color = color;
        }

        public override void Says()
        {
            Console.WriteLine($"{Color} {Name} says {Voice}");
        }
    }
}
