using System.Collections.Generic;
using JustInMindServer.Models;
using JustInMindServer.Repositories.Interfaces;

namespace JustInMindServer.Repositories.Implementations
{
    public class CommentRepository : IRepository<Comment>
    {
        public IEnumerable<Comment> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Comment> GetAllDTO()
        {
            throw new System.NotImplementedException();
        }

        public Comment GetById(long id)
        {
            throw new System.NotImplementedException();
        }

        public void Add(Comment obj)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new System.NotImplementedException();
        }
    }
}