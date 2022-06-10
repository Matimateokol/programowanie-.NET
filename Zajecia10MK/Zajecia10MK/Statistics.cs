using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia10MK
{
    class Statistics
    {
        public float max(int[] integers) 
        {
            int max = int.MinValue;
            foreach(int i in integers)
            {
                if (i > max) max = i;
            }

            return max;
        }

        public float min(int[] integers)
        {
            int min = int.MaxValue;
            foreach(int i in integers)
            {
                if (i < min) min = i;
            }

            return min;
        }

        public float mean(int[] integers)
        {
            int sum = 0;
            foreach(int i in integers)
            {
                sum += i;
            }

            return sum / integers.Length;
        }

        public float median(int[] integers)
        {
            Array.Sort(integers);

            if(integers.Length % 2 == 0)
            {
                int mid = integers.Length / 2;
                return (integers[mid-1] + integers[mid]) / 2;
            } else
            {
                return integers[integers.Length / 2]; ;
            }

        }
    }
}
