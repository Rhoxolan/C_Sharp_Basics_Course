using System;

namespace program
{
    internal record DailyTemperature (DateTime Day, double Min, double Max)
    {
        public override string ToString()
        {
            return $"{Day.Day}.{Day.Month}.{Day.Year} Min - {Min}, Max - {Max}";
        }
    }
    internal static class DailyTemperatureExtension
    {
        public static DailyTemperature GetBiggestDifference(this DailyTemperature[] temperatures)
        {
            if (temperatures is null && temperatures.Length == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(temperatures));
            }
            DailyTemperature maxDay = temperatures[0];
            foreach(var t in temperatures)
            {
                if(t.Max - t.Min > maxDay.Max - maxDay.Min)
                {
                    maxDay = t;
                }
            }
            return maxDay;
        }
    }
}
