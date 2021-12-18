// using System;

// namespace Em_CSharp
// {
//     class Num6
//     {
//         static void Main(string[] args)
//         {
//             double imc, peso, altura;

//             Console.WriteLine("Digite o seu peso: ");
//             peso = Convert.ToDouble(Console.ReadLine());
            
//             Console.WriteLine("Digite a sua altura: ");
//             altura = Convert.ToDouble(Console.ReadLine());

//             imc = peso / Math.Pow(altura, 2);

//             if (imc < 17)
//             {
//                 Console.WriteLine("Muito abaixo do peso");
//             }
//             else if (imc >= 17 && imc <= 18.49)
//             {
//                 Console.WriteLine("Abaixo do peso");
//             }
//             else if (imc >= 18.5 && imc <= 24.99)
//             {
//                 Console.WriteLine("Peso normal");
//             }
//             else if (imc >= 25 && imc <= 29.99)
//             {
//                 Console.WriteLine("Acima do peso");
//             }
//             else if (imc >= 30 && imc <= 34.99)
//             {
//                 Console.WriteLine("Obesidade I");
//             }
//             else if (imc >= 35 && imc <= 39.99)
//             {
//                 Console.WriteLine("Obesidade II (severa)");
//             }
//             else
//             {
//                 Console.WriteLine("Obesidade III (mórbida)");
//             }
//         }
//     }
// }