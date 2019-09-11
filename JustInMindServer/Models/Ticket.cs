using System;

namespace JustInMindServer.Models
{
    public class Ticket
    {
        private readonly long _id;
        private readonly string _name;
        private readonly string _description;
        private readonly DateTime _createdOn;
        private readonly DateTime _desiredResolutionDate;
        private readonly long _assigneeId;
        private readonly long _ownerId;
        private readonly long _stateId;
        private readonly long _categoryId;
        private readonly long _urgencyId;
        private readonly long _approverId;
        
        public Ticket(
            long id,
            string name,
            string description,
            DateTime created_on,
            DateTime desired_resolution_date,
            long assignee_id,
            long owner_id,
            long state_id,
            long category_id,
            long urgency_id,
            long approver_id)
        {
            _id = id;
            _name = name;
            _description = description;
            _createdOn = created_on;
            _desiredResolutionDate = desired_resolution_date;
            _assigneeId = assignee_id;
            _ownerId = owner_id;
            _stateId = state_id;
            _categoryId = category_id;
            _urgencyId = urgency_id;
            _approverId = approver_id;
        }

        public long Id => _id;
        public string Name => _name;
        public string Description => _description;
        public DateTime CreatedOn => _createdOn;
        public DateTime DesiredResolutionData => _desiredResolutionDate;
        public long AssigneeId => _assigneeId;
        public long OwnerId => _ownerId;
        public long StateId => _stateId;
        public long CategoryId => _categoryId;
        public long UrgencyId => _urgencyId;
        public long ApproverId => _approverId;
    }
}