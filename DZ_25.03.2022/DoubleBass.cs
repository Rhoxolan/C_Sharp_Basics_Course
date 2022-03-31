using System;

namespace program
{
    internal class DoubleBass : MusicalInstrument
    {
        public DoubleBass(string name, double price) : base(name, price) { }

        public override string Classification()
        {
            return "Cмычковые";
        }

        public override string Description()
        {
            return "Контрабас";
        }
    }
}
