using System;

namespace Encapsulamento
{
    class TestaFuncionario
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            f.Nome = "Rafael Constantino";
            f.Salario = 2000;

            System.Console.WriteLine(f.Nome);
            System.Console.WriteLine(f.Salario);
        }
    }
}
