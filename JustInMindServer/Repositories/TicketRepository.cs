using System.Collections.Generic;
using System.Linq;
using JustInMindServer.Models;
using Dapper;
using MySql.Data.MySqlClient;

namespace JustInMindServer.Repositories
{
    public class TicketRepository : IRepository<Ticket>
    {
        private readonly string _connectionString;

        public TicketRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        
        public IReadOnlyCollection<Ticket> GetAll()
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                string strQuery = "Select * from tickets";

                IReadOnlyCollection<Ticket> tickets = connection.Query<Ticket>(strQuery).ToList();

                return tickets;
            }
        }

        public Ticket GetById(long id)
        {
            return null;
        }

        public void Add(Ticket obj)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new System.NotImplementedException();
        }
    }
}