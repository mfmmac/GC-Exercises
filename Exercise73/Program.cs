using System;
using System.Diagnostics;
using System.Threading;

namespace Exercise73and74
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            Console.WriteLine("Here are the first 500 prime numbers: ");
            stopWatch.Start();
            OutputListOfPrimeNumbers(500);
            stopWatch.Stop();
            Console.WriteLine("\n\n");
            Console.WriteLine("RunTime " + "Time elapsed: {0}", stopWatch.Elapsed);
        }

        public static void OutputListOfPrimeNumbers(int number)
        {
            var count = 0;
            for (int i = 0; count < number; i++)
            {
                var isPrime = DeterminePrimeNumber(i);
                if (isPrime && count != number - 1)
                {
                    Console.Write($"{i}, ");
                    count++;
                }
                else if (isPrime && count == number - 1)
                {
                    Console.Write($"{i}");
                    count++;
                }
            }
        }
        public static bool DeterminePrimeNumber(int number)
        {
                var flag = 0;
                var m = number / 2;
                if (number == 0 || number == 1)
                {
                    return false;
                }
                else
                {
                    for (int i = 2; i <= m; i++)
                    {
                        if (number % i == 0)
                        {
                            return false;
                        }
                    }
                    if (flag == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
        }
    }
}
