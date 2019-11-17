using System.Collections.Generic;
using System.Linq;
using JustInMindServer.Entities;
using JustInMindServer.Repositories.DbImplementations.EntityFramework.Contexts;
using JustInMindServer.Repositories.Interfaces;

namespace JustInMindServer.Repositories.DbImplementations.EntityFramework.Implementations
{
    public class CommentRepository : ICommentRepository
    {
        public IEnumerable<Comment> GetAllByTicketId(long ticketId)
        {
            var dbContext = new CommentContext();
            var comments = dbContext.Comments.Where(comment => comment.TicketId == ticketId).ToList();
            return comments;
        }
    }
}