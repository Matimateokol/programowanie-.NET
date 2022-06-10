using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia7MK
{
    abstract class First
    {
        public abstract void f(int number);

        public virtual void r(string sentence) 
        {
            String S2 = "";
            int i;
            int c = 1;

            Console.WriteLine("Running the Run Length Encoder:");
            Console.WriteLine("You are compressing -> \n" + sentence + "\ninto: ");

            //Compression
            sentence += " ";

            for (i = 0; i < sentence.Length - 1; i++)
            {
                if(sentence[i] == sentence[i + 1])
                {
                    c++;
                }
                else
                {
                    S2 += sentence[i];
                    if(c > 1)
                        S2 += c;
                    c = 1;
                }
            }

            Console.WriteLine(S2);
        }
    }
}
