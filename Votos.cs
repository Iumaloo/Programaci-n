using System;

namespace Votos
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese votos por partido 1");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese votos por partido 2");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese votos en blanco");
            int blancos = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese votos anulados");
            int anulados = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese número total de las poblaciones de todas las edades");
            int  n = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el porcentaje de la población que es mayor de edad");
            double p = double.Parse(Console.ReadLine());

            int totalVotantes = a + b + blancos + anulados;
            Console.WriteLine("Total de votantes: " + totalVotantes);

            int adultos = (int)((p * n) / 100);
            Console.WriteLine("Adultos : " + adultos);
            int abstencion = adultos - totalVotantes;
            Console.WriteLine("Abstención : " + abstencion);

            int amasb = (a + b);
            bool A = anulados < amasb*0.30;
            bool B = amasb > blancos;
            bool C = abstencion < totalVotantes;

            if ((A || B) && C)
                    {
                Console.WriteLine("Votación exitosa");
                 if (a>b)

                {
                    Console.WriteLine("Ganador : Partido a");
                }
                 else
                {
                    Console.WriteLine("Ganador : Partido b");
                }
            }
        else
            {
                Console.WriteLine("Las elecciones deben hacers de nuevo");
            }
        }
    }
}
