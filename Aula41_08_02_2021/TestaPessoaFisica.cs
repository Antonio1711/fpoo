namespace Aula41_08_02_2021
{
    public class TestaPessoaFisica
    {
        static void Main(string[] args)
        {
        Fisica f1 = new Fisica();
        
        f1.Nome = "Tim Maia";
        f1.dtNascimento = "01/01/2000";
        f1.CPF = "12345678-90";

        System.Console.WriteLine("Dados Pessoa Física:");
        System.Console.WriteLine($"Nome: {f1.Nome}");
        System.Console.WriteLine($"Data de nascimento: {f1.dtNascimento}");
        System.Console.WriteLine($"CPF: {f1.CPF}");
        f1.Comer("Física");
        }
    }
}