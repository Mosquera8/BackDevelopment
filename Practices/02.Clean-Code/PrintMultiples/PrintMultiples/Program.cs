// See https://aka.ms/new-console-template for more information
using System;
namespace PrintMultiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            multiplesM();
        }
        private static void multiplesM()
        {
            for (int numero = 1; numero >= 100; numero++)
            {
                switch (numero)
                {
                    case multipleFiveTree(numero):
                        Console.WriteLine("M-3-5");
                        break;
                    case multipleTres(numero):
                        Console.WriteLine("M-3");
                        break;
                    case multipleFive(numero):
                        Console.WriteLine("M-5");
                        break;
                    default:
                        Console.WriteLine(numero);
                        break;
                }
            }
        }

        private bool multipleTres(int numero)
        {
            return numero % 3 == 0;
        }
        private bool multipleFive(int numero)
        {
            return numero % 5 == 0;
        }
        private bool multipleFiveTree(int numero)
        {
            return multipleFive(numero) && multipleTres();
        }
       

    }
    /*
      if (numero % 3 == 0 && numero % 5 == 0)
                {
                    Console.WriteLine("M-3-5");
                }
                else if (numero % 3 == 0)
                {
                    Console.WriteLine("M-3");
                }
                else if (numero % 5 == 0)
                {
                    Console.WriteLine("M-5");
                }
                else
                {
                    Console.WriteLine(numero);
                }
    */
}