using System;
using JustInMindServer.Entities.Enums;

namespace JustInMindServer.Models
{
    public class Ticket
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created_On { get; set; }
        public DateTime? Desired_Resolution_Date { get; set; }
        public long? Assignee_Id { get; set; }
        public long Owner_Id { get; set; }
        public State State { get; set; }
        public long Category_Id { get; set; }
        public long Urgency_Id { get; set; }
        public long? Approver_Id { get; set; }
    }
}