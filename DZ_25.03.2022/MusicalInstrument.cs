using System;

namespace program
{
    internal abstract class MusicalInstrument : Device
    {
        public MusicalInstrument(string name, double price) : base(name, price) { }

        public abstract string Classification();
    }
}
