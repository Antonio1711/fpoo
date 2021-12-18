// using System;

// namespace Cs
// {
//     class Ex1
//     {
//         static void Main(string[] args)
//         {
//             int[,] matriz = new int[3, 3];

//             for(int i = 0; i < 3; i++)
//             {
//                 for(int j = 0; j < 3; j++)
//                 {
//                     Console.Write($"Informe o elemente de índice {i}, {j}: ");
//                     matriz[i, j] = Convert.ToInt32(Console.ReadLine());
//                 }
//             }
            
//             for(int i = 0; i < 3; i++)
//             {
//                 for(int j = 0; i < 3; j++)
//                 {
//                     if (i + j == 2)
//                     {
//                         Console.WriteLine($"{matriz[i, j]}");
//                     }
//                 }
//             }
//         }
//     }
// }
