using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Authentication.Database.Models;

namespace Authentication.Database
{
    public class DataContext
    {
        public List<User> Users { get; set; } = new List<User>();

        public DataContext()
        {
            AddUserSeeedings();
        }

        private void AddUserSeeedings()
        {
            Users.Add(new User("Super", "Admin", "123321", "admin@gmail.com", true));
        }
    }
}
