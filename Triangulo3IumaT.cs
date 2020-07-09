using System;

namespace Triangulo3Iuma
{
     public class Program
    {
        static void Main()
        {
            Console.WriteLine("Inserte c y z");
            double c = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());

            double cg = c * (Math.PI/180.0);

            double y = (z/ Math.Tan(cg));
            double t = Math.Sqrt(y * y + z * z);
            double a = Math.Atan(y / z);

            double ag = a * (180.0 / Math.PI);
            Console.WriteLine("y =" + y);
            Console.WriteLine("t =" + t);
            Console.WriteLine("a =" + ag);
        }
    }
}
