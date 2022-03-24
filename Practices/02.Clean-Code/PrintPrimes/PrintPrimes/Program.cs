using System;

namespace PrintPrimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintPrimes(13);
            // 2,3,5,7,11,13
            PrintPrimes(10);
            // 2,3,5,7
            PrintPrimes(0);
            // Error: Invalid Number
            PrintPrimes(1);
            // Error: 1 Is not Prime

        }

        private static void PrintPrimes(int number)
        {
           
            for (int i = 0; i <= number; i++)
            {
                //vandera y contador
                bool prime = true;
                int v = 2;
                //verificador, inicializa desde dos
                for (int j=0;j<=i;j++)
                {
                    //si tiene más dividendos no puede ser primo
                    if (i % v == 0)
                    {
                        prime = false;
                        break;
                    }
                    //si es primo imprimir
                    if (prime)
                    {
                        Console.WriteLine();
                    } 
                }
            }
           
        }
        // Para no tener errores
        static void exeption(int f)
        {
            if (f == 0)
            {
                throw new ArithmeticException("0 no es valido como primo");
            }
            else if (f == 1)
            {
                Console.WriteLine("El numero 1 no es permitido como un primo");
            }
            else
            {
                Console.WriteLine("What on earh did you put broh");
            }
        }
    }
}
