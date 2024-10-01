using AttractionsBE.Models;
using AttractionsBE.Services;
using Microsoft.AspNetCore.Mvc;

namespace AttractionsBE.Controllers
{
    [ApiController]
    [Route("api/attractions")]
    public class AttractionsController : ControllerBase
    {

        private readonly ITicketMasterApiService _ticketMasterApiService;
        public AttractionsController(ITicketMasterApiService ticketMasterApiService)
        {
            _ticketMasterApiService = ticketMasterApiService;
        }

        [HttpGet]
        public async Task<ActionResult<TicketMasterAttractionsDto?>> GetAttraction([FromQuery] string keyword)
        {
            var AttractionResult = await _ticketMasterApiService.SearchAttractionsAsync(keyword);
            return Ok(AttractionResult);

        }
    }
}
