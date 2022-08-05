using System;

namespace uc_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter End Points of First line");
            Console.WriteLine("Enter x1 value:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2 value:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1 value:");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2 value:");
            int y2 = Convert.ToInt32(Console.ReadLine());
            double lengthOfFirstLine = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("..............................................................");
            Console.WriteLine("Enter End Points of Second line");
            Console.WriteLine("Enter a1 value:");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a2 value:");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b1 value:");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b2 value:");
            int b2 = Convert.ToInt32(Console.ReadLine());
            double lengthOfSecondLine = Math.Sqrt((a2 - a1) * (a2 - a1) + (b2 - b1) * (b2 - b1));

            Console.WriteLine("Legth of first line is: " + lengthOfFirstLine);
            Console.WriteLine("Legth of  second line is: " + lengthOfSecondLine);
            Console.WriteLine(lengthOfFirstLine.CompareTo(lengthOfSecondLine));

        }
    }
}
