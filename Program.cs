using System;
namespace Structs_CSharp_1
{
    class Program
    {
        static void Main()
        {
            Point p1 = new Point(5, 2);
            p1.Display();

            // Structs can be declared and initialized without the "new" keyword
            Point p2;
            // All fields must be initialized before the struct can be used.
            p2.X = 10;
            p2.Y = 20;
            p2.Display();

            // Structs are value types, so they are copied by value and not by reference.
            // If you want to copy a struct by reference, you need to use the "ref" keyword
            // p3 is copying the value of p1
            Point p3 = p1;
            p3.X = 100;
            p3.Display();
            p1.Display();

        }
    }
}

