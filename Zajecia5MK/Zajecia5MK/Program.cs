using System;
using System.IO;
using System.Text;

namespace Zajecia5MK
{
    class Program
    {
        private static int NumberOfCirclePoints = 0;
        private static Random RandomObject = new Random();

        private static FileInfo fi = new FileInfo(@"C:\Users\mateu\Documents\filesCreated\monteCarlo.txt");

        private static double GenerateRandomDouble(double min, double max)
        {
            double d = RandomObject.NextDouble() * (max - min) + min;
            return d;
        }

        private static void saveNumberToFile(double number)
        {
            using FileStream fs = File.OpenWrite(fi.FullName);

            var data = number.ToString();
            byte[] bytes = Encoding.UTF8.GetBytes(data);

            fs.Write(bytes, 0, bytes.Length);
        }

        static void Main(string[] args)
        {
            Console.Write("Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Center of the circle (eg. 10,2): ");
            string center = Console.ReadLine();
            Console.Write("How many points? ");
            int numberOfPoints = Convert.ToInt32(Console.ReadLine());

            string[] centerCoordinates = center.Split(',');
            double cx = Convert.ToDouble(centerCoordinates[0].Trim());
            double cy = Convert.ToDouble(centerCoordinates[1].Trim());
            double scx, scy;
            scx = scy = cx + radius;

            for (int i = 0; i < numberOfPoints; i++)
            {
                double cxDouble = GenerateRandomDouble(cx, scx);
                double cyDouble = GenerateRandomDouble(cy, scy);
                // calculate the distance between the circle center and the given point.
                double distance = Math.Sqrt(Math.Pow(cxDouble - cx, 2) + Math.Pow(cyDouble - cy, 2));

                // If the distance is less or equal to the radius of the circle then the given point is inside the circle area.
                // Else the given point is outside the circle area.
                if (distance <= radius)
                    NumberOfCirclePoints++;
            }

            double PI = 4 * (Convert.ToDouble(NumberOfCirclePoints) / Convert.ToDouble(numberOfPoints));
            Console.WriteLine($"PI = {PI}");
            saveNumberToFile(PI);

            Console.ReadKey();
        }
    }
}
