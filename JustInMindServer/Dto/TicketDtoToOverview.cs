using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace JustInMindServer.Dto
{
    public class TicketDtoToOverview
    {
        public TicketDtoToOverview()
        {
            
        }

        public TicketDtoToOverview(
            long id, string name, DateTime createdOn, long stateId, long urgencyId,
            DateTime? desiredResolutionDate, string ownerName, string approverName,
            string assigneeName, string description, string category)
        {
            Id = id;
            Name = name;
            CreatedOn = createdOn;
            StateId = stateId;
            UrgencyId = urgencyId;
            DesiredResolutionDate = desiredResolutionDate;
            OwnerName = ownerName;
            ApproverName = approverName;
            AssigneeName = assigneeName;
            Description = description;
            Category = category;
        }
        
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