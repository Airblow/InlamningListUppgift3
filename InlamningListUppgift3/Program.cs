using System;
using System.Collections.Generic;

namespace InlamningListUppgift3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;

            while (loop != false)
            {
                Console.Clear();
                Console.WriteLine("Skriv ett utav länderna nedan för att få reda på deras yta (press 'n' to shutdown)");
                Console.WriteLine("Danmark, Finland, Norge, Sverige");

                string userInput = Console.ReadLine().ToLower();

                Dictionary<string, string> countrySize = new Dictionary<string, string>();
                countrySize["danmark"] = "43 000 km^2";
                countrySize["finland"] = "385 000 km^2";
                countrySize["norge"] = "385 000 km^2";
                countrySize["sverige"] = "450 000 km^2";

                if (countrySize.ContainsKey(userInput))
                {
                    Console.Clear();
                    string size = countrySize[userInput];
                    Console.WriteLine($"{userInput}s yta: {size}");

                }
                else if(userInput == "n")
                {
                    Console.Clear();
                    Console.WriteLine("Programmet stängs nu av");
                    loop = false;

                }
                else
                {
                    Console.WriteLine("Det landet finns inte i listan. Försök igen");

                }

                Console.ReadKey();
            }
        }

    }

}
