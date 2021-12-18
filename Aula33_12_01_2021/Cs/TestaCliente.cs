using System;

namespace Cs
{
    public class TestaCliente
    {
        static void Main(string[] args)
        {
            Cliente meuCliente = new Cliente(); 

            meuCliente.Nome = "Zé";
            meuCliente.Idade = "25";
            // meuCliente.Saldo = 1000;
        }
    }
}