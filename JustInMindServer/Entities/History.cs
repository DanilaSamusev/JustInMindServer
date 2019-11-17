using System;

namespace JustInMindServer.Entities
{
    public class History
    {
        /*private readonly long _id;
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
        }*/

        public long Id { get; set; }
        public long TicketId { get; set; }
        public DateTime Date { get; set; }
        public string Action { get; set; }
        public long UserId { get; set; }
        public string Description { get; set; }
    }
}