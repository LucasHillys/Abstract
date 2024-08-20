using AbstraE.Entities;
using System.Globalization;
namespace AbstraE
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            
            List<Players> list = new List<Players>();
            Console.Write("Enter the number of tax players: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine($"Tax player #{i} data:");
                Console.Write("Individual or Company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double aIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(health, name, aIncome));
                }
                else 
                {
                    Console.Write("Number of employers: ");
                    int employers = int.Parse(Console.ReadLine());
                    list.Add(new Company(employers, name, aIncome));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (Players players in list)
            {
                Console.WriteLine($"{players.Name}: $ {players.TaxesPaid().ToString("f2", CultureInfo.InvariantCulture)}");
            }
            double sum =0;
            foreach (Players players in list) 
            {
                sum += players.TaxesPaid();
            }
            Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("f2", CultureInfo.InvariantCulture)}");

        }
    }
}