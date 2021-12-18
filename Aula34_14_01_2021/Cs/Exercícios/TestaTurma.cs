using System;
using Exercícios.Model;
namespace Exercícios
{
    public class TestaTurma
    {
        static void Main(string[] args)
        {
            Turma d2 = new Turma();
            d2.periodo = "Manhã";
            d2.serie = 2;
            d2.sigla = "D";
            d2.tipoDeEnsino = "Médio";

            Turma h9 = new Turma();
            h9.periodo = "Tarde";
            h9.serie = 9;
            h9.sigla = "H";
            h9.tipoDeEnsino = "Fundamental II";

            System.Console.WriteLine("Dados da turma 2D:");
            System.Console.WriteLine($"Período: {d2.periodo}");
            System.Console.WriteLine($"Série: {d2.serie}");
            System.Console.WriteLine($"Sigla: {d2.sigla}");
            System.Console.WriteLine($"Tipo de ensino: {d2.tipoDeEnsino}");
            
            System.Console.WriteLine("\n----------------------\n");

            System.Console.WriteLine("Dados da turma 9H:");
            System.Console.WriteLine($"Período: {h9.periodo}");
            System.Console.WriteLine($"Série: {h9.serie}");
            System.Console.WriteLine($"Sigla: {h9.sigla}");
            System.Console.WriteLine($"Tipo de ensino: {h9.tipoDeEnsino}");
        }
    }
}