using System;

namespace Triangulo1
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese 'y' y 'z':");
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());

            double t = Math.Sqrt (z * z + y * y);
            double a = Math.Acos(z/t);
            double c = Math.PI- (Math.PI / 2) - a;

            double agrados= a* (180.0/ Math.PI);
            double cgrados = c *(180.0 / Math.PI);
            Console.WriteLine("t=" + t);

            Console.WriteLine("a=" + agrados);

            Console.WriteLine("c =" + cgrados);



        }
    }
}
