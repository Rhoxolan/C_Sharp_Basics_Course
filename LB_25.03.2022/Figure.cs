using System;

namespace program
{
    internal abstract class Figure
    {
        protected double length;

        public Figure (double length)
        {
            this.length = length;
        }

        public abstract double GetArea();
    }

    internal class Square : Figure
    {
        public Square(double length) : base(length) { }

        public override double GetArea()
        {
            return length * length;
        }
    }

    internal class Rectangle : Figure
    {
        double b;

        public Rectangle(double a, double b) : base (a)
        {
            this.b = b;
        }

        public override double GetArea()
        {
            return length * b;
        }
    }

    internal class Circle : Figure
    {
        public Circle(double radius) : base(radius) { }

        public override double GetArea()
        {
            return length * 2 * Math.PI;
        }
    }

    internal class Trapezoid : Figure
    {
        double b;
        double h;

        public Trapezoid(double a, double b, double h) : base(a)
        {
            this.b = b;
            this.h = h;
        }

        public override double GetArea()
        {
            return (length + b) / 2 * h;
        }
    }
}
