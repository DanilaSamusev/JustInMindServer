using FluentValidation;
using JustInMindServer.Entities.DTO;
using JustInMindServer.Models;

namespace JustInMindServer.Validators
{
    public class TicketCreationDtoValidator : AbstractValidator<TicketCreationDto>, ITicketCreationDtoValidator
    {
        public TicketCreationDtoValidator()
        {
            RuleFor(ticketDto => ticketDto.CategoryId).NotEqual(0);
            RuleFor(ticketDto => ticketDto.Name).NotEmpty();
            RuleFor(ticketDto => ticketDto.UrgencyId).NotEqual(0);
        }

        public bool IsValid(TicketCreationDto dto)
        {
            return Validate(dto).IsValid;
        }
    }
}