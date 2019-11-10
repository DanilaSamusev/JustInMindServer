using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace JustInMindServer.Dto
{
    public class TicketDtoToOverview
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public long StateId { get; set; }
        public long UrgencyId { get; set; }
        public DateTime? DesiredResolutionDate { get; set; }
        public string OwnerName { get; set; }
        public string ApproverName { get; set; }
        public string AssigneeName { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
    }
}