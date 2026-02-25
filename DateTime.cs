using System;
namespace Structs_CSharp_1
{
    public class DateTimeClass
    {
        private int v1;
        private int v2;
        private int v3;

        public DateTimeClass(int v1, int v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public void DisplayDate()
        {
            DateTime dateTime = new DateTime(2023, 6, 1);
            Console.WriteLine(dateTime);
        }
    }
}