using Cs.model;
using System;

namespace Cs
{
    public class TestaFuncionario
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            f1.nome = "Oi";
            f1.salario = 1967.57;

            f1.aumentaSalario(300);
            f1.consultaDados();
        }
    }
}