using System;

namespace program
{
    internal class Steamship : Device
    {
        public Steamship(string name, double price) : base(name, price) { }

        public override string Description()
        {
            return "Пароход";
        }
    }
}
