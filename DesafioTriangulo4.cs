using System;

namespace DesafioTriangulo4
{
    class Program
    {
        static void Main()

        {
            Console.WriteLine("Inserte w");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserte t");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserte c");
            double c = double.Parse(Console.ReadLine());

            double ccon = c * (Math.PI / 180.0);
            double z = Math.Sin(ccon) * t;
            double y = Math.Sqrt(t * t - z * z);
            double x = Math.Sqrt(w * w - z * z) - y;

            Console.WriteLine("x = " + x);
        }
    }
}
