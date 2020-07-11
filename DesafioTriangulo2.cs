using Microsoft.VisualBasic;
using System;

namespace DesafioTriangulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserte d");
            double d = double.Parse(Console.ReadLine());

            Console.WriteLine("Inserte b");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Inserte y");
            double y = double.Parse(Console.ReadLine());

            double dc = d * (Math.PI / 180.0);
            double bc = b * (Math.PI / 180.0);
            double e = (Math.PI) - (dc) - (bc);
            double c = (Math.PI) - (e);
            double z = Math.Tan(c) * y;

            Console.WriteLine("z = " + z);


        }
    }
}
