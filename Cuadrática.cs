using System;

namespace Fórmula_cuadrática
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese a");

            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese b");

            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese c");

            double c = double.Parse(Console.ReadLine());

            double disc= b * b - 4 * a * c;

            if (disc==0)
                    {
               
                double resultado1 = (-b  / (2 * a));
                Console.WriteLine("Solución única : " + resultado1);
            }
            
            else if (disc >0)
            {

                double resultado = (-b + (Math.Sqrt(disc))) / (2 * a);
                double resultado2 = (-b - (Math.Sqrt(disc)))/ (2 * a);
                Console.WriteLine("Tiene dos soluciones : " + resultado);
                    Console.WriteLine( resultado2 );
            }

            else
            {
                Console.WriteLine("No hay solución : " + disc);
            }

            
        }
    }
}
