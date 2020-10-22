using System;

namespace Exercise46
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the side lengths of a triangle:");
            int side1Length = int.Parse(Console.ReadLine());
            int side2Length = int.Parse(Console.ReadLine());
            int side3Length = int.Parse(Console.ReadLine());

            var triangle1 = new Triangle(side1Length, side2Length, side3Length);
            Console.WriteLine($"The perimeter is {triangle1.Side1Length}, and {triangle1.Side2Length}, and {triangle1.Side3Length}");
        }
    }
}
