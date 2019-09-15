using System.Collections.Generic;

namespace JustInMindServer.Repositories
{
    public interface IRepository<T>
    {
        string GetAll();
        T GetById(long id);
        void Add(T obj);
        void Delete(long id);
    }
}