

namespace AttractionsUI.Components.Models
{
    public class StartDateDto
    {
        public string? LocalDate { get; set; }
        public string? LocalTime { get; set; }
        public DateTime? DateTime { get; set; }
        public bool? DateTBD { get; set; }
        public bool? DateTBA { get; set; }
        public bool? TimeTBA { get; set; }
        public bool? NoSpecificTime { get; set; }
    }
}
