using System;

namespace JustInMindServer.Models
{
    public class Comment
    {
        private readonly long _id;
        private readonly long _userId;
        private readonly string _text;
        private readonly DateTime _date;
        private readonly long _ticketId;

        public Comment(long id, long userId, string text, DateTime date, long ticketId)
        { 
            _id = id;
            _userId = userId;
            _text = text;
            _date = date;
            _ticketId = ticketId;
        }

        public long Id => _id;
        public long UserId => _userId;
        public string Text => _text;
        public DateTime Date => _date;
        public long TicketId => _ticketId;
    }
}