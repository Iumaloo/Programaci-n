using System;

namespace OrdenamientoDatos
{
    class Program
    {
        static void Main(string[] args)
        {
                string[] nombres = { "Nezuko", "Tanjiru", "Zenitsu", "Inosuke", "Genya", "Kanao", "Tomioka" };
                double[] estatura = { 153, 165, 164.5, 164, 180, 156, 170 };
           
                for ( int j = 0; j < estatura.Length; j++)
                {
                    for (int i = 0; i < estatura.Length - 1; i++)
                    {
                        if (estatura[i] > estatura[i + 1])
                        {
                        string aux = nombres[i];
                        nombres[i] = nombres[i + 1];
                        nombres[i + 1] = aux;
                        double tmp = estatura[i];
                        estatura[i] = estatura[i + 1];
                        estatura[i + 1] = tmp;
                        }
                    }
                }
                Console.WriteLine("Datos ordenados : ");
                for (int i = 0; i < estatura.Length; i++)
                {
                    Console.WriteLine(nombres[i] + " tiene una estatura de  : " +estatura[i]);
                }
             
        }
    }
}
