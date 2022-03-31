using System;

namespace program
{
    internal abstract class MusicalInstrument : Product
    {
        public MusicalInstrument(string name, double price) : base(name, price) { }

        public abstract string Description();

        public abstract string Classification();
    }
}
