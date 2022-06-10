using System;

namespace Zajecia10MK
{
    class Program
    {
        public delegate float Delegacja(int[] integers);

        static void Main(string[] args)
        {
            int[] integers = { 4, 18, 3, 8, 1 };

            Statistics stat = new Statistics();
            //Console.WriteLine(stat.max(integers));
            //Console.WriteLine(stat.min(integers));
            //Console.WriteLine(stat.mean(integers));
            //Console.WriteLine(stat.median(integers));

            Delegacja del1 = stat.max;
            Console.WriteLine(del1(integers));

            del1 += stat.min;
            Console.WriteLine(del1(integers));
            
            del1 += stat.mean;
            Console.WriteLine(del1(integers));

            del1 += stat.median;
            Console.WriteLine(del1(integers));

        }
    }
}
