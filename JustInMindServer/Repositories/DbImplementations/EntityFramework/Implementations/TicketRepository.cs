using System.Collections.Generic;
using System.Linq;
using JustInMindServer.Entities.DTO;
using JustInMindServer.Entities.Enums;
using JustInMindServer.Models;
using JustInMindServer.Repositories.Contexts;
using JustInMindServer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;


//var tickets = dbContext.Tickets.FromSql("SELECT t.id, t.name, t.description, t.created_on, t.desired_resolution_date, t.assignee_id, t.owner_id, s.state, t.category_id, t.urgency_id, t.approver_id FROM tickets t, state s WHERE t.state_id = s.id")


namespace JustInMindServer.Repositories.Implementations
{
    public class TicketRepository : ITicketRepository
    {
        public IEnumerable<Ticket> GetAll()
        {
            return null;
        }
        
        public IEnumerable<TicketDTO> GetAllDto()
        {
            TicketDTOContext dbContext = new TicketDTOContext();
            
                var ticketsDto = dbContext.TicketsDto.FromSql(
                    "Select id, name, desiredResolutionDate, urgencyId, stateId from tickets")
                    .ToList();

                return ticketsDto;
            
        }

        public Ticket GetById(long id)
        {
            using (TicketContext dbContext = new TicketContext())
            {
                var ticket = dbContext.Tickets.FirstOrDefault(t => t.Id == id);

                return ticket;
            }
        }

        public void Add(Ticket obj)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new System.NotImplementedException();
        }
    }
}