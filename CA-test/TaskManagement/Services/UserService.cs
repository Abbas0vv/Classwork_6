using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database.Models;

namespace TaskManagement.Services
{
    public class UserService
    {
        public static User CurrentUser { get; set; }
    }
}
