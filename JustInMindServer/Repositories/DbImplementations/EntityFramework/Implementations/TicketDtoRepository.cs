using System.Collections.Generic;
using System.Linq;
using JustInMindServer.Dto;
using JustInMindServer.Repositories.DbImplementations.EntityFramework.Contexts;
using JustInMindServer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace JustInMindServer.Repositories.DbImplementations.EntityFramework.Implementations
{
    public class TicketDtoRepository : ITicketDtoRepository
    {
        public IEnumerable<TicketDtoToDisplay> GetAllDtoToDisplay()
        {
            var dbContext = new TicketDtoContext();

            var ticketsDto = dbContext.TicketsDtoToDisplay.FromSql
                (
                    "Select id, name, desiredResolutionDate, urgencyId, stateId from tickets"
                )
                .ToList();

            return ticketsDto;
        }

        public IEnumerable<TicketDtoToOverview> GetDtoToOverviewById(long ticketId)
        {
            var dbContext = new TicketDtoContext();

            var ticketsDto = dbContext.TicketsDtoToOverview.FromSql
            (
                "Select t.id, t.name, createdOn, stateId, urgencyId, desiredResolutionDate, u1.firstName as ownerName," +
                " u2.firstName as approverName, u3.firstName as assigneeName, description, c.name as category " +
            "from tickets t " +
            "left join users u1 on u1.id = t.ownerId " +
            "left join users u2 on u2.id = t.approverId " +
            "left join users u3 on u3.id = t.assigneeId " +
            "left join categories c on c.id = t.categoryId " +
            $"where t.id = {ticketId}"
            ).ToList();

            return ticketsDto;
        }
    }
}