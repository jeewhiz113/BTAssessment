namespace AttractionsBE.Clients
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;
        public ApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetDataAsync(string url)
        {
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var dataString = await response.Content.ReadAsStringAsync();
            return dataString;
        }
    }
}
