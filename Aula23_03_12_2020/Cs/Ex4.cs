using System;

namespace Cs
{
    class Ex4
    {
        static void Main(string[] args)
        {
            int i = 0, inicio, fim, passo;

            Console.Write("Digite o valor inicial: ");
            inicio = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor final: ");
            fim = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor do passo: ");
            passo = Convert.ToInt32(Console.ReadLine());

            if (passo > 0)
            {
                do
                {
                    i = inicio;
                    i += passo;

                    Console.WriteLine(i);
                } while(i <= inicio);
            
            }
            else if (passo < 0)
            {
                do
                {
                    i = fim;
                    i -= passo;

                    Console.WriteLine(i);
                } while(i <= inicio);
                
            }
        }
    }
}
