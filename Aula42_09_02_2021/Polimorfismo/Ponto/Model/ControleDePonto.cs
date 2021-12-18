using System;
namespace Ponto
{
    public class ControleDePonto
    {
        public void RegistrarEntrada(Gerente g)
        {
            DateTime agora = DateTime.Now;
            string horario = String.Format("{0:d/M/yyyy HH:mm:ss}", agora);

            System.Console.WriteLine();
        }
    }
}