using System;

namespace program
{
    internal class Violin : MusicalInstrument
    {
        public Violin(string name, double price) : base(name, price) { }

        public override string Classification()
        {
            return "Cмычковые";
        }

        public override string Description()
        {
            return "Скрипка";
        }
    }
}
