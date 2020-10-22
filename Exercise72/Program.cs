using System;

namespace Exercise72
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool userContinue = true;

            while (userContinue)
            {
                Console.WriteLine("Enter a number:");
                number = Convert.ToInt32(Console.ReadLine());
                if (IsPrime(number))
                {
                    Console.WriteLine("It is prime");
                }
                else
                {
                    Console.WriteLine("It is not prime");
                }

                static bool IsPrime(int number)
                {
                    if (number <= 1) return false;
                    if (number == 2) return true;
                    if (number % 2 == 0) return false;

                    var boundary = (int)Math.Floor(Math.Sqrt(number));

                    for (int i = 3; i <= boundary; i += 2)
                        if (number % i == 0)
                            return false;

                    return true;
                }
                string userInput = Validator.ValidateContinue();

                if (userInput.Equals("NO") || userInput.Equals("N"))
                    userContinue = false;
            }
        }        
    }
}
