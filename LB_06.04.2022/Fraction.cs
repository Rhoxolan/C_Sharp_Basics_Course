using System;

namespace program
{
    internal record Fraction(double Numerator, double Denominator);

    internal static class FractionExtension
    {
        public static (double Min, double Max) GetMinMaxResult(this Fraction[] fractions)
        {
            if (fractions.Length == 0)
            {
                throw new StackOverflowException("\nМассив пуст!\n");
            }
            double min = double.MaxValue;
            double max = double.MinValue;
            foreach (var f in fractions)
            {
                if(f.Numerator / f.Denominator > max)
                {
                    max = f.Numerator / f.Denominator;
                }
                if (f.Numerator / f.Denominator < min)
                {
                    min = f.Numerator / f.Denominator;
                }
            }
            return (min, max);
        }
    }
}
