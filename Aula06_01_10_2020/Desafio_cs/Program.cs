using System;

namespace Desafio_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar variáveis
            float f, c;

            //Entrada(s)
            Console.Write("Digite a temperatura em Fahrenheit: ");
            f = Convert.ToSingle(Console.ReadLine());
            
            //Processamento
            c = (f - 32) * 5/9;
            
            //Saída(s)
            Console.Write("Sua temperatura em Celsius é " + c + "°");
        }
    }
}
