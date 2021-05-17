using System;

namespace CotacaoDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            double quantidade;
            double cotacao;
            Console.WriteLine("Quantos Doláres?");
            quantidade = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a cotação do dolar?");
            cotacao = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor Total: " + Cotacao.CalculaValor(quantidade,cotacao).ToString());
        }
    }
}
