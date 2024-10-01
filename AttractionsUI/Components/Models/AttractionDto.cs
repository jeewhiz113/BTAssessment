
namespace AttractionsUI.Components.Models
{
    public class AttractionDto
    {
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Id { get; set; }
        public bool? Test { get; set; }
        public string? Url { get; set; }
        public string? Locale { get; set; }
        public ExternalLinksDto? ExternalLinks { get; set; }
        public List<string>? Aliases { get; set; }
        public List<ImageDto>? Images { get; set; }
        public UpcomingEventsDto? UpcomingEvents { get; set; }
    }
}
