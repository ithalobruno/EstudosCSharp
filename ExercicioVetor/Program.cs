using System;

namespace ExercicioVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdeQuartos = 0;
            Console.WriteLine("Quantos quartos serão alugados? ");
            qtdeQuartos = int.Parse(Console.ReadLine());
            Aluguel[] vetor = new Aluguel[9];

            for(int i = 0; i < qtdeQuartos; i++ )
            {
                Console.Write("Digite o nome do estudante: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o email do estudante: ");
                string email = Console.ReadLine();
                Console.Write("Digite o quarto em que o estudante irá ficar: ");
                int quarto = int.Parse(Console.ReadLine());
                vetor[quarto] = new Aluguel(nome, email);
            }

            for(int i = 0; i < 9; i ++ )
            {
                if(vetor[i]!= null)
                {
                    Console.WriteLine(i + " :" + vetor[i]);
                }
            }
        }
    }
}
