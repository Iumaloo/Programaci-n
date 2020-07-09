using System;

namespace Triangulo2Iuma
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Inserte t");

            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserte a");
            double a = double.Parse(Console.ReadLine());

            double arad = a * (Math.PI/180.0);
            
            double z = Math.Cos(arad) * t;
            double c = (Math.PI) - (Math.PI / 2) - arad;
            double y = (z / Math.Tan(c));

            double cg = c * (180.0/Math.PI);
            Console.WriteLine("z =" + z);
            Console.WriteLine("c =" + cg);
            Console.WriteLine("y =" + y);


        }
        
    }
}
