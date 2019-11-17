using System.Collections.Generic;
using JustInMindServer.Entities;

namespace JustInMindServer.Repositories.Interfaces
{
    public interface ICommentRepository
    {
        IEnumerable<Comment> GetAllByTicketId(long ticketId);
    }
}