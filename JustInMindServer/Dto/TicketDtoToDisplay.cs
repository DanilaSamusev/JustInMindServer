using System;
using JustInMindServer.Entities.Enums;

namespace JustInMindServer.Dto
{
    public class TicketDtoToDisplay
    {
        public long Id { get; set; }
        public long OwnerId { get; set; }
        public string Name { get; set; }
        public DateTime? DesiredResolutionDate { get; set; }
        public Urgency UrgencyId { get; set; }
        public State StateId { get; set; }
    }
}