using System;

namespace Cs
{
    class letraB
    {
        static void Main(string[] args)
        {
            int[] matrizA = new int[8], matrizB = new int[8];

            for (int i = 0; i < matrizA.Length; i++)
            {
                Console.Write($"Informe o elemento {i}: ");
                matrizA[i] = Convert.ToInt32(Console.ReadLine());
                
                matrizB[i] = 3 * matrizA[i];
            }
            Console.WriteLine("----------------------------------------------");
            for (int i = 0; i < matrizA.Length; i++)
            {                                                           //\t é como se fosse um tab para exibir
                Console.WriteLine($"Elemento {i} = Vetor A: {matrizA[i]} \t Vetor B: {matrizB[i]}");
            }
            
        }
    }
}