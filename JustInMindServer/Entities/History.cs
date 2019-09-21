using System;

namespace JustInMindServer.Models
{
    public class History
    {
        private readonly long _id;
        private readonly long _ticketId;
        private readonly DateTime _date;
        private readonly string _action;
        private readonly long _userId;
        private readonly string _description;

        public History(long id, long ticketId, DateTime date, string action, long userId, string description)
        {
            _id = id;
            _ticketId = ticketId;
            _date = date;
            _action = action;
            _userId = userId;
            _description = description;
        }

        public long Id => _id;
        public long TicketId => _ticketId;
        public DateTime Date => _date;
        public string Action => _action;
        public long UserId => _userId;
        public string Description => _description;
    }
}