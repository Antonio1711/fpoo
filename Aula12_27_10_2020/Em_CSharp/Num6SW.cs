using System;

namespace Em_CSharp
{
    class Num6SW
    {
        static void Main(string[] args)
        {
            double imc, peso, altura;

            Console.WriteLine("Digite o seu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Digite a sua altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            imc = peso / Math.Pow(altura, 2);

            Console.WriteLine("Seu IMC é: " + imc.ToString("0.00"));

            switch (imc)
            {
                case var _ when imc <= 17:
                    Console.WriteLine("Muito abaixo do peso");
                    break;
                case var _ when imc > 17 && imc <= 18.49:
                    Console.WriteLine("Abaixo do peso");
                    break;
                case var _ when imc >= 18.5 && imc <= 24.99:
                    Console.WriteLine("Peso normal");
                    break;
                case var _ when imc >= 25 && imc <= 29.99:
                    Console.WriteLine("Acima do peso");
                    break;
                case var _ when imc >= 30 && imc <= 34.99:
                    Console.WriteLine("Obesidade I");
                    break;
                case var _ when imc >= 35 && imc <= 39.99:
                    Console.WriteLine("Obesidade II (severa)");
                    break;
                case var _ when imc > 40:
                    Console.WriteLine("Obesidade III (mórbida)");
                    break;
            }
        }
    }
}