// using System;

// namespace Cs
// {
//     class teste4
//     {
//         static void Main(string[] args)
//         {
//             int[,] matriz = new int[4, 4];

//             for (int i = 0; i < 4; i++)
//             {
//                 for (int j = 0; j < 4; j++)
//                 {
//                     Console.Write("Digite um número qualquer: ");
//                     matriz[i, j] = Convert.ToInt32(Console.ReadLine());
//                 }
//             }
            
//             for (int i = 0; i < 4; i++)
//             {
//                 for (int j = 0; j < 4; j++)
//                 {
//                     if (i == j)
//                     {
//                         Console.WriteLine($"Linha {i}, coluna {j} = {matriz[i, j]}");
//                     }
//                 }
//             }
//         }
//     }
// }