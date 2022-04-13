using System;

namespace program
{
    internal record Point2D
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Point2D(float x, float y)
        {
            X = x;
            Y = y;
        }
    }

    internal static class Point2DExtension
    {
        public static double PointDistance(this Point2D point1, Point2D point2)
        {
            return Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
        }

        public static double PointsDistance(this Point2D[] points, Point2D point)
        {
            double distance = double.MinValue;
            foreach(var p in points)
            {
                if (Math.Sqrt(Math.Pow(point.X - p.X, 2) + Math.Pow(point.Y - p.Y, 2))
                    > distance)
                {
                    distance = Math.Sqrt(Math.Pow(point.X - p.X, 2) + Math.Pow(point.Y - p.Y, 2));
                }
            }
            return distance;
        }
    }
}
