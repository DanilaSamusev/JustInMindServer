namespace JustInMindServer.Models
{
    public class User
    {
        private readonly long _id;
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly long _roleId;
        private readonly string _email;
        private readonly string _password;

        public User(long id, string firstName, string lastName, long roleId, string email, string password)
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
            _roleId = roleId;
            _email = email;
            _password = password;
        }
        
        public long Id => _id;
        public string FirstName => _firstName;
        public string LastName => _lastName;
        public long RoleId => _roleId;
        public string Email => _email;
        public string Password => _password;
    }
}