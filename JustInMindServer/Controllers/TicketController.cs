using System;
using JustInMindServer.Models;
using JustInMindServer.Repositories;
using Microsoft.AspNetCore.Mvc;

//http://localhost:5001/api/ticket/allTickets

namespace JustInMindServer.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : Controller
    {
        private readonly IRepository<Ticket> _ticketRepository;

        public TicketController(IRepository<Ticket> ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        [HttpGet("allTickets")]
        public IActionResult GetAllTickets()
        {
            var tickets = _ticketRepository.GetAll();

            return Ok(tickets);
        }

        [HttpPut("addTicket")]
        public void Add()
        {
        }
    }
}