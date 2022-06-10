using System;

namespace Zajecia4MK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Exercise1.setup();
            int[] array =  { 8, 4, 7, 3, 1, 1, 9, 5, 2, 73 };

            Console.Write("Initial array is: ");
            foreach(int i in array)
            {
                Console.Write(i + " ");
            }

            quickSort(array, 0, 9);
            Console.Write("\nSorted Array is: ");
            foreach(int i in array)
            {
                Console.Write(i + " ");
            }
        }

        public static void quickSort(int[] arr, int left, int right)
        {
            if(left < right)
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

            for(int j = left; j <= right - 1; j++)
            {
                if(arr[j] < pivot)
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
