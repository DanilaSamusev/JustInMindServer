using System.Collections.Generic;
using System.Linq;
using JustInMindServer.Models;
using JustInMindServer.Repositories.Contexts;
using JustInMindServer.Repositories.DbImplementations.EntityFramework.Contexts;
using JustInMindServer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace JustInMindServer.Repositories.DbImplementations.EntityFramework.Implementations
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAll()
        {

            CategoryContext dbContext = new CategoryContext();
            
                var categories = dbContext.Categories.FromSql("Select * from categories").ToList();
                
                return categories;
            
        }

        public Ticket GetById(long id)
        {
            throw new System.NotImplementedException();
        }

        public void Add(Category ticket)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new System.NotImplementedException();
        }
    }
}