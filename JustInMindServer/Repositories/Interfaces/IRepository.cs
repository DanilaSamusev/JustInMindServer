using System.Collections.Generic;

namespace JustInMindServer.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(long id);
        void Add(T obj);
        void Delete(long id);
    }
}