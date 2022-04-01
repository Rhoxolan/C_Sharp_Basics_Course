using System;

namespace program
{
    internal abstract class Manager : Service
    {
        public Manager(string name, double price, string provided_work) : base(name, price, provided_work) { }

        public abstract string GetRank();
    }
}
