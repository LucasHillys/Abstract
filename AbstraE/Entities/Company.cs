namespace AbstraE.Entities
{
    internal class Company : Players
    {
        public int Employers { get; set; }

        public Company(int employers, string name, double aIncome) : base(name, aIncome)
        {
            Employers = employers;
        }

        public override double TaxesPaid()
        {
            if (Employers <= 10) 
            {
                return AIncome * 0.16;
            }

            return AIncome * 0.14;

        }
    }
}
