using System;
namespace Structs_CSharp_1
{
    public class DateTimeClass
    {
        // Date and times are primarily handled by the DateTime struct which represents a
        // specific instant in time. It is immutable and cannot be modified after creation.

        private int v1;
        private int v2;
        private int v3;

        public DateTimeClass(int v1, int v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        // DateTime.Now returns the current date and time
        public DateTime getCurrentDateTime = DateTime.Now;
        // DateTime.UtcNow returns the current date and time in UTC format
        public DateTime getUtcDateTime = DateTime.UtcNow;
        // DateTime.Today returns the current date without time
        public DateTime getCurrentDate = DateTime.Today;
        // Create a new DateTime object using the specified year, month, day, hour, minute, and second
        public DateTime specificDateTime = new DateTime(2023, 6, 1, 12, 0, 0);
        // Create a new DateTime object using the specified year, month, day.
        public DateTime specificDate = new DateTime(2023, 6, 1);
        public void DisplayDate()
        {
            // Manipulating date and time.
            DateTime now = DateTime.Now;
            DateTime futureDate = now.AddDays(7); // Add 7 days to the current date and time
            DateTime pastDate = now.AddDays(-7); // Subtract 7 days from the current date and time

        public void DisplayDate()
        {
            DateTime dateTime = new DateTime(2023, 6, 1);
            Console.WriteLine(dateTime);
            Console.WriteLine(DateTime.Now);        
        }
    }
}