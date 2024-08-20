namespace AbstraE.Entities
{
    internal class Individual : Players
    {

        public double Health { get; set; }

        public Individual(double health, string name, double aIncome) : base(name, aIncome)
        {
            Health = health;
        }

        public override double TaxesPaid()
        {
            if (AIncome <= 20000) 
            {
                return (AIncome * 0.15) - (Health * 0.5);
            }
            else
            {
                return (AIncome * 0.25) - (Health * 0.5);
            }
        }
    }
}
