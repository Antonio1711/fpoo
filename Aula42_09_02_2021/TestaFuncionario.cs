using System;

namespace Aula41_09_02_2021
{
    class TestaFuncionario
    {
        static void Main(string[] args)
        {
            Gerente g = new Gerente();
            g.Nome = "Sonin blaiden";
            g.Salario = 151103;
            g.Usuario = "sonin blaiden";
            g.Senha = "bolo5555";

            Telefonista f = new Telefonista();
            f.Nome = "Gigaton Games";
            f.Salario = 5435;
            f.estacaoDeTrabalho = 13;

            Secretaria s = new Secretaria();
            s.Nome = "Zelda";
            s.Salario = 2053;
            s.Ramal = 198;

            System.Console.WriteLine("Exibindo dados do gerente:");
            g.MostrarDados();

            System.Console.WriteLine("\nExibindo dados do telefonista:");
            f.MostrarDados();

            System.Console.WriteLine("\nExibindo dados da secretária:");
            s.MostrarDados();
        }
    }
}
