using System;
using JustInMindServer.Entities;
using JustInMindServer.Entities.DTO;
using JustInMindServer.Models;
using JustInMindServer.Repositories.Interfaces;
using JustInMindServer.Validators;

namespace JustInMindServer.Services
{
    public class TicketService
    {
        private readonly ITicketCreationDtoValidator _ticketCreationDtoValidator;
        private readonly ITicketRepository _ticketRepository;

        public TicketService(ITicketCreationDtoValidator ticketCreationDtoValidator, ITicketRepository ticketRepository)
        {
            _ticketCreationDtoValidator = ticketCreationDtoValidator;
            _ticketRepository = ticketRepository;
        }

        public long AddTicket(TicketCreationDto dto)
        {
            if (dto == null)
            {
                throw new NullReferenceException("TicketCreationDto can't be null!");
            }

            if (!_ticketCreationDtoValidator.IsValid(dto))
            {
                throw new ArgumentException("Check input data!");
            }

            Ticket ticket = new Ticket
            (
                dto.Name,
                dto.Description,
                dto.CreatedOn,
                dto.DesiredResolutionDate,
                1,
                dto.StateId,
                dto.CategoryId,
                dto.UrgencyId
            );
            
            return _ticketRepository.Add(ticket);
        }
    }
}