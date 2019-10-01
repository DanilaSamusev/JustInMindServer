using System;
using JustInMindServer.Entities.DTO;
using JustInMindServer.Models;
using JustInMindServer.Repositories.Interfaces;
using JustInMindServer.Services.Validators;
using Microsoft.AspNetCore.Mvc;

namespace JustInMindServer.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : Controller
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly ITicketCreationDtoValidator _ticketCreationDtoValidator;

        public TicketController(ITicketRepository ticketRepository, ITicketCreationDtoValidator ticketCreationDtoValidator)
        {
            _ticketRepository = ticketRepository;
            _ticketCreationDtoValidator = ticketCreationDtoValidator;
        }

        [HttpGet("allTickets")]
        public IActionResult GetAllTickets()
        {
            var ticketsDto = _ticketRepository.GetAllDto();
            
            return Ok(ticketsDto);
        }

        [HttpPost("ticket")]
        public void CreateTicket([FromBody] TicketCreationDTO ticketDto)
        {
            if (_ticketCreationDtoValidator.IsTicketValidToCreate(ticketDto))
            {
                Ticket ticket = new Ticket
                {
                    Name = ticketDto.Name,
                    Description = ticketDto.Description,
                    Desired_Resolution_Date = ticketDto.DesiredResolutionDate,
                    Created_On = ticketDto.CreatedOn,
                    Owner_Id = 1,
                    State = ticketDto.State,
                    Category_Id = ticketDto.CategoryId,
                    Urgency_Id = ticketDto.UrgencyId,
                };
                Console.WriteLine();
            }
        }
    }
}