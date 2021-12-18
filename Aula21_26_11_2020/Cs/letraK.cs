using System;

namespace Cs
{
    class LetraK
    {
        static void Main(string[] args)
        {
            int i, graos, soma = 0;

            for (i = 1; i <= 64; i++)
            {
                graos = i * 2;

                soma += graos;
                Console.WriteLine($"A soma dos grãos é {soma}");
            }
        }
    }
}