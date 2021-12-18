using System;

namespace Cs
{
    class Ex2
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[3];
            int[,] notas = new int[4, 4];
            int[] mf = new int [3];
            string situacao;

            for(int i = 0; i < 3; i++)
            {
                Console.Write($"Digite o nome do aluno {i}: ");
                nomes[i] = Console.ReadLine();
            }

            for(int x = 1; x < 5; x++)
            {
                for(int j = 1; j < 5; j++)
                {
                    for(int i = 0; i < 3; i++)
                    {
                        Console.Write($"Digite a nota {x} de {nomes[i]}: ");
                        notas[x, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
        }
    }
}