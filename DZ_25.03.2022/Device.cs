using System;

namespace program
{
    internal abstract class Device : Product
    {
        protected Device(string name, double price) : base(name, price) { }

        public abstract string Description();

    }
}
