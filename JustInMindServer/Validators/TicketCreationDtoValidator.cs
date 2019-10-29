using FluentValidation;
using JustInMindServer.Dto;

namespace JustInMindServer.Validators
{
    public class TicketCreationDtoValidator : AbstractValidator<TicketDtoToCreateTicket>, ITicketCreationDtoValidator
    {
        public TicketCreationDtoValidator()
        {
            RuleFor(ticketDto => ticketDto.CategoryId).NotEqual(0).WithMessage("Fill category!");
            RuleFor(ticketDto => ticketDto.Name).NotEmpty().WithMessage("Fill name!");
            RuleFor(ticketDto => ticketDto.UrgencyId).NotEqual(0).WithMessage("Fill urgency!");
        }

        public new void Validate(TicketDtoToCreateTicket dtoToCreateTicket)
        {
            this.ValidateAndThrow(dtoToCreateTicket);
        }
    }
}