using System;
using System.Collections.Generic;

namespace Exercise68
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> spanishTranslator = new Dictionary<string, string>()
            {
                {"hello", "hola" },
                {"food", "comida" },
                {"world", "mundo" },
                {"computer", "computadora" },
                {"exercise", "ejercicio" },
                {"taco", "taco" },
                {"beer", "cerveza" },
            };

            Console.WriteLine("Enter a word in English");
            string userWord = Console.ReadLine();
            
            if (spanishTranslator.TryGetValue(userWord, out string translatedWord))
            {
                Console.WriteLine($"{userWord} is {translatedWord} in spanish");
            }
            else
            {
                Console.WriteLine($"{userWord} cannot be translated");
            }
        }
    }
}
