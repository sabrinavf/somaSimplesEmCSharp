using System;
using System.Globalization;

namespace Estudo
{
    class somaSimples
    {
        static void Main(string[] args)
        {
            int SOMA;

            string[] vet = (Console.ReadLine().Split(" "));
            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);

            SOMA = A + B;

            Console.WriteLine("SOMA = " + SOMA);



        }
    }
}