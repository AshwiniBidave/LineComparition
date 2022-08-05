using System;

namespace uc_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2 value:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1 value:");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2 value:");
            int y2 = Convert.ToInt32(Console.ReadLine());
            double length = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

            Console.WriteLine("Legth of line is: " + length);
        }
    }
}
