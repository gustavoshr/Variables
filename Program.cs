using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numero = 11;
           int numero2 = 21;
           Console.WriteLine(numero + " - " + numero2);

           int numeroAC = numero + 1;
           int numeroDec = numero2 - 1;
           Console.WriteLine(numeroAC + " - " + numeroDec);

        }
    }
}