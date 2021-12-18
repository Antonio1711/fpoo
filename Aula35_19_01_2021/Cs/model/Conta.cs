using System;
namespace Cs.model
{
    public class Conta
    {
        public int numeroConta { get; set; }
        public double saldo { get; set; }
        public double limite { get; set; }
        public Agencia agencia { get; set; }

        public Conta(Agencia agencia)
        {
            this.agencia = agencia;
        }

        public void Deposita(double valor)
        {
            this.saldo += valor;
        } 

        public void Saca(double valor)
        {
            this.saldo -= valor;
        }

        public void Transfere(Conta destino, double valor)
        {
            this.saldo -= valor;
            destino.saldo += valor;
        }

        public void ImprimeExtrato()
        {
            Console.WriteLine($"SALDO: {this.saldo}");
        }

        public double ConsultaSaldoDisponivel()
        {
            return this.saldo + this.limite;
        }
    }
}