using System;

namespace Cálculo_Tarifa
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Ingrese su salario");

            double salario = double.Parse(Console.ReadLine());

            double sm = 877803;

            double dossm = 2 * sm;

            double cuasm = 4 * sm;

            if (salario<=sm)
            {
                Console.WriteLine("Tarifa A");
            }
            else if (dossm<=salario&&salario<cuasm)
            {
                Console.WriteLine("Tarifa B");
            }

            else
            {
                Console.WriteLine("Tarifa C");

            }

     
        }
    }
}
