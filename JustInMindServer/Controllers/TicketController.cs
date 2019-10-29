using System;
using System.Linq;
using FluentValidation;
using JustInMindServer.Dto;
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
        private readonly ITicketDtoRepository _ticketDtoRepository;
        private readonly TicketService _ticketService;

        public TicketController(ITicketRepository ticketRepository,
            ITicketDtoRepository ticketCreationDto, TicketService ticketService)
        {
            _ticketRepository = ticketRepository;
            _ticketDtoRepository = ticketCreationDto;
            _ticketService = ticketService;
        }

        [HttpGet("allTickets")]
        public IActionResult GetAllTickets()
        {
            var ticketsDto = _ticketDtoRepository.GetAllDtoToDisplay();

            return Ok(ticketsDto);
        }

        [HttpGet("ticket")]
        public IActionResult GetTicketById([FromQuery] long ticketId)
        {
            var ticket = _ticketDtoRepository.GetDtoToOverviewById(ticketId);
            
            return Ok(ticket);
        }
        
        //TODO avoid ex.Errors.First() - FluentValidation only 
        [HttpPost("ticket")]
        public IActionResult CreateTicket([FromBody] TicketDtoToCreateTicket ticketDtoToCreateTicket)
        {
            try{
                var ticketId = _ticketService.AddTicket(ticketDtoToCreateTicket);
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