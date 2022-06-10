using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia7MK
{
    class Second : First
    {
        public override void f(int number) 
        {
            if(number <= 0)
            {
                Console.Write("[" + number + "]");
                return;
            }

            if((number & 1) == 0)
            {
                Console.Write("[" + number / 2.0 + "," + 2 + "]");
                return;
            }

            int a = (int)Math.Ceiling(Math.Sqrt(number));

            if(a * a == number)
            {
                Console.Write("[" + a + "," + a + "]");
                return;
            }
            
            int b;
            while (true)
            {
                int b1 = a * a - number;
                b = (int)(Math.Sqrt(b1));

                if (b * b == b1)
                    break;
                else
                    a += 1;
            }
            Console.Write("[" + (a - b) + "," + (a + b) + "]");
        
            return;
        }
    }
}
