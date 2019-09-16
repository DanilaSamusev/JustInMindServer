using JustInMindServer.Models;
using JustInMindServer.Repositories;
using Microsoft.AspNetCore.Mvc;

//https://localhost:5001/api/ticket/allTickets

namespace JustInMindServer.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : Controller
    {
        private readonly IRepository<Ticket> _ticketRepository;
        
        public TicketController()
        {
            
        }

        [HttpGet("allTickets")]
        public IActionResult GetAllTickets()
        {

            return Ok(_ticketRepository.GetAll());
        }
        
        [HttpPut("addTicket")]
        public void Add()
        {
            
            
        }
        
        
    }
}