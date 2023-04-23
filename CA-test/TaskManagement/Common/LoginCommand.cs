using TaskManagement.Admin;
using TaskManagement.Client;
using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;
using TaskManagement.Services;

namespace TaskManagement.Common
{
    public class LoginCommand
    {
        public static void Handle() //use alias
        {
            string email = Console.ReadLine()!;
            string password = Console.ReadLine()!;
            UserRepository userRepository = new UserRepository();
            List<User> users = userRepository.GetAll(); 

            for (int i = 0; i < users.Count; i++)
            {
                User user = users[i];

                if (user.Email == email && user.Password == password)
                {
                    if (user.IsBanned)
                    {
                        Console.WriteLine("Your account is banned, you can't join");
                        return;
                    }
                    
                    UserService.CurrentUser = user;

                    if (user.IsAdmin)
                        AdminDashboard.Introduction();
                    else
                        ClientDashboard.Introduction();
                }
            }
        }
    }
}
