using System;
using System.Collections.Generic;

namespace Zajecia8MK
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            Nww nww = new Nww();

            Console.WriteLine(nww.calculate(33, 9));

            // Exercise 2
            string[] words =
            {
                "Kobyła ma mały bok",
                "Ala ma kota",
                "Pan Knap",
                "Tolo ma samolot",
                "samochód",
                "Anna",
                "Rotator",
                "Paprykarz Szczeciński",
                "Majonez",
                "Musztarda"
            };

            Palindrom pal = new Palindrom();
            List<string> result = pal.findPalindromes(words);

            foreach (string s in result) Console.WriteLine(s);

        }
    }
}
