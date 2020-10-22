using System;

namespace Exercise42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter X point");
            var xPoint = Console.ReadLine();
            Console.WriteLine("Enter Y point");
            var yPoint = Console.ReadLine();

            var point = new Point(xPoint, yPoint);
            Console.WriteLine($"Here is the X point { point.X}, and Y point {point.Y}");
        }
    }
}
