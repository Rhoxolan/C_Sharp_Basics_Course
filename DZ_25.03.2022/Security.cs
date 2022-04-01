using System;

namespace program
{
    internal class Security : Service
    {
        public Security(string name, double price, string provided_work) : base(name, price, provided_work) { }

        public override void ShowProvidedWork()
        {
            Console.WriteLine(provided_work);
        }
    }
}
