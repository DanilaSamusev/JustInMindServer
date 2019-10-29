using System;
using System.ComponentModel.DataAnnotations;
using JustInMindServer.Entities.Enums;

namespace JustInMindServer.Entities
{
    public class Ticket
    {
        public Ticket()
        {
        }

        public Ticket(
            string name, string description, DateTime createdOn, DateTime? desiredResolutionDate,
            long ownerId, State stateId, long categoryId, long urgencyId)
        {
            Name = name;
            Description = description;
            CreatedOn = createdOn;
            DesiredResolutionDate = desiredResolutionDate;
            OwnerId = ownerId;
            StateId = stateId;
            CategoryId = categoryId;
            UrgencyId = urgencyId;
        }

        [Key] public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? DesiredResolutionDate { get; set; }
        public long? AssigneeId { get; set; }
        public long OwnerId { get; set; }
        public State StateId { get; set; }
        public long CategoryId { get; set; }
        public long UrgencyId { get; set; }
        public long? ApproverId { get; set; }
    }
}