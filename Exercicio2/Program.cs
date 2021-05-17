using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultado = 0;
            Aluno al = new Aluno();
            Console.WriteLine("Digite o nome do Aluno!");
            al.Nome = Console.ReadLine();
            Console.Write("Nota 1: ");
            al.Nota1 = double.Parse(Console.ReadLine());
            Console.Write("Nota 2: ");
            al.Nota2 = double.Parse(Console.ReadLine());
            Console.Write("Nota 3: ");
            al.Nota3 = double.Parse(Console.ReadLine());
            string NotaFinal = "Nota Final: " + al.NotaFinal().ToString();

            if (al.VerificaAprovacao())
            {
                Console.WriteLine("APROVADO!!");
                Console.WriteLine(NotaFinal);
            }
            else
            {
                Console.WriteLine("REPROVADO!!");
                Console.WriteLine(NotaFinal);
                Console.WriteLine("Faltaram: " + al.NotaRestante().ToString() + " pontos");
            }
        }
    }
}
