using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia9MK
{
    class Outside
    {
        public class Inside
        {
            public void calculateSquareRoot(float number)
            {
                float sec = number / 2;
                while(Math.Abs(sec - number / sec) > 0.000001f)
                {
                    sec = (sec + number / sec) / 2;
                    if (sec * sec == number) break;
                }
                Console.WriteLine(sec);
            }
        }
    }
}
