using System;

namespace S2Casa
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1 = 0, dado2 = 0, vidas = 3, turnos = 0, total = 0, dobles = 0;
            string answer = "";
            Console.WriteLine("Diga si para iniciar el juego");
            answer = Console.ReadLine();

            while ((answer == "si" && 1 <= vidas && vidas <= 3))
            {
                dado1 = aleatorio.Next(1, 7);
                turnos++;
                total += dado1;
                dobles++;

                if (turnos == 2)
                {
                    vidas--;
                    turnos = 0;
                }

                else if (dobles == 3)
                {
                    dado2 = aleatorio.Next(1, 7);
                    Console.WriteLine("DADO 2 : " + dado2);
                    total += dado2;
                  
                    if (dado1 == dado2)
                    {
                        vidas++;
                    }
                }

                else if (total >= 100)
                {
                    Console.WriteLine("¡Ganaste!");
                    break;
                }

                if (vidas == 0)
                {
                    Console.WriteLine("¡Perdiste!");
                    break;
                }

                Console.WriteLine("DADO 1 : " + dado1 + "\nTOTAL : " + total);
           
                Console.WriteLine("VIDAS: " + vidas); Console.WriteLine("¿Desea continuar? (si/no)");
                answer = Console.ReadLine();
              
            }

            Console.WriteLine(" ¡Gracias por jugar!");
            Console.WriteLine("VIDAS FINALES : " +vidas + "\nTOTAL FINAL : " +total);
        }
    }
}
