using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia8MK
{
    public interface INww
    {
        public int a { get; set; }
        public int b { get; set; }

        int calculate(int a, int b);
    }
}
