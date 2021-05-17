using System;
using System.Collections.Generic;
using System.Text;

namespace CotacaoDolar
{
    class Cotacao
    {
      
        public static double CalculaValor(double val, double CotacaoAtual)
        {
            return (val * CotacaoAtual) * 1.06;
        }
    }
}
