using AttractionsBE.Models;
using AttractionsBE.Services;
using Microsoft.AspNetCore.Mvc;

namespace AttractionsBE.Controllers
{
    public class HomeController : Controller
    {
        [ApiController]
        [Route("api/events")]
        public class EventsController : ControllerBase
        {
            private readonly ITicketMasterApiService _ticketMasterApiService;
            public EventsController(ITicketMasterApiService ticketMasterApiService)
            {
                _ticketMasterApiService = ticketMasterApiService;
            }

            [HttpGet]
            public async Task<ActionResult<TicketMasterEventsDto?>> GetEvents([FromQuery] string attractionId)
            {
                var AttractionResult = await _ticketMasterApiService.FindEventsAsync(attractionId);
                {
                    return Ok(AttractionResult);

                }
            }
        }
    }
}
