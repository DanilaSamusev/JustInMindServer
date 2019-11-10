using JustInMindServer.Dto;
using JustInMindServer.Models;

namespace JustInMindServer.Validators
{
    public interface ITicketCreationDtoValidator
    {
        void Validate(TicketDtoToCreate ticketDtoToCreate);
    }
}