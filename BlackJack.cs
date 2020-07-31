using System;

namespace BlackJack
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Bienvenido al juego");
            int valorcartas1 = 0;
            int valorcartas2 = 0;

            Random aleatorio = new Random();
            valorcartas1 = aleatorio.Next(1, 11);
            valorcartas2 = aleatorio.Next(1, 11);
            int total = valorcartas1 + valorcartas2;
            Console.WriteLine("El primer valor de sus cartas es : " + valorcartas1);
            Console.WriteLine("El segundo valor de sus cartas es : " + valorcartas2 + " , \nEl valor de total es : " + (total));
            string respuesta = "";
            Console.WriteLine("¿Continuar? (pedir otra carta) " + " , (si/no)"+ respuesta);
            respuesta = Console.ReadLine();
         
            while (respuesta == "si")
            {
                int nuevacarta = aleatorio.Next(1, 11);
                total += nuevacarta;
                Console.WriteLine("El valor de su nueva  carta es : " + nuevacarta + " , y el total es : " +total);

                if (total<21)
                {
                    Console.WriteLine("¿Continuar? (si/no)");
                   respuesta = Console.ReadLine();
                }

                else if (total ==21)
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
            Console.WriteLine("Gracias por jugar");
        }
    }
}
