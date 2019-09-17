namespace JustInMindServer.Models
{
    public class Table
    {
        private int id;
        
        public Table(int id)
        {
            this.id = id;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }
    }
}