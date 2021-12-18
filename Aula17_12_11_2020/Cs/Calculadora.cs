using System;

namespace Cs
{
    class Calculadora
    {
        static void Main(string[] args)
        {
            double num1, num2;
            int op;

            Console.WriteLine("Digite o número da operação que deseja realizar para posteriormente escolher o(s) número(s): ");

            Console.WriteLine("1. Adição(+) \n2. Subtração(-) \n3. Multiplicação(*) \n4. Divisão(/) \n5. Potenciação(^) \n6. Raiz quadrada \n7. Conversão de real para moeda estrangeira \n8. Conversão de moeda estrangeira para real \n9. Conversão de Celsius para Fahrenheit \n10. Conversão de Fahrenheit para Celsius \nDigite o número abaixo: ");
            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case var _ when op == 1: 
                    Console.WriteLine("Digite o primeiro número: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
                    break;
                case var _ when op == 2: 
                    Console.WriteLine("Digite o primeiro número: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
                    break;
                case var _ when op == 3: 
                   Console.WriteLine("Digite o primeiro número: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
                    break;
                case var _ when op == 4: 
                    Console.WriteLine("Digite o primeiro número: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
                    break;
                case var _ when op == 5: 
                    Console.WriteLine("Digite a base: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o expoente: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(num1 + " ^ " + num2 + " = " + (Math.Pow(num1, num2)));
                    break;
                case var _ when op == 6: 
                    Console.WriteLine("Digite o número: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("√ " + num1 + " = " + (Math.Sqrt(num1)));
                    break;
                case var _ when op == 7: 
                    Console.WriteLine("Digite o valor em real que deseja converter: ");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("1. Dólar americano \n2. Euro \n3. Libra Esterlina \nDigite o número da moeda estrangeira: ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    switch (num2)
                    {
                        case var _ when num2 == 1:
                        Console.WriteLine("Seu valor em Dólar americano é: " + (num1 * 0.18));
                        break;
                        case var _ when num2 == 2:
                        Console.WriteLine("Seu valor em Euro é: " + (num1 * 0.15));
                        break;
                        case var _ when num2 == 3:
                        Console.WriteLine("Seu valor em Libra esterlina é: " + (num1 * 0.14));
                        break;
                        default:
                        Console.WriteLine("Número inválido");
                        break;
                    }
                    break;
                case var _ when op == 8: 
                    Console.WriteLine("Digite o valor da moeda estrangeira que deseja converter para real: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("1. Dólar americano \n2. Euro \n3. Libra Esterlina \nDigite o número da moeda estrangeira: ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    switch (num2)
                    {
                        case var _ when num2 == 1:
                        Console.WriteLine("Seu valor em Real é: " + (num1 * 5.43));
                        break;
                        case var _ when num2 == 2:
                        Console.WriteLine("Seu valor em Real é: " + (num1 * 6.46));
                        break;
                        case var _ when num2 == 3:
                        Console.WriteLine("Seu valor em Real é: " + (num1 * 7.19));
                        break;
                        default:
                        Console.WriteLine("Número inválido");
                        break;
                    }
                    break;
                case var _ when op == 9: 
                    Console.WriteLine("Digite a temperatura em Celsius que deseja converter para Fahrenheit: ");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Sua temperatura em Fahrenheit: " + ((9 * num1 + 160) / 5));
                    break;
                case var _ when op == 10: 
                    Console.WriteLine("Digite a temperatura em Fahrenheit que deseja converter para Celsius: ");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Sua temperatura em Celsius: " + ((num1 - 32) * 5/9));
                    break;
                default:
                    Console.WriteLine("Opção inválida, tente novamente");
                    break;
            }

        }
    }
}
