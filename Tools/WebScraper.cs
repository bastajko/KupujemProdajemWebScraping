namespace KupujemProdajemWebScraping.Tools
{
    using HtmlAgilityPack;
    using KupujemProdajemWebScraping.Interfaces;
    using KupujemProdajemWebScraping.Models;
    using System.Net.Http.Json;
    using System.Runtime.Serialization;
    using System.Text.Json;

    public class WebScraper : IWebScraper
    {
        private readonly HttpClient _httpClient;

        public WebScraper()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<Ad>> ScrapeAsync(string url)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string jsonResponse = await response.Content.ReadAsStringAsync();

            // Deserialize the response
            ApiResponse apiResponse = JsonSerializer.Deserialize<ApiResponse>(jsonResponse, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }) ?? throw new SerializationException("Unsuccessful response deserialization.");

            if (apiResponse != null && apiResponse.Results != null)
            {
                return apiResponse.Results.Ads;
            }

            return new List<Ad>();
        }
    }
}