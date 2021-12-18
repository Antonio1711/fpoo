// using System;

// namespace Cs
// {
//     class LetraL
//     {
//         static void Main(string[] args)
//         {
//             int i, num, f, cont, soma;
//             soma = 0;

//             for (i = 1; i <= 15; i++)
//             {
//                 Console.Write($"Digite o valor do número {i}: ");
//                 num = Convert.ToInt32(Console.ReadLine());

//                 if (num > 0)
//                 {
//                     f = 1;
//                     cont = 1;
            
//                     while(cont <= num)
//                     {
//                         f *= cont;
//                         cont++;
//                     }
//                     soma += f;
//                 }
//             }
            
//             Console.WriteLine($"A soma dos fatoriais desses números é igual a {soma}");
//         }
//     }
// }