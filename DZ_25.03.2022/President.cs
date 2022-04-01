using System;

namespace program
{
    internal class President : Manager
    {
        public President(string name, double price, string provided_work) : base(name, price, provided_work) { }

        public override string GetRank()
        {
            return "Высокий";
        }

        public override void ShowProvidedWork()
        {
            Console.WriteLine(provided_work);
        }
    }
}
