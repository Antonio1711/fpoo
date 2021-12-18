using System;

namespace CA_Enum
{

    public enum Generos {Aventura, Policial, Ficção, Comédia}
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Os genêros são: ");

            //Iterando uma enum - Generos
            foreach (var gen in Enum.GetNames(typeof(Generos)))
            {
                System.Console.WriteLine(gen);
            }
            
            System.Console.WriteLine("\nOs respectivos valores são:");
            foreach (int gen in Enum.GetValues(typeof(Generos)))
            {
                System.Console.WriteLine(gen);
            }
            //Iterando através de uma enumeração retornando nomes e valores
            Type nome_valor = typeof(Generos);

            System.Console.WriteLine("\nOs respectivos nomes e valores são:");
            foreach (string dados in Enum.GetNames(typeof(Generos)))
            {
                System.Console.WriteLine("{0, -10} = {1}", dados, Enum.Format(nome_valor, Enum.Parse(nome_valor, dados), "d"));
            }
        }
    }
}
