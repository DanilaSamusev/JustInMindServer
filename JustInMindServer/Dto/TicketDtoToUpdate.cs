using System;

namespace JustInMindServer.Dto
{
    public class TicketDtoToUpdate
    {
        public long CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long Id { get; set; }
        public DateTime? DesiredResolutionDate { get; set; }
        public long UrgencyId { get; set; }
    }
}