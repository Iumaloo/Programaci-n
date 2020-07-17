using System;
using System.Collections;

namespace Deducción_salarial
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Ingrese su salario : ");
            double salarioMensual = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su tipo de contrato: " + "Escriba 1 si es Dependiente : "  + " Escriba 2 si es Independiente : ");
            int tipoContrato = int.Parse(Console.ReadLine());

            double salm = 877803;
            double basecot = salarioMensual * 0.4;
            
            if (basecot < salm) basecot = salm;
           if (tipoContrato==1)
            {
                double pension = basecot * 0.04;
                double eps = basecot * 0.04;
                double prima = salarioMensual;
                double salReal = salarioMensual - ( pension + eps);
                double salanual =( salReal * 12) + (prima);
                Console.WriteLine("Deducciones: EPS :" + eps + ", Pensión : " + pension);
                Console.WriteLine("Salario Real : " + salReal + "," + " Salario Anual : " + salanual);

            }
      else
            {
                Console.WriteLine("Ingrese su número de riesgo");
                int riesgo = int.Parse(Console.ReadLine());

                if (riesgo==1)
                {
                    double arl = basecot * 0.00522;
                    double pension = basecot * 0.16;
                    double eps = basecot * 0.125;
                    double salReal = salarioMensual - (arl + pension + eps);
                    double salanual = salReal * 12;
                    Console.WriteLine("Deducciones: EPS : " + eps + ",Pensión : " + pension + ", Arl : " + arl);
                    Console.WriteLine("Salario Real : " + salReal + "," + " Salario Anual : " + salanual);
                }
                else if (riesgo==2)
                {
                    double arl = basecot * 0.01044;
                    double pension = basecot * 0.16;
                    double eps = basecot * 0.125;
                    double salReal = salarioMensual - (arl + pension + eps);
                    double salanual = salReal * 12;
                    Console.WriteLine("Deducciones: EPS : " + eps + ",Pensión : " + pension + ", Arl : " + arl);
                    Console.WriteLine("Salario Real : " + salReal + "," + " Salario Anual : " + salanual);
                }

                else if (riesgo == 3)
                {
                    double arl = basecot * 0.02436;
                    double pension = basecot * 0.16;
                    double eps = basecot * 0.125;
                    double salReal = salarioMensual - (arl + pension + eps);
                    double salanual = salReal * 12;
                    Console.WriteLine("Deducciones: EPS : " + eps + ",Pensión : " + pension + ", Arl : " + arl);
                    Console.WriteLine("Salario Real : " + salReal + "," + " Salario Anual : " + salanual);
                }
                else if (riesgo == 4)
                {
                    double arl = basecot * 0.0435;
                    double pension = basecot * 0.16;
                    double eps = basecot * 0.125;
                    double salReal = salarioMensual - (arl + pension + eps);
                    double salanual = salReal * 12;
                    Console.WriteLine("Deducciones: EPS : " + eps + ",Pensión : " + pension + ", Arl : " + arl);
                    Console.WriteLine("Salario Real : " + salReal + "," + " Salario Anual : " + salanual);
                }
                else if (riesgo == 5)
                {
                    double arl = basecot * 0.0696;
                    double pension = basecot * 0.16;
                    double eps = basecot * 0.125;
                    double salReal = salarioMensual - (arl + pension + eps);
                    double salanual = salReal * 12;
                    Console.WriteLine("Deducciones: EPS : " + eps + ",Pensión : " + pension + ", Arl : " + arl);
                    Console.WriteLine("Salario Real : " + salReal + "," + " Salario Anual : " + salanual);
                }
            }
            



        }
    }
}


