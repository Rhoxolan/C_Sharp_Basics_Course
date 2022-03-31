using System;

namespace program
{
    internal class Viola : MusicalInstrument
    {
        public Viola(string name, double price) : base(name, price) { }

        public override string Classification()
        {
            return "Cмычковые";
        }

        public override string Description()
        {
            return "Альт";
        }
    }
}
