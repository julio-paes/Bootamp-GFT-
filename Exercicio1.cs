using System;


namespace DIO1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dados = Console.ReadLine().Split();
            int tempoGasto, velocidadeMedia;

            tempoGasto = int.Parse(dados[0]);
            velocidadeMedia = int.Parse(dados[1]);

            double calculo = tempoGasto * velocidadeMedia;
            double litros = calculo / 12;

            Console.WriteLine(string.Format("{0:0.000}", litros));
        }
    }
}