namespace Cs
{
    public class Produto
    {
        public string nome { get; set; }
        public double preco { get; set; }
        public int quantidade { get; set; }

        //Construtor padrão
        public Produto(){}

        //Primeira sobrecarga do construtor - parâmetro nome
        public Produto(string qqnome)
        {
            this.nome = qqnome;
        }
        public Produto(string qqnome, double qqpreco){
            this.nome = qqnome;
            this.preco = qqpreco;
        }

        //Terceira sobrecarga do construtor - parâmetros quantidade e preco
        public Produto(int qqquantidade, double qqpreco)
        {
            this.quantidade = qqquantidade;
            this.preco = qqpreco;
        }

        public Produto(string qqnome, int qqquantidade, double qqpreco)
        {
            this.nome = qqnome;
            this.quantidade = qqquantidade;
            this.preco = qqpreco;
        }
    }
}