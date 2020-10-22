using System;

namespace Exercise19
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please input a number");
            var inputOne = Console.ReadLine();
            Console.WriteLine("Please input another number");
            var inputTwo = Console.ReadLine();

            
            var result = SumUserInputs(int.Parse(inputOne), int.Parse(inputTwo));

            Console.WriteLine($"Here is the sum of numbers: {result}");
        }

        public static int SumUserInputs(int valueOne, int valueTwo)
        {
            return valueOne + valueTwo;
        }
    }
}
