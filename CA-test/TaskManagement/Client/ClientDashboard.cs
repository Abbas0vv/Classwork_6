using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Client.Commands;
using TaskManagement.Common;
using TaskManagement.Database.Models;
using TaskManagement.Services;

namespace TaskManagement.Client
{
    public class ClientDashboard
    {
        public static void Introduction()
        {
            Console.WriteLine($"Hello! : {UserService.CurrentUser.Email} {UserService.CurrentUser.Name}");

            string command = Console.ReadLine()!;

            while (true)
            {

                switch (command)
                {
                    case "/close-account":
                        CloseAccountCommand.Handle();
                        break;
                    case "/update-settings":
                        UpdateSettingsForUser.Handle();
                        break;
                    case "/show-messages":
                        ShowMessagesCommand.Handle();
                        break;
                    default:
                        Console.WriteLine("Invalid command, pls try again");
                        break;
                }

            }
        }
    }
}
