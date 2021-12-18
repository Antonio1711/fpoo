// using System;

// namespace Cs
// {
//     class letraC
//     {
//         static void Main(string[] args)
//         {
//             int[] matrizA = new int[20], matrizB = new int[20], matrizC = new int[20];

//             Console.WriteLine("Matriz A:");
//             for (int i = 1; i < 21; i++)
//             {
//                 Console.Write($"Digite o {i}º número: ");
//                 matrizA[i] = Convert.ToInt32(Console.ReadLine());
//             }
            
//             Console.WriteLine("Matriz B:");
//             for (int i = 1; i < 21; i++)
//             {
//                 Console.Write($"Digite o {i}º número: ");
//                 matrizB[i] = Convert.ToInt32(Console.ReadLine());
//             }
            
//             Console.WriteLine("Matriz C:");
//             for (int i = 1; i < 21; i++)
//             {
//                 matrizC[i] = matrizA[i] - matrizB[i];

//                 Console.WriteLine($"{i}º número = {matrizC[i]}");
//             }
//         }
//     }
// }