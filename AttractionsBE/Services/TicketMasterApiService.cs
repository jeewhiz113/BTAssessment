using AttractionsBE.Clients;
using AttractionsBE.Models;
using System.Text.Json;

namespace AttractionsBE.Services
{
    public class TicketMasterApiService : ITicketMasterApiService
    {
        private string _attractionSearchUrl = string.Empty;
        private string _eventsSearchUrl = string.Empty;
        private string _apiKey = string.Empty;
        private readonly HttpClient _httpClient;

        public TicketMasterApiService(IConfiguration configuration, IHttpClientFactory clientFactory)
        {
            _attractionSearchUrl = configuration["urls:attractionSearch"] ?? "";
            _eventsSearchUrl = configuration["urls:eventSearch"] ?? "";
            _apiKey = configuration["ApiKey"] ?? "";
            _httpClient = clientFactory.CreateClient();

        }

        public async Task<TicketMasterAttractionsDto?> SearchAttractionsAsync(string keyword)
        {
            var attractionUrl = $"{_attractionSearchUrl}?apikey={_apiKey}&keyword={keyword}";
            var ticketMasterClient = new ApiClient(_httpClient);
            var responseAsString = await ticketMasterClient.GetDataAsync(attractionUrl);
            TicketMasterAttractionsDto? data = JsonSerializer.Deserialize<TicketMasterAttractionsDto>(responseAsString, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return data;
        }

        public async Task<TicketMasterEventsDto?> FindEventsAsync(string attractionId)
        {
            var eventUrl = $"{_eventsSearchUrl}?apikey={_apiKey}&attractionId={attractionId}";
            var ticketMasterClient = new ApiClient(_httpClient);
            var responseAsString = await ticketMasterClient.GetDataAsync(eventUrl);
            TicketMasterEventsDto? data = JsonSerializer.Deserialize<TicketMasterEventsDto>(responseAsString, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return data;
        }
    }
}
