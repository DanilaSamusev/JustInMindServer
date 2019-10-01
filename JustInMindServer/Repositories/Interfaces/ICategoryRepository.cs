using System.Collections.Generic;
using JustInMindServer.Models;

namespace JustInMindServer.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAll();
        Ticket GetById(long id);
        void Add(Category ticket);
        void Delete(long id);
    }
}