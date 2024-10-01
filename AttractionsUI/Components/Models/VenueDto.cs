
namespace AttractionsUI.Components.Models
{
    public class VenueDto
    {
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Id { get; set; }
        public bool? Test { get; set; }
        public string? Url { get; set; }
        public string? Locale { get; set; }
        public List<string>? Aliases { get; set; }
        public List<ImageDto>? Images { get; set; }
        public string? PostalCode { get; set; }
        public string? Timezone { get; set; }
        public CityDto? City { get; set; }
        public StateDto? State { get; set; }
        public CountryDto? Country { get; set; }
        public AddressDto? Address { get; set; }
        public LocationDto? Location { get; set; }
    }
}
