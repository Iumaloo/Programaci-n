using System;
using System.Runtime.InteropServices.ComTypes;
using System.Xml;

namespace Simulacrop2_Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int turnos = 0, vidas= 1, dnormal = 0, despecial1=0, despecial2=0 , total = 0,cUnos=0, cSeis=0;
            int cdado1 = 2, cdado2 = 2;
            string answer = "";
            string answerE = "";
            Console.WriteLine("Diga si para iniciar el juego");
            answer = Console.ReadLine();

            while ((answer == "si"&&(1<=vidas&&vidas<=3)&&total<100))
            {
                turnos++;
                if (cdado1 > 0 && cdado2>0)
                {
                    Console.WriteLine("¿Desea usar los dados especiales? (si/no)");
                    answerE = Console.ReadLine();
                }

                if (answerE == "si" && cdado1 <= 2 && cdado2 <= 2)
                {
                    despecial1 = aleatorio.Next(1, 13);
                    cdado1--;
                    despecial2 = aleatorio.Next(1, 13);
                    cdado2--;
                    total= total+despecial1+despecial2;
                    Console.WriteLine("DADO 1 : " + despecial1 + "    DADO 2 : " + despecial2 + "\nTOTAL : " + total);
                    Console.WriteLine("cdado1 = " + cdado1 + " cdado2 = " + cdado2);
                    answerE = "n";
                }
                else
                {
                    dnormal = aleatorio.Next(5,7);
                    total += dnormal;
                    Console.WriteLine("DADO : " + dnormal + "\nTOTAL : " + total);
                }
               if ((dnormal==1 || despecial1==1||despecial2==1))
                {
                    cUnos++;
                    Console.WriteLine("Unos:  " + cUnos);
                }
               if (cUnos==2)
                {
                    total = total-10;
                    vidas=vidas-1;
                    cUnos = 0;
                }
             
                 if(cSeis==1&&dnormal==6)
                {
                    if (vidas < 3) vidas++;
                    cSeis = 0;
                }
                 else
                {
                    cSeis = 0; 
                }
                if (dnormal == 6&&cSeis==0) cSeis++;
               
                if (vidas == 0)
                {
                    Console.WriteLine("Uy pai, muy de malas, te me cuidas"); break;
                }
                 if (total >= 100)
                {
                    Console.WriteLine("Uy pai qué crack;ganassstesss");
                    break;
                }

                Console.WriteLine("VIDA: " + vidas);
                Console.WriteLine("¿Desea continuar? (si/no)");
                answer = Console.ReadLine();

            }
            Console.WriteLine("¡Gracias por jugar!");

        }
    }
}
