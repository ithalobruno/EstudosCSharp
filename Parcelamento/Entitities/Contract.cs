using System;
using System.Collections.Generic;

namespace Parcelamento.Entitities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime DataContract { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime dataContract, double totalValue)
        {
            Number = number;
            DataContract = dataContract;
            TotalValue = totalValue;
            Installments = new List<Installment>();
        }

        public void AddInstallments(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
