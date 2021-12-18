using System;
using Cs.model;

namespace Cs
{
    public class TestaGerente
    {
        static void Main(string[] args)
        {
            Gerente g = new Gerente();
            g.salario = 1000;

            Console.WriteLine($"Salário: {g.salario}");       
            
            System.Console.WriteLine("Aumentando o salário em 10%");
            g.AumentaSalario();

            System.Console.WriteLine($"Salário: {g.salario}");

            System.Console.WriteLine("Aumentando o salário em 30%: ");
            g.AumentaSalario(0.3);

            System.Console.WriteLine($"Salário: {g.salario}");
        }
    }
}