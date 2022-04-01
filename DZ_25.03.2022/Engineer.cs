using System;

namespace program
{
    internal class Engineer : Manager
    {
        public Engineer(string name, double price, string provided_work) : base(name, price, provided_work) { }

        public override string GetRank()
        {
            return "Средний";
        }

        public override void ShowProvidedWork()
        {
            Console.WriteLine(provided_work);
        }
    }
}
