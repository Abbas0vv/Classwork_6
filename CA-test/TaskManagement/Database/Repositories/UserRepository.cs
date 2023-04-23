using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database.Models;

namespace TaskManagement.Database.Repositories
{
    public class UserRepository
    {
        public List<User> GetAll()
        {
            return DataContext.Users;
        }

        public void Insert(User user)
        {
            DataContext.Users.Add(user);
        }

        public User GetUserOrDefaultByEmail(string email)
        {
            foreach (User user in DataContext.Users)
            {
                if (user.Email == email)
                {
                    return user;
                }
            }

            return null!;
        }

        public User GetUserOrDefaultById(int id)
        {
            foreach (User user in DataContext.Users)
            {
                if (user.Id == id)
                {
                    return user;
                }
            }

            return null!;
        }

        public void RemoveById(int id)
        {
            User user = GetUserOrDefaultById(id);
            DataContext.Users.Remove(user);
        }

        public void RemoveByEmail(string email)
        {
            User user = GetUserOrDefaultByEmail(email);
            DataContext.Users.Remove(user);
        }

        public void Remove(User user)
        {
            DataContext.Users.Remove(user);
        }
    }
}
