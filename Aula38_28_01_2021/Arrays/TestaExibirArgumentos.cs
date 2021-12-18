namespace Arrays
{
    public class TestaExibirArgumentos
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[] {"Marquin", "Julin", "Flavin"};

            ExibeArgumentos mandaExibir = new ExibeArgumentos();

            mandaExibir.ExibirArgumentos(nomes);
        }
    }
}