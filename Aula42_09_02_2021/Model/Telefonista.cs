namespace Aula41_09_02_2021
{
    public class Telefonista : Funcionario
    {
        public int estacaoDeTrabalho { get; set; }

        public override void MostrarDados()
        {
            base.MostrarDados();
            System.Console.WriteLine($"Estação de trabalho: {this.estacaoDeTrabalho}");
        }
    }
}