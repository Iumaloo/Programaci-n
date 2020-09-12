using System;

namespace Matriz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] valores = { "-", "-", "O", "X" };
            int n = 10;
            int m = 15;
            int contX = 0, contO=0, contGuion= 0,total=0;
            string[,] tablero = new string[n, m];
            string[,] salida = new string[n, m];

            for (int i =0; i<tablero.GetLength(0);i++)
            {
                for (int j = 0; j <tablero.GetLength(1);j++)
                {
                    int indice = random.Next(0, valores.Length);
                    tablero[i, j] = valores[indice];
                    salida[i, j] = "-";
                    if (tablero[i,j]=="X")
                    {
                        contX++;
                    }
                    if (tablero[i, j] == "O")
                    {
                        contO++;
                    }
                    if (tablero[i, j] == "-")
                    {
                        contGuion++;
                    }
                    salida[i, j] = "-";
                }
            }

            Console.WriteLine("ENTRADA : ");
            for (int i = 0; i < tablero.GetLength(0)-2; i++)
            {
                for (int j = 0; j < tablero.GetLength(1)-2; j++)
                {
                    if (tablero[i, j] == "X")
                    {
                        if (tablero[i, j] == tablero[i + 1, j] && tablero[i, j] == tablero[i + 2, j])
                        {
                            salida[i, j] = "1";
                            salida[i+1, j] = "1";
                            salida[i+2, j] = "1";
                        }
                        if (tablero[i, j] == tablero[i, j+1] && tablero[i, j] == tablero[i, j+2])
                        {
                            salida[i, j] = "1";
                            salida[i, j+1] = "1";
                            salida[i, j+2] = "1";
                        }
                    }

                    if (tablero[i, j] == "O")
                    {
                        if (tablero[i, j] == tablero[i + 1, j] && tablero[i, j] == tablero[i + 2, j])
                        {
                            salida[i, j] = "2";
                            salida[i + 1, j] = "2";
                            salida[i + 2, j] = "2";
                        }
                        if (tablero[i, j] == tablero[i, j + 1] && tablero[i, j] == tablero[i, j + 2])
                        {
                            salida[i, j] = "2";
                            salida[i, j + 1] = "2";
                            salida[i, j + 2] = "2";
                        }
                    }
                }
             
            }
            total = n * m;
            int porcentajeX = (contX * 100) / total;
            int porcentajeO = (contO * 100) / total;
            int porcentajeGuion= (contGuion * 100) / total;
            Console.WriteLine("Porcentaje X : " +porcentajeX + " Porcentaje  O : " +porcentajeO + " Porcentaje - : " +porcentajeGuion);

            Console.WriteLine("\nSALIDA: ");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write("|" + salida[i, j]);
                }
                Console.Write("|\n");
            }
            Console.Write("|\n");
        }
    }
}
