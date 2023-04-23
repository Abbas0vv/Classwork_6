using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;

namespace TaskManagement.Admin.Commands
{
    public class RemoveUserCommand
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
                Console.WriteLine($"User is admin you can't remove {user.GetShortInfo()}");
                return;
            }

            userRepository.Remove(user);
        }
    }
}
