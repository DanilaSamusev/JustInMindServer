using System.Collections.Generic;
using JustInMindServer.Dto;

namespace JustInMindServer.Repositories.Interfaces
{
    public interface ITicketDtoRepository
    { 
        IEnumerable<TicketDtoToDisplay> GetAllDtoToDisplay();
        IEnumerable<TicketDtoToOverview> GetDtoToOverviewById(long ticketId);
        TicketDtoToUpdate GetDtoToUpdateById(long ticketId);
    }
}