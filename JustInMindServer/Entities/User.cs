namespace JustInMindServer.Entities
{
    public class User
    {
        public long Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public long Role_Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}