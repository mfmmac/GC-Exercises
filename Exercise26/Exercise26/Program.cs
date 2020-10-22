using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Exercise26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter some text");

            var userInput = Console.ReadLine();

            bool userContinue = true;
            var vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u'};
            int count = 0;

            do
            {
                foreach (char charInString in userInput)
                {
                    if (vowels.Contains(charInString))
                    {
                        count++;
                    }
                    
                    Console.WriteLine($"Number of vowels: {count}");
                }

                var contInput = Console.ReadLine().ToLower();

                Console.WriteLine("Do you want to continue? (Y/N)");
                if ((contInput == "y") || (contInput == "yes"))
                {
                    userContinue = true;
                }
                else if ((contInput == "n") || (contInput == "no"))
                {
                    userContinue = false;
                    Console.WriteLine("Thank you. Goodbye");
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid Entry. Please use y or n.");
                    var contInput2 = Console.ReadLine();
                    userContinue = true;
                }
            }
            while (userContinue);

        }
    }
}
