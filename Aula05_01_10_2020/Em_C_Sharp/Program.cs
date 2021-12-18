using System;

namespace Aula05_29_09_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, soma;

            Console.Write("Insira o primeiro número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira o segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            soma = num1 + num2;

            Console.WriteLine("A soma é " + soma);
        }
    }
}
