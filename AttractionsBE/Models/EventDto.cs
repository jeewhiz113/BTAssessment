namespace AttractionsBE.Models
{
    public class EventDto
    {
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Id { get; set; }
        public bool? Test { get; set; }
        public string? Url { get; set; }
        public string? Locale { get; set; }
        public List<ImageDto>? Images { get; set; }
        public DatesDto? Dates { get; set; }
        public EmbeddedVenueDto? _embedded { get; set; }
    }
}
