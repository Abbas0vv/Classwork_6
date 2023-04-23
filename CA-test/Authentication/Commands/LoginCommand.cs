using Authentication.Database;
using Authentication.Database.Models;

namespace Authentication.Commands
{
    public class LoginCommand
    {
        public void Handle(DataContext database) //use alias
        {
            string email = Console.ReadLine()!;
            string password = Console.ReadLine()!;

            foreach (User user in database.Users) //fully qualified namespace
            {
                if (user.Email == email && user.Password == password)
                {
                    if (user.IsAdmin)
                        Console.WriteLine("Hello dear admin");
                    else
                        Console.WriteLine($"Hello! : {user.Email} {user.Password}");
                }
            }

        }
    }
}
