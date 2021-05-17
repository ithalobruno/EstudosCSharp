namespace Chapter10Exercise.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        
        public Individual(string name, double anualInCome, double healthExpenditures) : base(name, anualInCome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public double CalculateHealthExpenditures()
        {
            if(HealthExpenditures > 0)
            {
                return HealthExpenditures / 2;
            }
            else
            {
                return 0.00;
            }
        }

        public override double Tax()
        {
            double tax = 0.00;
            
            if (AnualInCome < 20000)
            {
                tax = AnualInCome * 0.15;
            }
            else
            {
                tax = AnualInCome * 0.25;
            }

            return tax - CalculateHealthExpenditures();
        }
    }
}
