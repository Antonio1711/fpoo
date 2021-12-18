namespace Aula41_08_02_2021
{
    public class TestaPessoaJuridica
    {
        static void Main(string[] args)
        {
            Juridica j1 = new Juridica();

            j1.Nome = "Walter White";
            j1.dtNascimento = "01/01/1970";
            j1.CNPJ = "12345678-90";

            System.Console.WriteLine("Dados Pessoa Jurídica");
            System.Console.WriteLine($"Nome: {j1.Nome}");
            System.Console.WriteLine($"Data de nascimento: {j1.dtNascimento}");
            System.Console.WriteLine($"CNPJ: {j1.CNPJ}");
            j1.Comer("Jurídica");
        }
    }
}