using System;
using System.Xml.Schema;

namespace Simulacroprimero
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int dado1 = 0, dado2 = 0;
            int sumdados = dado1 + dado2;
            int turno = 0;
            int tmayoraseis = 0;
            int sumita = 0;
            int dobles = 0;
             Console.WriteLine("Diga si para iniciar el juego");
            string answer = Console.ReadLine();
     
            while ( (answer=="si")) 
            {
                dado1 = aleatorio.Next(1, 7);
                dado2 = aleatorio.Next(1, 7);

                sumita = dado1 + dado2;
                if (sumita>6)
                {
                    tmayoraseis++;
                }

                if (dado1==dado2)
                {
                    dobles++;
                }
                
                if ((dado1 ==1) && dado2 ==1)
                {
                    sumdados = 0;
                    Console.WriteLine("Dado 1 : " + dado1 + "   Dado 2 : " +dado2 + "\n Eliminado" );
                    answer = "no";
                }

                else if (dobles==3)
                {
                    Console.WriteLine(" Felicidades, ha ganado");
                    answer = "no";
                }
                else 
                {
                    sumdados += dado1 + dado2;
                    Console.WriteLine("Dado 1 : " + dado1 + "\nDado 2 : " + dado2 + " \nTotal : " + sumdados);
                

                    if (sumdados >= 100)
                    {
                        Console.WriteLine(" Felicidades, ha ganado");
                        answer = "no";
                        break;
                    }
                    Console.WriteLine("¿Continuar?");
                     answer = Console.ReadLine();
                }
                turno++;

            }

            double porcentaje = ((double) tmayoraseis / turno) * 100;

            Console.WriteLine("Número de partidas : " + turno + " \nPorcentaje : " + porcentaje ) ;
           
            Console.WriteLine(" Gracias por jugar");
        }
    }
}
