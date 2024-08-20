namespace AbstraE.Entities
{
    abstract class Players
    {
        public string Name { get; set; }
        public double AIncome { get; set; }

        protected Players(string name, double aIncome)
        {
            Name = name;
            AIncome = aIncome;
        }

        public abstract double TaxesPaid();
    }
}
