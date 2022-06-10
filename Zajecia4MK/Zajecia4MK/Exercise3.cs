using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia4MK
{
    static class Exercise3
    {
        static DirectoryInfo directoryInfo;

        public static long getDirectorySize()
        {
            long size = 0;

            Console.WriteLine("Input a directory's name to be searched: ");
            string directoryName = Console.ReadLine();
            DirectoryInfo di = new DirectoryInfo(@$"c:\{directoryName}");
            
            foreach(var fi in di.GetFiles())
            {
                size += fi.Length;
            }

            return size;
        }
    }
}
