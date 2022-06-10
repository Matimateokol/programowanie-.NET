using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia4MK
{
    public static class Exercise1
    {
        static DirectoryInfo di;
        static FileInfo fi;
        static FileStream fs;

        public static void setup()
        {
            Console.WriteLine("Input a new folder name: ");
            string catalogName = Console.ReadLine();

            Console.WriteLine("Input a new file name: ");
            string fileName = Console.ReadLine();

            //Creating a new folder:
            try
            {
                Exercise1.di = new DirectoryInfo($@"c:\{catalogName}");
                Exercise1.di.Create();

            } catch (Exception e)
            {
                Console.WriteLine("It wasn't possible to create a new folder.");
            }

            //Creating a new file:
            try
            {
                Exercise1.fi = new FileInfo($@"c:\{catalogName}\{fileName}");
                fs = Exercise1.fi.Create();
                fs.Close();

            } catch (Exception e)
            {
                Console.WriteLine("It wasn't possible to create a new file.");
            }

            //Populating the file with a 10-element array:
            try 
            {
                string path = @$"c:\{catalogName}\{fileName}";
                // This text is added only once to the file.
                if (File.Exists(path))
                {
                    Random r = new Random();
                    int number = 0;
                    // Create a file to write to.
                    using (StreamWriter writer = File.AppendText(path))
                    {
                        for (int i = 1; i < 11; i++)
                        {
                            number = r.Next(1, 101);
                            writer.Write(number + ",");
                        }
                        writer.Close();
                    }
                }

            } catch (Exception e)
            {
                Console.WriteLine("The program failed to write numbers to the file {0}", fi.FullName);
                return;
            }
        }

        //sorting the the array in the file 
        public static void quickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pi = partition(arr, left, right);

                quickSort(arr, left, pi - 1);
                quickSort(arr, pi + 1, right);
            }
        }

        public static void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static int partition(int[] arr, int left, int right)
        {
            int pivot;
            pivot = arr[right];
            int i = (left - 1);

            for (int j = left; j <= right - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    swap(arr, i, j);
                }
            }
            swap(arr, i + 1, right);
            return (i + 1);
        }
    }
}
