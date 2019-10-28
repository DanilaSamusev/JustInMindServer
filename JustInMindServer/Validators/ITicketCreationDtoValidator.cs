using JustInMindServer.Entities.DTO;
using JustInMindServer.Models;

namespace JustInMindServer.Validators
{
    public interface ITicketCreationDtoValidator
    {
        void Validate(TicketCreationDto ticketDto);
    }
}