namespace TaskManagement.Database.Models
{
    public class User
    {
        public static int IdCounter { get; private set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string RegistrationDate { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsBanned { get; set; }

        public User(string name, string lastName, string password, string email, string registrationDate)
        {
            Id = ++IdCounter;
            Name = name;
            LastName = lastName;
            Password = password;
            Email = email;
            RegistrationDate = registrationDate;
        }

        public string GetShortInfo()
        {
            return $"Id : {Id}, Full name : {Name} {LastName}, Email : {Email}, Is admin : {GetIsAdminInfo()}";
        }

        public string GetIsAdminInfo()
        {
            return IsAdmin ? "Yes" : "No"; 
        }

        public string GetFullName()
        {
            return $"{Name} {LastName}";
        }
    }
}