using System.Globalization;

namespace BancoOficial
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Titular = titular;
            Numero = numero;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero,titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double valor)
        {
             Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= (valor + 5);
        }

        public override string ToString()
        {
           return "Conta: "
                  + Numero
                  + ", Titular: "
                  + Titular
                  + ", Saldo: $ "
                  + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
