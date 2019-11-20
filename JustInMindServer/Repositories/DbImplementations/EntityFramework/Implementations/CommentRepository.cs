using System.Collections.Generic;
using System.Linq;
using JustInMindServer.Entities;
using JustInMindServer.Repositories.DbImplementations.EntityFramework.Contexts;
using JustInMindServer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace JustInMindServer.Repositories.DbImplementations.EntityFramework.Implementations
{
    public class CommentRepository : ICommentRepository
    {
        public IEnumerable<Comment> GetAllByTicketId(long ticketId)
        {
            var dbContext = new CommentContext();
            var comments = dbContext.Comments.FromSql("Select date, text, u.firstName as userName" +
                                                      " from comments" +
                                                      " left join users u on u.id = userId" +
                                                      $" where ticketId = {ticketId}").ToList();
            return comments;
        }
    }
}