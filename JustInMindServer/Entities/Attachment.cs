namespace JustInMindServer.Entities
{
    public class Attachment
    {
        private readonly long _id;
        private readonly string _blob;
        private readonly long _ticketId;
        private readonly string _name;

        public Attachment(long id, string blob, long ticketId, string name)
        {
            _id = id;
            _blob = blob;
            _ticketId = ticketId;
            _name = name;
        }

        public long Id => _id;
        public string Blob => _blob;
        public long TicketId => _ticketId;
        public string Name => _name;
    }
}