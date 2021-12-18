namespace Aula41_08_02_2021
{
    public class TestaProduto
    {
        static void Main(string[] args)
        {
            Produto[] vetProduto = new Produto[2];
            System.Console.WriteLine("Dados dos produtos: ");
            
            for (int i = 0; i < vetProduto.Length; i++)
            {
                vetProduto[i] = new Produto();

                System.Console.Write("\nDigite a marca: ");
                vetProduto[i].Marca = System.Console.ReadLine();
                
                System.Console.Write("Digite o modelo: ");
                vetProduto[i].Modelo = System.Console.ReadLine();

                System.Console.Write("Digite o preço: ");
                vetProduto[i].Preco = System.Console.ReadLine();
            }

            foreach (Produto prod in vetProduto)
            {
                System.Console.WriteLine($"\nMarca: {prod.Marca} \tModelo: {prod.Modelo} \tPreço: {prod.Preco}");
            }
        }
    }
}