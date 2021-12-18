using System;

namespace CA_Estruturas
{
    class Program
    {
        public struct Data
        {
            public int dia, mes, ano;

            public Data(int objDia, int objMes, int objAno)
            {
                this.dia = objDia;
                this.mes = objMes;
                this.ano = objAno;
            }
        }

        //Struct sem construtor
        public struct Horario
        {
            public int hora, minuto, segundo;
        }

        public struct Horario2
        {
            private int hora2, minuto2, segundo2;

            public Horario2(int h, int m, int s)
            {
                this.hora2 = h % 24;
                this.minuto2 = m % 60;
                this.segundo2 = s % 60;
            }

            public int Hora2() => this.hora2;

            public int Minuto2() => this.minuto2;

            public int Segundo2() => this.segundo2;
        }

        static void Main(string[] args)
        {
            Data objDataHoje = new Data(28, 01, 2021);

            System.Console.WriteLine($"Data de hoje: {objDataHoje.dia}/{objDataHoje.mes}/{objDataHoje.ano}");

            Data objDataOntem = objDataHoje;
            objDataOntem.dia--;
            
            System.Console.WriteLine($"\nData de ontem: {objDataOntem.dia}/{objDataHoje.mes}/{objDataHoje.ano}");
            
            Data objDataAmanha = objDataHoje;
            objDataAmanha.dia++;
            
            System.Console.WriteLine($"\nData de amanhã: {objDataAmanha.dia}/{objDataHoje.mes}/{objDataHoje.ano}");

            objDataHoje.dia = DateTime.Now.Day;

            Horario agora;
            agora.hora = DateTime.Now.Hour;
            agora.minuto = DateTime.Now.Minute;
            agora.segundo = DateTime.Now.Second;

            System.Console.WriteLine($"\nHorário: {agora.hora}:{agora.minuto}:{agora.segundo}");

            Horario2 agora2 = new Horario2(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);

            System.Console.WriteLine($"\nHorário: {agora2.Hora2()}:{agora2.Minuto2()}:{agora2.Segundo2()}");
        }
    }
}
