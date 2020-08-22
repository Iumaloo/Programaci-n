using System;
using System.ComponentModel;

namespace BlackJackArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int valorcartas1 = 0, valorcartas2 = 0;
            Console.WriteLine("Ingrese número de jugadores : ");
            int ansjugador = int.Parse(Console.ReadLine());
            while (ansjugador < 2 || (ansjugador > 5))
            {
                Console.WriteLine("El número de jugadores no es válido; intente de nuevo : ");
                ansjugador = int.Parse(Console.ReadLine());
            }

            int[] puntajes = new int[ansjugador];
            string[] nombres = new string[ansjugador];

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("Ingrese su nombre : ");
                nombres[i] = Console.ReadLine();
                Console.WriteLine("Bienvenido al juego" + "\nJugador : " + nombres[i]);
                valorcartas1 = aleatorio.Next(1, 11);
                valorcartas2 = aleatorio.Next(1, 11);
                puntajes[i] = valorcartas1 + valorcartas2;
                Console.WriteLine("El primer valor de sus cartas es : " + valorcartas1 + "  El segundo valor de sus cartas es : " + valorcartas2);
                Console.WriteLine("Su total es: " + puntajes[i]);
                string respuesta = "s";
                while ( respuesta == "s"&&puntajes[i]<21)
                {
                    Console.WriteLine("¿Desea continuar? (ingrese 'si o 'no' )");
                   respuesta = Console.ReadLine();
                    while (respuesta != "si" && respuesta != "no")
                    {
                        Console.WriteLine("Esa no es una respuesta válida; intente de nuevo: ");
                        respuesta = Console.ReadLine();
                    }

                    if (respuesta == "no") break;

                    else
                    {
                        int carta = aleatorio.Next(1, 11);
                        puntajes[i] += carta;
                        Console.WriteLine("EL valor de su nueva carta es: " + carta);
                        Console.WriteLine("Su total es : " + puntajes[i]);

                    }
                    if (puntajes[i] < 21)
                    {
                        Console.WriteLine("¿Continuar? (si/no)");
                        respuesta = Console.ReadLine();
                        while (respuesta != "si" && respuesta != "no")
                        {
                            Console.WriteLine("Esa no es una respuesta válida; intente de nuevo: ");
                            respuesta = Console.ReadLine();
                        }
                    }
                    else if (puntajes[i] == 21)
                    {
                        Console.WriteLine("Has ganado");
                        respuesta = "n";
                    }

                    else
                    {
                        Console.WriteLine("Eliminado");
                        respuesta = "n";
                        puntajes[i] = 0;
                    }
                   
                    for(int e=0; e<nombres.Length;e++)
                    {
                        for (int a = 0; a < nombres.Length - 1; a++)
                        {
                            if (puntajes[a] < puntajes[a + 1])
                            {
                                int tmp = puntajes[a];
                                puntajes[a] = puntajes[a + 1];
                                puntajes[a + 1]= tmp;

                                string aux = nombres[a];
                                nombres[a] = nombres[a + 1];
                                nombres[a + 1] = aux;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Ganador : " + nombres[0] + " \ncon un total de : " + puntajes[0]);
            Console.WriteLine("Segundo lugar : " + nombres[1] + "\ncon un total de : " + puntajes[1]);
        }
           
        }
    }

