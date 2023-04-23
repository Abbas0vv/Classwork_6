using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;
using TaskManagement.Utilities;

namespace TaskManagement.Common
{
    public class RegisterCommand
    {
        public static void Handle()
        {
            UserRepository userRepository = new UserRepository();
            UserValidator userValidator = new UserValidator();
            DateTime dateTime = DateTime.Now;

            string firstName = userValidator.GetAndValidateFirstName();
            string lastName = userValidator. GetAndValidateLastName();
            string password = userValidator.GetAndValidatePassword();
            string email = userValidator.GetAndValidateEmail();

            User human = new User(firstName, lastName, password, email, dateTime.ToString());
            userRepository.Insert(human);
        }
    }
}
