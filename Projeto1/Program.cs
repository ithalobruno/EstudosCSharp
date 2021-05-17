using System;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Dados do retangulo!");
            Console.Write("Altura: ");
            ret.Altura = double.Parse(Console.ReadLine());
            Console.Write("Largura: ");
            ret.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Area: " + ret.Area());
            Console.WriteLine("Perímetro: " + ret.Perimetro());
            Console.WriteLine("Diagonal: " + ret.Diagonal());

        }
    }
}
