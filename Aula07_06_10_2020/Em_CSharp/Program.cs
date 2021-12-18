using System;

namespace Aula07_06_10_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar variáveis
            double raio, altura, vol;

            //Entrada(s)
            Console.WriteLine("Declare o raio da embalagem: ");
            raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Agora declare a altura: ");
            altura = Convert.ToDouble(Console.ReadLine());
            
            //Processamento
            vol = 3.1415 * Math.Pow(raio, 2) * altura;

            //Saída(s)
            Console.Write("O volume da sua em embalagem é " + Math.Round(vol, 2));
        }
    }
}
