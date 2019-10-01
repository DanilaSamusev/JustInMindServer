using System;
using JustInMindServer.Entities.Enums;

namespace JustInMindServer.Entities.DTO
{
    public class TicketCreationDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? DesiredResolutionDate { get; set; }
        public State State { get; set; }
        public int CategoryId { get; set; }
        public int UrgencyId { get; set; }
    }
}