using System;
using System.Globalization;
namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre com o numero da Conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o Titular da Conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial? ");
            string possuiDepositoInicial = Console.ReadLine();

            if (possuiDepositoInicial.Equals("Sim"))
            {
                Console.Write("Entre com o saldo Inicial da Conta: ");
                double depositoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }
        }
    }
}
