using JustInMindServer.Entities.DTO;
using JustInMindServer.Models;

namespace JustInMindServer.Validators
{
    public interface ITicketCreationDtoValidator
    {
        bool IsValid(TicketCreationDto ticketDto);
    }
}