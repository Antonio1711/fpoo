using System;

namespace Aula39_04_02_2021
{
    class TestaFuncionario
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            f.Nome = "Antonio";
            f.Salario = 165413545153;

            System.Console.WriteLine($"Nome: {f.Nome} \nSalário: {f.Salario}");
        }
    }
}
