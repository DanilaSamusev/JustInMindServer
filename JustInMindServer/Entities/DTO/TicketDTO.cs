using System;
using JustInMindServer.Entities.Enums;

namespace JustInMindServer.Entities.DTO
{
    public class TicketDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime DesiredResolutionDate { get; set; }
        public Urgency UrgencyId { get; set; }
        public State StateId { get; set; }
    }
}