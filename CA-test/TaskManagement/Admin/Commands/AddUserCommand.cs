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
    public class AddUserCommand
    {
        public static void Handle()
        {
            UserValidator userValidator = new UserValidator();
            UserRepository userRepository = new UserRepository();

            string firstName = userValidator.GetAndValidateFirstName();
            string lastName = userValidator.GetAndValidateLastName();
            string password = userValidator.GetAndValidatePassword();
            string email = userValidator.GetAndValidateEmail();

            User human = new User(firstName, lastName, password, email);

            userRepository.Insert(human);
        }
    }
}
