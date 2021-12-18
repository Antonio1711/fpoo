using System;
namespace Cshp_Encapsulameto
{
    public class Retangulo
    {
        private double comprimento { get; set; }
        private double largura { get; set; }

        public double Comprimento
        {
            get { return comprimento; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("O valor do comprimento não pode ser menor que zero"); 
                }
                else
                {
                    comprimento = value;
                }
            }
        }

        public double Largura
        {
            get {return largura;}
            set 
            {
                largura = value;
            }
        }
        public double GetArea()
        {
            return comprimento * largura;
        }
        public void Exibir()
        {
            System.Console.WriteLine("Área do Retângulo\n");
            System.Console.WriteLine($"Comprimento: {comprimento}");
            System.Console.WriteLine($"Largura: {largura}");
            System.Console.WriteLine($"Área: {GetArea()}");
        }

        public void InformarValores()
        {
            System.Console.WriteLine("Informe o comprimento:");
            comprimento = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Informe a largura:");
            largura = Convert.ToDouble(Console.ReadLine());
        }
    }
}