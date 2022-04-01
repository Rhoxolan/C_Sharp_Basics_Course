using System;

namespace program
{
    internal abstract class Service : Product
    {
        protected string provided_work;

        public Service(string name, double price, string provided_work) : base(name, price)
        {
            this.provided_work = provided_work;
        }

        public abstract void ShowProvidedWork();
    }
}
