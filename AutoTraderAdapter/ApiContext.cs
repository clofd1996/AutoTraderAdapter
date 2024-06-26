using System;
using System.Threading.Tasks;

namespace AutoTraderAdapter
{
    /// <summary>
    /// Context class for applying the strategy pattern.
    /// </summary>
    public class ApiContext
    {
        private IStrategy _strategy;

        /// <summary>
        /// Sets the strategy to be used for getting company ratings.
        /// </summary>
        /// <param name="strategy">The strategy to be used.</param>
        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        /// <summary>
        /// Asynchronously gets the company rating using the set strategy.
        /// </summary>
        /// <param name="symbol">The company symbol.</param>
        /// <returns>A task that represents the asynchronous operation, containing the company rating as a string.</returns>
        /// <exception cref="InvalidOperationException">Thrown when the strategy is not set.</exception>
        public async Task<string> GetCompanyRating(string symbol)
        {
            if (_strategy == null)
            {
                throw new InvalidOperationException("Strategy not set.");
            }
            return await _strategy.GetCompanyRatingAsync(symbol);
        }
    }
}
