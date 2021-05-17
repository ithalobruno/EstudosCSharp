using System;
using System.Globalization;
namespace VetoresObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = 0;
            double soma = 0;
            Console.WriteLine("Digite a quantidade de produtos: ");
            quantidade = int.Parse(Console.ReadLine());
            Produto[] vetor = new Produto[quantidade];

            for(int i = 0; i < quantidade; i ++)
            {
                Console.Write("Digite o produto:");
                string nome = Console.ReadLine();
                Console.Write("Digite o preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vetor[i] = new Produto(nome, preco);
            }

            for(int i = 0; i < quantidade; i++)
            {
                soma += vetor[i].Preco;
            }

            Console.WriteLine("O preço médio é: " + (soma / quantidade).ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
