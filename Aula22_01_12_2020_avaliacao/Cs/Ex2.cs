using System;

namespace Cs
{
    class Ex2
    {
        static void Main(string[] args)
        {
            int i = 0;

            do{
                if(i % 2 == 0)
                {
                    Console.WriteLine($"O quadrado de {i} é igual a {Math.Pow(i, 2)}");
                }
                i++;
            } while(i <= 20);
        }
    }
}