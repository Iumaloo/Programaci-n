
using System;
using System.Xml.Schema;

namespace Valores_extremos
{
    class Program
    {
        static void Main()
        {
            double total = 0;
            Console.WriteLine("Ingrese el número de datos");
            int n = int.Parse(Console.ReadLine());
            int i = 0, max = 0 , min = 500;
            string nombremax = "";
            string nombremin = "";


            while (i < n)
            {

                Console.WriteLine("Ingrese nombre, luego la edad");
                string nombre = Console.ReadLine();
                int edad = int.Parse(Console.ReadLine());

                if (edad > max)
                {
                    max = edad;
                    nombremax = nombre; 

                }
                if (edad < min)
                {
                    min = edad;
                    nombremin = nombre; 
                }

                total += edad;

                i++;
            }

            double promedio = total / n;
            Console.WriteLine("Promedio : " + promedio);
            Console.WriteLine("Mayor : " + max + "," + nombremax);
            Console.WriteLine("Menor : " + min+ ","+  nombremin);
          
        }

        

    }
}
