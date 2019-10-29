using System;
using JustInMindServer.Dto;
using JustInMindServer.Entities;
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

        public long AddTicket(TicketDtoToCreateTicket dtoToCreateTicket)
        {
            if (dtoToCreateTicket == null)
            {
                throw new NullReferenceException("Ticket dto for creation can't be null!");
            }

            _ticketCreationDtoValidator.Validate(dtoToCreateTicket);

            var ticket = new Ticket
            (
                dtoToCreateTicket.Name,
                dtoToCreateTicket.Description,
                dtoToCreateTicket.CreatedOn,
                dtoToCreateTicket.DesiredResolutionDate,
                1,
                dtoToCreateTicket.StateId,
                dtoToCreateTicket.CategoryId,
                dtoToCreateTicket.UrgencyId
            );
            
            return _ticketRepository.Add(ticket);
        }
    }
}