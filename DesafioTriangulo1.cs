using System;

namespace DesafioTriangulo1o
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Ingrese b ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese z ");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese y ");
            double y = double.Parse(Console.ReadLine());

            double a = Math.Atan(y / z);
            double acon = a * (180.0 / Math.PI);
            double F = acon + b;
            double Fcon = F * (Math.PI / 180.0);
            double x = Math.Tan(Fcon) * z - y;

            Console.WriteLine("x =" + x);

        }
    }
}
