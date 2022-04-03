using System;

namespace program
{
    interface IPart //Часть дома
    {
        string GetName();
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
        public string GetName()
        {
            return "Фундамент";
        }
    }

    internal class Wall : IPart
    {
        public string GetName()
        {
            return "Стена";
        }
    }

    internal class Door : IPart
    {
        public string GetName()
        {
            return "Дверь";
        }
    }

    internal class Window : IPart
    {
        public string GetName()
        {
            return "Окно";
        }
    }

    internal class Roof : IPart
    {
        public string GetName()
        {
            return "Крыша";
        }
    }
}

