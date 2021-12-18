using System;
using Cs.model;
namespace Cs
{
    public class TestaContaEAgencia
    {
        static void Main(string[] args)
        {
            Agencia agencia = new Agencia(1234);
            Conta conta = new Conta(agencia);

            conta.numeroConta = 111;
            conta.limite = 852.25;
            conta.saldo = 458.68;

            agencia.numero = 85;

            System.Console.WriteLine("Dados da agência:");
            System.Console.WriteLine($"Número: {agencia.numero}");

            System.Console.WriteLine("--------------------");

            System.Console.WriteLine("Dados da conta:");
            System.Console.WriteLine($"Número: {conta.numeroConta}");
            System.Console.WriteLine($"Limite: {conta.limite}");
            System.Console.WriteLine($"Saldo: {conta.saldo}");

            System.Console.WriteLine("------------------------");

            System.Console.WriteLine("Dados da agência através da conta");
            System.Console.WriteLine($"Número {conta.agencia.numero}");
        }
    }
}