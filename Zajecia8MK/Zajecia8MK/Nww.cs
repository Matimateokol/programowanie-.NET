using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia8MK
{
    class Nww : INww
    {
        private int _a, _b;

        int INww.a { get => _a ; set => _a = value ; }
        int INww.b { get => _b ; set => _b = value ; }

        public int calculate(int a, int b)
        {
            int c = a * b;

            if(a != b)
            {
                if(a > b)
                {
                    return calculate(a - b, b);
                }
                else
                {
                    return calculate(a, b - a);
                }
            }
            else
            {
                return c / a;
            }
        }
    }
}
