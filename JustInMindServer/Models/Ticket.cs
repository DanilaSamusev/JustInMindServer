using System;

namespace JustInMindServer.Models
{
    public class Ticket
    {
        private readonly int _id;
        private readonly string _name;
        private readonly string _description;
        private readonly DateTime _createdOn;
        private readonly DateTime _desiredResolutionData;
        private readonly long _assigneeId;
        private readonly long _ownerId;
        private readonly long _stateId;
        private readonly long _categoryId;
        private readonly long _urgencyId;
        private readonly long _approverId;

        public Ticket(int id, string name, string description, DateTime createdOn, DateTime desiredResolutionData,
            long assigneeId, long ownerId, long stateId, long categoryId, long urgencyId, long approverId)
        {
            _id = id;
            _name = name;
            _description = description;
            _createdOn = createdOn;
            _desiredResolutionData = desiredResolutionData;
            _assigneeId = assigneeId;
            _ownerId = ownerId;
            _stateId = stateId;
            _categoryId = categoryId;
            _urgencyId = urgencyId;
            _approverId = approverId;
        }

        public int Id => _id;
        public string Name => _name;
        public string Description => _description;
        public DateTime CreatedOn => _createdOn;
        public DateTime DesiredResolutionData => _desiredResolutionData;
        public long AssigneeId => _assigneeId;
        public long OwnerId => _ownerId;
        public long StateId => _stateId;
        public long CategoryId => _categoryId;
        public long UrgencyId => _urgencyId;
        public long ApproverId => _approverId;
    }
}