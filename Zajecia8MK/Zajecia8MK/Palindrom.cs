using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia8MK
{
    class Palindrom : IPalindromable
    {
        public List<string> findPalindromes(string[] words)
        {
            List<string> output = new List<string>();
            foreach(string s in words)
            {
                string temp = new string(s.Replace(" ", String.Empty));
                string rev;

                char[] ch = temp.ToCharArray();
                Array.Reverse(ch);
                rev = new string(ch).ToLower();
                //Console.WriteLine(rev);

                if (temp.Equals(rev, StringComparison.OrdinalIgnoreCase)) output.Add(s);
            }
            return output;
        }

        /*
        private static bool isPalindrome(string word)
        {
            string rev;
            char[] ch = word.ToCharArray();
            Array.Reverse(ch);
            rev = new string(ch);

            return word.Equals(rev, StringComparison.OrdinalIgnoreCase);
        }
        */
    }
}
