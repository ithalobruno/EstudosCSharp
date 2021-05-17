using System;
using System.Globalization;
namespace BancoOficial
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Digite o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito Inicial: ");
            char opcao = char.Parse(Console.ReadLine());

            if(opcao == 's' || opcao == 'S')
            {
                Console.Write("Digite o valor Inicial da conta: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.Write("Entre com um valor para depósito:");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valorDeposito);
            Console.WriteLine("Dados Atualizados: ");
            Console.WriteLine(conta);

            Console.Write("Entre com um valor para saque:");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valorSaque);
            Console.WriteLine("Dados Atualizados: ");
            Console.WriteLine(conta);

        }
    }
}
