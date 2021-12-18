namespace Cs.model
{
    public class Gerente
    {
        public string nome { get; set; }
        public double salario { get; set; }

        public void AumentaSalario()
        {
            this.AumentaSalario(0.1);
        }
        
        public void AumentaSalario(double taxa)
        {
            this.salario += this.salario * taxa;
        }
    }
}