using FluentValidation;
using JustInMindServer.Entities.DTO;

namespace JustInMindServer.Validators
{
    public class TicketCreationDtoValidator : AbstractValidator<TicketCreationDto>, ITicketCreationDtoValidator
    {
        public TicketCreationDtoValidator()
        {
            RuleFor(ticketDto => ticketDto.CategoryId).NotEqual(0).WithMessage("Fill category!");
            RuleFor(ticketDto => ticketDto.Name).NotEmpty().WithMessage("Fill name!");
            RuleFor(ticketDto => ticketDto.UrgencyId).NotEqual(0).WithMessage("Fill urgency!");
        }

        public new void Validate(TicketCreationDto dto)
        {
            this.ValidateAndThrow(dto);
        }
    }
}