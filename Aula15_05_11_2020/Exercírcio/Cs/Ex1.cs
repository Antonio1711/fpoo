using System;

namespace Cs
{
    class Ex1
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Vamos descobrir que tipo de triânglo é o seu, para isso digite os lados a baixo:");

            Console.WriteLine("Digite o valor de A: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            c = Convert.ToDouble(Console.ReadLine());

            if (a == b && b == c)
            {
                Console.WriteLine("É um triângulo equilátero");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("É um triângulo isósceles");
            }
            else
            {
                Console.WriteLine("É um triângulo escaleno");
            }
        }
    }
}
