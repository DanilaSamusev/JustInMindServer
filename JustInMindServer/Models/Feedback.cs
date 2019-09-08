using System;

namespace JustInMindServer.Models
{
    public class Feedback
    {
        private readonly long _id;
        private readonly long _userUd;
        private readonly int _rate;
        private readonly DateTime _date;
        private readonly string _text;
        private readonly long _ticketId;

        public Feedback(long id, long userUd, int rate, DateTime date, string text, long ticketId)
        {
            _id = id;
            _userUd = userUd;
            _rate = rate;
            _date = date;
            _text = text;
            _ticketId = ticketId;
        }

        public long Id => _id;
        public long UserUd => _userUd;
        public int Rate => _rate;
        public DateTime Date => _date;
        public string Text => _text;
        public long TicketId => _ticketId;
    }
}