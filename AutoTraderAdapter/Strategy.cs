using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTraderAdapter
{
    /// <summary>
    /// Interface for strategy pattern to get company rating.
    /// </summary>
    public interface IStrategy
    {
        /// <summary>
        /// Asynchronously gets the company rating.
        /// </summary>
        /// <param name="symbol">The company symbol.</param>
        /// <returns>A task that represents the asynchronous operation, containing the company rating as a string.</returns>
        Task<string> GetCompanyRatingAsync(string symbol);
    }
}
