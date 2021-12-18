// using System;

// namespace Em_CSharp
// {
//     class Num3
//     {
//         static void Main(string[] args)
//         {
//             int num1, num2, num3, maior, menor, soma;
//             float media;
            
//             Console.WriteLine("Digite o primeiro número: ");
//             num1 = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Digite o segundo número: ");
//             num2 = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Digite o terceiro número: ");
//             num3 = Convert.ToInt32(Console.ReadLine());

//             if (num1 > num2 && num1 > num3)
//             {
//                 maior = num1;
//             }
//             else if (num2 > num1 && num2 > num3)
//             {
//                 maior = num2;
//             }
//             else
//             {
//                 maior = num3;
//             }

//             if (num1 < num2 && num1 < num3)
//             {
//                 menor = num1;
//             }
//             else if (num2 < num1 && num2 < num3)
//             {
//                 menor = num2;
//             }
//             else
//             {
//                 menor = num3;
//             }

//             soma = num1 + num2 + num3;
            
//             media = (num1 + num2 + num3) / 3;

//             Console.WriteLine("O maior número é: " + maior);
//             Console.WriteLine("O menor número é: " + menor);
//             Console.WriteLine("A soma desses números é: " + soma);
//             Console.WriteLine("A média desses números é: " + media);
            
//         }
//     }
// }