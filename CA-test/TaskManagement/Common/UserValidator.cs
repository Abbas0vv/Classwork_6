using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;
using TaskManagement.Utilities;

namespace TaskManagement.Common
{
    public class UserValidator
    {
        private StringUtility _utility = new StringUtility();


        #region First name

        public string GetAndValidateFirstName()
        {
            while (true)
            {
                Console.WriteLine("Pls enter first name : ");
                string firstName = Console.ReadLine()!;

                if (IsValidFirstName(firstName))
                    return firstName;

                Console.WriteLine("Some information is not correnct");
            }
        }
        private bool IsValidFirstName(string firstName)
        {
            int MIN_LENGTH = 3;
            int MAX_LENGTH = 30;

            return IsValidName(firstName, MIN_LENGTH, MAX_LENGTH);
        }

        #endregion

        #region Last name

        public string GetAndValidateLastName()
        {
            while (true)
            {
                Console.WriteLine("Pls enter last name : ");
                string lastName = Console.ReadLine()!;

                if (IsValidLastName(lastName))
                    return lastName;

                Console.WriteLine("Some information is not correnct");
            }
        }
        private bool IsValidLastName(string lastName)
        {
            int MIN_LENGTH = 5;
            int MAX_LENGTH = 20;

            return IsValidName(lastName, MIN_LENGTH, MAX_LENGTH);
        }

        #endregion

        #region Password

        public string GetAndValidatePassword()
        {
            while (true)
            {
                Console.WriteLine("Pls enter password : ");
                string password = Console.ReadLine()!;

                Console.WriteLine("Pls enter confirm password : ");
                string confirmPassword = Console.ReadLine()!;

                if (password == confirmPassword)
                    return password;

                Console.WriteLine("Some information is not correnct");
            }
        }

        #endregion

        #region Email

        public string GetAndValidateEmail()
        {
            StringUtility stringUtility = new StringUtility();

            while (true)
            {
                string pattern = @"^[a-zA-Z0-9._%+-]+@code\.edu\.az$";
                string email = Console.ReadLine()!;

                if (IsEmailExists(email))
                    Console.WriteLine("This email already taken, try again.");

                if (!stringUtility.IsLengthBetween(email, 22, 42)) //@code.edu.az --> 12 char var. Length yoxlayanda 10+12 ve 30+12 etdim ki dogru olsun
                    Console.WriteLine("");

                if (Regex.IsMatch(email, pattern))
                    return email;
                else
                {
                    Console.WriteLine("It is not a valid email address or does not end with '@code.edu.az'.");
                    Console.Write("Write your email again : ");
                }
            }
        }
        public bool IsEmailExists(string email)
        {
            UserRepository userRepository = new UserRepository();
            List<User> users = userRepository.GetAll();
            foreach (User user in users)
            {
                if (user.Email == email)
                {
                    return true;
                }
            }

            return false;
        }

        #endregion

        #region Common

        private bool IsValidName(string name, int minLength, int maxLenght)
        {
            if (!_utility.IsLengthBetween(name, minLength, maxLenght))
            {
                return false;
            }

            char firstLetter = name[0];

            if (!_utility.IsUpperLetter(firstLetter))
            {
                return false;
            }

            for (int i = 1; i < name.Length; i++)
            {
                if (_utility.IsUpperLetter(name[i]))
                {
                    return false;
                }
            }

            return true;
        }

        #endregion
    }
}
