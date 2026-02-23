using System;
namespace Structs_CSharp_1
{
    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        //public int X;
        //public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double DistanceTo(Point other)
        {
            double dx = other.X - X;
            double dy = other.Y - Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public void Display()
        {
            Console.WriteLine($"Point: ({X}, {Y})");
        }
    }
}