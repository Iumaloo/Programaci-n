using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor de X");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de iteraciones");
            int n = int.Parse(Console.ReadLine());
            double suma = 0;
       
            for (int i= 0;i<n;i++)
            {
                suma+=(Math.Pow(x, i)/Factorial(i));
            }
            Console.WriteLine("el valor de 'e' es : " + suma);
        }
        static double Factorial(double valor)
        {
            if (valor <= 1) return 1;
            else
            {
                return valor * Factorial(valor - 1);
            }
        }
    }
}
