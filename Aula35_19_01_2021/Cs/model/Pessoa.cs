namespace Cs.model
{
    public class Pessoa
    {
        public string rg { get; set; }
        public int cpf { get; set; }

        public Pessoa(string rg)
        {
            this.rg = rg;
        }

        public Pessoa(int cpf)
        {
            this.cpf = cpf;
        }
    }
}