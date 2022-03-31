using System;

namespace program
{
    internal class Microwave : Device
    {
        public Microwave(string name, double price) : base(name, price) { }

        public override string Description()
        {
            return "Микроволновка";
        }
    }
}
