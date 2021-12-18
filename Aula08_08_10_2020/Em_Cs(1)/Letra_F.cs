using System;

namespace Em_Cs_1_
{
    class Letra_F
    {
        static void Main(string[] args)
        {
          //Declarar variáveis
          int a, b, aux;

          //Entrada(s)
          Console.WriteLine("Digite o valor de a: ");
          a = Convert.ToInt32(Console.ReadLine());

          Console.WriteLine("Digite o valor de b: ");
          b = Convert.ToInt32(Console.ReadLine());

          //Processamento(s)
          aux = a;
          a = b;
          b = aux;

          //Saída(s)
          Console.WriteLine("O valor de a é: " + a);
          Console.WriteLine("O valor de b é: " + b);

        }
    }
}