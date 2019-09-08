namespace JustInMindServer.Models
{
    public class Category
    {
        private readonly long _id;
        private readonly string _name;

        public Category(long id, string name)
        {
            _id = id;
            _name = name;
        }

        public long Id => _id;
        public string Name => _name;
    }
}