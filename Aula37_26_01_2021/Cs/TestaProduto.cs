namespace Cs
{
    public class TestaProduto
    {
        static void Main(string[] args)
        {
            Produto prod1 = new Produto();

            prod1.nome = "HD SSD 240GB";
            prod1.preco = 350.00;
            prod1.quantidade = 100;

            System.Console.WriteLine("Dados depois da instância");
            System.Console.WriteLine($"Nome: {prod1.nome}");
            System.Console.WriteLine($"Preço: {prod1.preco}");
            System.Console.WriteLine($"Quantidade: {prod1.quantidade}");

            //prod2 com sobrecarga do construtor - nome
            Produto prod2 = new Produto("Mouse Wireless 1850dpi");
            System.Console.WriteLine("\nDados do produto:");
            System.Console.WriteLine($"Nome: {prod2.nome}");
            
            Produto prod3 = new Produto("Mouse Wireless 1850dpi", 70);
            System.Console.WriteLine("\nDados do produto:");
            System.Console.WriteLine($"Nome: {prod3.nome}");
            System.Console.WriteLine($"Preço: {prod3.preco}");

            Produto prod4 = new Produto(10, 70);
            System.Console.WriteLine("\n Dados do produto com quantidade e preço:");
            System.Console.WriteLine($"Quantidade: {prod4.quantidade}");
            System.Console.WriteLine($"Preço: {prod4.preco}");

            Produto prod5 = new Produto("ABC", 25, 25.64);
            System.Console.WriteLine("\n Dados do produto:");
        }
    }
}