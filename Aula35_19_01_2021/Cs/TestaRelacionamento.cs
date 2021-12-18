using Cs.model;
using System;

namespace Cs
{
    class TestaRelacionamento
    {
        static void Main(string[] args)
        {
            CartaoDeCredito cdc = new CartaoDeCredito(111111);
            Cliente c = new Cliente();

            c.nome = "Jão Days";
            c.codigo = 123;

            cdc.numero = 111111;
            cdc.dataDeValidade = "12/12/2018";

            Console.WriteLine("Dados do cliente:");
            Console.WriteLine($"Nome: {c.nome}");
            Console.WriteLine($"Código: {c.codigo}");

            Console.WriteLine("------------------------");

            Console.WriteLine("Dados do cartão:");
            Console.WriteLine($"Número: {cdc.numero}");
            Console.WriteLine($"Data de validade {cdc.dataDeValidade}");
            
            Console.WriteLine("------------------------");

            //ligando os objetos
            cdc.cliente = c;
            Console.WriteLine("Dados do cartão obtidos através do cartão");
            Console.WriteLine($"Nome: {cdc.cliente.nome}");
            Console.WriteLine($"Código: {cdc.cliente.codigo}");
        }
    }
}
