using System;

namespace Cs
{
    class Ex1
    {
        static void Main(string[] args)
        {
            int n, r_4, r_5;

            Console.WriteLine("Para descobrir se o número é divisível 4 e 5, digite o número: ");
            n = Convert.ToInt32(Console.ReadLine());

            r_4 = n % 4; 
            r_5 = n % 5;

            if (r_4 == 0 && r_5 == 0)
            {
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine("Não é divisível por 4 e 5");
            }
        }
    }
}