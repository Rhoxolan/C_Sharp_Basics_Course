using System;
using MyClassLibrary;

namespace program
{
    internal class Backpack
    {
        public string? Color { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? FabricStructure { get; set; }
        public int Weight { get; set; }
        public int Volume { get; set; }

        public delegate Tuple<string?, int> addingThing();
        public event addingThing? AddingThing;
        private int currentVolume;
        private List<string?> listOfThings;

        public Backpack(string? color, string? brand, string? model, string? fabricStructure, int weight, int volume)
        {
            Color = color;
            Brand = brand;
            Model = model;
            FabricStructure = fabricStructure;
            Weight = weight;
            Volume = volume;
            currentVolume = 0;
            listOfThings = new();
        }

        public void AddThing()
        {
            if (AddingThing is null)
            {
                return;
            }
            Tuple<string?, int> thing = AddingThing();
            if (currentVolume + thing.Item2 > Volume)
            {
                throw new Exception();
            }
            listOfThings.Add(thing.Item1);
            currentVolume += thing.Item2;
        }

        public List<string?> ListOfThings
        {
            get
            {
                return listOfThings;
            }
        }
    }
}
