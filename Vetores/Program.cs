using System;
using System.Globalization;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de pessoas:");
            int num = int.Parse(Console.ReadLine());
            double[] altura = new double[num];
            double soma = 0;

            for (int i =0; i<num; i++)
            {
                Console.Write("Digite a altura da pessoa: ");
                altura[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            
            for (int i = 0; i < num; i ++)
            {
                soma += altura[i];
            }

            Console.WriteLine("Altura média é: " + (soma / num).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
