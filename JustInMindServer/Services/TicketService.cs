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

        public long AddTicket(TicketDtoToCreate dtoToCreate)
        {
            if (dtoToCreate == null)
            {
                throw new NullReferenceException("Ticket dto for creation can't be null!");
            }
            
            _ticketCreationDtoValidator.Validate(dtoToCreate);

            var ticket = new Ticket
            (
                dtoToCreate.Name,
                dtoToCreate.Description,
                dtoToCreate.CreatedOn,
                dtoToCreate.DesiredResolutionDate,
                1,
                dtoToCreate.StateId,
                dtoToCreate.CategoryId,
                dtoToCreate.UrgencyId
            );
            
            return _ticketRepository.Add(ticket);
        }
    }
}