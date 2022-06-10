using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia4MK
{
    static class Exercise2
    {
        public static void run()
        {
            string choice = "";
            string fileName = "";
            string directoryName = "";

            while (choice != "f" || choice != "d") 
            {
                Console.WriteLine("If you want to delete a file press 'f'. If you want to delete a directory press 'd' : ");
                choice = Console.ReadLine();
            }

            if(choice == "f")
            {
                Console.WriteLine("Insert the name of the file to be deleted: ");
                fileName = Convert.ToString(Console.ReadLine());

                Console.WriteLine($"In what directory I can find {fileName} file?: ");
                directoryName = Convert.ToString(Console.ReadLine());

                FileInfo fi = new FileInfo(@$"c:\{directoryName}\{fileName}");

                Console.WriteLine("Are you sure that you want to proceed? (Y/N): ");
                char answer = Convert.ToChar(Console.Read());
                
                if(answer == 'Y' || answer == 'y')
                {
                    fi.Delete();
                } else
                {
                    Console.WriteLine("The file wasn't deleted. Program executed successfully!");
                    return;
                }
                
            }

            if (choice == "d")
            {
                Console.WriteLine("Insert the name of the directory to be deleted: ");
                directoryName = Convert.ToString(Console.ReadLine());

                DirectoryInfo di = new DirectoryInfo(@$"c:\{directoryName}");

                Console.WriteLine("Are you sure that you want to proceed? (Y/N): ");
                char answer = Convert.ToChar(Console.Read());

                if (answer == 'Y' || answer == 'y')
                {
                    di.Delete();
                }
                else
                {
                    Console.WriteLine("The directory wasn't deleted. Program executed successfully!");
                    return;
                }

            }


        }
        
    }
}
