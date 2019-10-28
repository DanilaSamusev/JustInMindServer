using System;
using JustInMindServer.Entities;
using JustInMindServer.Entities.DTO;
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
                throw new NullReferenceException("Ticket dto for creation can't be null!");
            }

            _ticketCreationDtoValidator.Validate(dto);

            var ticket = new Ticket
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