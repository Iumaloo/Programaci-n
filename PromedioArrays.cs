using System;
using System.Diagnostics.CodeAnalysis;

namespace Promedio_y_distancia__arrays_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Nezuko", "Tanjiru", "Zenitsu", "Inosuke", "Genya", "Kanao", "Tomioka" };
            double[] estatura = { 153, 165, 164.5, 164, 180, 156, 170 };
            double[] distancia = new double[estatura.Length];
            double suma = 0, promedio=0, min=180;
            int i = 0, e = 0, a=0;
            for ( i = 0; i < nombres.Length ; i++)
            {
                Console.WriteLine(nombres[i] + " tiene una estatura de  : " + estatura[i]);
            }

            for(e=0; e<estatura.Length;e++)
            {
                suma += estatura[e];
            }
            promedio = suma / estatura.Length;
            Console.WriteLine("El promedio es : " + promedio);
            for (int u = 0; u < estatura.Length; u++)
            {
                distancia[u] = Math.Abs(promedio - estatura[u]);
                Console.WriteLine("Distancia  de " + distancia[u]);
                if (distancia[u] < min)
                {
                    min = distancia[u];
                    a = u;
                }
            }

            Console.WriteLine("Quien tiene menor distancia es: " + nombres[a]);

        }
    }
}
