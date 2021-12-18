using System;

namespace Cs
{
    class Ex1
    {
        static void Main(string[] args)
        {
            int i, num, f;

            Console.WriteLine("Digite o número: ");
            num = Convert.ToInt32(Console.ReadLine());
            
            if (num == 0){
                Console.WriteLine("O fatorial de 0 é 0");
            }
            else
            {
                f = 1;
                i = 1;
            
                while(i <= num)
                {
                    f *= i;
                    i++;
                }
                Console.WriteLine($"Fatorial é = {f}");
            }

        }
    }
}