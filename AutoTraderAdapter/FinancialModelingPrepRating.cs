using System.Net.Http;
using System.Threading.Tasks;

namespace AutoTraderAdapter
{
    /// <summary>
    /// Strategy implementation for fetching company ratings from the Financial Modeling Prep API.
    /// </summary>
    public class FinancialModelingRating : IStrategy
    {
        /// <summary>
        /// Asynchronously gets the company rating from the Financial Modeling Prep API.
        /// </summary>
        /// <param name="symbol">The company symbol.</param>
        /// <returns>A task that represents the asynchronous operation, containing the company rating as a string.</returns>
        public async Task<string> GetCompanyRatingAsync(string symbol)
        {
            using (var client = new HttpClient())
            {
                var url = $"{ApiConfig.FmpBaseUrl}/rating/{symbol}?apikey={ApiConfig.FmpApiKey}";
                var response = await client.GetStringAsync(url);
                return response;
            }
        }
    }
}
