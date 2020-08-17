using System;

namespace Coseno
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese el valor de X");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de iteraciones");
            int n = int.Parse(Console.ReadLine());
            double suma = 0;

            for (int i = 0; i < n; i++)
            {
                suma += (Math.Pow(-1, i) / Factorial(2 * i )) * (Math.Pow(x, (2 * i)));
            }
            Console.WriteLine("El valor del Coseno es  : " + suma);
        }

        static double Factorial(double valor)
        {
            if (valor <= 1) return 1;
            return valor * Factorial(valor - 1);
        }
    }
}
