using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common;
using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;

namespace TaskManagement.Admin.Commands
{
    public class ShowUsersCommand
    {
        public static void Handle()
        {
            UserRepository userRepository = new UserRepository();
            List<User> users = userRepository.GetAll();

            int order = 1;

            foreach (User user in users)
            {
                Console.WriteLine($"{order}. {user.GetShortInfo()}");
                order++;
            }
        }
    }
}
