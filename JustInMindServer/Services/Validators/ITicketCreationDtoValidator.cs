using JustInMindServer.Entities.DTO;
using JustInMindServer.Models;
using FluentValidation;

namespace JustInMindServer.Services.Validators
{
    public interface ITicketCreationDtoValidator
    {
        bool IsTicketValidToCreate(TicketCreationDTO ticketDto);
        bool IsTicketValidToAdd(Ticket ticket);
    }
}