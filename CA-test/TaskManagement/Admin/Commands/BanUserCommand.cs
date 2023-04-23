using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;
using TaskManagement.Services;

namespace TaskManagement.Admin.Commands
{
    public class BanUserCommand
    {
        public static void Handle()
        {
            UserRepository userRepository = new UserRepository();

            string email = Console.ReadLine()!;
            User user = userRepository.GetUserOrDefaultByEmail(email);

            if (user == null)
            {
                Console.WriteLine("User not found");
                return;
            }

            if (user.IsAdmin)
            {
                Console.WriteLine($"User is admin you can't ban him {user.GetShortInfo()}");
                return;
            }

            user.IsBanned = true;
        }
    }
}
