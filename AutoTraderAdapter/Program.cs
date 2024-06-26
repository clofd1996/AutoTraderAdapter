using System;
using System.Threading.Tasks;

namespace AutoTraderAdapter
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Choose strategy (1: FinancialModelingRating, 2: AnotherRating): ");
            string choice = Console.ReadLine();

            IStrategy strategy;
            switch (choice)
            {                
                case "1":
                default:
                    strategy = new FinancialModelingRating();
                    break;
                case "2":
                    strategy = new AnotherRating();
                    break;
            }

            var context = new ApiContext();
            context.SetStrategy(strategy);

            Console.Write("Please enter the company symbol: ");
            string symbol = Console.ReadLine();

            try
            {
                var rating = await context.GetCompanyRating(symbol);
                Console.WriteLine("Company rating information: ");
                Console.WriteLine(rating);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving company rating information: {ex.Message}");
            }
        }
    }
}
