
using AttractionsUI.Components.Models;
using System.Text.Json;

namespace AttractionsUI.Components.Services
{
    public class AttractionsService
    {
        private readonly HttpClient _httpClient;

        public AttractionsService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<TicketMasterAttractionsDto?> GetAttractionsAsync(string keyword)
        {
            var attractionUrl = $"http://10.0.2.2:5246/api/attractions?keyword={keyword}";
            //var attractionUrl = $"http://localhost:5246/api/attractions?keyword={keyword}";
            var response = await _httpClient.GetAsync(attractionUrl);
            var dataString = await response.Content.ReadAsStringAsync();
            TicketMasterAttractionsDto? data = JsonSerializer.Deserialize<TicketMasterAttractionsDto>(dataString, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return data;
        }

        public async Task<TicketMasterEventsDto?> GetEventsAsync(string attractionId)
        {
            var eventsUrl = $"http://10.0.2.2:5246/api/events?attractionId={attractionId}";
            //var eventsUrl = $"http://localhost:5246/api/events?attractionId={attractionId}";
            var response = await _httpClient.GetAsync(eventsUrl);
            var dataString = await response.Content.ReadAsStringAsync();
            TicketMasterEventsDto? data = JsonSerializer.Deserialize<TicketMasterEventsDto>(dataString, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return data;
        }
    }
}
