using System;

namespace BinarioAdecimal
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese números binarios");
            Console.WriteLine("Ingrese b4");

            int b4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese b3");
            int b3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese b2");
            int b2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese b1");
            int b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese b0");
            int b0 = int.Parse(Console.ReadLine());

            double dec1 = (0 * 2 + b4);
            double dec2 = (dec1 * 2 + b3);
            double dec3 = (dec2 * 2 + b2);
            double dec4 = (dec3 * 2 + b1);

            double Numero_Final = (dec4*2 +b0);

            Console.WriteLine("Decimal= " + Numero_Final);
        }
    }
}
