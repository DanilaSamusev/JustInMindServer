using System;
using System.Linq;
using FluentValidation;
using JustInMindServer.Dto;
using JustInMindServer.Entities;
using JustInMindServer.Repositories.DbImplementations.EntityFramework.Contexts;
using JustInMindServer.Repositories.DbImplementations.EntityFramework.Implementations;
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
        private readonly ICommentRepository _commentRepository;
        private readonly IHistoryRepository _historyRepository;
        private readonly TicketService _ticketService;

        public TicketController(ITicketRepository ticketRepository,
            ITicketDtoRepository ticketCreationDto, TicketService ticketService,
            ICommentRepository commentRepository, IHistoryRepository historyRepository)
        {
            _ticketRepository = ticketRepository;
            _ticketDtoRepository = ticketCreationDto;
            _ticketService = ticketService;
            _commentRepository = commentRepository;
            _historyRepository = historyRepository;
        }

        [HttpGet("allTickets")]
        public IActionResult GetAllTickets()
        {
            var ticketsDto = _ticketDtoRepository.GetAllDtoToDisplay();

            return Ok(ticketsDto);
        }

        [HttpGet("ticketOverview")]
        public IActionResult GetTicketToOverViewById([FromQuery] long ticketId)
        {
            var ticket = _ticketDtoRepository.GetDtoToOverviewById(ticketId);

            return Ok(ticket);
        }

        [HttpGet("ticketUpdate")]
        public IActionResult GetTicketToUpdateById([FromQuery] long ticketId)
        {
            var ticket = _ticketDtoRepository.GetDtoToUpdateById(ticketId);

            return Ok(ticket);
        }

        //TODO avoid ex.Errors.First() - FluentValidation only 
        [HttpPost("ticket")]
        public IActionResult CreateTicket([FromBody] TicketDtoToCreate ticketDtoToCreate)
        {
            try
            {
                var ticketId = _ticketService.AddTicket(ticketDtoToCreate);
                return Ok(ticketId);
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Errors.First().ErrorMessage);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("ticketState")]
        public IActionResult UpdateTicketState([FromBody] TicketStateUpdateData data)
        {
            _ticketRepository.UpdateState(data.TicketId, data.StateId, data.UserId);
            return Ok();
        }

        [HttpGet("ticketHistory")]
        public IActionResult GetTicketHistory([FromQuery] long ticketId)
        {
            var histories = _historyRepository.GetAllByTicketId(ticketId);
            return Ok(histories);
        }

        [HttpGet("ticketComments")]
        public IActionResult GetTicketComments([FromQuery] long ticketId)
        {
            var comments = _commentRepository.GetAllByTicketId(ticketId);
            return Ok(comments);
        }
    }
}