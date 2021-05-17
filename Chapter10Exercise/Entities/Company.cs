namespace Chapter10Exercise.Entities
{
    class Company : TaxPayer
    {
        public int NumberEmployees { get; set; }

        public Company (string name, double anualInCome , int numberEmployees) :base(name,anualInCome)
        {
            NumberEmployees = numberEmployees;
        }

        public override double Tax()
        {
            if(NumberEmployees > 10)
            {
                return AnualInCome * 0.14;
            }
            else
            {
                return AnualInCome * 0.16;
            }
        }
    }
}
