namespace AttractionsBE.Models
{
    public class TicketMasterAttractionsDto
    {
        public EmbeddedAttractionsDto? _Embedded { get; set; }
        public PageDto? Page { get; set; }
    }
}
