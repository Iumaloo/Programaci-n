using System;

namespace Cuota_moderadora
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Ingrese su salario");
            double salario = double.Parse(Console.ReadLine());
           
            double dossm = 1775606;
            double cinqsm = 4389015;

            double cuota1 = 3400;
            double cuota2 = 13500;
            double cuota3 = 35600;

            if(salario < dossm)
            {
                Console.WriteLine("Tarifa A : " + cuota1);
            }

            else if (dossm <=salario && salario < cinqsm)
            {
                Console.WriteLine("Tarifa B : " + cuota2);
            }

            else
            {
                Console.WriteLine("Tarifa C : " +cuota3);
            }
        }
    }
}
