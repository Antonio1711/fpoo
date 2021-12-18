namespace ExercíciosComplementares.Model
{
    public class Contas
    {
        private int agencia { get; set; }
        private string nome { get; set; }
        private string dataDeNascimento { get; set; }
        public int Agencia 
        {
            get
            {
                return this.agencia;
            }
            set
            {
                this.agencia = value;
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
        public string DataDeNascimento
        {
            get
            {
                return this.dataDeNascimento;
            }
            set
            {
                this.dataDeNascimento = value;
            }
        }
    }
}