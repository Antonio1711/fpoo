using System;

namespace Desafio_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar variáveis
            double tempo, vel_med, dist, litros_usados;

            //Entrada(s)
            Console.WriteLine("Digite o tempo gasto na viagem: ");
            tempo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a velocidade média da viagem: ");
            vel_med = Convert.ToDouble(Console.ReadLine());

            //Processamento(s)
            dist = tempo * vel_med;

            litros_usados = dist / 12;

            //Saída(s)
            Console.Write("Foram utilizados " + Math.Round(litros_usados, 2) + " litros de combustível durante a viagem.");
        }
    }
}
