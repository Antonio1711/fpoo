// using System;

// namespace CSharp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             double novo_salario, salario;

//             Console.Write("Para descobrir o reajuste, digite seu salário ao lado: ");
//             salario = Convert.ToDouble(Console.ReadLine());

//             if (salario < 500)
//             {
//                 novo_salario = salario * 1.15;
//             }
//             else if (salario <= 1000 && salario >= 500)
//             {
//                 novo_salario = salario * 1.10;
//             }
//             else
//             {
//                 novo_salario = salario * 1.05;
                
//             }

//             Console.Write($"Seu novo salário é: {novo_salario.ToString("0.00")}");
//         }
//     }
// }
