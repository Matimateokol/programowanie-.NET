using System;
using System.IO;

namespace Zajecia6MK
{
    class Program
    {
        static readonly string textFile = @"C:\Users\mateu\Documents\filesCreated\palindromes.txt";

        private static string _wordFromStream { get; set; } 

        private static bool isPalindrome(string word)
        {
            string rev;
            char[] ch = word.ToCharArray();
            Array.Reverse(ch);
            rev = new string(ch);

            return word.Equals(rev, StringComparison.OrdinalIgnoreCase);
        }

        private static void readFile(string textFile)
        {
            if(File.Exists(textFile))
            {
                using(StreamReader file = new StreamReader(textFile))
                {
                    string ln;

                    while ((ln = file.ReadLine()) != null)
                    {
                        _wordFromStream = ln;
                        if(isPalindrome(_wordFromStream))
                        {
                            Console.WriteLine(_wordFromStream);
                        }
                    }
                }
            }
        } 

        static void Main(string[] args)
        {
            readFile(textFile);
        }
    }
}
