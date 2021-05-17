namespace Chapter10Exercise.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualInCome { get; set; }

        public TaxPayer(string name, double anualInCome)
        {
            Name = name;
            AnualInCome = anualInCome;
        }

        public abstract double Tax();
    }
}
