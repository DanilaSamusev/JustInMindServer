using FluentValidation;
using JustInMindServer.Entities.DTO;
using JustInMindServer.Models;

namespace JustInMindServer.Services.Validators
{
    public class TicketCreationDtoValidator : AbstractValidator<TicketCreationDTO>, ITicketCreationDtoValidator
    {

        public TicketCreationDtoValidator()
        {
            RuleFor(ticketDto => ticketDto.CategoryId).NotEqual(0);
            RuleFor(ticketDto => ticketDto.Name).NotEmpty();
            RuleFor(ticketDto => ticketDto.UrgencyId).NotEqual(0);
        }

        public bool IsTicketValidToCreate(TicketCreationDTO ticketDto)
        {
            return Validate(ticketDto).IsValid;
        }

        public bool IsTicketValidToAdd(Ticket ticket)
        {
            throw new System.NotImplementedException();
        }
    }
}