using System;

namespace program
{
    internal class TubularBells : MusicalInstrument
    {
        public TubularBells(string name, double price) : base(name, price) { }

        public override string Classification()
        {
            return "Ударные";
        }

        public override string Description()
        {
            return "Трубчатые колокола";
        }
    }
}
