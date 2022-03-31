using System;

namespace program
{
    internal class Kettle : Device
    {
        public Kettle(string name, double price) : base(name, price) {}

        public override string Description()
        {
            return "Чайник";
        }
    }
}
