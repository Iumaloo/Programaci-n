using Microsoft.VisualBasic;
using System;

namespace BlackJack_Multiplayer
{
    class Program
    {
        static void Main()
        {
          
            int valorcartas1 = 0, valorcartas2 = 0, jugador = 1, min=21,max=0, ganador=0, turno=0;
            Console.WriteLine("Ingrese número de jugadores : ");
            int ansjugador = int.Parse(Console.ReadLine());
            while (ansjugador < 2 || (ansjugador > 5))
            {
                Console.WriteLine("El número de jugadores no es válido; intente de nuevo : ");
                ansjugador = int.Parse(Console.ReadLine());
            }
            while (ansjugador>=jugador) 
            {
                turno++;
                Console.WriteLine("Bienvenido al juego"+ "\nJugador : " + jugador);
                Random aleatorio = new Random();
                valorcartas1 = aleatorio.Next(1, 11);
                valorcartas2 = aleatorio.Next(1, 11);
                int total = valorcartas1 + valorcartas2;
                Console.WriteLine("El primer valor de sus cartas es : " + valorcartas1);
                Console.WriteLine("El segundo valor de sus cartas es : " + valorcartas2 + " , \nEl valor de total es : " + (total));
                string respuesta = "";
                Console.WriteLine("¿Continuar? (pedir otra carta) " + " , (si/no)" + respuesta);
                respuesta = Console.ReadLine();

                while (respuesta != "si" && respuesta != "no")
                {
                    Console.WriteLine("Esa no es una respuesta válida; intente de nuevo: ");
                    respuesta = Console.ReadLine();
                }
                while (respuesta == "si")
                {
                   
                    int nuevacarta = aleatorio.Next(1, 11);
                    total += nuevacarta;
                    Console.WriteLine("El valor de su nueva  carta es : " + nuevacarta + " , y el total es : " + total);

                    if (total < 21)
                    {
                        Console.WriteLine("¿Continuar? (si/no)");
                        respuesta = Console.ReadLine();
                        while (respuesta != "si" && respuesta != "no")
                        {
                            Console.WriteLine("Esa no es una respuesta válida; intente de nuevo: ");
                            respuesta = Console.ReadLine();
                        }
                    }
                    else if (total == 21)
                    {
                        Console.WriteLine("Has ganado");
                        respuesta = "n";
                    }
                    else
                    {
                        Console.WriteLine("Eliminado");
                        respuesta = "n";
                    }

                }

                jugador+=1;
                Console.WriteLine("Gracias por jugar");
                if (total>max&&total<=min)
                {
                    max = total;
                    ganador = turno;
                }
            }
          
           
                Console.WriteLine("Ganador : " + ganador + "\nTotal :" + max);
            
        }
    }
}

