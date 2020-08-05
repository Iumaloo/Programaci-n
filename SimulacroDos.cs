using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace Sim2
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int c = 0, n = 0, dado = 0, total=0;
          
            Console.WriteLine("Diga si para iniciar el juego");
            string answer = Console.ReadLine();

            while ((answer == "si"))
            {
                dado = aleatorio.Next(1,13);
                c++;
                total+=dado;
                Console.WriteLine("DADO : " + dado + "\nTOTAL : " + total);
                Console.WriteLine("TURNO: " + c);

                if (total >= 100)
                {
                    Console.WriteLine("¡Haz ganado!");
                    break;
                }
                if (dado==12)
                {
                    n++;
                }

                if (n==1 &&dado==10)
                {
                    Console.WriteLine("Ganaste :D (sacaste un 12 seguido de un 10)");
                    break;
                }
               
               else if (c >3)
                {
                    if (dado % 2 != 0)
                    {
                        Console.WriteLine("Perdiste; sacaste un número impar");
                        break;
                    }
                }

                Console.WriteLine("¿Desea continuar? (si/no)");
                answer = Console.ReadLine();

            }
            Console.WriteLine("¡Gracias por jugar!");
        }

    }
}
