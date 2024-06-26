namespace AutoTraderAdapter
{
    /// <summary>
    /// Configuration class for API base URLs and keys.
    /// </summary>
    public static class ApiConfig
    {
        // Financial Modeling Prep API
        public static string FmpBaseUrl { get; } = "https://financialmodelingprep.com/api/v3";
        public static string FmpApiKey { get; } = "RXBSLEHnPvudYIdaTvV00li7Rg4iHci4";

        //for another API, enter another API info here
        public static string AnotherApiBaseUrl { get; } = ""; 
        public static string AnotherApiKey { get; } = "";
    }
}
