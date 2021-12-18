// using System;

// namespace Cs
// {
//     class ex3
//     {
//         static void Main(string[] args)
//         {
//             int ip;

//             Console.WriteLine("Digite o primeiro octeto do IPv4 para saber sua classe: "); 
//             ip = Convert.ToInt32(Console.ReadLine());

//             if (ip >= 1 && ip <= 127)
//             {
//                 Console.WriteLine("Sua classe de IPv4 é A");
//             }
//             else if (ip >= 128 && ip <= 191)
//             {
//                 Console.WriteLine("Sua classe de IPv4 é B");
//             }
//             else
//             {
//                 Console.WriteLine("Sua classe de IPv4 é C");
//             }
//         }
//     }
// }