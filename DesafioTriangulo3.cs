using System;
using System.Net.Mail;

namespace DesafioTriangulo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserte w");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserte d");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserte x");
            double x = double.Parse(Console.ReadLine());

            double dcon = d * (Math.PI / 180.0);

            double F = (Math.PI) - (Math.PI / 2) - dcon;
            double y = Math.Sin(F) * w - x;

            Console.WriteLine("y = " + y);



        }
    }
}
