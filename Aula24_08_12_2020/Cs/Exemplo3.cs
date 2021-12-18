using System;

namespace Cs
{
    class Exemplo2
    {
        static void Main(string[] args)
        {
            float[] md= new float[8];
            float soma = 0;
            int i = 0;

            Console.WriteLine("Obtendo médias dos alunos");
            
            for(i = 0; i < md.Length; i++)
            {
                Console.Write($"Digite a nota do {i + 1}º aluno: ");
                md[i] = Convert.ToSingle(Console.ReadLine());
                soma = soma + md[i];
            }
            float mg = soma / md.Length;

            Console.WriteLine($"A média geral da turma é {mg}");        
            }
    }
}