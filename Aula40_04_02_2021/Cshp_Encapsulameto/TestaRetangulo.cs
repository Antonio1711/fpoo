using System;

namespace Cshp_Encapsulameto
{
    class TestaRetangulo
    {
        static void Main(string[] args)
        {
            var r = new Retangulo();
            try
            {
                System.Console.WriteLine("Informe o comprimento: ");
                r.Comprimento = Convert.ToDouble(Console.ReadLine());
                System.Console.WriteLine("Informe a largura: ");
                r.Largura = Convert.ToDouble(Console.ReadLine());
                System.Console.WriteLine($"Área do Retângulo: {r.GetArea()}");
            }
            catch (ArgumentException argEx)
            {
                System.Console.WriteLine($"Erro: {argEx}");
            }
        }
    }
}
