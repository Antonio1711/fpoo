using System;

namespace Aula_06_01_10_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar variáveis
            float cel, fah;

            //Entrada(s)
            Console.Write("Digite a temperatura em Celsius que deseja converter: ");
            cel = Convert.ToSingle(Console.ReadLine());

            //Processamento
            fah = (9 * cel + 160) / 5;

            //Saída(s)
            Console.Write("Sua conversão em Fahrenheit " + fah);
        }
    }
}
