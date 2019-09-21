using JustInMindServer.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JustInMindServer.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : Controller
    {
        private readonly ITicketRepository _ticketRepository;

        public TicketController(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        [HttpGet("allTickets")]
        public IActionResult GetAllTickets()
        {
            var ticketsDto = _ticketRepository.GetAllDto();
            
            return Ok(ticketsDto);
        }
    }
}