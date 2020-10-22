using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise72
{
    static class Validator
    {
        public static string ValidateContinue()
        {
            List<string> validInput = new List<string>()
            {
                "YES",
                "Y",
                "NO",
                "N"
            };

            Console.WriteLine("\nWould you like to play another game? (Yes/No)");
            string userInput = Console.ReadLine().ToUpper();

            while (!validInput.Contains(userInput))
            {
                Console.WriteLine("Invalid entry. Please try again");
                userInput = Console.ReadLine().ToUpper();
            }

            return userInput;
        }
    }
}