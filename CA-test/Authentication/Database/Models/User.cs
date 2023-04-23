namespace Authentication.Database.Models
{
    public class User
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }

        public User(string name, string lastName, string password, string email, bool isAdmin = false)
        {
            Name = name;
            LastName = lastName;
            Password = password;
            Email = email;
            IsAdmin = isAdmin;
        }
    }
}