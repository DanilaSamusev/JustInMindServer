using JustInMindServer.Models;
using JustInMindServer.Repositories;
using JustInMindServer.Repositories.Implementations;
using JustInMindServer.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Ninject;

//https://localhost:5001/api/ticket/allTickets

namespace JustInMindServer.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : Controller
    {
        
        private readonly IRepository<Ticket> _ticketRepository;
        
        public TicketController()
        {
            var ninjectKernel = new StandardKernel();
            ninjectKernel.Bind<ITicketRepository>().To<TicketRepository>();

            _ticketRepository = ninjectKernel.Get<ITicketRepository>();
        }

        [HttpGet("allTickets")]
        public IActionResult GetAllTickets()
        {

            return Ok(_ticketRepository.GetAll());
        }
        
        [HttpPut("addTicket")]
        public void Add()
        {
            
            
        }
        
        
    }
}