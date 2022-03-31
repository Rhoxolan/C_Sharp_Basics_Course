using System;

namespace program
{
    internal class Automobile : Device
    {
        public Automobile(string name, double price) : base(name, price) { }

        public override string Description()
        {
            return "Автомобиль";
        }
    }
}
