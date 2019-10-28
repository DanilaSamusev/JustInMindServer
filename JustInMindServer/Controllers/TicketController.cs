using System;
using System.Linq;
using FluentValidation;
using JustInMindServer.Entities.DTO;
using JustInMindServer.Repositories.Interfaces;
using JustInMindServer.Services;
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

        [HttpGet("ticket")]
        public IActionResult GetTicketById([FromQuery] long ticketId)
        {
            var ticket = _ticketRepository.GetById(ticketId);
            
            return Ok(ticket);
        }
        
        //TODO avoid ex.Errors.First() - FluentValidation only 
        [HttpPost("ticket")]
        public IActionResult CreateTicket([FromBody] TicketCreationDto ticketDto)
        {
            try{
                var ticketId = _ticketService.AddTicket(ticketDto);
                return Ok(ticketId);
            }
            catch(ValidationException ex)
            {
                return BadRequest(ex.Errors.First().ErrorMessage);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}