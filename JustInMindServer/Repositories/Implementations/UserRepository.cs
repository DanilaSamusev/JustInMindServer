using System.Collections.Generic;
using System.Linq;
using JustInMindServer.Models;
using JustInMindServer.Repositories.Contexts;
using JustInMindServer.Repositories.Interfaces;

namespace JustInMindServer.Repositories.Implementations
{
    public class UserRepository : IRepository<User>
    {
        public IEnumerable<User> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<User> GetAllDTO()
        {
            throw new System.NotImplementedException();
        }

        public User GetById(long id)
        {
            throw new System.NotImplementedException();
        }

        public void Add(User obj)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new System.NotImplementedException();
        }
    }
}