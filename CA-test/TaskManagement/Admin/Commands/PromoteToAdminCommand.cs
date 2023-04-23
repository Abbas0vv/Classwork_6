using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;

namespace TaskManagement.Admin.Commands
{
    public class PromoteToAdminCommand
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
                Console.WriteLine("User is already is admin");
                return;
            }

            user.IsAdmin = true;

            Console.WriteLine("User succussfully promoted to admin!");
        }
    }
}
