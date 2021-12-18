// using System;

// namespace Cs
// {
//     class Ex1
//     {
//         static void Main(string[] args)
//         {
//             float n1, n2, n3, n4, mf;

//             Console.WriteLine("Digite a primeira nota: ");
//             n1 = Convert.ToSingle(Console.ReadLine());
//             Console.WriteLine("Digite a segunda nota: ");
//             n2 = Convert.ToSingle(Console.ReadLine());
//             Console.WriteLine("Digite a terceira nota: ");
//             n3 = Convert.ToSingle(Console.ReadLine());
//             Console.WriteLine("Digite a quarta nota: ");
//             n4 = Convert.ToSingle(Console.ReadLine());

//             mf = (n1 + n2 + n3 + n4) / 4;

//             if (mf < 5)
//             {
//                 Console.WriteLine("Sua média é " + mf + "\nVocê foi reprovado!");
//             }
//             else if (mf >= 7)
//             {
//                 Console.WriteLine("Sua média é " + mf + "\nVocê foi aprovado!");
//             }
//             else
//             {
//                 Console.WriteLine("Sua média é " + mf + "\nVocê está de recuperação");
//             }
//         }
//     }
// }