namespace Encapsulamento
{
    public class Funcionario
    {
        private double salario { get; set; }
        private string nome { get; set; }
        public double Salario
        {
            get{
                return this.salario;
            }
            set
            {
                this.salario = value;
            }
        }
        public string Nome
        {
            get
            {
                return this.nome;
            }
            set
            {
                this.nome = value;
            }
        }
    }
}