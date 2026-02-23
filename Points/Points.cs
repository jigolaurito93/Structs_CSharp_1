using System;
namespace Structs_CSharp_1
{
    public struct Point
    {
        //public int X { get; set; }
        //public int Y { get; set; }

        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Display()
        {
            Console.WriteLine($"Point: ({X}, {Y})");
        }
    }
}