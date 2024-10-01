using AttractionsBE.Models;

namespace AttractionsBE.Services
{
    public interface ITicketMasterApiService
    {
        Task<TicketMasterAttractionsDto?> SearchAttractionsAsync(string keyword);
        Task<TicketMasterEventsDto?> FindEventsAsync(string attractionId);
    }
}
