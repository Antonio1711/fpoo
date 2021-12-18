using System;
using Cs.model;
namespace Cs
{
    public class TestaCartao
    {
        static void Main(string[] args)
        {
            CartaoDeCredito cdc1 = new CartaoDeCredito(111111);
            cdc1.dataDeValidade = "10/01/2013";
            
            CartaoDeCredito cdc2 = new CartaoDeCredito(222222);
            cdc2.dataDeValidade = "10/01/2014";

            System.Console.WriteLine("Dados do primeiro cartão:");
            System.Console.WriteLine($"Número: {cdc1.numero}");
            System.Console.WriteLine($"Data de validade: {cdc1.dataDeValidade}");
            
            System.Console.WriteLine("Dados do segundo cartão:");
            System.Console.WriteLine($"Número: {cdc2.numero}");
            System.Console.WriteLine($"Data de validade: {cdc2.dataDeValidade}");
        }
    }
}