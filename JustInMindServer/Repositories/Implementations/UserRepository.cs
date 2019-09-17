using System.Collections.Generic;
using System.Linq;
using JustInMindServer.Models;
using JustInMindServer.Repositories.Contexts;

namespace JustInMindServer.Repositories.Implementations
{
    public class UserRepository : IRepository<User>
    {
        
        public UserRepository()
        {
            
        }
        
        public IEnumerable<User> GetAll()
        {
            using (EntityDbContext dbContext = new EntityDbContext())
            {
                var users = dbContext.Users.ToList();
                
                return users;
            }
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