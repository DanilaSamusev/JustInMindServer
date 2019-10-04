using System;
using JustInMindServer.Entities.DTO;
using JustInMindServer.Models;
using JustInMindServer.Repositories.Interfaces;
using JustInMindServer.Services;
using JustInMindServer.Validators;
using Microsoft.AspNetCore.Mvc;

namespace JustInMindServer.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : Controller
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly TicketService _ticketService;

        public TicketController(ITicketRepository ticketRepository, TicketService ticketService)
        {
            _ticketRepository = ticketRepository;
            _ticketService = ticketService;
        }

        [HttpGet("allTickets")]
        public IActionResult GetAllTickets()
        {
            var ticketsDto = _ticketRepository.GetAllDto();
            
            return Ok(ticketsDto);
        }

        [HttpPost("ticket")]
        public IActionResult CreateTicket([FromBody] TicketCreationDto ticketDto)
        {
            long ticketId = _ticketService.AddTicket(ticketDto);
            
            return Ok(ticketId);
        }
    }
}