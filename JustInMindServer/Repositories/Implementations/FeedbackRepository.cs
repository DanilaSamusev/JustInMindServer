using System.Collections.Generic;
using JustInMindServer.Models;
using JustInMindServer.Repositories.Interfaces;

namespace JustInMindServer.Repositories.Implementations
{
    public class FeedbackRepository : IRepository<Feedback>
    {
        public IEnumerable<Feedback> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Feedback> GetAllDTO()
        {
            throw new System.NotImplementedException();
        }

        public Feedback GetById(long id)
        {
            throw new System.NotImplementedException();
        }

        public void Add(Feedback obj)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new System.NotImplementedException();
        }
    }
}