namespace Arrays
{
    class ExibeArgumentos
    {                               //nomes poderia ser qualquer nome e não interfiriria no TestaExibirArgumentos
        public void ExibirArgumentos(string[] nomes)
        {
            System.Array.Sort(nomes);
            foreach (string nome in nomes)
            {
                System.Console.WriteLine(nome);
            }
        }
    }
}