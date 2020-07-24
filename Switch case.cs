
using System;

namespace Switch_deducciones
{
    class Program
    {
        static void Main()
        {
            double pension = 0, eps = 0, arl = 0, prima = 0;
            Console.WriteLine("Ingrese su salario");
            double SalarioMensual = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su tipo de contrato " + " Escriba 1 si es dependiente " + "  , Escriba 2 si es independiente");
            int tipoContrato = int.Parse(Console.ReadLine());

            double smmlv = 877803;
            double baseCotizacion = SalarioMensual * 0.4;
            if (baseCotizacion < smmlv) baseCotizacion = smmlv;

            switch (tipoContrato)
            {
                case 1:
                    pension = baseCotizacion * 0.04;
                    eps = baseCotizacion * 0.04;
                    prima = SalarioMensual;
                    double salarioReal = SalarioMensual - (pension + eps);
                    double salarioAnual = ((salarioReal) * 12) + prima;

                    Console.WriteLine("Deducciones : Eps : " + eps + " , Pensión : " + pension);
                    Console.WriteLine("Salario Real : " + salarioReal + " , Salario Anual : " + salarioAnual); break;

                case 2:
                    Console.WriteLine("Ingrese su número de riesgo");
                    int riesgo = int.Parse(Console.ReadLine());
                    pension = baseCotizacion * 0.16;
                    eps = baseCotizacion * 0.125;

                    switch (riesgo)
                    {
                        case 1: arl = 0.00522; break;

                        case 2:arl = 0.1044; break;

                        case 3:arl = 0.02136; break;

                        case 4:arl = 0.0435; break;

                        case 5:arl = 0.0696; break;
                    }
                    arl *= baseCotizacion;
                    double salarioReali = SalarioMensual - (pension + eps + arl);
                    double salarioAnuali = (salarioReali * 12);

                    Console.WriteLine("Deducciones : Eps : " + eps + " , Pensión : " + pension + " , Arl : " + arl);
                    Console.WriteLine("Salario Real : " + salarioReali + " , Salario Anual : " + salarioAnuali);
                    break;


            }
        }
    }
}
