namespace Cs.model
{
    public class Funcionario
    {
        public string nome { get; set; }
        public double salario { get; set; }

        public void aumentaSalario(double aumento)
        {
            this.salario += aumento;
        }

        public void consultaDados()
        {
            System.Console.WriteLine($"Nome: {this.nome} \nSalário atual: {this.salario}");
        }
    }
}