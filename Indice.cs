using System;

namespace IMC
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Ingrese su estatura en centímetros");
            double estatura = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su peso en kilogramos");
            double peso = double.Parse(Console.ReadLine());

            double estaturac = (estatura / 100);
            double IMC = (peso / (estaturac * estaturac));
            

            if (IMC < 18.5)
            {
                Console.WriteLine("Su índice es : " + IMC);
                Console.WriteLine("Usted está bajo de peso");
            }

            else if (18.5 <= IMC && IMC < 25)
            {
                Console.WriteLine("Su índice es : " + IMC);
                Console.WriteLine("Usted tiene peso normal");
            }

            else if (25.0 <= IMC && IMC < 30)
            {
                Console.WriteLine("Su índice es : " + IMC);
                Console.WriteLine("Usted tiene sobrepeso");
            }

            else 

            {
                Console.WriteLine("Su índice es : " + IMC);
                Console.WriteLine("Usted tiene obesidad");
            }
        }
    }
}
