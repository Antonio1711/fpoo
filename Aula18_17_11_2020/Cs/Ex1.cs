using System;

namespace Cs
{
    class Ex1

    {
        static void Main(string[] args)
        {
            int i;

            for (i = 15; i <= 200; i++){
                Console.WriteLine($" O quadrado do número {i} é: {Math.Pow(i, 2)}");
            }
        }
    }
}