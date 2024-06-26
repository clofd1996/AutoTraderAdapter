using System.Net.Http;
using System.Threading.Tasks;

namespace AutoTraderAdapter
{
    public class AnotherRating : IStrategy
    {
        public async Task<string> GetCompanyRatingAsync(string symbol)
        {
            using (var client = new HttpClient())
            {
                var url = $"{ApiConfig.AnotherApiBaseUrl}/rating/{symbol}?apikey={ApiConfig.AnotherApiKey}";
                var response = await client.GetStringAsync(url);
                return response;
            }
        }
    }
}
