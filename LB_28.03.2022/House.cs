using System;

namespace program
{
    interface IPart //Часть дома
    {
        string Name { get; }
    }

    internal class House
    {
        List<IPart> parts;

        public House()
        {
            parts = new List<IPart>();
        }

        public void AddPart(IPart part)
        {
            parts.Add(part);
        }

        public List<IPart> Parts
        {
            get { return parts; }
        }
    }

    internal class Basement : IPart
    {
        public string Name
        {
            get
            {
                return "Фасад";
            }
        }
    }

    internal class Wall : IPart
    {
        public string Name
        {
            get
            {
                return "Стена";
            }
        }
    }

    internal class Door : IPart
    {
        public string Name
        {
            get
            {
                return "Дверь";
            }
        }
    }

    internal class Window : IPart
    {
        public string Name
        {
            get
            {
                return "Окно";
            }
        }
    }

    internal class Roof : IPart
    {
        public string Name
        {
            get
            {
                return "Крыша";
            }
        }
    }
}

